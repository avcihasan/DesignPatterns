using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Entities
{
    public class Teacher : CourseMember
    {
        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        public void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine("{0} isimli öğrenici, {1} soruyu sordu.",student.Name,question);
        }
        public void SendNewExam(string url)
        {
            Console.WriteLine("{0} url adresli sınav gönderildi",url);
            Mediator.SendExam(url);
        }
        public void AnswerQuestion(string answer,Student student)
        {
            Console.WriteLine("{0} isimli öğrencinin sorusuna {1} cevabı verildi", answer,student.Name);
            Mediator.SendAnswer(answer,student);
           
        }
    }
}
