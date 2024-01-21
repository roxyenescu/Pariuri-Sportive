using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pariuri_Sportive
{
    public class Meci
    {
        private string denumireSport;
        private string echipaGazda;
        private string echipaOaspete;
        private float cota;

        public Meci(string denumireSport, string echipaGazda, string echipaOaspete, float cota)
        {
            this.denumireSport = denumireSport;
            this.echipaGazda = echipaGazda;
            this.echipaOaspete = echipaOaspete;
            this.cota = cota;
        }

        public string DenumireSport { get => denumireSport; set => denumireSport = value; }
        public string EchipaGazda { get => echipaGazda; set => echipaGazda = value; }
        public string EchipaOaspete { get => echipaOaspete; set => echipaOaspete = value; }
        public float Cota { get => cota; set => cota = value; }

        public override string ToString()
        {
            return this.denumireSport + ", " + this.echipaGazda + ", " + this.echipaOaspete + ", " + this.cota;
        }
    }
}
