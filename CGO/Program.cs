using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CGO
{
    class Program
    {
        public static void Main()
        {

            int a = 12;

            double b = 5.1;



            // Visuel Studio vil ikke oversætte denne kode begrunde af de to forskellige variabler der bliver brugt!

            // Int: Kan kun tage 1-2-3 (Hele tal)

            // Double: Kan kun (Tage både tage 1 og 1.1)



            int c = a + b;



            Console.WriteLine(c);

            
           //Opgave C

           // Variablen (Double) kan både tage 1 (Helt tal) og 1.5 (comma tal/halvt tal)



            double d = a + b;



            Console.WriteLine(d);


            // Key Reader
            Console.ReadKey();
        }
    }
}