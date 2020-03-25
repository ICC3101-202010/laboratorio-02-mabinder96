using System;

namespace Laoratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Espotifai firstprueba = new Espotifai();  //Creo un constructor para correr el programa
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
            Console.WriteLine("Bienvenido a Espotifay "); 
            bool encender = true; 
            do  //Creo un ciclo do while para que el programa se repita hasta que la persona salga
            {
                Console.WriteLine("Seleccione su opción: ");
                Console.WriteLine("Opción 1: Ver todas las canciones");
                Console.WriteLine("Opción 2: Agregar canción");
                Console.WriteLine("Opción 3: Salir del programa");
                string elección = Console.ReadLine();
                if ((Convert.ToInt32(elección) == 1))
                {
                    firstprueba.VerCanciones();
                    Console.ReadKey();
                }
                else if ((Convert.ToInt32(elección) == 2))
                {
                    Console.WriteLine("Ingrese nombre de la canción: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el álbum de la canción: ");
                    string álbum = Console.ReadLine();
                    Console.WriteLine("Ingrese el artista de la canción: ");
                    string artista = Console.ReadLine();
                    Console.WriteLine("Ingrese el género de la canción: ");
                    string género = Console.ReadLine();
                    Cancion newsong = new Cancion(nombre, álbum, artista, género);
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

                else if ((Convert.ToInt32(elección) == 3))
                {
                    encender = false;
                }
                
                Console.Clear();
            }
            while (encender);

        }
    }
}
