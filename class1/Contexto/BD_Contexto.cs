using Microsoft.EntityFrameworkCore;
using UnidadVentas.CapaDeDatos.Entidades;

namespace UnidadVentas.CapaDeDatos.Contexto {
    /// <summary>
    /// P0001 se debe crear las entidades que representen las tablas de base de datos con class parciales
    ///Se debe agregar en el metodo OnModelCreating la configuracion que asocia la clase con la tabla
    ///Se debe crear una propiedad publica que represnete la entidad o clase.
    /// </summary>
    public partial class BD_Contexto : DbContext
    {
        public BD_Contexto(DbContextOptions<BD_Contexto> opts) : base(opts) { }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

             modelBuilder.Entity<DTOAcampantes>(entity =>
             
            {
                entity.ToTable("acampantes");
                

                entity.HasKey(e => e.Id);

                entity.Property(e => e.FirstName);

                entity.Property(e => e.LastName);

                entity.Property(e => e.Age);

                entity.Property(e => e.Email);

                entity.Property(e => e.Register);
            });

            modelBuilder.Entity<DTOCampamento>(entity =>

            {
                entity.ToTable("campamento");


                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id_city);

                entity.Property(e => e.CampName);

                entity.Property(e => e.Address);

                entity.Property(e => e.Rate);

            });

            modelBuilder.Entity<DTOCiudad>(entity =>
            {

                entity.ToTable("Ciudad");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.CityName);

            });

            modelBuilder.Entity<DTOEvento>(entity =>
            {

                entity.ToTable("Evento");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id_campament);

                entity.Property(e => e.Id_organizer);

                entity.Property(e => e.EventName);

                entity.Property(e => e.EventDate);

                entity.Property(e => e.DurationDays);


            });

            modelBuilder.Entity<DTOHistorial>(entity =>
            {

                entity.ToTable("Historial");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id_event);

                entity.Property(e => e.Id_organizer);

                entity.Property(e => e.Id_tutor);

                entity.Property(e => e.Id_campers);


            });

            modelBuilder.Entity<DTOOrganizador>(entity =>
            {

                entity.ToTable("Organizador");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.FirstName);

                entity.Property(e => e.Age);
            });

            modelBuilder.Entity<DTOTipoTransporte>(entity =>
            {

                entity.ToTable("TipoTransporte");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Ttype);

            });

            modelBuilder.Entity<DTOTransporte>(entity =>
            {

                entity.ToTable("Transporte");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id_campament);

                entity.Property(e => e.Id_typetransport);

                entity.Property(e => e.License);

            });

            modelBuilder.Entity<DTOTutor>(entity =>
            {

                entity.ToTable("Tutor");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.FirstName);

                entity.Property(e => e.LastName);

                entity.Property(e => e.Age);

                entity.Property(e => e.Relationship);

              
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        public  virtual DbSet<DTOAcampantes> Acampantes { get; set; }
        public virtual DbSet<DTOTransporte> Campamento { get; set; }
        public virtual DbSet<DTOCiudad> Ciudad { get; set; }
        public virtual DbSet<DTOEvento> Evento { get; set; }
        public virtual DbSet<DTOHistorial> Historial { get; set; }
        public virtual DbSet<DTOOrganizador> Organizador { get; set; }
        public virtual DbSet<DTOTipoTransporte> TipoTransporte { get; set; }
        public virtual DbSet<DTOTransporte> Transporte { get; set; }
        public virtual DbSet<DTOTutor> Tutor { get; set; }

    }
}
