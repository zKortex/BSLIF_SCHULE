using System;

namespace USB_Rackentwerfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Werfer USB_Rackentwerfer = new Werfer();
            while (true)
            {
            Console.WriteLine("USB Werfer Menu");
            Console.WriteLine("Was wollen Sie tuen? \n1. Nach Rechts drehen.\n2. Nach Links drehen.\n3. Nach Oben drehen.\n4. Nach Oben drehen.\n5. Schießen.\n6. Nachladen.\n7. System Infos.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Um viele Grad wollen Sie nach rechts drehen?");
                        USB_Rackentwerfer.Rechts(Convert.ToInt32(Console.ReadLine()));
                    break;

                    case 2:
                        Console.WriteLine("Um viele Grad wollen Sie nach Links drehen?");
                        USB_Rackentwerfer.Links(Convert.ToInt32(Console.ReadLine()));
                    break;

                    case 3:
                        Console.WriteLine("Um viele Grad wollen Sie nach Oben drehen?");
                        USB_Rackentwerfer.Auf(Convert.ToInt32(Console.ReadLine()));
                    break;


                    case 4:
                        Console.WriteLine("Um viele Grad wollen Sie nach Unten drehen?");
                        USB_Rackentwerfer.Ab(Convert.ToInt32(Console.ReadLine()));
                    break;

                    case 5:
                        Console.WriteLine("Wie weit ist das Ziel Entfernt?");
                        USB_Rackentwerfer.Feuern();
                        //USB_Rackentwerfer.Ab(Convert.ToInt32(Console.ReadLine()));
                    break;

                    case 6:
                        Console.WriteLine("Wollen Sie nachladen?");
                        USB_Rackentwerfer.Feuern();
                        //USB_Rackentwerfer.Ab(Convert.ToInt32(Console.ReadLine()));
                    break;


                    case 7:
                        Console.WriteLine("Munition:" + USB_Rackentwerfer.GetMunition());
                        Console.WriteLine("Richtung:" + USB_Rackentwerfer.GetRichtung());
                        Console.WriteLine("Azimut:" + USB_Rackentwerfer.GetAzimut());
                    break;

                    default:
                    break;
                }



                Console.Read();
            }
        }
    }
}
