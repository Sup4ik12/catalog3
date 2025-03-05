namespace каталог
{
    partial class GameForm
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
            this.nameLab = new System.Windows.Forms.Label();
            this.gamePic = new System.Windows.Forms.PictureBox();
            this.styleLab = new System.Windows.Forms.Label();
            this.deskText = new System.Windows.Forms.TextBox();
            this.priceLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(37, 32);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(51, 20);
            this.nameLab.TabIndex = 0;
            this.nameLab.Text = "label1";
            // 
            // gamePic
            // 
            this.gamePic.Location = new System.Drawing.Point(38, 108);
            this.gamePic.Name = "gamePic";
            this.gamePic.Size = new System.Drawing.Size(363, 422);
            this.gamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamePic.TabIndex = 1;
            this.gamePic.TabStop = false;
            // 
            // styleLab
            // 
            this.styleLab.AutoSize = true;
            this.styleLab.Location = new System.Drawing.Point(487, 40);
            this.styleLab.Name = "styleLab";
            this.styleLab.Size = new System.Drawing.Size(51, 20);
            this.styleLab.TabIndex = 2;
            this.styleLab.Text = "label1";
            // 
            // deskText
            // 
            this.deskText.Location = new System.Drawing.Point(483, 94);
            this.deskText.Multiline = true;
            this.deskText.Name = "deskText";
            this.deskText.Size = new System.Drawing.Size(503, 436);
            this.deskText.TabIndex = 3;
            // 
            // priceLab
            // 
            this.priceLab.AutoSize = true;
            this.priceLab.Location = new System.Drawing.Point(886, 552);
            this.priceLab.Name = "priceLab";
            this.priceLab.Size = new System.Drawing.Size(51, 20);
            this.priceLab.TabIndex = 4;
            this.priceLab.Text = "label1";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 628);
            this.Controls.Add(this.priceLab);
            this.Controls.Add(this.deskText);
            this.Controls.Add(this.styleLab);
            this.Controls.Add(this.gamePic);
            this.Controls.Add(this.nameLab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.PictureBox gamePic;
        private System.Windows.Forms.Label styleLab;
        private System.Windows.Forms.TextBox deskText;
        private System.Windows.Forms.Label priceLab;
    }
}