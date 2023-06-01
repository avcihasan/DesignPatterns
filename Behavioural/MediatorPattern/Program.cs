using MediatorPattern.Entities;

Mediator mediator = new();
Teacher teacher = new(mediator) { Name = "Öğretmen" };
Student student1 = new(mediator) { Name="Öğrenci1"};
Student student2 = new(mediator) { Name = "Öğrenci2" };
Student student3 = new(mediator) { Name = "Öğrenci3" };
mediator.Teacher = teacher;
mediator.Students.Add(student1);
mediator.Students.Add(student2);
mediator.Students.Add(student3);

teacher.SendNewExam("exam.com");

student1.SendQuestion("10/2");

teacher.AnswerQuestion("5",student1);

Console.ReadLine();