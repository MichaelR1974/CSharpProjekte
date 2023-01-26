using System;
using System.Collections.Generic;

using System.Text;


namespace properties
{
    class Auto
    {
        string kennzeichen, marke;
        double tankgroesse, kraftstoffmenge;




        public Auto(string kennzeichen, string marke, double tankgroesse, double kraftstoffmenge)
        {
            this.tankgroesse = tankgroesse;
            this.marke = marke;
            this.tankgroesse = tankgroesse;
            this.kraftstoffmenge = kraftstoffmenge;
        }


        public void autoTank(double tank)
        {
            if (tank + kraftstoffmenge > tankgroesse)
            {

                Console.WriteLine("zuviel Benzin!!!");
            }
            else
            {
                kraftstoffmenge += tank;
            }
        }

        public string Kennzeichen
        {
            get => kennzeichen;
            set => kennzeichen = value;
        }


        public string Marke
        {
            get => marke;   
            set => marke = value;
        }
            public double Kraftstoffmenge
        {
            get { return kraftstoffmenge; }

            set 
            { if(kraftstoffmenge + value > tankgroesse)
                {
                    Console.WriteLine("Achtung Tank voll!!");
                }
                else
                {
                    kraftstoffmenge += value;
                }
            }

       
        }
    }
}

