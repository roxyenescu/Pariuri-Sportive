using System;
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
    public partial class Form4 : Form
    {
        User u;
        public Form4(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = "Sunteți sigur că vreți să vă delogați?";
            string caption = "Delogare";
            var result = MessageBox.Show(mesaj, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(u);
            f5.Show();
        }
    }
}
