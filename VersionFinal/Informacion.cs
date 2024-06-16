using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public static class Informacion
    {
        public static void Info()
        {
            Clear();

            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("*** INFORMACIÓN ***");
            ResetColor();


            ForegroundColor = ConsoleColor.Green;
            WriteLine("\nDesarrollador: @axelmarroquinn");
            ResetColor();

            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Creado y desarrollado en Guatemala, al mes de Junio de 2024.");
            ResetColor();

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\nPresiona cualquier tecla para volver al menú principal...");
            ResetColor();

            ReadKey(true);
            Clear();
        }
    }
}
