using StrategyPattern.Services.Abstracts;
using StrategyPattern.Services.Concretes;

IUserService userService1 = new UserService(new YapiKrediCreditCalculator());

userService1.SaveCredit();

Console.WriteLine("-------------------------");

IUserService userService2 = new UserService(new HalkbankCreditCalculator());
userService2.SaveCredit();