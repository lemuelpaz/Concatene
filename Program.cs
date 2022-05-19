using System;

namespace Concatene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sap: ");

            switch (Console.ReadLine().ToLower())
            {
                case "sap":
                    Azul();
                    break;
            }

            static void Azul()
            {
                string Primeiro = "Boa noite";
                string Segundo = ", como vai?";
                string Terceiro = " Espero que você esteja bem.";
            

                Console.Write(Primeiro + Segundo + Terceiro);
            }
        }
    }
}
