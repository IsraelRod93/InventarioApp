namespace InventarioApp.Models;

public class Producto {
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
    public CategoriaProducto Categoria { get; set; }
    public EstadoProducto Estado { get; set; } = EstadoProducto.Activo;
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public decimal Valortotal => Precio * Cantidad;
    
    public override string ToString() => $"{Id} - {Nombre} - {Precio:N2} - {Cantidad} - {Valortotal:N2}";
}