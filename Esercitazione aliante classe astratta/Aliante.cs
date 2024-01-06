using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_classe_astratta
{
    public class Aliante : Composite
    {
        private List<Composite> _components;

        public List<Composite> Composites
        {
            get { return _components; }
            set { _components = value; }
        }

        public Aliante()
        {
            Composites = new List<Composite>();
        }

        public Aliante(List<Composite> components)
        {
            Composites = components;
        }

        public Aliante(Aliante vAliante)
        {
            Composites = vAliante.Composites;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aliante) || obj == null)
            {
                return false;
            }

            Aliante altro = (Aliante)obj;
            if (Composites.Count != altro.Composites.Count)
            {
                return false;
            }

            for (int i = 0; i < Composites.Count; i++)
            {
                if (!Composites[i].Equals(altro.Composites[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override void Aggiunta(Composite component)
        {
            Composites.Add(component);
        }

        public override void Rimuovi(int indice)
        {
            Composites.RemoveAt(indice);
        }

        public override Composite GetChild(int indice)
        {
            if (Composites.Count > indice)
            {
                return Composites[indice];
            }

            return null;
        }

        public override string ToString()
        {
            string str = "";

            foreach (var component in Composites)
            {
                str += component.ToString();
            }

            return str;
        }

        public override double Prezzo()
        {
            double tot = 0;

            foreach (var component in Composites)
            {
                tot += component.Prezzo();
            }

            return tot;
        }
    }
}
