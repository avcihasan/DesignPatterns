

AProduct aProduct = ProductCreator.GetInstance(ProductType.A) as AProduct;
BProduct bProduct = ProductCreator.GetInstance(ProductType.B) as BProduct;
CProduct cProduct = ProductCreator.GetInstance(ProductType.C) as CProduct;


AProduct aProduct2 = ProductCreator.GetInstance(ProductType.A) as AProduct;


aProduct.Run();
aProduct.Run();
aProduct.Run();
aProduct.Run();
aProduct.Run();
aProduct.Run();
aProduct2.Run();
aProduct2.Run();
aProduct2.Run();
aProduct.Run();
bProduct.Run();
cProduct.Run();







interface IProduct
{
    public string Name { get; set; }
    void Run();
}

class AProduct : IProduct
{
    public string Name { get; set; }
    int count = 0;
    public void Run()
    {
        Console.WriteLine($"{Name} {++count} Kere Çalıştı");
    }
}

class BProduct : IProduct
{
    public string Name { get; set; }

    public void Run()
    {
        Console.WriteLine($"{Name} Çalıştı");
    }
}

class CProduct : IProduct
{
    public string Name { get; set; }

    public void Run()
    {
        Console.WriteLine($"{Name} Çalıştı");
    }
}

enum ProductType
{
    A, B, C
}

class ProductCreator
{
    public static IProduct GetInstance(ProductType productType)
    {
        IProduct product = null;
        switch (productType)
        {
            case ProductType.A:
                product = new AProduct();
                product.Name = "A";
                break;
            case ProductType.B:
                product = new BProduct();
                product.Name = "B";
                break;
            case ProductType.C:
                product = new CProduct();
                product.Name = "C";
                break;
        }
        return product;
    }
}