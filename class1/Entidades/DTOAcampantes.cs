

namespace UnidadVentas.CapaDeDatos.Entidades
{
    // DTO son los modelos de salida del la capa de datos.
    public partial class DTOAcampantes
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public DateTime Register { get; set; } 
  
    }
}
