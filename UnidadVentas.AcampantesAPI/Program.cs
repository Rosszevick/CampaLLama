using Microsoft.EntityFrameworkCore;
using UnidadVentas.CapaDeDatos.Contexto;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt => {
    opt.AddPolicy(name: "Original",
        builder => { builder.AllowAnyHeader(). AllowAnyOrigin().AllowAnyMethod(); });
});

builder.Services.AddDbContext<BD_Contexto>(opt =>
opt.UseSqlServer(builder.Configuration.GetConnectionString("CampaLlama"))
);

var proveedor = new UnidadVenta.servicio.Puerta(builder.Services);
proveedor.Ejecutar();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("Original");
app.Run();
