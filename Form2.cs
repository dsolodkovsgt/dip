using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonsotryd_Click(object sender, EventArgs e)
        {
            Form3 sotryd3 = new Form3();
            Hide();
            sotryd3.ShowDialog();
            Show();
        }

        private void buttonback1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonzp_Click(object sender, EventArgs e)
        {
            Form4 plata = new Form4();
            Hide();
            plata.ShowDialog();
            Show();
        }
    }
}
