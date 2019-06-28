using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListGeneric.Classes;

namespace ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> listaGenerica = new GenericList<int>(5);
            listaGenerica.Add(3);
            listaGenerica.Add(7);
            listaGenerica.Add(21);
            listaGenerica.Add(25);
            listaGenerica.Add(3);
            listaGenerica.Add(-231);
            listaGenerica.Add(7);
            listaGenerica.Add(21);
            listaGenerica.Add(25);
            //listaGenerica.RemoveAt(4);
            //listaGenerica[4] = 1114;
            listaGenerica.InsertAt(3, 19);

            Console.WriteLine(listaGenerica.Min());
            Console.WriteLine(listaGenerica.Max());
            Console.WriteLine(listaGenerica);

            Console.ReadKey();
        }
    }
}
