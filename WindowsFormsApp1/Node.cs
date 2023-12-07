using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Node : IComparable<Node>
    {
        public (int, int) location;
        public (int, int) parent = (-1, -1);
        public bool visited = false;
        public bool isWall = false;
        public double f_x;
        public double g_x;
        public double h_x;
        public Node(int x, int y)
        {
            location = (x, y);
        }

        public int CompareTo(Node other)
        {
            return this.f_x.CompareTo(other.f_x);
        }
    }

}
