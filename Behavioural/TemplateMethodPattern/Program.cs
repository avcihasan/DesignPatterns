using TemplateMethodPattern.Services.Abstracts;
using TemplateMethodPattern.Services.Concretes;

DiscountAlgorithm discountAlgorithm;

discountAlgorithm = new WomenDiscountAlgorithm();
Console.WriteLine("Women : {0}",discountAlgorithm.GeneratePrice(25,10,250));

discountAlgorithm = new MansDiscountAlgorithm();
Console.WriteLine("Mans : {0}", discountAlgorithm.GeneratePrice(25, 10, 250));

Console.ReadLine();