using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Thread circle;
        Thread rectangle;
        Thread triangle;
        Random rdm;
        public void threadCircle()
        {
            while (true)
            {
                int width = rdm.Next(0, this.Width);
                int height = rdm.Next(0, this.Height);
                if (width < 700 && height < 400)
                {
                    int random = rdm.Next(0, 50);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Black, 1), new Rectangle(width, height, random, random));
                    Thread.Sleep(4000);
                }
            }
        }
        public void threadRectangle()
        {
            while (true)
            {
                int randomlength = rdm.Next(0, this.Width);
                int randomheight = rdm.Next(0, this.Height);
                int width = rdm.Next(0, this.Width);
                int height = rdm.Next(0, this.Height);
                if (randomlength < 100 && randomheight < 100 && width < 700 && height < 350)
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 1), new Rectangle(width
                    , height, randomlength, randomheight));
                    Thread.Sleep(3000);
                }

            }
        }
        public void threadTriangle()
        {
            while (true)
            {
                int pointWidth = rdm.Next(0, this.Width);
                int pointWidth1 = rdm.Next(0, this.Width);
                int pointHeight1 = rdm.Next(0, this.Height);
                int pointWidth2 = rdm.Next(0, this.Width);
                int pointHeight2 = rdm.Next(0, this.Height);
                if (pointWidth > 50 && pointWidth < 400 && pointWidth1 > 50 && pointWidth1 < 800 && pointWidth2 > 50 && pointWidth2 < 400 && pointHeight1 > 50 && pointHeight1 < 200 && pointHeight2 > 50 && pointHeight2 < 200)
                {
                    Point[] a = { new Point(pointWidth, pointWidth), new Point(pointWidth1, pointHeight1), new Point(pointWidth2, pointHeight2) };
                    this.CreateGraphics().DrawPolygon(new Pen(Brushes.Blue, 1), a);
                    Thread.Sleep(2000);
                }
            }
        }
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            triangle = new Thread(threadTriangle);
            triangle.Start();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            rectangle = new Thread(threadRectangle);
            rectangle.Start();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            circle = new Thread(threadCircle);
            circle.Start();
        }

        private void btnLines_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rdm = new Random(); 
        }
    }
}
