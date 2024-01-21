using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pariuri_Sportive
{
    public partial class Form3 : Form
    {
        string conexiuneString;
        public Form3()
        {
            InitializeComponent();
            conexiuneString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BDUtilizatori.accdb";
        }

        private void btnInregistreazaAcum_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void btnConectare_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(conexiuneString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM Utilizatori", conexiune);

            try
            {
                conexiune.Open(); 
                OleDbDataReader reader = comanda.ExecuteReader();

                bool verif = false; // pp initial ca datele introduse nu se gasesc in baza de date
                while (reader.Read()) 
                {
                    if (reader["Utilizator"].ToString().Equals(tbUtilizatorA.Text) && reader["Parola"].ToString().Equals(tbParolaA.Text))
                    {
                        verif = true; // s-au gasit in baza de date datele introduse 

                        string numeUtilizator = tbUtilizatorA.Text;
                        User u = new User(numeUtilizator);


                        Form4 f4 = new Form4(u);
                        this.Hide();
                        f4.ShowDialog();
                        this.Show();

                        tbUtilizatorA.Clear();
                        tbParolaA.Clear();
                    }

                }
                if (verif == false)
                {
                    MessageBox.Show("Nume de utilizator și/sau parola incorecte !");
                    tbUtilizatorA.Clear();
                    tbParolaA.Clear();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbUtilizatorA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
