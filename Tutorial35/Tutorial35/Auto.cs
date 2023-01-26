using System;
using System.Collections.Generic;

using System.Text;


namespace vsc060_Vererbung
{
    abstract class Auto
    {

        protected string model;
        protected double tankinhalt, verbrauch, fahrkosten;




        public Auto(string model, double tankinhalt, double verbrauch)
        {
            this.model = model;
            this.tankinhalt = tankinhalt;
            this.verbrauch = verbrauch;
            this.fahrkosten = 0;
        }

        public string Model{
            get
            { return model;
            }
            
        }

        public double Fahrkosten { 
            get { 
                return fahrkosten; 
            } 
        }

        public void Fahren(int km,bool autobahn)
        {
            double preis = 1.70;
            if (km <= 0)
            {
                Console.WriteLine("KM muss über 0 sein");
            }
            else if (tankinhalt < km * verbrauch /100) {

            }
            else
            {
                tankinhalt-= km * verbrauch /100;
                fahrkosten += verbrauch / 100 * preis;
            }
           
        }
    }
}
