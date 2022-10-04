using Microsoft.EntityFramworkCore;
using UnidadVentas.CapaDeDatos.Contexto;
var builder = WebApplication.CreateBuilder(args);

//Add Services to the Container.

builder.Services.AddControlls();
//Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndoPointApiExplorer();
builder.Services.AddswaggerGen();

builder.Services.AddCors(opt => {
    opt.AddPolicy(name: "Original",
        builder => { builder AllowAnyHeader(). AllowAnyOrigin().AllowAnyMethod(); });
});

builder.Services.AddDbContext<BD_Contexto>(opt => 
opt.UseMySQL(configuration.ConnectionString("proyectocamp"))
);

var proveedor = new UnidadVentas.Servicios.Puerta(builder.Services);
proveedor.Ejecutar();

var app = builder.Build();

//Configure the HTTP request pepiline.
if (app.Enviroment.IsDevelopment())
{ 
    app.UseSwagger();
    app.UseSwagger.UI();
}

app.UseHttpsRedirection();

app.UseAutorization();

app.MapControllers();

app.Run();