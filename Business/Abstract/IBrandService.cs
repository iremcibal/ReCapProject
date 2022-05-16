using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public void Add(Brand brand);
        public void Update(Brand brand);
        public void Delete(Brand brand);
        List<Brand> GetAll();


    }
}
