using Main;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading.Tasks;
using VersionFinal;

namespace Programa
{
    public static class Juego
    {
        private static Random random = new Random(); // Generador de números aleatorios.
        private static string nombrePersonaje = "";
        private static string generoPersonaje = "";
        private static int joyasDeVida = 3; // Inicializar con 3 Joyas de Vida

        // Método que inicia el juego.
        public static void Iniciar()
        {
            // Solicitar el nombre y género del personaje
            Inicio.Principal(out nombrePersonaje, out generoPersonaje);

            // Lista de tableros con tamaños y cantidad de trolls.
            List<(int tamaño, int trolls)> tableroTrolls = new List<(int, int)>
            {
                (3, 0),
                (4, 1),
                (5, 4),
                (6, 7),
                (10, 12)
            };

            int puntaje = 0;
            int tableroActual = 0;

            // Recorre cada tablero de la lista.
            while (tableroActual < tableroTrolls.Count)
            {
                var (size, numTrolls) = tableroTrolls[tableroActual];
                char[,] matriz = new char[size, size]; // Matriz que representa el tablero.
                Matriz.InicializarMatriz(matriz); // Inicializa la matriz con puntos (vacío) desde Matriz.cs.

                // Posición inicial del personaje.
                int personajeX, personajeY;
                if (size == 3)
                {
                    personajeX = 0;
                    personajeY = 0;
                }
                else
                {
                    do
                    {
                        personajeX = random.Next(size);
                        personajeY = random.Next(size);
                    } while (matriz[personajeX, personajeY] != '.');
                }
                matriz[personajeX, personajeY] = '☺'; // Coloca al personaje en la posición inicial.

                // Posición del portal.
                int portalX, portalY;
                if (size == 3)
                {
                    portalX = 2;
                    portalY = 2;
                }
                else
                {
                    do
                    {
                        portalX = random.Next(size);
                        portalY = random.Next(size);
                    } while ((portalX == personajeX && portalY == personajeY) || matriz[portalX, portalY] != '.');
                }
                matriz[portalX, portalY] = 'O'; // Coloca el portal.

                Generador.GenerarTrolls(matriz, size, numTrolls, personajeX, personajeY); // Genera trolls en el tablero desde el Generador.cs.
                int totalItems = Math.Min(6, size * size); // Calcula el total de ítems a generar.
                int itemsRecogidos = 0;
                Generador.GenerarItems(matriz, size, totalItems, personajeX, personajeY); // Genera ítems en el tablero desde el Generador.cs.

                bool juegoTerminado = false;

                // Bucle para el movimiento del personaje hasta que el tablero se complete.
                while (!juegoTerminado)
                {
                    Clear(); // Limpia la consola.
                    Matriz.MostrarMatriz(matriz, personajeX, personajeY, portalX, portalY); // Muestra la matriz en la consola desde Matriz.cs.
                    EstadoJuego.MostrarInstrucciones(nombrePersonaje, generoPersonaje, itemsRecogidos, totalItems, puntaje, joyasDeVida, personajeX, personajeY);
                    // Muestra las instrucciones y el estado actual desde EstadoJuego.cs.
                    var tecla = ReadKey(true).Key; // Lee la tecla presionada sin mostrarla en la consola.

                    // Añadir verificación para terminar el juego si se presiona ESC.
                    if (tecla == ConsoleKey.Escape)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("Juego terminado por el usuario.");
                        ResetColor();
                        ForegroundColor = ConsoleColor.Yellow;
                        WriteLine($"Tu puntaje final es: {puntaje}");
                        ResetColor();
                        ReadKey(true);
                        return; // Termina el juego.
                    }

                    char movimiento = ' ';
                    switch (tecla)
                    {
                        case ConsoleKey.W:
                            movimiento = 'w';
                            break;
                        case ConsoleKey.A:
                            movimiento = 'a';
                            break;
                        case ConsoleKey.S:
                            movimiento = 's';
                            break;
                        case ConsoleKey.D:
                            movimiento = 'd';
                            break;
                    }

                    matriz[personajeX, personajeY] = '.'; // Limpia la posición actual del personaje.

                    int nuevoX = personajeX;
                    int nuevoY = personajeY;

                    // Actualiza la posición del personaje según la tecla presionada.
                    switch (movimiento)
                    {
                        case 'w':
                            if (personajeX > 0) nuevoX--;
                            break;
                        case 'a':
                            if (personajeY > 0) nuevoY--;
                            break;
                        case 's':
                            if (personajeX < size - 1) nuevoX++;
                            break;
                        case 'd':
                            if (personajeY < size - 1) nuevoY++;
                            break;
                    }

                    // Comprueba si el personaje intenta moverse al portal sin haber recogido todos los ítems.
                    if (nuevoX == portalX && nuevoY == portalY && itemsRecogidos < totalItems)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("¡Aún no has recogido todos los cristales! No puedes pasar por el portal, y pierdes 5 puntos!");
                        ResetColor();
                        ForegroundColor = ConsoleColor.Yellow;
                        WriteLine($"Puntaje: {puntaje - 5}");
                        ResetColor();
                        puntaje -= 5;
                        ReadKey();
                        // Restaurar la posición anterior del personaje en la matriz.
                        nuevoX = personajeX;
                        nuevoY = personajeY;
                    }
                    else
                    {
                        personajeX = nuevoX;
                        personajeY = nuevoY;

                        // Comprueba si el personaje encuentra un troll.
                        if (matriz[personajeX, personajeY] == 'T')
                        {
                            int index = random.Next(BancoDePreguntas.preguntas.Count);
                            Pregunta preguntaAleatoria = BancoDePreguntas.preguntas[index];
                            bool respuestaCorrecta = MostrarPregunta.PrintPregunta(preguntaAleatoria, ref puntaje, ref joyasDeVida);

                            if (!respuestaCorrecta && joyasDeVida <= 0)
                            {
                                return; // Termina el juego si se acaban las Joyas de Vida.
                            }
                        }
                        // Comprueba si el personaje recoge un ítem.
                        else if (matriz[personajeX, personajeY] == '♦')
                        {
                            itemsRecogidos++;
                            puntaje += 15;
                        }
                        // Comprueba si el personaje intenta pasar por el portal habiendo recogido todos los ítems.
                        else if (matriz[personajeX, personajeY] == 'O')
                        {
                            Clear();
                            if (tableroActual == tableroTrolls.Count - 1)
                            {
                                puntaje += 1000; // Bonus por completar el último tablero.
                            }
                            else
                            {
                                ForegroundColor = ConsoleColor.Green;
                                WriteLine("¡Has pasado por el portal, aumentas 50 puntos!");
                                ResetColor();
                                ForegroundColor = ConsoleColor.Yellow;
                                WriteLine($"Puntaje: {puntaje + 50}");
                                ResetColor();
                                puntaje += 50;
                            }
                            ReadKey(true);
                            juegoTerminado = true;
                            tableroActual++; // Avanza al siguiente tablero.
                        }
                    }

                    // Coloca al personaje en la nueva posición.
                    matriz[personajeX, personajeY] = '☺';

                    // Asegurarse de que el portal esté en su posición.
                    if (matriz[portalX, portalY] != '☺')
                    {
                        matriz[portalX, portalY] = 'O';
                    }
                }
            }
            ForegroundColor = ConsoleColor.Green;
            WriteLine("**************************************");
            WriteLine("¡Has completado todos los tableros!");
            WriteLine($"Tu puntaje final es: {puntaje}");
            WriteLine("**************************************");
            ResetColor();
            ReadKey(true);
        }
    }
}