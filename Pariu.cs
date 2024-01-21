using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pariuri_Sportive
{
    public class Pariu
    {
        private float cotaTotala;
        private float miza;
        private float mizaDupaTaxa;
        private float castigPotential;

        public Pariu(float cotaTotala, float miza, float mizaDupaTaxa, float castigPotential)
        {
            this.cotaTotala = cotaTotala;
            this.miza = miza;
            this.mizaDupaTaxa = mizaDupaTaxa;
            this.castigPotential = castigPotential;
        }

        public float CotaTotala { get => cotaTotala; set => cotaTotala = value; }
        public float Miza { get => miza; set => miza = value; }
        public float MizaDupaTaxa { get => mizaDupaTaxa; set => mizaDupaTaxa = value; }
        public float CastigPotential { get => castigPotential; set => castigPotential = value; }

        public override string ToString()
        {
            return "Cota Totala: " + this.cotaTotala + " - Miza: " + this.miza + 
                " - Miza dupa aplicarea taxei: " + this.mizaDupaTaxa + " - Castig potential: " + this.castigPotential;
        }
    }
}
