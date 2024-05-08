namespace ProyectoBookSwap.Models
{
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public Libros oProducto { get; set; }
        public Usuarios oUsuario { get; set; }
    }
}
