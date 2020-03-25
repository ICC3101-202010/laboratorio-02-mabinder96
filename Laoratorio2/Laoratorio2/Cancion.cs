using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio2
{
    class Cancion
    {
        private string nombre;
        private string álbum;
        private string artista;
        private string género;

        public Cancion(string nombre, string álbum, string artista, string género)
        {
            this.nombre = nombre;
            this.álbum = álbum;
            this.artista = artista;
            this.género = género;
        }

        public string Informacion()
        {
            return "género: " + género + ", artista: " + artista + ", álbum: " + álbum + ", nombre: " + nombre;
        }

    }
}
