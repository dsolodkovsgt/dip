using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace dip
{

    public partial class Form4 : Form

    {
        MedbaseDataSetTableAdapters.NewAdapterWithFullInfoTableAdapter NewJobTitleTableAdapter = new MedbaseDataSetTableAdapters.NewAdapterWithFullInfoTableAdapter();
        MedbaseDataSet.JobTitleDataTable JobTitleDataTable;
        MedbaseDataSet.NewAdapterWithFullInfoRow rowtitle;
        MedbaseDataSetTableAdapters.JobTitleTableAdapter JobTitleTableAdapter = new MedbaseDataSetTableAdapters.JobTitleTableAdapter();
        MedbaseDataSet.NewAdapterWithFullInfoDataTable fullinfoadapter;
        MedbaseDataSetTableAdapters.SkiptitleTableAdapter skiptitleTableAdapter = new MedbaseDataSetTableAdapters.SkiptitleTableAdapter();
        MedbaseDataSet.SkiptitleDataTable skipDataTable;

        double oklad; // Судя по средней зп по СПб и статистическим данным
        double premia; // Премия составляет 30% от оклада
        double NDFL;   //oklad * 0,13
        double fondi;   //oklad / 0,30
        double resprem; //endresult
        double res;     //promejut
        double ifskip; //oklad / 30 days
        bool check = false;
        bool check1 = false;
        DataGridView dgv = new DataGridView();

        public Form4()
        {
            InitializeComponent();
            update();
            comboBoxpremial.DropDownStyle = ComboBoxStyle.DropDownList;
            dgv = dataGridView1;            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxpremial.Text == "Наличие премиальных")
            {
                if (!check)
                {
                    resprem = resprem + premia;
                    check = true;
                    check1 = false;
                }
            }
            else
            {
                if (!check1)
                {
                    resprem = resprem - premia;
                    check1 = true;
                    check = false;
                }
            }
            textboxresult.Text = Math.Round(resprem,2).ToString();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void update()
        {
            fullinfoadapter = NewJobTitleTableAdapter.GetData();
            dataGridView1.DataSource = fullinfoadapter;

            dgv.DataSource = fullinfoadapter;            

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[5].HeaderText = "Должность";
            dataGridView1.Columns[6].HeaderText = "Номер договора";
            dataGridView1.Columns[7].HeaderText = "Зарплата";
            dataGridView1.Columns[8].HeaderText = "Номер телефона";
            dataGridView1.Columns[9].HeaderText = "Оклад";

            skipDataTable = skiptitleTableAdapter.GetData();
            dataGridView2.DataSource = skiptitleTableAdapter.GetDataBySkip(6);
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].HeaderText = "Имя";
            dataGridView2.Columns[3].HeaderText = "Фамилия";
            dataGridView2.Columns[4].HeaderText = "Отчество";
            dataGridView2.Columns[5].HeaderText = "Должность";
            dataGridView2.Columns[6].HeaderText = "Пропущенный день";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime Den = dateTimePicker1.Value;
            int idshnik;
            string name, secondname, patronomyc, title;
            name = textBox2.Text;
            secondname = textBox3.Text;
            patronomyc = textBox4.Text;
            title = textBox5.Text;
            if (textBox1.Text != String.Empty)
            {
                idshnik = Convert.ToInt32(textBox1.Text);
                try
                {
                    skiptitleTableAdapter.InsertQueryWorkerSkip(idshnik, name, secondname, patronomyc, title, Den);
                    MessageBox.Show("Пропуск успешно добавлен");
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удалось добавить пропуск");
                    return;
                }

                update();

                if (dataGridView2.RowCount == 0)
                {
                    textboxresult.Text = Math.Round(resprem,2).ToString();
                    labelskip.Text = "Отсуствуют";
                }
                else
                {
                    resprem = resprem - ifskip;
                    textboxresult.Text = Math.Round(resprem,2).ToString();
                    int counttime = dataGridView2.RowCount;
                    labelskip.Text = Convert.ToString(counttime);
                }
            }
            else
                MessageBox.Show("Выберите сотрудника");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount != 0)
            {
                int ID;
                if (textBoxid.Text != String.Empty)
                {
                    ID = Convert.ToInt32(textBoxid.Text);
                    try
                    {
                        skiptitleTableAdapter.DeleteQuery(ID);
                        MessageBox.Show("Пропуск успешно удалён");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Не удалось удалить пропуск");
                    }
                }
            }
            else
                MessageBox.Show("Пропусков нет");

            update();

            resprem = resprem + ifskip;
            textboxresult.Text = Math.Round(resprem,2).ToString();

            int counttime = dataGridView2.RowCount;
            labelskip.Text = Convert.ToString(counttime);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != null)
            {
                int numRow = e.RowIndex;
                textBoxid.Text = dataGridView2.Rows[numRow].Cells[0].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxpremial.SelectedItem = comboBoxpremial.Items[1];
            check = false;
            check1 = false;
            int numRow = e.RowIndex;
            if (!(numRow < 0))
            {
                textBox1.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[numRow].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[numRow].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.Rows[numRow].Cells[5].Value.ToString();

                int chips = Convert.ToInt32(textBox1.Text);
                try
                {
                    dataGridView2.DataSource = skiptitleTableAdapter.GetDataBySkip(chips);
                }
                catch (Exception)
                {
                    dataGridView2.Rows.Clear();
                    MessageBox.Show("Данный пользователь не пропустил ни разу");
                    return;
                }

                if (dataGridView1.CurrentRow != null)
                {
                    DataRowView dtRow = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                    rowtitle = (MedbaseDataSet.NewAdapterWithFullInfoRow)dtRow.Row;
                    textboxtitle.Text = rowtitle.Title;
                    textboxsalary.Text = rowtitle.Salary;
                    oklad = Convert.ToDouble(rowtitle.Salary);
                    ifskip = oklad / 30;
                    premia = oklad * 0.30;

                    res = Convert.ToInt32(rowtitle.Salary);
                    resprem = res;
                    textboxresult.Text = Math.Round(resprem,2).ToString();
                }

                if (dataGridView2.RowCount == 0)
                {
                    textboxresult.Text = Math.Round(resprem,2).ToString();
                    labelskip.Text = "Отсутствуют";
                }
                else
                {
                    int counttime;
                    counttime = dataGridView2.RowCount;
                    labelskip.Text = Convert.ToString(counttime);
                }

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    resprem = resprem - ifskip;
                    textboxresult.Text = Math.Round(resprem,2).ToString();
                }
            }
        }

        private void bt_otchisleniya_Click(object sender, EventArgs e)
        {
            NDFL = resprem * 0.13;
            tb_NDFL.Text = Math.Round(resprem - NDFL,2).ToString();
            fondi = Convert.ToDouble(tb_NDFL.Text) * 0.30;
            tb_otchisleniya.Text = Math.Round(fondi,2).ToString();
        }
        //♂
        private void bt_add_Click(object sender, EventArgs e)
        {
            rowtitle.Payday = tb_NDFL.Text;

            JobTitleTableAdapter.Update(rowtitle);
            update();
        }

        private void bt_Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    (ExcelWorkSheet.Cells[1, j + 1] as Range).Value2 = dataGridView1.Columns[j].HeaderText;
                    (ExcelWorkSheet.Cells[i + 2, j + 1] as Range).Value2 = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            var saveexceldialog = new SaveFileDialog();
            saveexceldialog.Title = "Сохранить Excel как";
            saveexceldialog.OverwritePrompt = true;
            saveexceldialog.CheckPathExists = true;
            saveexceldialog.Filter = "Excel Files(*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveexceldialog.ShowHelp = true;
            if(saveexceldialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelWorkBook.SaveAs(saveexceldialog.FileName);
                    MessageBox.Show("Сохранено");
                    ExcelWorkBook.Close(true);
                    ExcelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelApp);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить Excel файл", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExcelWorkBook.Close(true);
                    ExcelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelApp);
                }
            }                                                                     
        }
    }
}
