using FactoryMethodPattern.Creator;

IProductCreator _productCreator=new ProductCreator();
Console.WriteLine(_productCreator.GetInstance("A").GetPrice());
Console.WriteLine(_productCreator.GetInstance("B").GetPrice());
Console.WriteLine(_productCreator.GetInstance("C").GetPrice());

Console.Read();
