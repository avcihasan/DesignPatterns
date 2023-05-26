using PrototypePattern.Entities;

Person person1 = new Person()
{
    Id= 1,
    Name="Hasan",
    Surname="Avcı"
};

Person person2 = (Person)person1.Clone();

person2.Name = "Deneme Ad";
person2.Surname = "Deneme Soyad";

Person person3 = person1;
person3.Name = "HASAN";

Console.WriteLine($"Name :{person1.Name} - Surname : {person1.Surname} - Id : {person1.Id}");
Console.WriteLine($"Name :{person2.Name} - Surname : {person2.Surname} - Id : {person2.Id}");
Console.WriteLine($"Name :{person3.Name} - Surname : {person3.Surname} - Id : {person3.Id}");


//person 1 ve person3 aynı objeyi referans ederken person2 yani person1 in klonu başka bir objeyi referans eder
