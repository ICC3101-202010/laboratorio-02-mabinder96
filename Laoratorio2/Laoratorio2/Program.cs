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
            Cancion song6 = new Cancion("Walter Palmeras", "Seis Tequilas", "Taburete", "Pop");
            firstprueba.AgregarCancion(song6);
            Cancion song7 = new Cancion("Vuela", "Como un niño", "Colegio Mayor Padre José Kentenich", "Religiosa");
            firstprueba.AgregarCancion(song7);
            Cancion song8 = new Cancion("Hasta Abajo", "Sex and Love", "Don Omar", "Reggaeton");
            firstprueba.AgregarCancion(song8);
            Cancion song9 = new Cancion("Viva la Vida", "Live in Buenos Aires", "Coldplay", "Pop");
            firstprueba.AgregarCancion(song9);
            Cancion song10 = new Cancion("Lovumba", "Prestige", "Daddy Yankee", "Reggaeton");
            firstprueba.AgregarCancion(song10);
            Cancion song11 = new Cancion("Canon in D", "Canon in D", "Pachabel", "Piano");
            firstprueba.AgregarCancion(song11);
            Cancion song12 = new Cancion("Lavender´s Blue", "Sleep Baby Sleep", "Jim Brickman", "Piano");
            firstprueba.AgregarCancion(song12);
            Cancion song13 = new Cancion("Una mattina", "2004", "Ludovico Einaudi", "Piano");
            firstprueba.AgregarCancion(song13);


            //Doy la bienvenida al programa
            Console.WriteLine("¡Bienvenido a Espotifay! \n "); 

            //Utilizo un ciclo do while, para que cuando el usuario no quiera seguir agregando canciones y usando el programa, pueda salir
            bool encender = true;
            do
            {
                //Imprimo las opciones y espero la respuesta del usuario
                Console.WriteLine("Seleccione su opción: ");
                Console.WriteLine("Opción 1: Ver todas las canciones");
                Console.WriteLine("Opción 2: Agregar canción");
                Console.WriteLine("Opción 3: Ver canciones por criterio");
                Console.WriteLine("Opción 4: Crear Playlist");
                Console.WriteLine("Opción 5: Ver mis PLaylist");
                Console.WriteLine("Opción 6: Salir del programa");
                string elección = Console.ReadLine();

                //Corro el programa según la selección del usuario

                //Al seleccionar la opción 1, llamo al método VerCanciones()
                if (elección == "1") 
                {
                    firstprueba.VerCanciones(); 
                    Console.ReadKey();
                }

                //Al seleccionar la opción 2, agrego una nueva canción
                else if (elección == "2")
                {
                    //Le pregunto al usuario todas las características de la canción
                    Console.WriteLine("Ingrese nombre de la canción: "); 
                    string Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el álbum de la canción: ");
                    string Álbum = Console.ReadLine();
                    Console.WriteLine("Ingrese el artista de la canción: ");
                    string Artista = Console.ReadLine();
                    Console.WriteLine("Ingrese el género de la canción: ");
                    string Género = Console.ReadLine();

                    Cancion newsong = new Cancion(Nombre, Álbum, Artista, Género); //Hago el constructor de la canción

                    //Agrego la canción en el caso de que no exista
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

                //Al seleccionar la opción 3, llamo al método ver canciones por criterio
               else if (elección == "3") 
                {
                    //Le pido al usuario el criterio que desea y el valor del criterio
                    Console.WriteLine("Ingrese su criterio: ");
                    Console.WriteLine("Opción 1: Nombre");
                    Console.WriteLine("Opción 2: Género");
                    Console.WriteLine("Opción 3: Artista");
                    Console.WriteLine("Opción 4: Álbum");
                    string criterio = Console.ReadLine();

                    switch (criterio)
                    {
                        case "1": criterio = "Nombre"; break;
                        case "2": criterio = "Género"; break;
                        case "3": criterio = "Artista"; break;
                        case "4": criterio = "Álbum"; break;
                    }
                    
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

                //Si el usuario selecciona la opción 4, creo una playlist. 
                else if (elección == "4")
                {
                    //Le pido al usuario el criterio, el valor del criterio 
                    Console.WriteLine("Ingrese su criterio: ");
                    Console.WriteLine("Opción 1: Nombre");
                    Console.WriteLine("Opción 2: Género");
                    Console.WriteLine("Opción 3: Artista");
                    Console.WriteLine("Opción 4: Álbum");
                    string criterio = Console.ReadLine();

                    switch (criterio)
                    {
                        case "1": criterio = "Nombre"; break;
                        case "2": criterio = "Género"; break;
                        case "3": criterio = "Artista"; break;
                        case "4": criterio = "Álbum"; break;
                    }
                    Console.WriteLine("Ingrese el valor del criterio: ");
                    string valorCriterio = Console.ReadLine();

                    //Usando el método CancionesPorCriterio creo el arreglo de canciones que va a llevar la playlist
                    dynamic canciones = firstprueba.CancionesPorCriterio(criterio, valorCriterio);

                    //Le pido al usuario el nombre de la playlist y analizo si ya existe o no
                    Console.WriteLine("Ingrese el nombre de su Playlist: ");
                    string nombrePlaylist = Console.ReadLine();
                    bool prueba=firstprueba.GenerarPlaylist(canciones, nombrePlaylist);
                    if (prueba == true)
                    {
                        Console.WriteLine("Se ha agregado correctamente la Playlist");
                    }
                    Console.ReadKey();
                }

                //Si el usuario selecciona la opción 5, entrego la información de las Playlist
                else if (elección == "5")
                {
                    firstprueba.VerMisPlaylists();
                    Console.ReadKey();
                }

                //Si el usuario selecciona la opción 6, salgo del programa
                else if (elección == "6")
                {
                    encender = false; //Cambio encender a false para que deje de correr el programa 
                    //No pongo Console.ReadKey, para que se cierre la ventana
                }

                else //Creo una opción en el caso que elija otra cosa
                {
                    Console.WriteLine("Esa opción no existe. ¿Desea continuar?");
                    Console.WriteLine("Opción 1: Sí");
                    Console.WriteLine("Opción 2: No");
                    string respuesta = Console.ReadLine();

                    if (respuesta == "1")
                    {
                        encender = true;
                    }

                    else
                    {
                        encender = false; //Si elije no, se cierra la ventana
                    }
                }
               
                Console.Clear(); //Limpio mi pantalla por orden
            }
            while (encender);  
        }
    }
}
