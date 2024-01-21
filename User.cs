using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pariuri_Sportive
{
    public class User
    {
        private string utilizator;

        public User(string utilizator)
        {
            this.utilizator = utilizator;
        }

        public string Utilizator { get => utilizator; set => utilizator = value; }

        public override string ToString()
        {
            return this.utilizator;
        }
    }
}
