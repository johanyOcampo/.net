using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectef.Models;

public class Tarea{
    //[Key] //CLAVE PRIMARIA DE LA TABLA
    public Guid TareaId {get;set;}

    //[ForeignKey("CategoriaID")]
    public Guid CategoriaID {get;set;}
    //[Required]
    //[MaxLength(200)]
    public string Titulo {get;set;}
    public string Descripcion{get;set;}

    public Prioridad PrioridadTarea{get;set;}
    public DateTime FechaCreacion {get;set;}
    public virtual Categoria Categoria{get;set;}
    //[NotMapped] //EL RESUMEN NO SE CREA EN LA BD
    public string Resumen {get;set;} //SE LLENA CON LA DESCRIPCION, PERO NO SE ALMACENA EN LA BD
}

public enum Prioridad{
    Baja,
    Media,
    Alta,
}