using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using каталог.Properties;

namespace каталог
{
    public struct Game
    {
        public string name;
        public string style;
        public string mode;
        public int price;
        public PictureBox pb;
        public Label lb;

        public Game(string _name, string _style, string _mode, int _price)
        {
            name = _name;
            style = _style;
            mode = _mode;
            price = _price;
            pb = new PictureBox();
            try
            {
                pb.Load("../../Pictures/" + name + ".jpg");
            }
            catch(Exception)  { }

            lb = new Label();
            lb.Text = name;
        }

    }
    public partial class mainForm : Form
    {
        List<Game> game_list = new List<Game>();
        public mainForm()
        {
            InitializeComponent();
            filtrPanel.Height = hideBut.Height;
            nameLab.Visible = false;

            game_list.Clear();
            string[] strs = System.IO.File.ReadAllLines("games.txt");
            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                Game game = new Game(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3]));
                game_list.Add(game);
            }

            int x = 30;
            int y = 30;

            for (int i = 0; i < game_list.Count; i++)
            {
                game_list[i].pb.Location = new Point(x, y);
                game_list[i].pb.Size = new Size(219, 243);
                game_list[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                game_list[i].pb.Tag = game_list[i].name;
                game_list[i].pb.Click += new EventHandler(picture_Click);
                menuPanel.Controls.Add(game_list[i].pb);

                game_list[i].lb.Location = new Point(x,y + 260);
                game_list[i].lb.Size = new Size(200, 25);
                game_list[i].lb.TextAlign = ContentAlignment.MiddleCenter;
                menuPanel.Controls.Add(game_list[i].lb);

                x += 300;
                if (x+250 > menuPanel.Width)
                {
                    x = 30;
                    y += 300; 
                }
            }
        }

        private void hideBut_Click(object sender, EventArgs e)
        {
            if(filtrPanel.Height>hideBut.Height)
            {
                filtrPanel.Height = hideBut.Height;
                hideBut.Text = "Развернуть";
            }
            else
            {
                filtrPanel.Height = 131;
                hideBut.Text = "Свернуть";
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {
            for (int i=0;i < game_list.Count; i++)
            {
                if (((PictureBox)sender).Tag == game_list[i].pb.Tag)
                {
                    GameForm gameForm = new GameForm(game_list[i]);
                    gameForm.ShowDialog();
                }
            }
        }

        private void findBut_Click(object sender, EventArgs e)
        {
            int x = 30;
            int y = 30;

            for (int i = 0; i < game_list.Count; i++)
            {
                game_list[i].pb.Visible = true;
                game_list[i].lb.Visible = true;

                if(styleBox.Text != game_list[i].style && styleBox.Text != "")
                {
                    game_list[i].pb.Visible = false;
                    game_list[i].lb.Visible = false;
                }

                if (!game_list[i].name.ToLower().Contains(nameText.Text.ToLower()) && nameText.Text != "")
                {
                    game_list[i].pb.Visible = false;
                    game_list[i].lb.Visible = false;
                }

                if (modeCBox.Text != game_list[i].mode && modeCBox.Text != "")
                {
                    game_list[i].pb.Visible = false;
                    game_list[i].lb.Visible = false;
                }

                if (PriceTextbox.Text != "" && Convert.ToInt32(PriceTextbox.Text) >= game_list[i].price)
                {
                    game_list[i].pb.Visible = false;
                    game_list[i].lb.Visible = false;
                }

                if (game_list[i].pb.Visible)
                {
                    game_list[i].pb.Location = new Point(x, y);
                    game_list[i].lb.Location = new Point(x, y+260);
                    x += 300;
                    if (x + 250 > menuPanel.Width)
                    {
                        x = 30;
                        y += 300;
                    }
                }

                

            }
        }

        private void menuPanel_Resize(object sender, EventArgs e)
        {
            findBut_Click(null, null);
        }

        private void nameText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                findBut_Click(null, null);
            }    
        }

        private void regBut_Click(object sender, EventArgs e)
        {
            RegForm regform = new RegForm();
            regform.ShowDialog();
        }

        private void logbut_Click(object sender, EventArgs e)
        {
            if(logbut.Text == "Войти")
            {
                LogForm logForm = new LogForm();
                logForm.ShowDialog();
                if(LogForm.login != "")
                {
                    nameLab.Text = "Вы авторизовались как" + " " + LogForm.name + " " + LogForm.surename;
                    nameLab.Visible = true;
                    logbut.Text = "Выйти";
                }
            }
            else
            {
                nameLab.Text = "";
                nameLab.Visible = false;
                logbut.Text = "Вoйти";
                LogForm.login = "";
                LogForm.surename = "";
                LogForm.name = "";
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LogForm.isAdmin == true)
            {
                AddForm add = new AddForm();
                add.ShowDialog();
            }
            else
            {
                MessageBox.Show("Добавлять объекты может только администратор");
            }
        }
    }
}
