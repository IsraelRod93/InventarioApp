TipoRetorno nombreMetodo(tipo parametro1, tipo parametro2) {
    //cuerpo del metodo
    return valor;
}

void nombreMetodo(tipo parametro1, tipo parametro2) {
    //cuerpo del metodo
}

int suma(int a, int b) {
    return a + b;
}

void saludar(string nombre) {
    Console.WriteLine($"Hola {nombre}");
}

int resultado = suma(1, 2);
saludar("Juan");


 ## Clase:

class Producto 
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
}

### Enum:

 Sin enun (problema):
 string categoria = "electronica"; -> Minuscula
 string otra = "ELECTRONICA"; -> Mayuscula
 El compilador NO valida, ambas son validas como string
 pero en runtime causaran bugs

 Con enun (seguro):
    public enum CategoriaProductos
    {
        Electronica, //0
        Ropa, //1
        Hogar, //2
        Alimentos, //3
        Bebidas, //4
        Limpieza, //5
        Deportes, //6
        Libros, //7
        Juguetes, //8
        Otros //9
    } 

    usar enum:
    var productos = new Producto {Categoria = CategoriaProducto.Electronica};
    // intellisense sugiere solo valores validos
    // El compilador valida en compile-time

 ## PRODUCTOS.CS:

    Antes                               vs          Después
    public strin Nombre {get; set;}                 //campo privado + setter con guard
    public decimal Precio {get; set;}               //Setter con validación
    public int Cantidad {get; set;}                 //Setter con validación

    // guard clause (mal implementado):
    void ProcesarPago (decimal monto){

        //....100 lineas de codigo....
        if (monto <= 0) // validar al final
        {
            throw new ArgumentException("Monto invalido");
        }
    }

    // Con guard clause (implementado correctamente):
    void ProcesarPago (decimal monto)
    {
        if (monto <= 0) // validar Primero
        {
            throw new ArgumentException("Monto invalido");
            //....100 lineas de codigo....
        }   
    }

    // Guard clause = fail Fast
    // Falla temprano, evita procesamiento innecesario
    // Código mas limpio y legible
    // Menos indentación (no nested if)


## List:
 Ordenada, acceso por indice [0],[1],[2]...
 Uso: Cuando importa el orden   

 var productos = new List<Producto>();
 productos.Add(new Producto { Id = 1, Nombre = "Laptop" });

## Dictionary:
Clave, Valor, ["ID"]  = objeto
Uso: Cuando necesitamos una busqueda rapida

var productos = new Dictionary<int, Producto>();
productos.Add(1, new Producto { Id = 1, Nombre = "Laptop" });

## HasgSet:
Sin duplicados
Uso: Cuando requerimos unicidad

var usuarios = new HashSet<string>();
usuarios.Add("Juan");
usuarios.Add("Maria");
usuarios.Add("Juan"); // No se agrega, ya existe

## LinQ