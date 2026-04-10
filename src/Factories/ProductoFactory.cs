namespace InventarioApp.Factories;

using InventarioApp.Models;

public static class ProductoFactory
{
   private static int _nextId = 1;

   public static Producto CrearProducto(string nombre, decimal precio, int cantidad)
   {
       return new Producto
       {
           Id = _nextId++,
           Nombre = nombre,
           Precio = precio,
           Cantidad = cantidad
       };
   }
}