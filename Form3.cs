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
    public partial class Form3 : Form
    {
        MedbaseDataSetTableAdapters.NewAdapterWithFullInfoTableAdapter NewJobTitleTableAdapter = new MedbaseDataSetTableAdapters.NewAdapterWithFullInfoTableAdapter();
        MedbaseDataSet.JobTitleDataTable JobTitleDataTable;
        MedbaseDataSet.NewAdapterWithFullInfoRow rowtitle;
        MedbaseDataSetTableAdapters.JobTitleTableAdapter JobTitleTableAdapter = new MedbaseDataSetTableAdapters.JobTitleTableAdapter();
        MedbaseDataSet.NewAdapterWithFullInfoDataTable fullinfoadapter;
        public Form3()
        {
            InitializeComponent();
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 addsotryd = new Form5(null);
            Hide();
            addsotryd.ShowDialog();
            Show();
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rowtitle.Payday == null)
                JobTitleTableAdapter.Delete(rowtitle.ID, rowtitle.Name, rowtitle.SecondName, rowtitle.PatronymicName, rowtitle.IDTitle, rowtitle.ContractNumber, null, rowtitle.PhoneNumber);
            else
                JobTitleTableAdapter.Delete(rowtitle.ID, rowtitle.Name, rowtitle.SecondName, rowtitle.PatronymicName, rowtitle.IDTitle, rowtitle.ContractNumber, rowtitle.Payday, rowtitle.PhoneNumber);
            MessageBox.Show("Сотрудник успешно удалён из базы данных");
            update();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem != null)
            {                
                DataRowView dtRow = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                rowtitle = (MedbaseDataSet.NewAdapterWithFullInfoRow)dtRow.Row;
            }
        }

        private void update()
        {
            fullinfoadapter = NewJobTitleTableAdapter.GetData();
            dataGridView1.DataSource = fullinfoadapter;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[5].HeaderText = "Должность";
            dataGridView1.Columns[6].HeaderText = "Номер договора";
            dataGridView1.Columns[7].HeaderText = "Зарплата";
            dataGridView1.Columns[8].HeaderText = "Номер телефона";
            dataGridView1.Columns[9].HeaderText = "Оклад";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 editform5 = new Form5(rowtitle);
            Hide();
            editform5.ShowDialog();
            Show();
            update();

        }
    }
}
