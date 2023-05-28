using AdapterPattern.Services.Abstracts;
using AdapterPattern.Services.Adapters;
using AdapterPattern.Services.Concretes;

ILogger logger = new CustomLogger();
logger.Log("Custom Logger");

ILogger loggerAdapter = new SeriLogAdapter();
loggerAdapter.Log("Logger Adapter");


Console.ReadLine();