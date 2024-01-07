

#region Asenkron birden fazla nesen üretimi
//var taks1 = Task.Run(() =>
//{
//    var i1 = MyClass.GetInstance;
//});

//var taks2 = Task.Run(() =>
//{
//    var i2 = MyClass.GetInstance;
//});

//await Task.WhenAll(taks1, taks2);

#endregion

#region Asenkron süreçte birden fazla nesne üretimini engelleme 1.Yöntem
//List<Task> tasks = new();
//for (int i = 0; i < 100; i++)
//{
//    tasks.Add(Task.Run(() =>
//    {
//        var i1 = MyClass1.GetInstance;
//    }));
//}
//await Task.WhenAll(tasks);
#endregion

#region Asenkron süreçte birden fazla nesne üretimini engelleme 2.Yöntem
List<Task> tasks = new();
for (int i = 0; i < 100; i++)
{
    tasks.Add(Task.Run(() =>
    {
        var i1 = MyClass2.GetInstance;
    }));
}
await Task.WhenAll(tasks);
#endregion

class MyClass
{
    //asenkron süreçte birden fazla nesne oluşur
    static MyClass _myClass;
    MyClass()
    {
        Console.WriteLine($"{typeof(MyClass)} oluştu");
    }
    public static MyClass GetInstance
    {
        get
        {
            if (_myClass is null)
                _myClass = new MyClass();
            return _myClass;
        }
    }

}

class MyClass1
{
    //asenkron süreçlerde sadece 1 nesne oluşur
    static MyClass1 _myClass1;
    static object _lock = new();
    MyClass1()
    {
        Console.WriteLine($"{typeof(MyClass1)} oluştu");
    }
    public static MyClass1 GetInstance
    {
        get
        {
            lock (_lock)
            {
                if (_myClass1 is null)
                    _myClass1 = new MyClass1();
            }
            
            return _myClass1;
        }
    }
}
class MyClass2
{
    //asenkron süreçlerde sadece 1 nesne oluşur
    static MyClass2 _myClass2;
    MyClass2()
    {
        Console.WriteLine($"{typeof(MyClass2)} oluştu");
    }
    static MyClass2()
    {
        _myClass2 = new MyClass2();
    }
    public static MyClass2 GetInstance
    {
        get
        {
            return _myClass2;
        }
    }
}