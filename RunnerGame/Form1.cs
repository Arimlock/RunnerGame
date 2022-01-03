using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunnerGame
{
    public partial class Form1 : Form
    {
        //this.Controls.Add(this.GameField);
        //this.Controls.Add(this.Menu);
        int fps=24;
        PictureBox Dino = new PictureBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBut_Click(object sender, EventArgs e)
        {
            Menu.Parent = null;
            Controls.Add(GameField);
            Field1.Location = new Point(0, 180);
            Field2.Location = new Point(Field1.Width, 180);
            fps = 24;
            FpsShower.Text = (fps).ToString();
            Fps.Interval = 1000 / fps;
            Dino.Height = Field1.Height / 3;
            Dino.Width = Dino.Height;
            Dino.Location = new Point(0,180);
            GameField.Controls.Add(Dino);
            Dino.BringToFront();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            GameField.Parent = null;
            Controls.Add(Menu);
        }

        private void GoStop_Click(object sender, EventArgs e)
        {
            if (GoStop.Text == "Пуск")
            {
                GoStop.Text = "Стоп";
                Fps.Enabled = true;
            }
            else
            {
                GoStop.Text = "Пуск";
                Fps.Enabled = false;
            }
        }

        private void Fps_Tick(object sender, EventArgs e)
        {
            Field1.Location = new Point(Field1.Location.X - 10, Field1.Location.Y);
            Field2.Location = new Point(Field2.Location.X - 10, Field2.Location.Y);
            if (Field1.Location.X <= (-1)*(Field1.Width))
                Field1.Location = new Point(Field2.Location.X + Field1.Width, Field1.Location.Y);
            if (Field2.Location.X <= (-1) * (Field2.Width))
                Field2.Location = new Point(Field1.Location.X+Field1.Width, Field2.Location.Y);
        }

        private void PlusBut_Click(object sender, EventArgs e)
        {
            fps++;
            Fps.Interval = 1000/fps;
            FpsShower.Text = (fps).ToString();
        }

        private void MinusBut_Click(object sender, EventArgs e)
        {
            if (fps > 1)
            {
                fps--;
                Fps.Interval = 1000 / fps;
            }
            FpsShower.Text = (fps).ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            ConsoleKey key=ConsoleKey.A;
            switch (e.KeyValue)
            {
                case ((char)Keys.W):
                    key = ConsoleKey.W;
                    break;
                case ((char)Keys.S):
                    key = ConsoleKey.S;
                    break;
            }
            ShowPlaying.Move(key, Dino);
        }
    }
}
