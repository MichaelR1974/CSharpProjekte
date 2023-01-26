using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class Auto // Deklaration der Klasse Auto
    {
        // Membervariablen (Mitgliedervariablen)
        // Eigenschaften
        string hersteller; // Deklaration der Eigenschaft
        string fahrzeugtyp;
        string farbe;
        double alter;
        string kennzeichen;


        //Standard Konstruktor (Default Konstruktor)
        public Auto()
        {
            hersteller = "Opel Automobile GmbH";
            fahrzeugtyp = "Corsa";
        }

        // Konstruktor  mit Parametern (Parametrisierter Konstruktor)
        // Anlage eines gebrauchten Fahrzeuges
        public Auto(string hersteller, string fahrzeugtyp)
        {
            this.hersteller = hersteller;
            this.fahrzeugtyp = fahrzeugtyp;

        }

        public Auto(string fahrzeugtyp, string farbe, double alter)
        {
            this.fahrzeugtyp = fahrzeugtyp;
            this.farbe = farbe;
            this.alter = alter;

        }

        public Auto(string fahrzeugtyp, string kennzeichen, string farbe, double alter)
        {
            this.fahrzeugtyp = fahrzeugtyp;
            this.kennzeichen = kennzeichen;
            this.alter = alter;

        }


        // Member Methode
        public void AusgabeFahrzeug()
        {
            if (hersteller != null && fahrzeugtyp != null)
            {
                Console.WriteLine("Der Fahrzeugtyp ist: {0} vom Hersteller: {1} ", fahrzeugtyp, hersteller);
            }
            else if (fahrzeugtyp != null && farbe != null && alter != 0)
            {
                Console.WriteLine("Der Fahrzeugtyp ist: {0} und hat die Farbe: {1} und ist {2} alt", fahrzeugtyp, farbe, alter);
            }
        }

    }
}
