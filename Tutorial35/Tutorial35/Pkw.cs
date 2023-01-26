using System;
using System.Collections.Generic;

using System.Text;


namespace vsc060_Vererbung
{
    class Pkw : Auto
    {
        private bool vignette;


        public Pkw(string model, double verbrauch, double tankinhalt, bool vignette)
        : base(model, verbrauch, tankinhalt)
        {
            this.vignette = vignette;

        }

        public Pkw(string model, double verbrauch, double tankinhalt)
        : base(model, verbrauch, tankinhalt)
        {
            this.vignette = false;

        }

        public new void Fahren(int km,bool autobahn)
        {
            base.Fahren(km,autobahn);
            if (autobahn == true && vignette == false)
            {
                fahrkosten += 100;
                vignette= true;
            }
        }
    }
}
