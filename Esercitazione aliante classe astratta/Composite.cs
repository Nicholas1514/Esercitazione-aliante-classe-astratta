using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_aliante_classe_astratta
{
    public abstract class Composite
    {
        public abstract void Aggiunta(Composite componente);

        public abstract void Rimuovi(int indice);

        public abstract Composite GetChild(int indice);

        public new abstract bool Equals(object obj);

        public new abstract string ToString();

        public abstract double Prezzo();
    }
}
