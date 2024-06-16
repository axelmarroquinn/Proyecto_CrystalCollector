using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace VersionFinal
{
    public static class Matriz
    {
        // Inicializa la matriz con puntos (vacío).
        public static void InicializarMatriz(char[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = '.';
                }
            }
        }


        // Muestra la matriz en la consola.
        public static void MostrarMatriz(char[,] matriz, int personajeX, int personajeY, int portalX, int portalY)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == personajeX && j == personajeY)
                    {
                        ForegroundColor = ConsoleColor.Yellow;
                        Write('☺' + " ");
                    }
                    else if (i == portalX && j == portalY)
                    {
                        ForegroundColor = ConsoleColor.Magenta;
                        Write('O' + " ");
                    }
                    else if (matriz[i, j] == 'T')
                    {
                        ForegroundColor = ConsoleColor.Gray;
                        Write('.' + " "); // Muestra los trolls como puntos, pero la lógica se mantiene como T.
                    }
                    else if (matriz[i, j] == '♦')
                    {
                        ForegroundColor = ConsoleColor.DarkCyan;
                        Write(matriz[i, j] + " ");
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Gray;
                        Write(matriz[i, j] + " ");
                    }
                }
                WriteLine();
            }
            ResetColor(); // Restablece el color después de mostrar la matriz.
        }
    }
}
