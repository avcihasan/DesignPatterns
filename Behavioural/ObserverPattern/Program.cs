using ObserverPattern.Observers.Concretes;
using ObserverPattern.Services.Abstracts;
using ObserverPattern.Services.Concretes;

IProductService service = new ProductService();
service.Attach(new CustomerObserver());
service.Attach(new EmployeeObserver());
service.Attach(new CustomerObserver());
service.UpdateProduct();

Console.ReadLine();