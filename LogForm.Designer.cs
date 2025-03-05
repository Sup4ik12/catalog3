namespace каталог
{
    partial class LogForm
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
            this.logBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logBut
            // 
            this.logBut.Location = new System.Drawing.Point(15, 191);
            this.logBut.Margin = new System.Windows.Forms.Padding(6);
            this.logBut.Name = "logBut";
            this.logBut.Size = new System.Drawing.Size(263, 56);
            this.logBut.TabIndex = 0;
            this.logBut.Text = "Войти";
            this.logBut.UseVisualStyleBackColor = true;
            this.logBut.Click += new System.EventHandler(this.logBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(13, 44);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(268, 38);
            this.logText.TabIndex = 3;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(10, 129);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(268, 38);
            this.passText.TabIndex = 4;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 260);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logBut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.TextBox passText;
    }
}