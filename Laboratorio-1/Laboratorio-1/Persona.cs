using System;

namespace Laboratorio1
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Lanzar()
        {
            Random rand = new Random();

            return rand.Next(0, 3);
        }

    }
}
