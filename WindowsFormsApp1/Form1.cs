using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        private int NumRows = 30;
        private int NumCols = 30;
        private int cellWidth;
        private int cellHeight;
        private Node[,] listNode = new Node[30, 30];
        private int mode = -1;
        private List<string> listMode = new List<string> { "Tạo tường", "Tạo điểm xuất phát", "Tạo điểm đích" };
        private (int, int) sourceNode = (-1, -1);
        private (int, int) desNode = (-1, -1);

        public Home()
        {
            InitializeComponent();
            initNode();
        }

        private void initNode()
        {
            for (int row = 0; row < NumRows; row++)
                for (int col = 0; col < NumCols; col++)
                {
                    listNode[row, col] = new Node(row, col);
                }
        }

        private void MapPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int CellWidth = ((Panel)sender).Width / NumRows;
            int CellHeight = ((Panel)sender).Height / NumCols;
            cellWidth = CellWidth;
            cellHeight = CellHeight;

            for (int row = 0; row < NumRows; row++)
            {
                for (int col = 0; col < NumCols; col++)
                {
                    int x = col * CellWidth;
                    int y = row * CellHeight;

                    g.DrawRectangle(Pens.Black, x, y, CellWidth, CellHeight);
                }
            }

            g.Dispose();
        }

        private void MapPanel_MouseClick(object sender, MouseEventArgs e)
        {
            CreateNode(sender, e);
        }

        private void CreateNode(object sender, MouseEventArgs e)
        {
            Point clickedPoint = e.Location;
            Graphics g = ((Panel)sender).CreateGraphics();

            int x = clickedPoint.X / cellWidth;
            int y = clickedPoint.Y / cellHeight;

            if (x > NumRows - 1 || x < 0) return;
            if (y > NumCols - 1 || y < 0) return;

            Rectangle rectangle = new Rectangle(x * cellWidth, y * cellHeight, cellWidth, cellHeight);
            if (mode == 0)
            {
                g.FillRectangle(Brushes.Black, rectangle);
                listNode[x, y].isWall = true;
            }
            else if (mode == 1)
            {
                if (sourceNode != (-1, -1)) return;
                g.FillRectangle(Brushes.Blue, rectangle);
                sourceNode = (x, y);
                listNode[x, y].isWall = false;
            }
            else if (mode == 2)
            {
                if (desNode != (-1, -1)) return;
                g.FillRectangle(Brushes.Red, rectangle);
                desNode = (x, y);
                listNode[x, y].isWall= false;
            }

            g.Dispose();
        }

        private void CreateWallBtn_Click(object sender, EventArgs e)
        {
            if (mode != 0)
            {
                mode = 0;
                ModeLbl.Text = listMode[mode];
            }
            else
            {
                mode = -1;
                ModeLbl.Text = "Mode : Không";
            }
        }

        private void CreateSourceBtn_Click(object sender, EventArgs e)
        {
            if (mode != 1)
            {
                mode = 1;
                ModeLbl.Text = listMode[mode];
            }
            else
            {
                mode = -1;
                ModeLbl.Text = "Mode : Không";
            }
        }

        private void CreateDesBtn_Click(object sender, EventArgs e)
        {
            if (mode != 2)
            {
                mode = 2;
                ModeLbl.Text = listMode[mode];
            }
            else
            {
                mode = -1;
                ModeLbl.Text = "Mode : Không";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MapPanel.Invalidate();
            initNode();
            mode = -1;
            sourceNode = (-1, -1);
            desNode = (-1, -1);
            ModeLbl.Text = "Mode : Không";
        }

        private void ChangeColor((int, int) location, int code)
        {
            Graphics g = MapPanel.CreateGraphics();

            Rectangle rectangle = new Rectangle(location.Item1 * cellWidth, location.Item2 * cellHeight, cellWidth - 1, cellHeight - 1);
            if (code == 0)
            {
                Thread.Sleep(25); 
                g.FillRectangle(Brushes.Yellow, rectangle);
            }
            else if (code == 1)
                g.FillRectangle(Brushes.Green, rectangle);
            else g.FillRectangle(Brushes.White, rectangle);
            g.Dispose();
        }

        private bool checkNode((int, int) location)
        {
            return location.Item1 >= 0 && location.Item2 >= 0 && location.Item1 < NumRows && location.Item2 < NumCols;
        }

        private List<(int, int)> Neighbor((int, int) current)
        {
            List<(int, int)> list = new List<(int, int)>();
            if (checkBox1.Checked == true)
            {
                List<(int, int)> addlist = new List<(int, int)> { (-1,-1), (-1, 0), (-1,1), (0,-1), (0,1), (1,-1), (1,0), (1,1) };
                foreach (var i in addlist)
                    list.Add((i.Item1 + current.Item1, i.Item2 + current.Item2));
            }
            else
            {
                List<(int, int)> addlist = new List<(int, int)> { (-1,0), (1,0), (0,-1), (0, 1) };
                foreach (var i in addlist)
                    list.Add((i.Item1 + current.Item1, i.Item2 + current.Item2));
            }
            
            return list;
        }

        private void resetVisited()
        {
            for (int row = 0; row < NumRows; row++)
                for (int col = 0; col < NumCols; col++)
                {
                    listNode[row, col].visited = false;
                }
        }
        private void BFS()
        {
            int count = 0;
            bool hasPath = false;
            if (sourceNode == (-1, -1)) return;
            if (desNode == (-1, -1)) return;
            resetVisited();
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue(sourceNode);

            while (queue.Count > 0)
            {
                (int, int) current = queue.Dequeue();
                count++;
                if (current != sourceNode && current != desNode)
                    ChangeColor(current, 0);
                if (current == desNode)
                {
                    StatusLbl.Text = "Trạng thái : Đã tìm thấy đích";
                    hasPath = true;
                    break;
                }

                List<(int, int)> neighbor = Neighbor(current);
                foreach (var i in neighbor)
                {
                    if (!checkNode(i)) continue;
                    if (listNode[i.Item1, i.Item2].visited == true) continue;
                    if (listNode[i.Item1, i.Item2].isWall == true) continue;

                    queue.Enqueue((i.Item1, i.Item2));
                    listNode[i.Item1, i.Item2].visited = true;
                    listNode[i.Item1, i.Item2].parent = current;
                }
            }

            if (!hasPath)
            {
                StatusLbl.Text = "Trạng thái : Không có đường đi";
                CountNodeLbl.Text = "";
                CountPathLbl.Text = "";
                return;
            }
            Stack<(int, int)> stack = new Stack<(int, int)>();
            var tmp = listNode[desNode.Item1, desNode.Item2].parent;
            stack.Push(tmp);
            while (tmp != sourceNode)
            {
                stack.Push(tmp);
                tmp = listNode[tmp.Item1, tmp.Item2].parent;
            }
            CountPathLbl.Text = $"Độ dài đường đi : {stack.Count}";
            CountNodeLbl.Text = $"Số nút đã xét : {count}";
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                ChangeColor(node, 1);
            }
        }

        private void DFS()
        {
            bool hasPath = false;
            int count = 0;
            if (sourceNode == (-1, -1)) return;
            if (desNode == (-1, -1)) return;
            resetVisited();
            Stack<(int, int)> stack = new Stack<(int, int)>();
            stack.Push(sourceNode);

            while (stack.Count > 0)
            {
                (int, int) current = stack.Pop();
                count++;
                if (current != sourceNode && current != desNode)
                    ChangeColor(current, 0);
                if (current == desNode)
                {
                    StatusLbl.Text = "Trạng thái : Đã tìm thấy đích";
                    hasPath = true;
                    break;
                }

                List<(int, int)> neighbor = Neighbor(current);
                foreach (var i in neighbor)
                {
                    if (!checkNode(i)) continue;
                    if (listNode[i.Item1, i.Item2].visited == true) continue;
                    if (listNode[i.Item1, i.Item2].isWall == true) continue;

                    stack.Push((i.Item1, i.Item2));
                    listNode[i.Item1, i.Item2].visited = true;
                    listNode[i.Item1, i.Item2].parent = current;
                }
            }

            if (!hasPath)
            {
                StatusLbl.Text = "Trạng thái : Không có đường đi";
                CountNodeLbl.Text = "";
                CountPathLbl.Text = "";
            }
            Stack<(int, int)> path_stack = new Stack<(int, int)>();
            var tmp = listNode[desNode.Item1, desNode.Item2].parent;
            path_stack.Push(tmp);
            while (tmp != sourceNode)
            {
                path_stack.Push(tmp);
                tmp = listNode[tmp.Item1, tmp.Item2].parent;
            }
            CountPathLbl.Text = $"Độ dài đường đi : {path_stack.Count}";
            CountNodeLbl.Text = $"Số nút đã xét : {count}";
            while (path_stack.Count > 0)
            {
                var node = path_stack.Pop();
                ChangeColor(node, 1);
            }
        }

        private void SolBtn_Click(object sender, EventArgs e)
        {
            mode = -1;
            if (BfsRadiobtn.Checked == true)
            {
                BFS();
            }
            else if (DfsRadioBtn.Checked == true)
            {
                DFS();
            }
            else if (AStarRadioBtn.Checked == true)
            {
                AStar();
            }
            StatusLbl.Text += "\n Nên xóa trước khi thực hiện thuật toán mới";
        }

        private void MapPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CreateNode(sender, e);
            }
        }

        private double heuristic((int, int) x, (int, int) y)
        {
            return Math.Pow(x.Item1 - y.Item1, 2) + Math.Pow(x.Item2 - y.Item2, 2);
        }

        private void AStar()
        {
            bool hasPath = false;
            int count = 0;
            if (sourceNode == (-1, -1)) return;
            if (desNode == (-1, -1)) return;
            resetVisited();
            var heap = new C5.IntervalHeap<Node>();
            listNode[sourceNode.Item1, sourceNode.Item2].g_x = 0;
            listNode[sourceNode.Item1, sourceNode.Item2].h_x = heuristic(sourceNode, desNode);
            listNode[sourceNode.Item1, sourceNode.Item2].f_x = 
                listNode[sourceNode.Item1, sourceNode.Item2].g_x + listNode[sourceNode.Item1, sourceNode.Item2].h_x;
            listNode[sourceNode.Item1, sourceNode.Item2].visited = true;
            heap.Add(listNode[sourceNode.Item1, sourceNode.Item2]);
            while (heap.Count > 0)
            {
                var current = heap.DeleteMin();
                //listNode[current.location.Item1, current.location.Item2].visited = true;
                count++;
                if (current.location != sourceNode && current.location != desNode)
                    ChangeColor(current.location, 0);
                if (current.location == desNode)
                {
                    StatusLbl.Text = "Trạng thái : Đã tìm thấy đích";
                    hasPath = true;
                    break;
                }

                List<(int, int)> neighbor = Neighbor(current.location);
                foreach (var i in neighbor)
                {
                    if (!checkNode(i)) continue;
                    if (listNode[i.Item1, i.Item2].visited == true) continue;
                    if (listNode[i.Item1, i.Item2].isWall == true) continue;

                    listNode[i.Item1, i.Item2].g_x = current.g_x + 1;
                    listNode[i.Item1, i.Item2].h_x = heuristic(i, desNode);
                    listNode[i.Item1, i.Item2].f_x = listNode[i.Item1, i.Item2].g_x + listNode[i.Item1, i.Item2].h_x;
                    listNode[i.Item1, i.Item2].visited = true;
                    listNode[i.Item1, i.Item2].parent = current.location;
                    heap.Add(listNode[i.Item1, i.Item2]);
                    //ChangeColor(listNode[i.Item1, i.Item2].location, 2);
                }
            }

            if (!hasPath)
            {
                StatusLbl.Text = "Trạng thái : Không có đường đi";
                CountNodeLbl.Text = "";
                CountPathLbl.Text = "";
                return;
            }
            Stack<(int, int)> path_stack = new Stack<(int, int)>();
            var tmp = listNode[desNode.Item1, desNode.Item2].parent;
            path_stack.Push(tmp);
            while (tmp != sourceNode)
            {
                path_stack.Push(tmp);
                tmp = listNode[tmp.Item1, tmp.Item2].parent;
            }
            CountPathLbl.Text = $"Độ dài đường đi : {path_stack.Count}";
            CountNodeLbl.Text = $"Số nút đã xét : {count}";
            while (path_stack.Count > 0)
            {
                var node = path_stack.Pop();
                ChangeColor(node, 1);
            }
        }
    }
}
