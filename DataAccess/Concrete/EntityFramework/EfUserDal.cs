using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User , ReCapContext> , IUserDal
    {
        public List<OperationClaims> GetClaims(User user)
        {
            using (var context = new ReCapContext())
            {
                var result = from operationClaims in context.OperationClaims
                             join userOperationClaims in context.UserOperationClaims
                                 on operationClaims.Id equals userOperationClaims.OperationClaimsId
                             where userOperationClaims.UserId == user.Id
                             select new OperationClaims { Id = operationClaims.Id, Name = operationClaims.Name };
                return result.ToList();

            }
        }
    }
}
