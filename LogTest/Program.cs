// See https://aka.ms/new-console-template for more information
using NLog;

Console.WriteLine("Hello, World!");
Logger Logger =NLog.LogManager.GetCurrentClassLogger();
try
{
  Logger.Info("Hello World");  
}
catch (System.Exception)
{
    
    Logger.Error("Goodbay cruel wordl");
}

