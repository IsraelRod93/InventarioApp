using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine($"Version: {version}");