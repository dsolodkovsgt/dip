
namespace dip
{
    partial class Form2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonback1 = new System.Windows.Forms.Button();
            this.buttonzp = new System.Windows.Forms.Button();
            this.buttonsotryd = new System.Windows.Forms.Button();
            this.labelmenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::dip.Properties.Resources.med;
            this.splitContainer1.Panel1.Controls.Add(this.buttonback1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonzp);
            this.splitContainer1.Panel1.Controls.Add(this.buttonsotryd);
            this.splitContainer1.Panel1.Controls.Add(this.labelmenu);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::dip.Properties.Resources.med;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.Size = new System.Drawing.Size(797, 269);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonback1
            // 
            this.buttonback1.BackColor = System.Drawing.Color.White;
            this.buttonback1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonback1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonback1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonback1.Location = new System.Drawing.Point(33, 205);
            this.buttonback1.Name = "buttonback1";
            this.buttonback1.Size = new System.Drawing.Size(204, 40);
            this.buttonback1.TabIndex = 3;
            this.buttonback1.Text = "Назад";
            this.buttonback1.UseVisualStyleBackColor = false;
            this.buttonback1.Click += new System.EventHandler(this.buttonback1_Click);
            // 
            // buttonzp
            // 
            this.buttonzp.BackColor = System.Drawing.Color.White;
            this.buttonzp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonzp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonzp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonzp.Location = new System.Drawing.Point(33, 146);
            this.buttonzp.Name = "buttonzp";
            this.buttonzp.Size = new System.Drawing.Size(204, 40);
            this.buttonzp.TabIndex = 2;
            this.buttonzp.Text = "Расчёт Заработной Платы";
            this.buttonzp.UseVisualStyleBackColor = false;
            this.buttonzp.Click += new System.EventHandler(this.buttonzp_Click);
            // 
            // buttonsotryd
            // 
            this.buttonsotryd.BackColor = System.Drawing.Color.White;
            this.buttonsotryd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsotryd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsotryd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsotryd.Location = new System.Drawing.Point(33, 87);
            this.buttonsotryd.Name = "buttonsotryd";
            this.buttonsotryd.Size = new System.Drawing.Size(204, 40);
            this.buttonsotryd.TabIndex = 1;
            this.buttonsotryd.Text = "Список Сотрудников";
            this.buttonsotryd.UseVisualStyleBackColor = false;
            this.buttonsotryd.Click += new System.EventHandler(this.buttonsotryd_Click);
            // 
            // labelmenu
            // 
            this.labelmenu.AutoSize = true;
            this.labelmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmenu.Location = new System.Drawing.Point(96, 28);
            this.labelmenu.Name = "labelmenu";
            this.labelmenu.Size = new System.Drawing.Size(80, 25);
            this.labelmenu.TabIndex = 0;
            this.labelmenu.Text = "МЕНЮ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "\"Назад\" - возвращает вас обратно на форму регистрации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(479, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Для того чтобы продолжить работу выберите необходимый вам раздел:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "\"Расчёт заработной платы\" - перенаправляет вас в следующее окно, \r\nгде вы можете " +
    "расчитать З/П ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "\"Список сотрудников\" - позволяет просмотреть/изменить/редактировать\r\n актуальный " +
    "список сотрудников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добро пожаловать в раздел МЕНЮ!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dip.Properties.Resources.med;
            this.ClientSize = new System.Drawing.Size(797, 269);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(813, 308);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonback1;
        private System.Windows.Forms.Button buttonzp;
        private System.Windows.Forms.Button buttonsotryd;
        private System.Windows.Forms.Label labelmenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}