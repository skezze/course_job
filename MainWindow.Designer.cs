namespace course_job
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonToLoginForm = new System.Windows.Forms.Button();
            this.buttonToRegForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonToLoginForm
            // 
            this.buttonToLoginForm.Location = new System.Drawing.Point(158, 166);
            this.buttonToLoginForm.Name = "buttonToLoginForm";
            this.buttonToLoginForm.Size = new System.Drawing.Size(172, 45);
            this.buttonToLoginForm.TabIndex = 0;
            this.buttonToLoginForm.Text = "Войти";
            this.buttonToLoginForm.UseVisualStyleBackColor = true;
            this.buttonToLoginForm.Click += new System.EventHandler(this.buttonToLoginForm_Click);
            // 
            // buttonToRegForm
            // 
            this.buttonToRegForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToRegForm.Location = new System.Drawing.Point(158, 278);
            this.buttonToRegForm.Name = "buttonToRegForm";
            this.buttonToRegForm.Size = new System.Drawing.Size(172, 45);
            this.buttonToRegForm.TabIndex = 1;
            this.buttonToRegForm.Text = "Зарегистрироваться";
            this.buttonToRegForm.UseVisualStyleBackColor = true;
            this.buttonToRegForm.Click += new System.EventHandler(this.buttonToRegForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добро пожаловать !";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonToRegForm);
            this.Controls.Add(this.buttonToLoginForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToLoginForm;
        private System.Windows.Forms.Button buttonToRegForm;
        private System.Windows.Forms.Label label1;
    }
}

