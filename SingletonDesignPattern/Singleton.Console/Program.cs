

MyClass1 m1 = MyClass1.GetInstance;
MyClass1 m2 = MyClass1.GetInstance;
MyClass1 m3 = MyClass1.GetInstance;


MyClass2 m21 = MyClass2.GetInstance;
MyClass2 m22 = MyClass2.GetInstance;
MyClass2 m23 = MyClass2.GetInstance;



class MyClass1
{
    static MyClass1 _instance;
    MyClass1()
    {
        Console.WriteLine($"{nameof(MyClass1)} Oluştu");
    }

    public static MyClass1 GetInstance { 
        get 
        {
            if (_instance ==null)
                return _instance = new MyClass1();
            return _instance;
        } 
    }
}

class MyClass2
{
    static MyClass2 _instance;
     MyClass2()
    {
        Console.WriteLine($"{nameof(MyClass2)} Oluştu");
    }
    static MyClass2()
    {
        _instance = new MyClass2();
    }
    public static MyClass2 GetInstance => _instance;
}