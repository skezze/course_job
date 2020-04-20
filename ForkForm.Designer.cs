namespace course_job
{
    partial class ForkForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FIOField = new System.Windows.Forms.TextBox();
            this.PayCheck = new System.Windows.Forms.TextBox();
            this.Debt = new System.Windows.Forms.TextBox();
            this.CostField = new System.Windows.Forms.TextBox();
            this.TOWField = new System.Windows.Forms.TextBox();
            this.NOCField = new System.Windows.Forms.TextBox();
            this.add_to_base = new System.Windows.Forms.Button();
            this.clear_but = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clear_but);
            this.tabPage1.Controls.Add(this.add_to_base);
            this.tabPage1.Controls.Add(this.NOCField);
            this.tabPage1.Controls.Add(this.TOWField);
            this.tabPage1.Controls.Add(this.CostField);
            this.tabPage1.Controls.Add(this.Debt);
            this.tabPage1.Controls.Add(this.PayCheck);
            this.tabPage1.Controls.Add(this.FIOField);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Новая анкета";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Просмотр базы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО пациента :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер учетной карточки :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вид работы :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стоимость выполненной работы :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Задолженность за лечение :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Отметка об оплате :";
            // 
            // FIOField
            // 
            this.FIOField.Location = new System.Drawing.Point(356, 35);
            this.FIOField.Name = "FIOField";
            this.FIOField.Size = new System.Drawing.Size(100, 22);
            this.FIOField.TabIndex = 6;
            // 
            // PayCheck
            // 
            this.PayCheck.Location = new System.Drawing.Point(356, 266);
            this.PayCheck.Name = "PayCheck";
            this.PayCheck.Size = new System.Drawing.Size(100, 22);
            this.PayCheck.TabIndex = 7;
            // 
            // Debt
            // 
            this.Debt.Location = new System.Drawing.Point(356, 328);
            this.Debt.Name = "Debt";
            this.Debt.Size = new System.Drawing.Size(100, 22);
            this.Debt.TabIndex = 8;
            // 
            // CostField
            // 
            this.CostField.Location = new System.Drawing.Point(356, 203);
            this.CostField.Name = "CostField";
            this.CostField.Size = new System.Drawing.Size(100, 22);
            this.CostField.TabIndex = 9;
            // 
            // TOWField
            // 
            this.TOWField.Location = new System.Drawing.Point(356, 143);
            this.TOWField.Name = "TOWField";
            this.TOWField.Size = new System.Drawing.Size(100, 22);
            this.TOWField.TabIndex = 10;
            // 
            // NOCField
            // 
            this.NOCField.Location = new System.Drawing.Point(356, 87);
            this.NOCField.Name = "NOCField";
            this.NOCField.Size = new System.Drawing.Size(100, 22);
            this.NOCField.TabIndex = 11;
            // 
            // add_to_base
            // 
            this.add_to_base.Location = new System.Drawing.Point(667, 482);
            this.add_to_base.Name = "add_to_base";
            this.add_to_base.Size = new System.Drawing.Size(99, 33);
            this.add_to_base.TabIndex = 12;
            this.add_to_base.Text = "Сохранить";
            this.add_to_base.UseVisualStyleBackColor = true;
            // 
            // clear_but
            // 
            this.clear_but.Location = new System.Drawing.Point(538, 482);
            this.clear_but.Name = "clear_but";
            this.clear_but.Size = new System.Drawing.Size(99, 33);
            this.clear_but.TabIndex = 13;
            this.clear_but.Text = "Очистить";
            this.clear_but.UseVisualStyleBackColor = true;
            // 
            // ForkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ForkForm";
            this.Text = "Приложение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForkForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox NOCField;
        private System.Windows.Forms.TextBox TOWField;
        private System.Windows.Forms.TextBox CostField;
        private System.Windows.Forms.TextBox Debt;
        private System.Windows.Forms.TextBox PayCheck;
        private System.Windows.Forms.TextBox FIOField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_but;
        private System.Windows.Forms.Button add_to_base;
    }
}