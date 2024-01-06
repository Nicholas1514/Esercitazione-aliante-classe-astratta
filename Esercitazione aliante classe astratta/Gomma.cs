using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_classe_astratta
{
    public class Gomma : Composite
    {
        private double _alt;
        private double _larg;
        private double _raggio;

        public double Alt
        {
            get { return _alt; }
            set
            {
                if (value >= 200F && value <= 400F)
                    _alt = value;
                else
                    _alt = 300F;
            }
        }

        public double Larg
        {
            get { return _larg; }
            set
            {
                if (value >= 200F && value <= 400F)
                    _larg = value;
                else
                    _larg = 300F;
            }
        }

        public double Raggio
        {
            get { return _raggio; }
            set
            {
                if (value >= 40F && value <= 60F)
                    _raggio = value;
                else
                    _raggio = 50F;
            }
        }

        public Gomma()
        {
            Alt = 0;
            Larg = 0;
            Raggio = 0;
        }

        public Gomma(double alt, double larg, double raggio)
        {
            Alt = alt;
            Larg = larg;
            Raggio = raggio;
        }

        public Gomma(Gomma vGomma)
        {
            Alt = vGomma.Alt;
            Larg = vGomma.Larg;
            Raggio = vGomma.Raggio;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Gomma) || obj == null)
            {
                return false;
            }

            Gomma altro = (Gomma)obj;
            return Alt == altro.Alt && Larg == altro.Larg && Raggio == altro.Raggio;
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
            return $"Altezza: {Alt}; Larghezza: {Larg}; Raggio: {Raggio}";
        }

        public override double Prezzo()
        {
            return Alt * Larg * Raggio * 10;
        }
    }
}
