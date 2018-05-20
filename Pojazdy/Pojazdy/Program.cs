using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazdy
{
    class Program
    {
        delegate void TestDelegate(string s);
        static void Main(string[] args)
        {
            Samochód s1 = new Samochód(100.0f,"AUDI A8");
            Samochód s2 = new Samochód(250.0f,"Maluch");
            Samochód s3 = new Samochód(115.0f,"golf 3");
            Samochód s4 = new Samochód(350.0f,"porsche");
            List<Samochód> lista = new List<Samochód>();
            lista.Add(s1);
            lista.Add(s2);
            lista.Add(s3);
            lista.Add(s4);

            s2.PojemnoscSilnika = 0.5f;
            Console.WriteLine("Teraz legalna zmiana:");
            s2.PojemnoscSilnika = 1.5f;
            Console.WriteLine("Po zmianie: "+s2.PojemnoscSilnika);

            s2.Info();

            IEnumerable<Samochód> lista1 = lista.Where(s =>s.PojemnoscSilnika > 2.0f);
            foreach (Samochód tmp in lista1)
            {
                Console.WriteLine("Samochód {0} ma silnik o pojemności {1} litra i spelnia warunki wyszukiwania",tmp.Nazwa,tmp.PojemnoscSilnika);

            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
