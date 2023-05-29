using ProxyPattern.Proxies;
using ProxyPattern.Services;

MathBase math = new MathServiceProxy();

Console.WriteLine(math.GetPi());
Console.WriteLine(math.GetPi());
Console.WriteLine(math.GetPi());
Console.WriteLine(math.GetPi());

Console.ReadLine();