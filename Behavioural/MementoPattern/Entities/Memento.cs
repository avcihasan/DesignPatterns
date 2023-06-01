using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Entities
{
    public class Memento
    {
        public Memento(string name, string surname, string password, DateTime lastEdited)
        {
            Name = name;
            Surname = surname;
            Password = password;
            LastEdited = lastEdited;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public DateTime LastEdited { get; set; }
    }
}
