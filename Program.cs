using System.Reflection; // Permite acceder a la información del programa (metadatos)

// --- CONFIGURACIÓN INICIAL ---
// Obtenemos la información del "ensamblado" (tu programa ejecutándose)
var assembly = Assembly.GetExecutingAssembly();
// Extraemos la versión definida en los archivos del proyecto
var version = assembly.GetName().Version;

// Variables de estado del inventario (datos temporales)
int cantidadProductos = 0;
decimal valorTotalInventario = 0.00m; // El sufijo 'm' indica que es tipo decimal (ideal para dinero)
bool sistemaActivo = true; // Controla si el ciclo principal debe seguir corriendo

// --- MANEJO DE ARGUMENTOS (dotnet run --opción) ---
// args contiene las palabras que escribes después de ejecutar el programa
if (args.Length > 0)
{
    // Evaluamos el primer argumento (args[0]) convirtiéndolo a minúsculas
    switch (args[0].ToLower())
    {
        case "--help":
        case "-h":
            MostrarAyuda();
            Environment.Exit(0); // Cierra el programa con éxito
            break;
        case "--version":
        case "-v":
            Console.WriteLine($"InventarioApp v{version}");
            Environment.Exit(0);
            break;
        default:
            // Si escriben algo que no existe, mostramos error y salimos
            Console.WriteLine($"Error: Comando '{args[0]}' no reconocido");
            Console.WriteLine("Use --help para ver comandos disponibles.");
            Environment.Exit(2); // El código 2 indica un error de argumentos
            break;
    }
}

// --- INICIO DE LA INTERFAZ ---
MostrarBanner();
Console.WriteLine("Comandos disponibles: listar, agregar, buscar, salir");
Console.WriteLine();

// --- BUCLE PRINCIPAL (Modo Interactivo) ---
// Mientras sistemaActivo sea verdadero, el programa no se cerrará
while (sistemaActivo)
{
    Console.Write("inventario> ");
    // Leemos lo que el usuario escribe
    string? entrada = Console.ReadLine();
    // Trim() quita espacios extras y ToLower() estandariza a minúsculas
    // ?? "salir" es un valor por defecto si la entrada es nula
    string comando = entrada?.Trim().ToLower() ?? "salir";

    // Lógica para decidir qué hacer según el comando
    switch (comando)
    {
        case "salir":
        case "exit":
        case "q":
            sistemaActivo = false; // Esto romperá el ciclo 'while' en la próxima vuelta
            Console.WriteLine("¡Hasta luego!");
            break;
        case "listar":
            // :N2 aplica un formato de número con 2 decimales
            Console.WriteLine($"📦 Productos en inventario: {cantidadProductos}");
            Console.WriteLine($"💰 Valor total: ${valorTotalInventario:N2}");
            break;
        case "agregar":
            Console.WriteLine("📝 Función agregar (se implementará en Módulo 3)");
            break;
        case "buscar":
            Console.WriteLine("🔍 Función buscar (se implementará en Módulo 4)");
            break;
        case "":
            // Si el usuario solo presiona Enter, no hacemos nada
            break;
        default:
            Console.WriteLine($"❌ Comando '{comando}' no reconocido");
            Console.WriteLine("   Use: listar, agregar, buscar, salir");
            break;
    }

    // Si el usuario no eligió salir, dejamos un espacio en blanco antes de pedir el siguiente comando
    if (sistemaActivo)
        Console.WriteLine();
}

// Salida formal del programa
Environment.Exit(0);

// --- MÉTODOS (Funciones de apoyo) ---

void MostrarBanner()
{
    Console.WriteLine("╔══════════════════════════════════════╗");
    Console.WriteLine("║   SISTEMA DE GESTIÓN DE INVENTARIO   ║");
    Console.WriteLine("╚══════════════════════════════════════╝");
    Console.WriteLine();
    // Mostramos información técnica útil del sistema
    Console.WriteLine($"Versión: {version}");
    Console.WriteLine($".NET: {Environment.Version}");
    Console.WriteLine($"Sistema: {Environment.OSVersion.Platform}");
    Console.WriteLine();
}

void MostrarAyuda()
{
    Console.WriteLine("USO: dotnet run [opciones]");
    Console.WriteLine();
    Console.WriteLine("OPCIONES:");
    Console.WriteLine("  --help, -h       Muestra esta ayuda");
    Console.WriteLine("  --version, -v    Muestra la versión");
    // ... más líneas de ayuda ...
}