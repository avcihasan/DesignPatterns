using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Entities
{
    public class User
    {
        private string _name;
        private string _surname;
        private string _password;
        private DateTime _lastEdited;

        public string Name { get => _name; set { _name = value; SetLastEdited(); } }
        public string Surname { get => _surname; set { _surname = value; SetLastEdited(); } }
        public string Password { get => _password; set { _password = value; SetLastEdited(); } }

        private void SetLastEdited()
        {
            _lastEdited = DateTime.Now; 
        }
        public Memento CreateUndo()
        {
            return new Memento(_name,_surname,_password,_lastEdited);
        }
        public void RestoreFromUndo(Memento memento)
        {
            _name = memento.Name;
            _surname = memento.Surname;
            _password = memento.Password;
            _lastEdited = memento.LastEdited;
        }
    }
}
