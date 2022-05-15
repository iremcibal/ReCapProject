using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Color : IEntity 
    {
        //Color-->Id,Name
        public int ColorId { get; set; }
        public string ColorName { get; set; }


    }
}
