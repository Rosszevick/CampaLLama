namespace UnidadVentas.CapaDeDatos.Entidades
{
    public class DTOEvento    {
        public int Id { get; set; }
        public int Id_campament { get; set; }
        public int Id_organizer { get; set; }
        public string? EventName { get; set; }
        public DateTime EventDate { get; set; }
        public int DurationDays{ get; set; }

    }
}
