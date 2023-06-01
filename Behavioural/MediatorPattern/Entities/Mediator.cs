using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Entities
{
    public class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public Mediator()
        {
            Students=new List<Student>();
        }

        public void SendExam(string url)
        {
            foreach (Student student in Students)
                student.RecieveExam(url);
        }
        public void SendQuestion(string question, Student student)
        {
            Teacher.RecieveQuestion(question,student);
        }
        public void SendAnswer(string answer, Student student)
        {
            student.RecieveAnswer(answer);
        }
    }
}
