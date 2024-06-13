using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_peliculas_en_archivo_de_texto
{
    public class Peliculas_class
    {
            public string Titulo { get; set; }
            public string Genero { get; set; }
            public string  Duracion { get; set; }
            public string Director { get; set; }
            public string Productora { get; set; }

            public Peliculas_class(string titulo, string genero, string duracion, string director, string productora)
            {
                Titulo = titulo;
                Genero = genero;
                Duracion = duracion;
                Director = director;
                Productora = productora;
            }
        }
    }

