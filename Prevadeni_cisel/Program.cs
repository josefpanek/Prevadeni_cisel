using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevadeni_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string znaky = "0123456789ABCDEF";
            int cisloVstup; 
            int soustava;
            string vysledek = "";
            string obracenyVysledek = "";

            Console.WriteLine("Číslo v desítkové soustavě: ");
            while (!int.TryParse(Console.ReadLine(), out cisloVstup))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu: ");

            int mezivysledek = cisloVstup;

            Console.WriteLine("Číselná soustava (2-16): ");
            while (!int.TryParse(Console.ReadLine(), out soustava))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu: ");

            while (mezivysledek != 0)
            {
                obracenyVysledek += znaky[mezivysledek % soustava];
                mezivysledek /= soustava;
            }

            for (int i = 0; i < obracenyVysledek.Length; i++)
                vysledek += obracenyVysledek[obracenyVysledek.Length - i - 1];

            Console.WriteLine("Číslo ve zvolené soustavě: " + vysledek);
            Console.ReadKey();
        }
    }
}