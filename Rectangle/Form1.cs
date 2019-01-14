using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangletest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Panel pnl = new Panel();
            pnl.Parent = this;
            pnl.Dock = DockStyle.Fill;
            pnl.BackColor = Color.Green;
            pnl.Paint += new PaintEventHandler(drawRectangle);
            pnl.Click += new EventHandler(doubleClick);
            //this.Paint += new PaintEventHandler(drawRectangle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.ClientSize = new Size(800, 400);
            
        }

        private void drawRectangle(object sender, PaintEventArgs e)
        {
            Point pt = new Point(20, 20);
            Size size = new Size(200, 200);
            Pen pen = new Pen(Color.Red, 5);

            Rectangle rect = Rectangle.FromLTRB(1, 1, 300, 50);
            e.Graphics.DrawRectangle(pen, rect);

            e.Graphics.DrawString("hello", Font, Brushes.Red, pt);

        }

        private void doubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
