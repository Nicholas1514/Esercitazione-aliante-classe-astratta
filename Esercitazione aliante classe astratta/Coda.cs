using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_classe_astratta
{
    public class Coda : Composite
    {
        private double _lung;

        public double Lung
        {
            get { return _lung; }
            set { _lung = value;}
            
        }

        public Coda()
        {
            Lung = 0;
        }

        public Coda(double lung)
        {
            Lung = lung;
        }

        public Coda(Coda vCoda)
        {
            Lung = vCoda.Lung;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Coda) || obj == null)
            {
                return false;
            }

            Coda altro = (Coda)obj;
            return Lung == altro.Lung;
        }

        public override void Aggiunta(Composite component)
        {

        }

        public override void Rimuovi(int index)
        {

        }

        public override Composite GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return $"Lunghezza coda: {Lung}";
        }

        public override double Prezzo()
        {
            return Lung * 30;
        }
    }
}
