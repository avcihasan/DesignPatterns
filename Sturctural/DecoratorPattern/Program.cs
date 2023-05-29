using DecoratorPattern.Decorators;
using DecoratorPattern.Entities;

FenerbahceJersey fb = new() { Size = "L", KDV = 0.10, Price = 100.0 };

SpecialPrice specialPRice = new(fb) { DiscountRate = 50 };

Console.WriteLine(fb.PriceWithKdv);
Console.WriteLine(specialPRice.PriceWithKdv);