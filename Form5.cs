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
    public partial class Form5 : Form
    {
        MedbaseDataSetTableAdapters.JobTitleTableAdapter JobTitleTableAdapter = new MedbaseDataSetTableAdapters.JobTitleTableAdapter();
        MedbaseDataSet.JobTitleDataTable JobTitleDataTable;
        MedbaseDataSetTableAdapters.MainTitleTableAdapter maintitleadapter = new MedbaseDataSetTableAdapters.MainTitleTableAdapter();
        MedbaseDataSet.NewAdapterWithFullInfoRow titlerowjob;
        bool check;
        public Form5(MedbaseDataSet.NewAdapterWithFullInfoRow jobrowtitle)
        {
            InitializeComponent();
            titlerowjob = jobrowtitle;
            cbtitle.DataSource = maintitleadapter.GetData();
            cbtitle.DisplayMember = "Title";
            cbtitle.ValueMember = "ID";
            if (jobrowtitle == null)
            {
                check = false;
                cbtitle.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                check = true;
                textboxname.Text = jobrowtitle.Name;
                textBoxlastname.Text = jobrowtitle.SecondName;
                textboxpatronymic.Text = jobrowtitle.PatronymicName;
                cbtitle.SelectedValue = jobrowtitle.IDTitle;
                textBoxnumber.Text = jobrowtitle.ContractNumber;
                maskedTextBoxPhoned.Text = jobrowtitle.PhoneNumber;
            }
            cbtitle.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check)
            {
                titlerowjob.Name = textboxname.Text;
                titlerowjob.SecondName = textBoxlastname.Text;
                titlerowjob.PatronymicName = textboxpatronymic.Text;
                titlerowjob.IDTitle = (int) cbtitle.SelectedValue;
                titlerowjob.ContractNumber = textBoxnumber.Text;
                titlerowjob.PhoneNumber = maskedTextBoxPhoned.Text;
                JobTitleTableAdapter.Update(titlerowjob);
                MessageBox.Show("Данные успешно обновлены!");


            }
            else
            {
                JobTitleTableAdapter.Insert(textboxname.Text, textBoxlastname.Text, textboxpatronymic.Text, (int)cbtitle.SelectedValue, textBoxnumber.Text, null, maskedTextBoxPhoned.Text);
                MessageBox.Show("Сотрудник успешно внесён в базу данных");
            }


        }

        private void cbtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asdasdasdasdasdasdasdas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
