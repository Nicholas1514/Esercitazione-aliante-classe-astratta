using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_classe_astratta
{
    public class Ala : Composite
    {
        private double _lung;
        private double _aper;

        public double Lung
        {
            get { return _lung; }
            set
            {
                if (value >= 15F)
                    _lung = value;
                else
                    _lung = 15F;
            }
        }

        public double Aper
        {
            get { return _aper; }
            set { _aper = value;}
        }

        public Ala()
        {
            Lung = 0;
            Aper = 0;
        }

        public Ala(double lung, double aper)
        {
            Lung = lung;
            Aper = aper;
        }

        public Ala(Ala vala)
        {
            Lung = vala.Lung;
            Aper = vala.Aper;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ala) || obj == null)
            {
                return false;
            }

            Ala altro = (Ala)obj;
            return Lung == altro.Lung && Aper == altro.Aper;
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
            return $"Lunghezza ala: {Lung}; Apertura ala: {Aper}";
        }

        public override double Prezzo()
        {
            return Lung * Aper;
        }
    }
}
