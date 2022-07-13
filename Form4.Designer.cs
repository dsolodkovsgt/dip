
namespace dip
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_add = new System.Windows.Forms.Button();
            this.comboBoxpremial = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_NDFL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_otchisleniya = new System.Windows.Forms.Button();
            this.tb_otchisleniya = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxresult = new System.Windows.Forms.TextBox();
            this.textboxsalary = new System.Windows.Forms.TextBox();
            this.textboxtitle = new System.Windows.Forms.TextBox();
            this.labelskip = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_Excel = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(663, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.White;
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_add.Location = new System.Drawing.Point(143, 190);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(124, 44);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Добавить";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // comboBoxpremial
            // 
            this.comboBoxpremial.DisplayMember = "Отсутствие премиальных";
            this.comboBoxpremial.FormattingEnabled = true;
            this.comboBoxpremial.Items.AddRange(new object[] {
            "Наличие премиальных",
            "Отсутствие премиальных"});
            this.comboBoxpremial.Location = new System.Drawing.Point(128, 130);
            this.comboBoxpremial.Name = "comboBoxpremial";
            this.comboBoxpremial.Size = new System.Drawing.Size(239, 28);
            this.comboBoxpremial.TabIndex = 4;
            this.comboBoxpremial.ValueMember = "Отсутствие премиальных";
            this.comboBoxpremial.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tb_NDFL);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bt_otchisleniya);
            this.groupBox1.Controls.Add(this.tb_otchisleniya);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textboxresult);
            this.groupBox1.Controls.Add(this.textboxsalary);
            this.groupBox1.Controls.Add(this.textboxtitle);
            this.groupBox1.Controls.Add(this.comboBoxpremial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(814, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 394);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные атрибуты";
            // 
            // tb_NDFL
            // 
            this.tb_NDFL.Location = new System.Drawing.Point(6, 308);
            this.tb_NDFL.Name = "tb_NDFL";
            this.tb_NDFL.ReadOnly = true;
            this.tb_NDFL.Size = new System.Drawing.Size(301, 26);
            this.tb_NDFL.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Итог с НДФЛ";
            // 
            // bt_otchisleniya
            // 
            this.bt_otchisleniya.BackColor = System.Drawing.Color.White;
            this.bt_otchisleniya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_otchisleniya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_otchisleniya.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_otchisleniya.Location = new System.Drawing.Point(6, 234);
            this.bt_otchisleniya.Name = "bt_otchisleniya";
            this.bt_otchisleniya.Size = new System.Drawing.Size(305, 44);
            this.bt_otchisleniya.TabIndex = 18;
            this.bt_otchisleniya.Text = "Рассчитать";
            this.bt_otchisleniya.UseVisualStyleBackColor = false;
            this.bt_otchisleniya.Click += new System.EventHandler(this.bt_otchisleniya_Click);
            // 
            // tb_otchisleniya
            // 
            this.tb_otchisleniya.Location = new System.Drawing.Point(6, 360);
            this.tb_otchisleniya.Name = "tb_otchisleniya";
            this.tb_otchisleniya.ReadOnly = true;
            this.tb_otchisleniya.Size = new System.Drawing.Size(301, 26);
            this.tb_otchisleniya.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Сумма отчислениями и НДФЛ (ФМС ФМОС и др.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Оклад";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Итог без отчислений";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Премиальные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Должности";
            // 
            // textboxresult
            // 
            this.textboxresult.Location = new System.Drawing.Point(6, 197);
            this.textboxresult.Name = "textboxresult";
            this.textboxresult.ReadOnly = true;
            this.textboxresult.Size = new System.Drawing.Size(301, 26);
            this.textboxresult.TabIndex = 7;
            // 
            // textboxsalary
            // 
            this.textboxsalary.Location = new System.Drawing.Point(128, 81);
            this.textboxsalary.Name = "textboxsalary";
            this.textboxsalary.ReadOnly = true;
            this.textboxsalary.Size = new System.Drawing.Size(239, 26);
            this.textboxsalary.TabIndex = 6;
            // 
            // textboxtitle
            // 
            this.textboxtitle.Location = new System.Drawing.Point(129, 32);
            this.textboxtitle.Name = "textboxtitle";
            this.textboxtitle.ReadOnly = true;
            this.textboxtitle.Size = new System.Drawing.Size(239, 26);
            this.textboxtitle.TabIndex = 5;
            // 
            // labelskip
            // 
            this.labelskip.AutoSize = true;
            this.labelskip.BackColor = System.Drawing.Color.Transparent;
            this.labelskip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelskip.Location = new System.Drawing.Point(634, 376);
            this.labelskip.Name = "labelskip";
            this.labelskip.Size = new System.Drawing.Size(19, 20);
            this.labelskip.TabIndex = 17;
            this.labelskip.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(470, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Кол-во пропусков";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(464, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "Подтвердить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(461, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "ПРОПУЩЕННЫЙ ДЕНЬ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(464, 300);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // bt_Excel
            // 
            this.bt_Excel.BackColor = System.Drawing.Color.White;
            this.bt_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Excel.Location = new System.Drawing.Point(275, 190);
            this.bt_Excel.Name = "bt_Excel";
            this.bt_Excel.Size = new System.Drawing.Size(124, 44);
            this.bt_Excel.TabIndex = 6;
            this.bt_Excel.Text = "Распечатка";
            this.bt_Excel.UseVisualStyleBackColor = false;
            this.bt_Excel.Click += new System.EventHandler(this.bt_Excel_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.White;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_exit.Location = new System.Drawing.Point(407, 190);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(124, 44);
            this.bt_exit.TabIndex = 7;
            this.bt_exit.Text = "Назад";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1257, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1257, 369);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1257, 401);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1257, 428);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1257, 455);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(425, 165);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(464, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 32);
            this.button5.TabIndex = 14;
            this.button5.Text = "Удалить пропуск";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(1257, 481);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 20);
            this.textBoxid.TabIndex = 15;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dip.Properties.Resources.med;
            this.ClientSize = new System.Drawing.Size(1214, 447);
            this.Controls.Add(this.labelskip);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_Excel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1230, 552);
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.ComboBox comboBoxpremial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxsalary;
        private System.Windows.Forms.TextBox textboxtitle;
        private System.Windows.Forms.Button bt_Excel;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxresult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelskip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button bt_otchisleniya;
        private System.Windows.Forms.TextBox tb_otchisleniya;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_NDFL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}