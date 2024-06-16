using Main;
using static System.Console;
namespace Programa
{
    public static class Menu
    {
        public static void MostrarMenu()
        {
            bool salir = false;
            while (!salir)
            {
                Clear();
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("*** MENÚ PRINCIPAL ***");
                ResetColor();

                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("\nSeleccione una opción:");
                ResetColor();

                ForegroundColor = ConsoleColor.White;
                WriteLine("\n1. Iniciar juego");
                WriteLine("2. Mostrar instrucciones");
                WriteLine("3. Información sobre CRYSTAL COLLECTOR");
                WriteLine("3. Salir");
                Write("\nOpción: ");

                string opcion = ReadLine();
                switch (opcion)
                {
                    case "1":
                        Juego.Iniciar();
                        break;
                    case "2":
                        Instrucciones.MostrarInstrucciones();
                        break;
                    case "3":
                        Informacion.Info();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Opción no válida. Intente de nuevo.");
                        ResetColor();
                        break;
                }
            }
        }
    }
}