using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class Dollard : Devise
    {
        private const double taux_EUR = 0.9;
        private const double taux_MAD = 9.6;

        public Dollard(double valeur) : base(valeur, "Dollard")
        {
        }
        public override Devise convert_to(string symbole)
        {
            if (symbole == "Banque.Euro")
            {
                return new Euro(this.convert_taux(taux_EUR));
            }
            else if (symbole == "Banque.MAD")
            {
                return new MAD(this.convert_taux(taux_MAD));
            }
            else
            {
                if (symbole != "Banque.Dollard")
                    Console.WriteLine("Devise Invalide");
                return new Dollard(this.convert_taux(4));

            }

        }
        public override string ToString()
        {

            return base.ToString();
        }

    }
}
