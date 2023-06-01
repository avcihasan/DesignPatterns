using NullObjcetPattern.Services.Abstracts;
using NullObjcetPattern.Services.Concretes;
using NullObjcetPattern.Tests;

IProductService service = new ProductService(new Nlog());
service.CreateProduct();

ProductServiceTests productServiceTests = new();
productServiceTests.CreateProductTest();

Console.ReadLine();