using CommandPattern.Services.Abstracts;
using CommandPattern.Services.Concretes;

IStockService stockService = new StockService();
BuyStock buyStock = new(stockService);
SellStock sellStock = new(stockService);

StockController stockController = new();
stockController.TakeOrder(buyStock);
stockController.TakeOrder(buyStock);
stockController.TakeOrder(sellStock);
stockController.PlaceOrder();
stockController.TakeOrder(sellStock);
stockController.PlaceOrder();

Console.ReadLine();