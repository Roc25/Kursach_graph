using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kursach_graph {
    public class Graph {
        public bool[,] Graphs { get; private set; }
        public int Len;

        public Graph() { 
            Graphs = new bool[1,1];
            Len = 0;
        }

        public int AddGraph() {
            Len++;
            bool[,] n = new bool[Len, Len];
            Array.Copy(Graphs, n, Graphs.Length);
            Graphs = n;

            return Len-1;
        }

        public void AddConnection(int id1, int id2) {
            Graphs[id1, id2] = !Graphs[id1, id2];
            Graphs[id2, id1] = !Graphs[id2, id1];
        }
    }
}
