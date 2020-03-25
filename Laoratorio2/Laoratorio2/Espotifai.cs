using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio2
{
    class Espotifai
    {
        public Espotifai()
        {

        }
        List <dynamic> canciones = new List<dynamic>();
        public bool AgregarCancion(Cancion cancion)
        {
            bool seguir = true;
            do
            {
                for (int i = 0; i < canciones.Count; ++i)
                {
                    if (canciones[i].Informacion() == cancion.Informacion())
                    {
                        seguir= false;
                        return false;
                    }
                    else
                    {
                        seguir = true;
                    }
                }
                canciones.Add(cancion);
                return true;
            }
            while (seguir);      
        }
        public void VerCanciones()
        {
            if (canciones.Count == 0)
            {
                Console.WriteLine("No hay canciones");
            }
            for (int i=0; i < canciones.Count ; ++i)
            {
                Console.WriteLine(canciones[i].Informacion());
            }
            
        }
    }
}
