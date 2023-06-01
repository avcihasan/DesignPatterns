using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Entities
{
    public class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }

        public void RecieveExam(string url)
        {
            Console.WriteLine("{0} url adresindeki sınavı {1} aldı",url,this.Name);
        }

        public void RecieveAnswer(string answer)
        {
            Console.WriteLine("{0} cevabını {1} aldı", answer, this.Name);
        }
        public void SendQuestion(string question)
        {
            Console.WriteLine("{0}, {1} sorusunu sordu", this.Name,question);
            Mediator.SendQuestion(question,this);

        }
    }
}
