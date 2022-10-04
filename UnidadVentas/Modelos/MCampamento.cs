namespace UnidadVentas.Modelos
{
    public class MCampamento
    {
        // los modelos se comparten entre NEG y API.
        public int Id { get; set; }
        public int Id_city { get; set; }
        public string? CampName { get; set; }
        public string? Address { get; set; }
        public int Rate { get; set; }
 
    }
}
