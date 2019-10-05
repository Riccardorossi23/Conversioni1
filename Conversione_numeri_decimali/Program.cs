using System;

namespace Conversione_numeri_decimali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero un");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(numero, 2));
            Console.ReadLine();
        }
    }
}
