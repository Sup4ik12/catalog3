namespace каталог
{
    partial class RegForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sureText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pass1Text = new System.Windows.Forms.TextBox();
            this.regBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(14, 40);
            this.nameText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(302, 37);
            this.nameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // sureText
            // 
            this.sureText.Location = new System.Drawing.Point(14, 108);
            this.sureText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.sureText.Name = "sureText";
            this.sureText.Size = new System.Drawing.Size(302, 37);
            this.sureText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин";
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(14, 176);
            this.logText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(302, 37);
            this.logText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль";
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(14, 244);
            this.passText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(302, 37);
            this.passText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Подтвердите пароль";
            // 
            // pass1Text
            // 
            this.pass1Text.Location = new System.Drawing.Point(14, 312);
            this.pass1Text.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pass1Text.Name = "pass1Text";
            this.pass1Text.PasswordChar = '*';
            this.pass1Text.Size = new System.Drawing.Size(302, 37);
            this.pass1Text.TabIndex = 9;
            // 
            // regBut
            // 
            this.regBut.Location = new System.Drawing.Point(14, 358);
            this.regBut.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.regBut.Name = "regBut";
            this.regBut.Size = new System.Drawing.Size(302, 39);
            this.regBut.TabIndex = 10;
            this.regBut.Text = "Зарегистрироваться";
            this.regBut.UseVisualStyleBackColor = true;
            this.regBut.Click += new System.EventHandler(this.regBut_Click_1);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 412);
            this.Controls.Add(this.regBut);
            this.Controls.Add(this.pass1Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sureText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sureText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass1Text;
        private System.Windows.Forms.Button regBut;
    }
}