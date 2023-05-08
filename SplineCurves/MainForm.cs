using System.Drawing;

namespace SplineCurves
{
    public partial class MainForm : Form
    {
        private List<Point> points = new List<Point>();
        private readonly Bitmap bmp;
        private readonly Graphics graph;
        private Point mouseDownLocation;

        public MainForm()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(bmp);
            graph.Clear(Color.White);
            pictureBox1.Image = bmp;
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            points.Add(mouseDownLocation);

            Pen blackPen = new Pen(Color.Black, 5);
            Rectangle rect = new Rectangle(mouseDownLocation.X, mouseDownLocation.Y, 2, 2);
            graph.Clear(Color.White);
            foreach (Point p in points)
            {
                graph.DrawEllipse(new Pen(Color.Black, 5), p.X, p.Y, 2, 2);
            }

            graph.DrawEllipse(blackPen, rect);
            pictureBox1.Invalidate();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point nearestPoint = FindNearestPoint(mouseDownLocation);

            if (nearestPoint != Point.Empty)
            {
                points.Remove(nearestPoint);
                graph.Clear(Color.White);
                foreach (Point p in points)
                {
                    graph.DrawEllipse(new Pen(Color.Black, 5), p.X, p.Y, 2, 2);
                }
            }
            pictureBox1.Invalidate();
        }

        private Point FindNearestPoint(Point p)
        {
            Point nearestPoint = Point.Empty;
            double minDistance = double.MaxValue;
            foreach (Point point in points)
            {
                double distance = Math.Sqrt(Math.Pow(point.X - p.X, 2) + Math.Pow(point.Y - p.Y, 2));

                if (distance < minDistance)
                {
                    nearestPoint = point;
                    minDistance = distance;
                }
            }

            return nearestPoint;
        }

        private void DrawBezierCurve(Graphics g, Pen pen, Point[] new_points)
        {
            int n = new_points.Length;
            if (n < 4)
            {
                MessageBox.Show("Необходимо поставить четыре и более точек на поле.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (double t = 0.0; t <= 1.0; t += 0.0001)
            {
                Point pt = CalculateBezierPoint(t, new_points, n);
                g.DrawRectangle(pen, pt.X, pt.Y, 1, 1);
            }
        }

        private Point CalculateBezierPoint(double t, Point[] new_points, int n)
        {
            Point[] temp = new Point[n];
            Array.Copy(new_points, temp, n);

            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    temp[i].X = (int)((1.0 - t) * temp[i].X + t * temp[i + 1].X);
                    temp[i].Y = (int)((1.0 - t) * temp[i].Y + t * temp[i + 1].Y);
                }
            }
            return temp[0];
        }


        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(Cursor.Position);
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mouseDownLocation = e.Location;
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            pictureBox1.Invalidate();
            points = new List<Point>();
        }

        private void PaintButton_Click(object sender, EventArgs e)
        {
            Point[] new_points = points.ToArray();
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255));
            DrawBezierCurve(graph, pen, new_points);
            pictureBox1.Invalidate();
        }
    }
}