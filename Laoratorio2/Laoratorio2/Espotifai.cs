using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio2
{
    class Espotifai //Creo la clase Espotifai
    {
        public Espotifai() //Creo el constructor vacío
        {

        }

        //Creo la lista canciones, que es una lista que va a almacenar los objetos de las canciones 
        List<Cancion> canciones = new List<Cancion>(); 

        //Creo el método AgregarCancion, que recibe una canción y en el caso de no estar en la lista canciones, la agrega
        public bool AgregarCancion(Cancion cancion) 
        {
            for (int i = 0; i < canciones.Count; ++i)
            {
                if (canciones[i].Informacion() == cancion.Informacion())
                {
                    return false; //si la canción si está en la lista retorno inmediatamente false
                }
                else
                {
                    continue; //si la canción no está en la lista, continuo
                }
            }
            canciones.Add(cancion); //si la canción no está en la lista luego de recorrerla completa, agrego la canción y retorna true
            return true;            
        }

        //Creo el método VerCanciones(), el que imprime todas las canciones disponibles con su información correspondiente
        public void VerCanciones() 
        {
            if (canciones.Count == 0)
            {
                Console.WriteLine("No hay canciones");
            }
            foreach (Cancion a in canciones) 
            {
                Console.WriteLine(a.Informacion());
            }
        }


        //Creo el método CancionesPor Criterio, el cual me permite ver las canciones según un criterio y su valor
        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            List<Cancion> respuesta = new List<Cancion>();
            if (criterio == "Nombre")
            {
                foreach (Cancion a in canciones)
                {
                    if (a.Nombre == valor)
                    {
                        respuesta.Add(a);
                    }
                }
            }
            else if (criterio == "Género")
            {
                foreach (Cancion a in canciones)
                {
                    if (a.Género == valor)
                    {
                        respuesta.Add(a);
                    }
                }
            }
            else if (criterio == "Artista")
            {
                foreach (Cancion a in canciones)
                {
                    if (a.Artista == valor)
                    {
                        respuesta.Add(a);
                    }
                }
            }
            else if (criterio == "Álbum")
            {
                foreach (Cancion a in canciones)
                {
                    if (a.Álbum == valor)
                    {
                        respuesta.Add(a);
                    }
                }
            }
            return respuesta;
        }

        //Creo la lista playlist, la que almacena objetos de la clase Playlist
        List<Playlist> playlists = new List<Playlist>();

        //Creo el método para generar Playlist, el que recibe el arreglo con las canciones (utilizando el método anterior) y el nombre de la Playlist
        public bool GenerarPlaylist(List<Cancion> canciones, String nombrePlaylist)
        {

            for (int i = 0; i < playlists.Count; ++i)
            {
                if (playlists[i].Nombre == nombrePlaylist) //Cuando el nombre de la playlist ya existe
                {
                    Console.WriteLine("Ya existe una Playlist con ese nombre");
                    return false; 
                }
            }
            if (canciones.Count == 0) //Cuando no hay canciones que cumplen con el criterio
            {
                Console.WriteLine("No existen canciones que cumplan con el criterio");
                return false;
            }
            else  //Cuando si es posible crear la nueva Playlist
            {
                Playlist nuevaplaylist = new Playlist(nombrePlaylist, canciones);
                playlists.Add(nuevaplaylist);
                return true;
            }
        }

        //Para ver la información de cada Playlist y de cada canción contenida en las Playlist
        public string VerMisPlaylists()
        {
            string resultado = "";
            if (playlists.Count == 0)
            {
                return "No existen Playlist";
            }
            foreach (Playlist i in playlists)
            {
                resultado += i.Informacionplaylist();
                resultado += "\n";
            }
            return resultado;
        }

    }
}
