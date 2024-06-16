using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    public static class Instrucciones
    {
        public static void MostrarInstrucciones()
        {
            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("*** INSTRUCCIONES ***");
            ResetColor();

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\n1. Movimiento del personaje:");
            ForegroundColor = ConsoleColor.White;
            WriteLine("   - Usa las siguientes teclas para mover a tu personaje '☺' por el tablero:");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("     - W: Mover hacia arriba");
            WriteLine("     - A: Mover hacia la izquierda");
            WriteLine("     - S: Mover hacia abajo");
            WriteLine("     - D: Mover hacia la derecha");
            WriteLine();

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("2. Objetivo del juego:");
            ForegroundColor = ConsoleColor.White;
            WriteLine("   - Recoge todos los diamantes '♦' del tablero antes de intentar pasar por el portal 'O'.");
            WriteLine("   - Debes recoger todos los diamantes en el tablero actual para poder avanzar al siguiente nivel.");
            WriteLine();

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("3. Trolls:");
            ForegroundColor = ConsoleColor.White;
            WriteLine("   - Los trolls son invisibles y se representan como puntos ('.') en el tablero.");
            WriteLine("   - Si te encuentras con un troll, deberás responder una pregunta de trivia correctamente para continuar.");
            WriteLine("   - Responder correctamente te otorga puntos y una joya de vida adicional, mientras que una respuesta incorrecta te resta puntos y una joya de vida.");
            WriteLine("   - Una vez que superes al troll, no volverá a aparecer en la misma posición del tablero.");
            WriteLine("   - Si respondes incorrectamente, deberás repetir la pregunta hasta que la respondas correctamente o pierdas todas tus joyas de vida.");
            WriteLine();

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("4. Portal:");
            ForegroundColor = ConsoleColor.White;
            WriteLine("   - El portal 'O' te permite avanzar al siguiente nivel una vez que hayas recogido todos los diamantes.");
            WriteLine("   - Si intentas pasar por el portal sin haber recogido todos los diamantes, perderás puntos.");
            WriteLine();

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("5. Puntuación:");
            ForegroundColor = ConsoleColor.White;
            WriteLine("   - Recoger un diamante te otorga 15 puntos.");
            WriteLine("   - Responder correctamente a una pregunta de trivia te otorga 10 puntos y una joya de vida.");
            WriteLine("   - Responder incorrectamente a una pregunta de trivia te resta 20 puntos y una joya de vida.");
            WriteLine("   - Pasar por el portal te otorga 50 puntos.");
            WriteLine("   - Completar todos los niveles te otorga un bono de 1000 puntos.");
            WriteLine();

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("6. Final del juego:");
            ForegroundColor = ConsoleColor.White;
            WriteLine("   - El juego termina cuando completas todos los niveles o decides salir presionando la tecla ESC.");
            WriteLine("   - Tu puntuación final se mostrará al terminar el juego.");
            WriteLine();

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Presiona cualquier tecla para volver al menú principal...");
            ResetColor();
            ReadKey(true);
        }
    }
}