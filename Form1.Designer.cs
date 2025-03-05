namespace каталог
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.regPanel = new System.Windows.Forms.Panel();
            this.nameLab = new System.Windows.Forms.Label();
            this.logbut = new System.Windows.Forms.Button();
            this.regBut = new System.Windows.Forms.Button();
            this.filtrPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.modeCBox = new System.Windows.Forms.ComboBox();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.findBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.hideBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regPanel.SuspendLayout();
            this.filtrPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regPanel
            // 
            this.regPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.regPanel.Controls.Add(this.nameLab);
            this.regPanel.Controls.Add(this.logbut);
            this.regPanel.Controls.Add(this.regBut);
            this.regPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.regPanel.Location = new System.Drawing.Point(0, 0);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(1060, 57);
            this.regPanel.TabIndex = 0;
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(396, 20);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(51, 20);
            this.nameLab.TabIndex = 6;
            this.nameLab.Text = "label1";
            // 
            // logbut
            // 
            this.logbut.Location = new System.Drawing.Point(246, 12);
            this.logbut.Name = "logbut";
            this.logbut.Size = new System.Drawing.Size(109, 37);
            this.logbut.TabIndex = 5;
            this.logbut.Text = "Войти";
            this.logbut.UseVisualStyleBackColor = true;
            this.logbut.Click += new System.EventHandler(this.logbut_Click);
            // 
            // regBut
            // 
            this.regBut.Location = new System.Drawing.Point(24, 12);
            this.regBut.Name = "regBut";
            this.regBut.Size = new System.Drawing.Size(191, 37);
            this.regBut.TabIndex = 4;
            this.regBut.Text = "Зарегистрироваться";
            this.regBut.UseVisualStyleBackColor = true;
            this.regBut.Click += new System.EventHandler(this.regBut_Click);
            // 
            // filtrPanel
            // 
            this.filtrPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.filtrPanel.Controls.Add(this.label6);
            this.filtrPanel.Controls.Add(this.modeCBox);
            this.filtrPanel.Controls.Add(this.PriceTextbox);
            this.filtrPanel.Controls.Add(this.label5);
            this.filtrPanel.Controls.Add(this.findBut);
            this.filtrPanel.Controls.Add(this.label4);
            this.filtrPanel.Controls.Add(this.styleBox);
            this.filtrPanel.Controls.Add(this.nameText);
            this.filtrPanel.Controls.Add(this.hideBut);
            this.filtrPanel.Controls.Add(this.label3);
            this.filtrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtrPanel.Location = new System.Drawing.Point(0, 57);
            this.filtrPanel.Name = "filtrPanel";
            this.filtrPanel.Size = new System.Drawing.Size(1060, 131);
            this.filtrPanel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Режим";
            // 
            // modeCBox
            // 
            this.modeCBox.FormattingEnabled = true;
            this.modeCBox.Items.AddRange(new object[] {
            "",
            "однопользовательский",
            "многопользовательский",
            "гибридный"});
            this.modeCBox.Location = new System.Drawing.Point(376, 85);
            this.modeCBox.Name = "modeCBox";
            this.modeCBox.Size = new System.Drawing.Size(196, 28);
            this.modeCBox.TabIndex = 12;
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(109, 82);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(91, 26);
            this.PriceTextbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цена от $";
            // 
            // findBut
            // 
            this.findBut.Location = new System.Drawing.Point(932, 35);
            this.findBut.Name = "findBut";
            this.findBut.Size = new System.Drawing.Size(116, 37);
            this.findBut.TabIndex = 9;
            this.findBut.Text = "Найти";
            this.findBut.UseVisualStyleBackColor = true;
            this.findBut.Click += new System.EventHandler(this.findBut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Жанр";
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
            this.styleBox.Location = new System.Drawing.Point(376, 38);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(196, 28);
            this.styleBox.TabIndex = 7;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(125, 38);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(150, 26);
            this.nameText.TabIndex = 6;
            this.nameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameText_KeyDown);
            // 
            // hideBut
            // 
            this.hideBut.Location = new System.Drawing.Point(0, 0);
            this.hideBut.Name = "hideBut";
            this.hideBut.Size = new System.Drawing.Size(154, 31);
            this.hideBut.TabIndex = 0;
            this.hideBut.Text = "Развернуть";
            this.hideBut.UseVisualStyleBackColor = true;
            this.hideBut.Click += new System.EventHandler(this.hideBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название";
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 188);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1060, 461);
            this.menuPanel.TabIndex = 2;
            this.menuPanel.Resize += new System.EventHandler(this.menuPanel_Resize);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Добавить объект";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 649);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.filtrPanel);
            this.Controls.Add(this.regPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.filtrPanel.ResumeLayout(false);
            this.filtrPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Button regBut;
        private System.Windows.Forms.Panel filtrPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button hideBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findBut;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox modeCBox;
        private System.Windows.Forms.Button logbut;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
    }
}

