using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazdy
{
    class Pojazd
    {
        private float pojemnoscSilnika=0;
        public float PojemnoscSilnika
        {
            get { return this.pojemnoscSilnika; }
            set {
                if (value > 1.0)
                {
                    this.pojemnoscSilnika = value;
                }
                else
                {
                    Console.WriteLine("Pojemność silnika nie może być mniejsza niż 1!");
                }
            }
        }
        public Pojazd(float pojemnoscSilnika)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
        }

        public virtual void Info() {
            Console.WriteLine("Pojemnosc silnika to {0}",pojemnoscSilnika);
        }
    }
}
