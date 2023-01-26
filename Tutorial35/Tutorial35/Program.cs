using System;

namespace vsc060_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {

            Pkw auto1 = new Pkw("Astra", 7.2, 50);
            auto1.Fahren(150, true);

            Console.WriteLine("Die Fahrkosten mit vignette vom {0} betragen: {1}", auto1.Model,Convert.ToString(auto1.Fahrkosten));

        }
    }
}