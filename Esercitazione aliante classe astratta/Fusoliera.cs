using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_classe_astratta
{
    public class Fusoliera : Composite
    {
        private double _lung;
        private string _materiale;

        public double Lung
        {
            get { return _lung;}
            set { _lung = value;}
        }

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        public Fusoliera()
        {
            Lung = 0;
            Materiale = string.Empty;
        }

        public Fusoliera(double lung, string materiale)
        {
            Lung = lung;
            Materiale = materiale;
        }

        public Fusoliera(Fusoliera vFusoliera)
        {
            Lung = vFusoliera.Lung;
            Materiale = vFusoliera.Materiale;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Fusoliera) || obj == null)
            {
                return false;
            }

            Fusoliera altro = (Fusoliera)obj;
            return Lung == altro.Lung && Materiale == altro.Materiale;
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
            return $"Lunghezza fusoliera: {Lung}; Materiale fusoliera: {Materiale}";
        }

        public override double Prezzo()
        {
            return Lung * 30;
        }
    }
}
