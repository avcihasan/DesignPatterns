using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Entities
{
    public class Employee : IPerson,IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new();

        public void AddSubordinates(IPerson person)
        {
            _subordinates.Add(person);
        }
        public void RemoveSubordinates(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson GetSubordinates(int index)
        {
            return _subordinates[index];
        }

        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var item in _subordinates)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
