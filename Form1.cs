using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingToolForTeaching
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x;
        int y;
        bool moving=false;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0.2;
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Red, 3);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(10, Color.Black);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // moving = true;
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving) {
                g.DrawLine(pen, new Point(x,y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //moving = true;
            moving = false;
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pen.Color = pic.BackColor;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pen.Color = pic.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pen.Color = pic.BackColor;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pen.Color = pic.BackColor;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pen.Color = pic.BackColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pen.Color = pic.BackColor;
        }
    }
}
