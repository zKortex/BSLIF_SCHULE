using System;
namespace USB_Rackentwerfer
{
    class Werfer
    {
        private int iRichtung = 180;
        private int iAzimut = 45;
        private int iMunition = 4;



        public int Rechts(int iGrad)
        {
           int iNewRotation = iRichtung + iGrad;
           int iRestgrad = 0;
            if (GetSpannung() >= 5)
            {

            
            if (iNewRotation > 0 && iNewRotation < 360)
             {
                iRichtung = iNewRotation;
                return iRichtung;
             }
            else
            {
                for (int i = iRichtung; i < 360; i++)
                {
                    iRestgrad++;
                }
                Console.WriteLine("Der Werfer kann nur noch " + iRestgrad + " Grade Rechts bewegt werden!");
            }
            }
            else
            {
                Console.WriteLine("Aktion nicht möglich! Spannungsschwankung erkannt!");
            }
            return iRichtung;
        }

        public int Links(int iGrad)
        {
            int iNewRotation = iRichtung - iGrad;
            int iRestgrad = 0;
            if (GetSpannung() > 5)
            {
                if (iNewRotation > 0 && iNewRotation < 360)
                {
                    iRichtung = iNewRotation;
                    return iRichtung;
                }
                else
                {
                    for (int i = iRichtung; i > 0; i--)
                    {
                        iRestgrad++;
                    }
                    Console.WriteLine("Der Werfer kann nur noch " + iRestgrad + " Grade Rechts bewegt werden!");
                }
            }
            else
            {
                Console.WriteLine("Aktion nicht möglich! Spannungsschwankung erkannt!");
            }
            return iRichtung;
        }

        public int Auf(int iGrad)
        {
            int iNewAzimut = iAzimut + iGrad;
            int iRestAzimut = 0;
            if (GetSpannung() > 5)
            {
                if (iNewAzimut > 0 && iNewAzimut < 90)
                {
                    iAzimut = iNewAzimut;
                    return iAzimut;
                }
                else
                {
                    for (int i = iAzimut; i < 90; i++)
                    {
                        iRestAzimut++;
                    }
                    Console.WriteLine("Der Werfer kann nur noch " + iRestAzimut + "Grade noch oben verschoben werden!");
                }
            }
            else
            {
                Console.WriteLine("Aktion nicht möglich! Spannungsschwankung erkannt!");
            }
                return iAzimut;
        }

        public int Ab(int iGrad)
        {
            int iNewAzimut = iAzimut - iGrad;
            int iRestAzimut = 0;
            if (GetSpannung() > 5)
            {
                if (iNewAzimut > 0 && iNewAzimut < 90)
                {
                    iAzimut = iNewAzimut;
                    return iAzimut;
                }
                else
                {
                    for (int i = iAzimut; i > 0; i--)
                    {
                        iRestAzimut++;
                    }
                    Console.WriteLine("Der Werfer kann nur noch " + iRestAzimut + "Grade noch oben verschoben werden!");
                }
            }
            else
            {
                Console.WriteLine("Aktion nicht möglich! Spannungsschwankung erkannt!");
            }
        return iAzimut;
        }

        public bool Feuern()
        {
            if (GetSpannung() >= 5)
            {
                if (iMunition >0)
                {
                    int distance = 100;
                    if (distance > 0.5)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool laden()
        {
            if (GetSpannung() >= 5)
            {
                if (iMunition < 0)
                {
                    return true;
                }
            }
            return false;
        }
        
        public double GetDistance()
        {
            return 100;
        }

        public int GetMunition()
        {
            return iMunition;
        }

        public double GetRichtung()
        {
            return iRichtung;
        }

        public double GetAzimut()
        {
            return iAzimut;
        }

        private double GetSpannung()
        {
            Random Spannung = new Random();
            double dspannung_v = Convert.ToDouble(Spannung.Next(48, 56)) / 10;
           return dspannung_v;
        }
    }
}
