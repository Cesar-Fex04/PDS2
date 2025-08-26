using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

 
        public class RepositorioProyectos : IRepositorioProyectos
        {

        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
             {

                       new Proyecto()
                    {
                        Titulo = "Amazon",
                        Descripcion = "E-COmerce realizado en ASP.NET core",
                        Link = "https://amazon.com",
                        ImagenURL = "..\\imagenes\\amazon.jpg"
                    }
                    , new Proyecto()
                    {
                        Titulo = "New York Times",
                        Descripcion = "Pagina de noticias en React",
                        Link = "https://nytimes.com",
                        ImagenURL = "..\\imagenes\\nyt.jpg"
                    },
                    new Proyecto()
                    {
                        Titulo = "Reditt",
                        Descripcion = "Red social patra compartir comunidades",
                        Link = "https://reddit.com",
                        ImagenURL = "..\\imagenes\\reddit.jpeg"
                    },
                     new Proyecto()
                    {
                        Titulo = "Steam",
                        Descripcion = "Tienda en linea",
                        Link = "https://store.steampowered.com",
                        ImagenURL = "..\\imagenes\\setam.jpg"
                    }
                };
        }
    }
}
