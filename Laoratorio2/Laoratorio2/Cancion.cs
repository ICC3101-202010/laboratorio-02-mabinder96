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
            this.Nombre = nombre;
            this.Álbum = álbum;
            this.Artista = artista;
            this.Género = género;
        }

        public string Nombre 
        {
            get => nombre; 
            set => nombre = value; 
        }
        public string Álbum 
        {
            get => álbum; 
            set => álbum = value; 
        }
        public string Artista 
        {
            get => artista; 
            set => artista = value; 
        }
        public string Género 
        {
            get => género; 
            set => género = value; 
        }

        public string Informacion() //Creo el método Informacion()
        {
            return "género: " + Género + ", artista: " + Artista + ", álbum: " + Álbum + ", nombre: " + Nombre; 
        }

    }
}
