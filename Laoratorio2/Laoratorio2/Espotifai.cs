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
        List<Cancion> canciones = new List<Cancion>(); //Creo la lista canciones, que es una lista que va a almacenar los objetos de las canciones 
        public bool AgregarCancion(Cancion cancion) //Creo el método AgregarCancion, que recibe una canción y en el caso de no estar en la lista canciones, la agrega
        {
            bool seguir = true; //Para analizar si ya está o no en la lista uso el ciclo do while y recorro la lista 
            do
            {
                for (int i = 0; i < canciones.Count; ++i)
                {
                    if (canciones[i].Informacion() == cancion.Informacion())
                    {
                        seguir = false;
                        return false; //si la canción si está en la lista, el ciclo while se para
                    }
                    else
                    {
                        seguir = true; //si la canción no está en la lista sigue buscando
                    }
                }
                canciones.Add(cancion); //si la canción no está en la lista luego de recorrerla completa, agrego la canción y retorna true
                return true;
            }
            while (seguir);
        }
        public void VerCanciones() //Creo el método VerCanciones(), el que imprime todas las canciones disponibles con su información correspondiente
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


        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            List<Cancion> respuesta = new List<Cancion>();
            if (criterio == "nombre" || criterio == "Nombre")
            {
                foreach (Cancion a in canciones)
                {
                    if (a.Nombre == valor)
                    {
                        respuesta.Add(a);
                    }
                }
            }
            else if (criterio == "género" || criterio == "Género")
            {
                foreach (Cancion a in canciones)
                {
                    if (a.Género == valor)
                    {
                        respuesta.Add(a);
                    }
                }
            }
            else if (criterio == "artista" || criterio == "Artista")
            {
                foreach (Cancion a in canciones)
                {
                    if (a.Artista == valor)
                    {
                        respuesta.Add(a);
                    }
                }
            }
            else if (criterio == "álbum" || criterio == "Álbum")
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
    }
}
