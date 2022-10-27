using portafolio.Models;

namespace portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
         public List<Proyecto> ObtenerProyectos()
    {
        return new List<Proyecto>() { 
                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-commerce realizado en ASP.NET Core",
                Link = "http://amazon.com",
                ImagenURL = "/imagenes/1.jpg"
            },
               new Proyecto
            {
                Titulo = "SyK",
                Descripcion = "E-commerce realizado en ASP.NET Core",
                Link = "http://amazon.com",
                ImagenURL = "/imagenes/2.jpg"
            },
               new Proyecto
            {
                Titulo ="Diario Epoca",
                Descripcion = "E-commerce realizado en ASP.NET Core",
                Link = "http://amazon.com",
                ImagenURL = "/imagenes/3.jpg"
            },
               new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "E-commerce realizado en ASP.NET Core",
                Link = "http://amazon.com",
                ImagenURL = "/imagenes/4.jpg"
            },

        };
    }
    }
}