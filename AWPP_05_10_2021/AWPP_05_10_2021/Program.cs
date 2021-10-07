using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bAutoGestartet1;
            bool bAutoGestartet2;
            Auto FordFocus = new Auto();
            FordFocus.tanken(5.0);
            FordFocus.pflegen(1);
            bAutoGestartet1 = FordFocus.starten();
            if (bAutoGestartet1)
            {
                Console.WriteLine("Auto ist gestartet");
            }
            else
            {
                Console.WriteLine("Auto ist nicht gestartet");
            }
            FordFocus.beschleunigen();
            Console.WriteLine("Die Geschwindigkeit beträgt: " + FordFocus.getGeschwindigkeit() + " km/h");
            FordFocus.beschleunigen();
            FordFocus.beschleunigen();
            FordFocus.beschleunigen();
            FordFocus.beschleunigen();
            FordFocus.beschleunigen();
            Console.WriteLine("Die Geschwindigkeit beträgt: " + FordFocus.getGeschwindigkeit() + " km/h");
            Console.ReadKey();
        }
    }
}
