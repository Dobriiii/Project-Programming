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
        Thread th;
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
                    Thread.Sleep(400);
                }
            }
        }
        private void btnTriangle_Click(object sender, EventArgs e)
        {

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            th = new Thread(threadCircle);
            th.Start();
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
