using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    public class Pregunta
    {
        public string Enunciado { get; set; }
        public Dictionary<string, string> Opciones { get; set; }
        public string RespuestaCorrecta { get; set; }
    }

    public static class BancoDePreguntas
    {
        // Lista de preguntas para el juego.
        public static List<Pregunta> preguntas = new List<Pregunta>
        {
            new Pregunta
            {
                Enunciado = "¿Cuál es el río más largo del mundo?",
                Opciones = new Dictionary<string, string>
                {
                    {"a", "Nilo"},
                    {"b", "Amazonas"},
                    {"c", "Motagua"},
                    {"d", "Misisipi"}
                },
                RespuestaCorrecta = "b"
            },
            new Pregunta
            {
                Enunciado = "¿Quién escribió 'Don Quijote de la Mancha'?",
                Opciones = new Dictionary<string, string>
                {
                    {"a", "Miguel de Cervantes"},
                    {"b", "William Shakespeare"},
                    {"c", "Friedrich Nietzsche"},
                    {"d", "Leo Tolstoy"}
                },
                RespuestaCorrecta = "a"
            },
            new Pregunta
            {
                Enunciado = "¿Quién pintó la Mona Lisa?",
                Opciones = new Dictionary<string, string>
                {
                    {"a", "Vincent van Gogh"},
                    {"b", "Leonardo da Vinci"},
                    {"c", "Pablo Picasso"},
                    {"d", "Michelangelo"}
                },
                RespuestaCorrecta = "b"
            },
            new Pregunta
            {
                Enunciado = "¿Cuál es la montaña más alta del mundo?",
                Opciones = new Dictionary<string, string>
                {
                    {"a", "Monte Everest"},
                    {"b", "Monte Kilimanjaro"},
                    {"c", "Monte Fuji"},
                    {"d", "Monte Aconcagua"}
                },
                RespuestaCorrecta = "a"
            },
            new Pregunta
            {
                Enunciado = "¿En qué año comenzó la Primera Guerra Mundial?",
                Opciones = new Dictionary<string, string>
                {
                    {"a", "1914"},
                    {"b", "1916"},
                    {"c", "1918"},
                    {"d", "1920"}
                },
                RespuestaCorrecta = "a"
            },
            new Pregunta
            {
                Enunciado = "¿Cuál es el metal más abundante en la corteza terrestre?",
                Opciones = new Dictionary<string, string>
                {
                    {"a", "Hierro"},
                    {"b", "Oro"},
                    {"c", "Aluminio"},
                    {"d", "Cobre"}
                },
                RespuestaCorrecta = "c"
            },
            new Pregunta
            {
                Enunciado = "¿Quién desarrolló la teoría de la relatividad?",
                Opciones = new Dictionary<string, string>
                {
                    {"a", "Isaac Newton"},
                    {"b", "Albert Einstein"},
                    {"c", "Galileo Galilei"},
                    {"d", "Nikola Tesla"}
                },
                RespuestaCorrecta = "b"
            },
            new Pregunta
            {
                Enunciado = "¿Cuál es el país más grande del mundo?",
                Opciones = new Dictionary<string, string>
                {
                    {"a", "Canadá"},
                    {"b", "China"},
                    {"c", "Estados Unidos"},
                    {"d", "Rusia"}
                },
                RespuestaCorrecta = "d"
            }
        };
    }
}