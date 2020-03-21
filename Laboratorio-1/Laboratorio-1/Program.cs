using System;

namespace Laboratorio1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Persona p1 = new Persona("Bob", "Kunga");

            Console.WriteLine(p1.Lanzar());
        }
    }
}
