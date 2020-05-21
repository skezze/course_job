namespace course_job
{
    partial class Edit
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NOCField = new System.Windows.Forms.TextBox();
            this.CostField = new System.Windows.Forms.TextBox();
            this.Debt = new System.Windows.Forms.TextBox();
            this.FIOField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(506, 275);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 21);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "Нет";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(396, 275);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 21);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Да";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Протезирование",
            "Пломбирование",
            "Имплантация"});
            this.comboBox1.Location = new System.Drawing.Point(396, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // NOCField
            // 
            this.NOCField.Enabled = false;
            this.NOCField.Location = new System.Drawing.Point(396, 96);
            this.NOCField.Name = "NOCField";
            this.NOCField.Size = new System.Drawing.Size(208, 22);
            this.NOCField.TabIndex = 30;
            // 
            // CostField
            // 
            this.CostField.Enabled = false;
            this.CostField.Location = new System.Drawing.Point(396, 212);
            this.CostField.Name = "CostField";
            this.CostField.Size = new System.Drawing.Size(208, 22);
            this.CostField.TabIndex = 29;
            // 
            // Debt
            // 
            this.Debt.Enabled = false;
            this.Debt.Location = new System.Drawing.Point(396, 337);
            this.Debt.Name = "Debt";
            this.Debt.Size = new System.Drawing.Size(208, 22);
            this.Debt.TabIndex = 28;
            // 
            // FIOField
            // 
            this.FIOField.Enabled = false;
            this.FIOField.Location = new System.Drawing.Point(396, 44);
            this.FIOField.Name = "FIOField";
            this.FIOField.Size = new System.Drawing.Size(208, 22);
            this.FIOField.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(57, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Отметка об оплате :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(57, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Задолженность за лечение :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Стоимость выполненной работы :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Вид работы :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Номер учетной карточки :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "ФИО пациента :";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(633, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 33);
            this.button2.TabIndex = 36;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NOCField);
            this.Controls.Add(this.CostField);
            this.Controls.Add(this.Debt);
            this.Controls.Add(this.FIOField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox NOCField;
        private System.Windows.Forms.TextBox CostField;
        private System.Windows.Forms.TextBox Debt;
        private System.Windows.Forms.TextBox FIOField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}