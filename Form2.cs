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
    public partial class Form2 : Form
    {
        string conexiuneString;
        public Form2()
        {
            InitializeComponent();
            conexiuneString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BDUtilizatori.accdb";
        }

        private void tbNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInregis_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tbNume.Text == "")
            {
                errorProvider1.SetError(tbNume, "Câmpul 'Nume' este gol!");
            }
            else if (tbNume.Text[0] == 'a' || tbNume.Text[0] == 'î' || tbNume.Text[0] == 'b' || tbNume.Text[0] == 'c' ||
                tbNume.Text[0] == 'd' || tbNume.Text[0] == 'e' || tbNume.Text[0] == 'f' || tbNume.Text[0] == 'g' ||
                tbNume.Text[0] == 'h' || tbNume.Text[0] == 'i' || tbNume.Text[0] == 'j' || tbNume.Text[0] == 'k' ||
                tbNume.Text[0] == 'l' || tbNume.Text[0] == 'm' || tbNume.Text[0] == 'n' || tbNume.Text[0] == 'o' ||
                tbNume.Text[0] == 'p' || tbNume.Text[0] == 'q' || tbNume.Text[0] == 'r' || tbNume.Text[0] == 's' ||
                tbNume.Text[0] == 'ș' || tbNume.Text[0] == 't' || tbNume.Text[0] == 'ț' || tbNume.Text[0] == 'u' ||
                tbNume.Text[0] == 'v' || tbNume.Text[0] == 'w' || tbNume.Text[0] == 'x' || tbNume.Text[0] == 'y' ||
                tbNume.Text[0] == 'z')
            {
                errorProvider1.SetError(tbNume, "Numele trebuie sa înceapă cu literă mare!");
                tbNume.Clear();
            }

            else if (tbPrenume.Text == "")
            {
                errorProvider1.SetError(tbPrenume, "Câmpul 'Prenume' este gol!");
            }
            else if (tbPrenume.Text[0] == 'a' || tbPrenume.Text[0] == 'î' || tbPrenume.Text[0] == 'b' || tbPrenume.Text[0] == 'c' ||
                tbPrenume.Text[0] == 'd' || tbPrenume.Text[0] == 'e' || tbPrenume.Text[0] == 'f' || tbPrenume.Text[0] == 'g' ||
                tbPrenume.Text[0] == 'h' || tbPrenume.Text[0] == 'i' || tbPrenume.Text[0] == 'j' || tbPrenume.Text[0] == 'k' ||
                tbPrenume.Text[0] == 'l' || tbPrenume.Text[0] == 'm' || tbPrenume.Text[0] == 'n' || tbPrenume.Text[0] == 'o' ||
                tbPrenume.Text[0] == 'p' || tbPrenume.Text[0] == 'q' || tbPrenume.Text[0] == 'r' || tbPrenume.Text[0] == 's' ||
                tbPrenume.Text[0] == 'ș' || tbPrenume.Text[0] == 't' || tbPrenume.Text[0] == 'ț' || tbPrenume.Text[0] == 'u' ||
                tbPrenume.Text[0] == 'v' || tbPrenume.Text[0] == 'w' || tbPrenume.Text[0] == 'x' || tbPrenume.Text[0] == 'y' ||
                tbPrenume.Text[0] == 'z')
            {
                errorProvider1.SetError(tbPrenume, "Prenumele trebuie sa înceapă cu literă mare!");
                tbPrenume.Clear();
            }

            else if (tbEmail.Text == "")
            {
                errorProvider1.SetError(tbEmail, "Câmpul 'Email' este gol!");
            }
            else if (tbEmail.Text.Length < 5)
            {
                errorProvider1.SetError(tbEmail, "E-mail invalid!");
            }
            //else if (tbEmail.Text.Length > 5)
            //{
            //    bool c = false;
            //    for (int i = 0; i < tbEmail.Text.Length; i++)
            //    {
            //        if (tbEmail.Text[i] == '@')
            //        {
            //            int litere = 0;
            //            for (int j = i + 1; j < tbEmail.Text.Length; j++)
            //            {
            //                litere++;
            //            }
            //            if (litere <= 3)
            //            {
            //                errorProvider1.SetError(tbEmail, "E-mail invalid!");
            //                //tbEmail.Clear();
            //            }
            //            else
            //            {
            //                i = tbEmail.Text.Length + 1;
            //                c = true;
            //            }
            //        }
            //    }

            //    if (c == false)
            //    {
            //        errorProvider1.SetError(tbEmail, "E-mail invalid!");
            //        //tbEmail.Clear();
            //    }
            //}

            else if (tbTelefon.Text == "")
            {
                errorProvider1.SetError(tbTelefon, "Câmpul 'Telefon' este gol!");
            }
            else if (tbTelefon.Text.Length < 10 || tbTelefon.Text.Length > 10)
            {
                errorProvider1.SetError(tbTelefon, "Număr de telefon invalid!");
                tbTelefon.Clear();
            }
            //else if (tbTelefon.Text.Length == 10 && tbTelefon.Text[0] != '0' && tbTelefon.Text[1] != '7')
            //{
            //    errorProvider1.SetError(tbTelefon, "Numărul de telefon trebuie să înceapă cu '07'!");
            //    //tbTelefon.Clear();
            //}

            else if (cbJudet.Text == "")
            {
                errorProvider1.SetError(cbJudet, "Câmpul 'Județ' este gol!");
            }

            else if (tbUtilizatorInreg.Text == "")
            {
                errorProvider1.SetError(tbUtilizatorInreg, "Câmpul 'Utilizator' este gol!");
            }
            else if (tbUtilizatorInreg.Text.Length < 3)
            {
                errorProvider1.SetError(tbUtilizatorInreg, "Numele de utilizator trebuie sa conțină minim 3 caractere!");
                tbUtilizatorInreg.Clear();
            }

            else if (tbParolaInreg.Text == "")
            {
                errorProvider1.SetError(tbParolaInreg, "Câmpul 'Parola' este gol!");
            }
            else if (tbParolaInreg.Text.Length < 6)
            {
                errorProvider1.SetError(tbParolaInreg, "Parola trebuie să conțină minim 6 caractere!");
                tbParolaInreg.Clear();
                tbConfirmareParola.Clear();
            }
            else if (tbConfirmareParola.Text == "")
            {
                errorProvider1.SetError(tbConfirmareParola, "Confirmați-vă parola!");
            }
            else if (tbConfirmareParola.Text != tbParolaInreg.Text)
            {
                errorProvider1.SetError(tbConfirmareParola, "Confirmarea parolei este invalidă!");
                tbConfirmareParola.Clear();
            }
            else if (cbTermeni.Checked == false && cbGDPR.Checked == true)
            {
                errorProvider1.SetError(cbTermeni, "Nu ați bifat căsuța 1 obligatorie!");
            }
            else if (cbTermeni.Checked == true && cbGDPR.Checked == false)
            {
                errorProvider1.SetError(cbGDPR, "Nu ați bifat căsuța 2 obligatorie!");
            }
            else if (cbTermeni.Checked == false && cbGDPR.Checked == false)
            {
                errorProvider1.SetError(cbTermeni, "Nu ați bifat căsuțele obligatorii!");
            }

            else
            {
                errorProvider1.Clear();
                OleDbConnection conexiune = new OleDbConnection(conexiuneString);
                OleDbCommand comandaUtilizator = new OleDbCommand("SELECT Utilizator FROM Utilizatori", conexiune);

                try
                {
                    conexiune.Open();
                    OleDbDataReader reader = comandaUtilizator.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["Utilizator"].ToString().Equals(tbUtilizatorInreg.Text))
                        {
                            MessageBox.Show("Nume de utilizator existent!");
                            tbUtilizatorInreg.Clear();
                        }

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                }



                OleDbCommand comandaInsert = new OleDbCommand();
                try
                {
                    conexiune.Open();
                    comandaInsert.CommandText = $"INSERT INTO Utilizatori (Nume, Prenume, Email, Telefon, Judet, Utilizator, Parola) " +
                        $"VALUES ('{tbNume.Text}', '{tbPrenume.Text}', '{tbEmail.Text}', '{tbTelefon.Text}', '{cbJudet.Text}', '{tbUtilizatorInreg.Text}', '{tbParolaInreg.Text}')";
                    comandaInsert.Connection = conexiune;
                    int c = (int)comandaInsert.ExecuteNonQuery();
                    if (c != 0)
                    {
                        Form3 f3 = new Form3();
                        this.Hide();
                        f3.ShowDialog();
                        this.Show();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                }


                tbNume.Clear();
                tbPrenume.Clear();
                tbEmail.Clear();
                cbJudet.Items.Clear();
                tbTelefon.Clear();
                tbUtilizatorInreg.Clear();
                tbParolaInreg.Clear();
            }
        }
    } 
}