﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kursach_graph
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Graph Graphs;
        Graphics g;

        public Form()
        {
            InitializeComponent();
            Graphs = new Graph();
            g = Field.CreateGraphics();
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
                Location = new Point(e2.X - 40 / 2, e2.Y - 40 / 2),
                BackColor = Color.White,
                Tag = Graphs.AddGraph()
            };

            graph.Text = graph.Tag.ToString();
            graph.MouseClick += Graph_MouseClick;
            btns.Add(graph);

            Field.Controls.Add(graph);
        }

        Button selected = null;
        List<Button> btns = new List<Button>();

        private void DrawLines()
        {
            g.Clear(Color.Gray);
            Pen p = new Pen(Color.Red, 2);

            for (int i = 0; i < Graphs.Len; i++)
            {
                for (int j = 0; j < Graphs.Len; j++)
                {
                    if (Graphs.Graphs[i, j])
                    {
                        Point f = btns[i].Location;
                        Point t = btns[j].Location;

                        g.DrawLine(p, f.X + 20, f.Y + 20, t.X + 20, t.Y + 20);
                    }
                }
            }
        }

        private void Graph_MouseClick(object sender, MouseEventArgs e)
        {
            Button snd = sender as Button;
            if (selected == null)
            {
                selected = snd;
                snd.BackColor = Color.Blue;
                return;
            }
            if (selected == snd)
            {
                selected = null;
                snd.BackColor = Color.White;
                return;
            }

            Graphs.AddConnection((int)snd.Tag, (int)selected.Tag);
            DrawLines();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var par = Graphs.MaxParS();


            Pen p = new Pen(Color.Green, 5);
            Point firstbtn = new Point();
            Point secondbtn = new Point();

            foreach (var item in par)
            {

                foreach (var j in btns)
                {
                    if ((int)j.Tag == item[0])
                    {
                        firstbtn = j.Location;
                    }
                    if ((int)j.Tag == item[1])
                    {
                        secondbtn = j.Location;
                    }
                }


                g.DrawLine(p, firstbtn.X + 20, firstbtn.Y + 20, secondbtn.X + 20, secondbtn.Y + 20);
            }


        }
    }
}
