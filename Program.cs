using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MAD M = new MAD(1000.00);
            Euro E= new Euro(1000.00);
            Dollard S = new Dollard(1000.00);


            Console.ReadKey();
        }

    }
}
