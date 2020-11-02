using System;

namespace conversione_di_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseP, baseF;
            double numero;
            Console.Write("Inserisci la base da cui convertire: ");
            baseP = int.Parse(Console.ReadLine());
            Console.Write("Inserisci la base in cui convertire: ");
            baseF = int.Parse(Console.ReadLine());
            Console.Write("inserisci il numero da convertire: ");
            numero = double.Parse(Console.ReadLine());
            string risultato = Convert.ToString(Convert.ToInt32(numero, baseP), baseF);
            Console.WriteLine($"il numero convertito è {risultato}");
        }
    }
}
