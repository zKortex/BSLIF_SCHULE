﻿using System;
namespace AWPP_05_10_2021
{
    class auto
    {

        /*
           double dLeistung;
           double dKilometerstand;
           int iBaujahr;
           int iGewicht;
           double dTankstand;

           public auto(double Leistung, double kilometerstand,int Baujahr, int Gewicht, double Tankstand)
           {
               dKilometerstand = kilometerstand;
               dLeistung = Leistung;
               iBaujahr = Baujahr;
               iGewicht = Gewicht;
               dTankstand = Tankstand;
           }
        */


        private double dLeistung;
        private double dKilometerstand;
        private int iBaujahr;
        private int iGewicht;
        private double dTankstand;
        private double dGeschwindigkeit;
        private bool bgestartet;

        public void tanken(double Menge)
        {
            dTankstand = dTankstand + Menge;
            pflegen(1000);
        }

         public void pflegen(int Dauer)
         {

         }

         public bool starten()
         {
            if (dTankstand == 0)
            {
                return false;
            }
            return true;
         }


        public void beschleunigen()
        {
            bgestartet = true;
            dGeschwindigkeit++;
            dTankstand = dTankstand - 0.1;

            if (dTankstand == 0)
            {
                dGeschwindigkeit--;
                if (dGeschwindigkeit == 0)
                {
                    bgestartet = false;
                }
            }
        }


        public void bremsen()
        {

        }
        
    }
}
