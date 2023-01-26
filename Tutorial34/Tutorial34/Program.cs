using System;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto BMW = new Auto("KD-FP 234", "P3", 12, 3);
            BMW.autoTank(4);
            BMW.Kraftstoffmenge = 2;
            BMW.Kennzeichen = "S-BB-88";
            BMW.Marke = "P43";
            Console.WriteLine("Der Tank beinhaltet {0} Liter", BMW.Kraftstoffmenge);
            Console.WriteLine("Der Tank beinhaltet {0} Kennzeichen", BMW.Kennzeichen);
            Console.WriteLine("Der Tank beinhaltet {0} Marke", BMW.Marke);

        }
    }
}
