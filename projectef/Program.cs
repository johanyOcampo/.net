using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectef;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("cnTareas"));
var app = builder.Build(); //APP CORRIENDO Y ESCUCHANDO PETICIONES



//PARTE 2: VERIFICAR SI LA BD ESTA CORRIENDO
app.MapGet("/", () => "Hello World!");


app.MapGet ("/dbconexion", async([FromServices] TareasContext DbContext) => 
{
    try
    {
        DbContext.Database.EnsureCreated();
        return Results.Ok("Base de datos en memoria: " + DbContext.Database.IsInMemory()); //DEVULEVE TRUE O FALSE
    }
    catch (Exception e)
    {
        return Results.Ok("Error al verificar la base de fatos en memoria: "+ e.Message);
        
    }
});
app.Run();
