using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace каталог
{
    public partial class AddForm: Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        string fileName = "";

        private void pickMeBut_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                pictureBox.Load(fileName);
            }
        }

        private void adBut_Click(object sender, EventArgs e)
        {
            if(nameBox.Text=="" || styleBox.Text=="" || modeBox.Text=="" || priceBox.Text=="")
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            File.AppendAllText("games.txt", nameBox.Text + ", " + 
                                            styleBox.Text + ", " + 
                                            modeBox.Text + ", " + 
                                            priceBox.Text + Environment.NewLine);
            if(fileName != "")
            {
                File.Copy(fileName, "../../pictures/" + nameBox.Text + ".jpg");
            }
        }
    }
}
