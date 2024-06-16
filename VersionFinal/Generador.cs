using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace VersionFinal
{
    public static class Generador
    {
                private static Random random = new Random(); // Generador de números aleatorios.

        // Genera trolls en posiciones aleatorias de la matriz.
        public static void GenerarTrolls(char[,] matriz, int size, int numTrolls, int personajeX, int personajeY)
        {
            for (int i = 0; i < numTrolls; i++)
            {
                int trollX, trollY;
                do
                {
                    trollX = random.Next(size);
                    trollY = random.Next(size);
                } while ((trollX == personajeX && trollY == personajeY) || matriz[trollX, trollY] != '.');

                matriz[trollX, trollY] = 'T';
            }
        }



        // Genera ítems en posiciones aleatorias de la matriz.
        public static void GenerarItems(char[,] matriz, int size, int totalItems, int personajeX, int personajeY)
        {
            for (int i = 0; i < totalItems; i++)
            {
                int itemX, itemY;
                do
                {
                    itemX = random.Next(size);
                    itemY = random.Next(size);
                } while ((itemX == personajeX && itemY == personajeY) || matriz[itemX, itemY] != '.');

                matriz[itemX, itemY] = '♦';
            }
        }
    }
}