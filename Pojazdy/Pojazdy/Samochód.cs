using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazdy
{
    class Samochód : Pojazd
    {
        private string nazwa;
        public string Nazwa
        {
            get { return this.nazwa; }
            set { this.nazwa = value; }
        }

        public Samochód(float pojemnoscSilnika,String nazwa) : base(pojemnoscSilnika)
        {
            this.PojemnoscSilnika = pojemnoscSilnika;
            this.Nazwa = nazwa;

        }
        public override void Info()
        {
            Console.Write("Nazwa samochodu to: "+nazwa+". ");
            base.Info();
        }
    }
}
