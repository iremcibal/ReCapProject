using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        public void Add(Color color);
        public void Update(Color color);
        public void Delete(Color color);
        List<Color> GetAll();
    }
}
