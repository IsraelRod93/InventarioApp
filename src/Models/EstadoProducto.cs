namespace InventarioApp.Models;

///<summary>
/// Ciclo de vida de un producto en el inventario
///</summary>



public enum EstadoProducto {
    /// <summary> Producto activo en el inventario </summary>
    Activo,
    /// <summary> Producto inactivo en el inventario </summary>
    Inactivo,
    /// <summary> Producto descontinuado en el inventario </summary>
    Descontinuado
}