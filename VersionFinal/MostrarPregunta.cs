using Programa;
using System;
using static System.Console;

namespace VersionFinal
{
    public static class MostrarPregunta
    {
        // Muestra una pregunta y verifica la respuesta del usuario.
        public static bool PrintPregunta(Pregunta pregunta, ref int puntaje, ref int joyasDeVida)
        {
            bool respuestaCorrecta = false;

            while (!respuestaCorrecta && joyasDeVida > 0)
            {
                Clear();
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("¡Oops! Has encontrado un troll. Pero no te preocupes, aquí tienes una pregunta de cultura general:");
                ResetColor();

                ForegroundColor = ConsoleColor.Cyan;
                WriteLine(pregunta.Enunciado);
                ResetColor();

                foreach (var opcion in pregunta.Opciones)
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine($"{opcion.Key}) {opcion.Value}");
                    ResetColor();
                }

                ForegroundColor = ConsoleColor.White;
                Write("Ingresa la letra de tu respuesta: ");
                ResetColor();
                string respuestaUsuario = ReadLine().ToLower();

                if (respuestaUsuario == pregunta.RespuestaCorrecta)
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Respuesta correcta. ¡Puedes continuar, obtienes 10 puntos y una joya de vida!");
                    ResetColor();
                    puntaje += 10;
                    joyasDeVida++;
                    respuestaCorrecta = true;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Respuesta incorrecta. ¡Pierdes 20 puntos y una joya de vida!");
                    puntaje -= 20;
                    joyasDeVida--;
                    ResetColor();
                }

                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"Puntaje: {puntaje}");
                WriteLine($"Joyas de Vida: {joyasDeVida}");
                ResetColor();
                WriteLine("Presiona cualquier tecla para continuar...");
                ReadKey(true);

                if (joyasDeVida <= 0)
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Has perdido todas tus Joyas de Vida. ¡Juego terminado!");
                    ResetColor();
                    WriteLine($"Tu puntaje final es: {puntaje}");
                    ResetColor();
                    ReadKey(true);
                }
            }

            return respuestaCorrecta;
        }
    }
}