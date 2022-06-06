using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class MAD : Devise
    {
        private const double taux_EUR = 0.09;
        private const double taux_DOL = 0.10;

        public MAD(double valeur) : base(valeur, "MAD")
        {
        }
        public override Devise convert_to(string symbole)
        {
            if (symbole == "Banque.Dollard")
            {
                return new Dollard(this.convert_taux(taux_DOL));
            }
            else if (symbole == "Banque.Euro")
            {
                return new Euro(this.convert_taux(taux_EUR));
            }
            else
            {
                if (symbole != "Banque.MAD")
                    Console.WriteLine("Devise Invalide");
                return new MAD(this.convert_taux(1));

            }

        }
        public override string ToString()
        {

            return base.ToString();
        }



    }

}
