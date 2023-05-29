using BridgePattern.Services.Abstracts;
using BridgePattern.Services.Concretes;

IProductService productService = new ProductService(new SmsSender());
productService.CreateProduct();


IProductService productService2 = new ProductService(new MailSender());
productService2.CreateProduct();

Console.ReadLine();