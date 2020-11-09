using System;

namespace conversione_di_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, baseF;
           Console.Write("inserisci il numero da convertire: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Inserisci la base in cui convertire: ");
            baseF = int.Parse(Console.ReadLine());
            string risultato = Convert.ToString(numero, baseF);
            Console.WriteLine($"il numero convertito è {risultato}");
        }
    }
}
