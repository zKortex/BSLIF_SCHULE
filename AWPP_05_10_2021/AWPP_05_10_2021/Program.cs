using System;

namespace AWPP_05_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // auto FordFocus = new auto(100,100,100,100,100);
            auto FordFocus = new auto();
            FordFocus.tanken(5.0);
            FordFocus.pflegen(1000);
            
            Console.WriteLine(FordFocus.starten());
            Console.Read();
        }
    }
}
