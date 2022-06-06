using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class Euro : Devise
    {
        private const double taux_DOL = 1.07;
        private const double taux_MAD = 10.5;

        public Euro(double valeur) : base(valeur, "Euro")
        {
        }
        public override Devise convert_to(string symbole)
        {
            if (symbole == "Banque.Dollard")
            {
                return new Dollard(this.convert_taux(taux_DOL));
            }
            else if (symbole == "Banque.MAD")
            {
                return new MAD(this.convert_taux(taux_MAD));
            }
            else
            {
                if (symbole != "Banque.Euro")
                    Console.WriteLine("Devise Invalide");
                return new Euro(this.convert_taux(1));

            }

        }
        public override string ToString()
        {

            return base.ToString();
        }
    }
}
