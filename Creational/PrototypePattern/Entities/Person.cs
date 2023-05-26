using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Entities
{
    public class Person : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
