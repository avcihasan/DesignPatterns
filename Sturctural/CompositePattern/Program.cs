using CompositePattern.Entities;

Employee p1 = new() { Name = "deneme1" };
Employee p2 = new() { Name = "deneme2" };
Employee p3 = new() { Name = "deneme3" };
Employee p4 = new() { Name = "deneme4" };
Employee p5 = new() { Name = "deneme5" };
Employee p6 = new() { Name = "deneme6" };

p1.AddSubordinates(p2);
p1.AddSubordinates(p3);
p2.AddSubordinates(p3);
p2.AddSubordinates(p4);
p2.AddSubordinates(p5);
p3.AddSubordinates(p6);
p4.AddSubordinates(p5);
p4.AddSubordinates(p6);
p1.AddSubordinates(p6);

Console.WriteLine(p1.Name);
foreach (Employee item in p1)
{
    Console.WriteLine("  {0}", item.Name);
    foreach (Employee item1 in item)
    {
        Console.WriteLine("    {0}", item1.Name);
        foreach (Employee item2 in item1)
        {
            Console.WriteLine("      {0}", item2.Name);
        }
    }

}