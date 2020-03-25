using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio2
{
    class Cancion //Creo la clase Cancion 
    {
        private string nombre; //Atributo nombre
        private string álbum; //Atributo álbum
        private string artista; //Atributo artista
        private string género; //Atributo género

        public Cancion(string nombre, string álbum, string artista, string género) //Creo el constructr de Cancion
        {
            this.nombre = nombre;
            this.álbum = álbum;
            this.artista = artista;
            this.género = género;
        }

        public string Informacion() //Creo el método Informacion()
        {
            return "género: " + género + ", artista: " + artista + ", álbum: " + álbum + ", nombre: " + nombre; //me devuelve los atributos de la clase Cancion
        }

    }
}
