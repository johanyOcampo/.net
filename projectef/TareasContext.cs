using Microsoft.EntityFrameworkCore;
using projectef.Models;
namespace projectef;

public class TareasContext:DbContext
{
//AQUIE SE IMPORRTA LA LIBRERIA USING QUE REPRESENTA
//LAS TABLAS DENTRO DE LA BD

public DbSet<Categoria> Categorias{get;set;} //SI DIERA ERROR, IMPORTA USING PROJECTEF.MODELS
public DbSet<Tarea> Tareas{get;set;}

//CREAR EL METODO BASE DEL CONTROLADOR
public TareasContext (DbContextOptions<TareasContext>options):base(options){}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.Entity<Categoria>(categoria => 
       {
        categoria.ToTable("Categoria"); //CREAR LA TABLA CATEGORIA
        categoria.HasKey(p=> p.CategoriaId); //CREAR EL CATEGORIAID
        //
        categoria.Property(p=> p.Nombre).IsRequired().HasMaxLength(150); //CREAR Y VALIDAR EL CAMPO CATEGORIA
        categoria.Property(p=> p.Descripcion);

       });
       
       modelBuilder.Entity<Tarea>(tarea =>
       {
        tarea.ToTable("Tarea"); //CREAR LA TABLA TAREA
        tarea.HasKey(p=> p.TareaId); //CREAR LA PK DE LA TABLA
        tarea.HasOne(p=> p.Categoria).WithMany(p=> p.Tareas).HasForeignKey(p=> p.CategoriaID); //CLAVE FORANEA
        tarea.Property(p=> p.Titulo).IsRequired().HasMaxLength(200);
        tarea.Property(p=> p.Descripcion);
        tarea.Property(p=> p.PrioridadTarea);
        tarea.Property(p=> p.FechaCreacion);
        tarea.Ignore(p=> p.Resumen);
       });
    }
}