using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio2
{
    class Playlist
    {
        private string nombre; //Atributo nombre
        private List<Cancion> canciones; //Arreglo de la clase Canción

        public Playlist(string nombre, List<Cancion> canciones)
        {
            this.nombre = nombre;
            this.canciones = canciones;
            
        }
        public string Nombre 
        { 
            get => nombre;
            set => nombre = value; 
        }
        internal List<Cancion> Canciones 
        {
            get => canciones; 
            set => canciones = value; 
        }

        public string Informacionplaylist() //Creo el método Informacionplaylist() que me permite ver su información
        {
            string resultado = "";
            if (canciones.Count() == 0)
            {
                return "Playlist vacía";
            }
            else
            {
                resultado+="Nombre Playlist: " + nombre  + "\n";
                foreach (Cancion i in canciones)
                {
                    resultado +=i.Informacion()+"\n";
                }
            }
            return resultado;
        }
    }
}

