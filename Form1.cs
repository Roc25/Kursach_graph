using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace Kursach_graph {
    public partial class Form1 : Form {
        public Graph Graphs;
        Graphics g;

        public Form1() {
            InitializeComponent();
            Graphs = new Graph();
            g = Field.CreateGraphics();
        }

        private void Form1_Load( object sender, EventArgs e ) {

        }

        private void Panel1_Paint( object sender, PaintEventArgs e ) {
        }

        private void Field_DoubleClick( object sender, EventArgs e ) {
            MouseEventArgs e2 = (MouseEventArgs) e;
            var graph = new Button {
                Size = new Size( 40, 40 ),
                Location = new Point( e2.X - 40 / 2, e2.Y - 40 / 2 ),
                BackColor = Color.White,
                Tag = Graphs.AddGraph()
            };

            graph.Text = graph.Tag.ToString();
            graph.MouseClick += Graph_MouseClick;
            btns.Add( graph );

            Field.Controls.Add( graph );
        }

        Button selected = null;
        List<Button> btns = new List<Button>();

        private void DrawLines() {
            g.Clear(Color.Gray);
            Pen p = new Pen( Color.Red, 2 );

            for ( int i = 0; i < Graphs.Len; i++ ) {
                for ( int j = 0; j < Graphs.Len; j++) {
                    if (Graphs.Graphs[i,j]) {
                        Point f = btns[i].Location;
                        Point t = btns[j].Location;

                        g.DrawLine( p, f.X + 20, f.Y + 20, t.X + 20, t.Y + 20 );
                    }
                }
            }
        }

        private void Graph_MouseClick( object sender, MouseEventArgs e ) {
            Button snd = sender as Button;
            if ( selected == null ) { 
                selected = snd;
                snd.BackColor = Color.Blue;
                return;
            }
            if ( selected == snd) {
                selected = null;
                snd.BackColor = Color.White;
                return;
            }

            Graphs.AddConnection((int) snd.Tag, (int) selected.Tag);
            DrawLines();
        }
    }
}
