using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pariuri_Sportive
{
    public partial class Form6 : Form
    {
        public Form6(Pariu p, List<Meci> listaMeciuri, User u)
        {
            InitializeComponent();

            tbCotaTotala2.Text = p.CotaTotala.ToString();
            tbMiza2.Text = p.Miza.ToString();
            tbMizaDupaTaxa2.Text = p.MizaDupaTaxa.ToString();
            tbCastigPotential2.Text = p.CastigPotential.ToString();

            tbNumeUtilizator.Text = u.ToString();

            tbNrMeciuri.Text = listaMeciuri.Count.ToString();

            for(int i = 0; i < listaMeciuri.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(listaMeciuri[i].DenumireSport);
                listViewItem.SubItems.Add(listaMeciuri[i].EchipaGazda.ToString());
                listViewItem.SubItems.Add(listaMeciuri[i].EchipaOaspete.ToString());
                listViewItem.SubItems.Add(listaMeciuri[i].Cota.ToString());
                lvMeciuri.Items.Add(listViewItem);
            }
        }

        private void btnÎnchide_Click(object sender, EventArgs e)
        {
            string mesaj = "Sunteți sigur că vreți să renunțați?";
            string caption = "Renunțare";
            var result = MessageBox.Show(mesaj, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
        }

        private void btnPrintare_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.CotaTotala = tbCotaTotala2.Text;
            f7.Utilizator = tbNumeUtilizator.Text;
            f7.Miza = tbMiza2.Text;
            f7.MizaDupaTaxa = tbMizaDupaTaxa2.Text;
            f7.CastigPotential = tbCastigPotential2.Text;
            f7.ShowDialog();
        }

        private void btnPrintare_MouseHover(object sender, EventArgs e)
        {
        
        }
    }
}
