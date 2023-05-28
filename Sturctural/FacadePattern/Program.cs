
using FacadePattern.Services;

AllServicesFacade allServices = new();

allServices.AuthService.SignIn();
allServices.ProductService.AddProduct();
allServices.LogService.Log();

Console.Read();