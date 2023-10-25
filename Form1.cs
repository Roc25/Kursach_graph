using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Field_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs e2 = (MouseEventArgs)e;
            var graph = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(e2.X - 40 / 2, e2.Y - 40 / 2)
            };

            Field.Controls.Add(graph);
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            button1.Location = new Point(e.X, e.Y);
        }
    }
}
