using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public static class Inicio
    {
        public static void Principal(out string nombre, out string genero)
        {
            nombre = "";
            genero = "";
            bool validInput = false;

            while (!validInput)
            {
                Clear();

                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Selecciona el género de tu avatar:");
                ResetColor();

                ForegroundColor = ConsoleColor.Blue;
                WriteLine("\n1. Masculino");
                ResetColor();

                ForegroundColor = ConsoleColor.Magenta;
                WriteLine("2. Femenino");
                ResetColor();

                ForegroundColor = ConsoleColor.White;
                WriteLine("\nSelecciona una opción...");
                ResetColor();

                int opcion;
                if (int.TryParse(ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            while (string.IsNullOrWhiteSpace(nombre))
                            {
                                Clear();
                                ForegroundColor = ConsoleColor.Blue;
                                WriteLine("Escribe un nombre para tu avatar masculino (♂): ");
                                ResetColor();
                                nombre = ReadLine()!;
                                genero = "Masculino";
                                if (string.IsNullOrWhiteSpace(nombre))
                                {
                                    ForegroundColor = ConsoleColor.Red;
                                    WriteLine("El nombre no puede estar vacío. Por favor, ingresa un nombre válido.");
                                    ResetColor();
                                    WriteLine("Presiona cualquier tecla para intentar de nuevo...");
                                    ReadKey(true);
                                }
                            }
                            validInput = true;
                            break;
                        case 2:
                            while (string.IsNullOrWhiteSpace(nombre))
                            {
                                Clear();
                                ForegroundColor = ConsoleColor.Magenta;
                                WriteLine("Escribe un nombre para tu avatar femenino (♀): ");
                                ResetColor();
                                nombre = ReadLine()!;
                                genero = "Femenino";
                                if (string.IsNullOrWhiteSpace(nombre))
                                {
                                    ForegroundColor = ConsoleColor.Red;
                                    WriteLine("El nombre no puede estar vacío. Por favor, ingresa un nombre válido.");
                                    ResetColor();
                                    WriteLine("Presiona cualquier tecla para intentar de nuevo...");
                                    ReadKey(true);
                                }
                            }
                            validInput = true;
                            break;
                        default:
                            Clear();
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("Error generado, no seleccionaste la opción correcta.");
                            ResetColor();
                            WriteLine("Presiona cualquier tecla para intentar de nuevo...");
                            ReadKey(true);
                            break;
                    }
                }
                else
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Error generado, no seleccionaste la opción correcta.");
                    ResetColor();
                    WriteLine("Presiona cualquier tecla para intentar de nuevo...");
                    ReadKey(true);
                }
            }
        }
    }
}
