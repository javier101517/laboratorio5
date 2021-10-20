using System;

namespace Proyecto_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GeneradorDeLlaves.Class1 generador = new GeneradorDeLlaves.Class1();
            Char[] test =  generador.generadorK1("00010000");
            Console.WriteLine("aaasa");
        }
    }
}
