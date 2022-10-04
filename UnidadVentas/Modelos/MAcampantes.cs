namespace UnidadVentas.Modelos
{
    public class MAcampantes
    {
        // los modelos se comparten entre NEG y API.
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public DateTime Register { get; set; }


    }
}
