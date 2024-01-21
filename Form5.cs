using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pariuri_Sportive
{
    public partial class Form5 : Form
    {
        User u;
        List<Meci> listaMeciuri = new List<Meci>();
        float cotaTotala = 0;
        public Form5(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void btnAdaugaMeci_Click(object sender, EventArgs e)
        {
            //float cotaTotala = 1;
            
            if (tbSport.Text == "")
            {
                errorProvider.SetError(tbSport, "Introduceți denumirea sportului!");
            }
            else if (tbSport.Text != "FOTBAL" && tbSport.Text != "BASCHET")
            {
                errorProvider.SetError(tbSport, "Sportul introdus este inexistent!");
            }
            else if (tbGazda.Text == "")
            {
                errorProvider.SetError(tbGazda, "Introduceți echipa gazdă!");
            }
            else if (tbOaspete.Text == "")
            {
                errorProvider.SetError(tbOaspete, "Introduceți echipa oaspete!");
            }
            else if (tbCota.Text == "")
            {
                errorProvider.SetError(tbCota, "Introduceți cota!");
            }
            else
            {
                errorProvider.Clear();
                string denumireSport = tbSport.Text;
                string echipaGazda = tbGazda.Text;
                string echipaOaspete = tbOaspete.Text;
                float cota = float.Parse(tbCota.Text);

                Meci m = new Meci(denumireSport, echipaGazda, echipaOaspete, cota);
                listaMeciuri.Add(m);

                if(cotaTotala == 0)
                {
                    cotaTotala = (cotaTotala + 1) * cota;
                }
                else
                {
                    cotaTotala = cotaTotala * cota;
                }

                ListViewItem listViewItem = new ListViewItem(m.DenumireSport);
                listViewItem.SubItems.Add(m.EchipaGazda.ToString());
                listViewItem.SubItems.Add(m.EchipaOaspete.ToString());
                listViewItem.SubItems.Add(m.Cota.ToString());
                lvMeciuri.Items.Add(listViewItem);

                tbSport.Clear();
                tbGazda.Clear();
                tbOaspete.Clear();
                tbCota.Clear();

            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            string mesaj = "Datele introduse vor fi pierdute. Continuați?";
            string caption = "Renunțare bilet";
            var result = MessageBox.Show(mesaj, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCotaTotala_Click(object sender, EventArgs e)
        {
            tbAfisCotaTotala.Text = cotaTotala.ToString();     
        }

        
        private void btnMizaTaxa_Click(object sender, EventArgs e)
        {
            float mizaDT = float.Parse(tbMiza.Text);
            mizaDT = mizaDT - mizaDT * 5 / 100;
            tbMizaDupaTaxa.Text = mizaDT.ToString();         
        }

        private void btnAfisCastigPotential_Click(object sender, EventArgs e)
        {
            float mizaDT = float.Parse(tbMizaDupaTaxa.Text);
            float afisTotalCota = float.Parse(tbAfisCotaTotala.Text);
            mizaDT = mizaDT * afisTotalCota;
            tbCastigPotential.Text = mizaDT.ToString();
        }

        private void btnPregatireBilet_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tbAfisCotaTotala.Text == "")
            {
                errorProvider1.SetError(tbAfisCotaTotala, "Afișați cota totală!");
            }
            else if (tbMiza.Text == "")
            {
                errorProvider1.SetError(tbMiza, "Introduceți miza!");
            }
            else if (tbMizaDupaTaxa.Text == "")
            {
                errorProvider1.SetError(tbMizaDupaTaxa, "Afisați miza după aplicarea taxei!");
            }
            else if (tbCastigPotential.Text == "")
            {
                errorProvider1.SetError(tbCastigPotential, "Afișați câștigul potențial!");
            }
            else
            {
                errorProvider.Clear();
                float totalCota = float.Parse(tbAfisCotaTotala.Text);
                float miza = float.Parse(tbMiza.Text);
                float mizaDupaTaxa = float.Parse(tbMizaDupaTaxa.Text);
                float castigPotential = float.Parse(tbCastigPotential.Text);

                Pariu p = new Pariu(totalCota, miza, mizaDupaTaxa, castigPotential);
                
                Form6 f6 = new Form6(p, listaMeciuri, u);
                this.Hide();
                f6.ShowDialog();
                this.Show();
            }         
        }
    }
}
