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
    public partial class Form1 : Form
    {
        MedbaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter = new MedbaseDataSetTableAdapters.UsersTableAdapter();
        MedbaseDataSet.UsersDataTable usersDataTable;
        int counttimer1, counttimer2;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonenter_Click(object sender, EventArgs e)
        {
            // Исходные данные
            string log, pas;
            pas = this.textBoxPass.Text;
            log = this.textBoxEmail.Text;
            usersDataTable = this.usersTableAdapter.GetData();

            var filter = usersDataTable.FirstOrDefault(rec => rec.Email == log && rec.Password == pas);

            if (filter != null)
            {
                switch (filter.IDRole)
                {
                    case 1:
                        MessageBox.Show("Вы вошликак администратор");
                        Form2 formadmin = new Form2();
                        Hide();
                        formadmin.ShowDialog();
                        Show();
                        break;
                    case 2:
                        MessageBox.Show("Вы вошли как бухгалтер");
                        Form4 formbuh = new Form4();
                        Hide();
                        formbuh.ShowDialog();
                        Show();
                        break;
                }
            }
            else
            {
                counttimer1++;
                MessageBox.Show("Внесенные данные не корректны!\nЕсли вы введёте данные неверно 3 раза подряд, приложение заблокируется!");
                if (counttimer1 == 3)
                {
                    timer1.Start();
                }
            }
        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpass.Checked)
                this.textBoxPass.PasswordChar = '\0';
            else
                this.textBoxPass.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkpass.Checked = false;
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxEmail.Enabled = false;
            textBoxPass.Enabled = false;
            buttonenter.Enabled = false;
            checkpass.Enabled = false;

            counttimer2++;
            if (counttimer2 == 50)
            {
                timer1.Stop();
                textBoxEmail.Enabled = true;
                textBoxPass.Enabled = true;
                buttonenter.Enabled = true;
                checkpass.Enabled = true;
                counttimer1 = 0;
            }
        }
    }
}
