// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

using System.Reflection;
using Internal;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Versión: 1.0.0");
//Interpolacion de cadena
Console.WriteLine($"Version: {version}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}"); //enviar el sistema operativo en el que se esta ejecutando el programa
Console.WriteLine($".NET Version: {Environment.Version}"); //enviar la version de .NET en la que se esta ejecutando el programa
Console.WriteLine();
Console.WriteLine("Estructura dle proyecto");
Console.WriteLine(" InventarioApp/");
Console.WriteLine("  |-- Program.cs");
Console.WriteLine("  |-- InventarioApp.csproj");
Console.WriteLine("  |-- gitignore");
Console.WriteLine("  |-- README.md");
Console.WriteLine("  |-- src/");
Console.WriteLine("  |-- Models/ (Proxima clase)");




Console.WriteLine("Configuracion .csproj");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Agregar argumentos CLI' y configuracion de repositorio en Github");