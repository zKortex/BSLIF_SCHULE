using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoprojekt
{
    class Auto
    {
        private double dLeistung;
        private double dKilometerstand;
        private int iBaujahr;
        private int iGewicht;
        private double dTankfuellstand = 0;
        private double dGeschwindigkeit = 0;
        private bool bLaeuft = false;


        public void tanken(double Menge)
        {
            dTankfuellstand = dTankfuellstand + Menge;
            pflegen(1);
        }

        public void pflegen(int Dauer)
        {
        }

        public bool starten()
        {
            bool bStartet = true;
            if (dTankfuellstand == 0)
            {
                bStartet = false;
            }
            else
            {
                bLaeuft = true;
            }
            return bStartet;
        }

        public void beschleunigen()
        {
            if (bLaeuft == true)
            {
                dGeschwindigkeit++;
                dTankfuellstand = dTankfuellstand - 0.1;
                if (dTankfuellstand == 0)
                {
                    bLaeuft = false;
                }
            }
        }

        public void bremsen()
        {
            dGeschwindigkeit--;
        }

        public double getGeschwindigkeit()
        {
            return dGeschwindigkeit;
        }
    }
}
