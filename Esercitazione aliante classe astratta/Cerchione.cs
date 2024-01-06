using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_classe_astratta
{
    public class Cerchione : Composite
    {
        private double _pollici;
        private string _materiale;

        public double Pollici
        {
            get { return _pollici;}
            set { _pollici = value;}
           
        }

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        public Cerchione()
        {
            Pollici = 0;
            Materiale = string.Empty;
        }

        public Cerchione(double pollici, string materiale)
        {
            Pollici = pollici;
            Materiale = materiale;
        }

        public Cerchione(Cerchione vCerchione)
        {
            Pollici = vCerchione.Pollici;
            Materiale = vCerchione.Materiale;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Cerchione) || obj == null)
            {
                return false;
            }

            Cerchione altro = (Cerchione)obj;
            return Pollici == altro.Pollici && Materiale == altro.Materiale;
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
            return $"Pollici: {Pollici}; Materiale cerchioni: {Materiale}";
        }

        public override double Prezzo()
        {
            return Pollici * 1.5;
        }
    }
}
