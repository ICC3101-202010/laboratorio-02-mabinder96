using System;

namespace Laoratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Espotifai firstprueba = new Espotifai();  //Creo un constructor para correr el programa
            //Agrego canciones de forma manual a la lista (1.1)
            Cancion song1 = new Cancion("Sirenas", "Dr. Chacra", "Taburete", "Pop"); 
            firstprueba.AgregarCancion(song1);
            Cancion song2 = new Cancion("El fin", "Dr. Chacra", "Taburete", "Pop");
            firstprueba.AgregarCancion(song2);
            Cancion song3 = new Cancion("Acordaos", "Mar Adentro", "Misión País", "Religiosa");
            firstprueba.AgregarCancion(song3);
            Cancion song4 = new Cancion("La Luz de Jesús", "Ven y Verás", "Misión País", "Religiosa");
            firstprueba.AgregarCancion(song4);
            Cancion song5 = new Cancion("Tusa", "Tusa", "Karol G", "Reggaeton");
            firstprueba.AgregarCancion(song5);

            Console.WriteLine("¡Bienvenido a Espotifay! \n "); //Doy la bienvenida al programa
            //Utilizo un ciclo so while, para que cuando el usuario no quiera seguir agregando canciones y usando el programa, pueda salir
            bool encender = true;
            do
            {
                //Imprimo las opciones y espero la respuesta del usuario
                Console.WriteLine("Seleccione su opción: ");
                Console.WriteLine("Opción 1: Ver todas las canciones");
                Console.WriteLine("Opción 2: Agregar canción");
                Console.WriteLine("Opción 3: Ver canciones por criterio");
                Console.WriteLine("Opción 4: Salir del programa");
                string elección = Console.ReadLine();

                //Corro el programa según la selección del usuario
                if (elección == "1") 
                {
                    firstprueba.VerCanciones(); //Llamo al método VerCanciones()
                    Console.ReadKey();
                }
                else if (elección == "2")
                {
                    Console.WriteLine("Ingrese nombre de la canción: "); 
                    string Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el álbum de la canción: ");
                    string Álbum = Console.ReadLine();
                    Console.WriteLine("Ingrese el artista de la canción: ");
                    string Artista = Console.ReadLine();
                    Console.WriteLine("Ingrese el género de la canción: ");
                    string Género = Console.ReadLine();
                    Cancion newsong = new Cancion(Nombre, Álbum, Artista, Género);//Agrego la canción en el caso de que no exista
                    if (firstprueba.AgregarCancion(newsong) == true) 
                    {
                        Console.WriteLine("Se ha agregado correctamente la canción");
                    }

                    else if (firstprueba.AgregarCancion(newsong) == false)
                    {
                        Console.WriteLine("La canción ya existe.");
                    }
                    Console.ReadKey();
                }

                else if (elección == "4")
                {
                    encender = false; //Como esta opción es salir, cambio encender a false para que deje de correr el programa
                }

               else if (elección == "3") //Llamo al método ver canciones por criterio (le pregunto antes al usurario el criterio y el valor)
                {
                    Console.WriteLine("Ingrese su criterio: ");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Ingrese el valor del criterio: ");
                    string valor = Console.ReadLine();
                    if (firstprueba.CancionesPorCriterio(criterio, valor).Count == 0)
                    {
                        Console.WriteLine("No se han encontrado canciones que cumplan con el valor solicitado");
                    }
                    else
                    {
                        foreach (Cancion a in firstprueba.CancionesPorCriterio(criterio, valor))
                        {
                            Console.WriteLine(a.Informacion());
                        }
                    }
                    Console.ReadKey();
                }

                else //Creo una opción en el caso que elija otra cosa
                {
                    Console.WriteLine("Esa opción no existe.");
                    Console.ReadKey();
                    encender = false;
                }
               
                Console.Clear(); //Limpio mi pantalla por orden
            }
            while (encender);
           
        }
    }
}
