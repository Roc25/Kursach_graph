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
            Graphs = new bool[1, 1];
            Len = 0;
        }

        public int AddGraph() {
            Len++;
            bool[,] n = new bool[Len, Len];
            Array.Copy( Graphs, n, Graphs.Length );
            Graphs = n;

            return Len - 1;
        }

        public void AddConnection( int id1, int id2 ) {
            Graphs[id1, id2] = !Graphs[id1, id2];
            Graphs[id2, id1] = !Graphs[id2, id1];
        }

        private int[,] reb;

        public List<int[]> MaxParS() {
            List<int[]> converted = Convert();
            List<int[]> otv = new List<int[]>();
            foreach( int[] ids in converted ) {
                var returned = Delet( ids[0], ids[1], converted, new List<int[]>() );
                if (returned.Count() > otv.Count()) {
                    otv = returned;
                }
            }
            return otv;
        }

        private List<int[]> Delet( int x, int y, List<int[]> mas, List<int[]> g ) {
            List<int[]> nmas = new List<int[]>();
            for (int i = 0; i < mas.Count(); i++) {
                if (!(mas[i].Contains( x ) || mas[i].Contains( y ))) {
                    nmas.Add( new int[2] { mas[i][0], mas[i][1] } );
                }
            }
            g.Add( new int[2] { x, y } );
            if (nmas.Count() == 0) {
                return g;
            }

            foreach (int[] item in nmas) {
                return Delet( item[0], item[1], new List<int[]>( nmas ), g );
            }
            return g;
        }

        private List<int[]> Convert() {
            List<int[]> Gr = new List<int[]>();
            for (int i = 0; i < Len; i++) {
                for (int j = 0; j < Len; j++) {
                    if (Graphs[i, j]) {
                        int[] n = { i, j };
                        Gr.Add( n );
                    }
                }
            }
            return Gr;
        }

    }
}
