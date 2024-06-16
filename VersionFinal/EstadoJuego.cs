using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace VersionFinal
{
    public static class EstadoJuego
    {
        // Muestra el estado actual del juego.
        public static void MostrarInstrucciones(string nombre, string genero, int itemsRecogidos, int totalItems, int puntaje, int joyasDeVida, int posX, int posY)
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("\n**** Estado del Juego ****");
            ResetColor();

            if (genero == "Masculino")
            {
                ForegroundColor = ConsoleColor.Blue;
            }
            else if (genero == "Femenino")
            {
                ForegroundColor = ConsoleColor.Magenta;
            }
            WriteLine($"Nombre del avatar: {nombre}");
            WriteLine($"Género del avatar: {genero}");
            ResetColor();

            ForegroundColor = ConsoleColor.Green;
            WriteLine($"Cristales recogidos: {itemsRecogidos}/{totalItems}");
            ResetColor();

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"Joyas de Vida: {joyasDeVida}");
            WriteLine($"Puntaje: {puntaje}");
            ResetColor();


            if (itemsRecogidos == totalItems)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n¡Has recogido todos los cristales! Dirígete al portal para avanzar al siguiente nivel.");
                ResetColor();
            }

            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("\nUsa W (arriba), A (izquierda), S (abajo), D (derecha) para moverte.");
            WriteLine("Usa ESC para salir del juego.");
            ResetColor();
        }
    }
}