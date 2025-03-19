namespace каталог
{
    partial class AddForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.modeBox = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pickMeBut = new System.Windows.Forms.Button();
            this.adBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(18, 57);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(252, 30);
            this.nameBox.TabIndex = 0;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(18, 295);
            this.priceBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(252, 30);
            this.priceBox.TabIndex = 1;
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "",
            "Стратегия",
            "Шутер",
            "Сюжет",
            "Выживание",
            "Песочница",
            "Экшен",
            "Ролевая игра"});
            this.styleBox.Location = new System.Drawing.Point(18, 136);
            this.styleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(252, 33);
            this.styleBox.TabIndex = 2;
            // 
            // modeBox
            // 
            this.modeBox.FormattingEnabled = true;
            this.modeBox.Items.AddRange(new object[] {
            "",
            "однопользовательский",
            "многопользовательский",
            "гибридный"});
            this.modeBox.Location = new System.Drawing.Point(18, 217);
            this.modeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(252, 33);
            this.modeBox.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(313, 35);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(263, 255);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // pickMeBut
            // 
            this.pickMeBut.Location = new System.Drawing.Point(344, 300);
            this.pickMeBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickMeBut.Name = "pickMeBut";
            this.pickMeBut.Size = new System.Drawing.Size(205, 37);
            this.pickMeBut.TabIndex = 5;
            this.pickMeBut.Text = "Загрузить картинку";
            this.pickMeBut.UseVisualStyleBackColor = true;
            this.pickMeBut.Click += new System.EventHandler(this.pickMeBut_Click);
            // 
            // adBut
            // 
            this.adBut.Location = new System.Drawing.Point(37, 335);
            this.adBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adBut.Name = "adBut";
            this.adBut.Size = new System.Drawing.Size(216, 50);
            this.adBut.TabIndex = 6;
            this.adBut.Text = "Добавить игру";
            this.adBut.UseVisualStyleBackColor = true;
            this.adBut.Click += new System.EventHandler(this.adBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = " Название игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Жанр игры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Режим игры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Цена";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adBut);
            this.Controls.Add(this.pickMeBut);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddForm";
            this.Text = "Форма добавления объектов";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.ComboBox modeBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button pickMeBut;
        private System.Windows.Forms.Button adBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}