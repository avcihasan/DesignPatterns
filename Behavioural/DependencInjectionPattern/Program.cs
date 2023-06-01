using DependencInjectionPattern.Services.Abstracts;
using DependencInjectionPattern.Services.Concretes;
using Ninject;

//IProductService productService1 = new ProductService(new EfProductDal());
//productService1.GetProducts();

//IProductService productService2 = new ProductService(new NhProductDal());
//productService2.GetProducts();

IKernel kernel = new StandardKernel(); 
kernel.Bind<IProductService>().To<ProductService>();    
kernel.Bind<IProductDal>().To<EfProductDal>();

kernel.Get<IProductService>().GetProducts();

Console.ReadLine();