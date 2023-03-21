using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace AffineTransformation
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        // два массива, поскольку фигура строится из двух треугольников
        private PointF[] firstPoints;
        private PointF[] secondPoints;
        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            firstPoints = new PointF[] { new PointF(300, 200), new PointF(400, 200), new PointF(360, 120) };
            secondPoints = new PointF[] { new PointF(300, 200), new PointF(400, 200), new PointF(270, 120) };
            using (Graphics g = Graphics.FromImage(bitmap))
                DrawFromScratch(g);
        }

        private void DrawFromScratch(Graphics graph)
        {
            graph.Clear(Color.White);
            graph.DrawLine(new Pen(Brushes.Black, 2), new Point(0, 200), new Point(pictureBox1.Width, 200)); // рисуем оси под размер экрана
            graph.DrawLine(new Pen(Brushes.Black, 2), new Point(300, 0), new Point(300, pictureBox1.Height));
            graph.DrawPolygon(new Pen(Color.Black, 3), firstPoints);
            graph.DrawPolygon(new Pen(Color.Black, 3), secondPoints);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int angle = Convert.ToInt32(textBox1.Text); //угол поворота
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    PointF r = firstPoints[0]; // точка относительно которой поворачиваем
                    double angleRadian = angle * Math.PI / 180; //переводим угол в радианты
                    PointF[] r_ = new PointF[firstPoints.Length]; //для хранения новых координат объекта
                    PointF[] c_ = new PointF[secondPoints.Length];
                    for (int j = 0; j < firstPoints.Length; j++)
                    {
                        float x = (float)((firstPoints[j].X - r.X) * Math.Cos(angleRadian) - (firstPoints[j].Y - r.Y) * Math.Sin(angleRadian) + r.X);
                        float y = (float)((firstPoints[j].X - r.X) * Math.Sin(angleRadian) + (firstPoints[j].Y - r.Y) * Math.Cos(angleRadian) + r.Y);
                        r_[j] = new PointF(x, y);
                    }
                    for (int j = 0; j < secondPoints.Length; j++)
                    {
                        float x = (float)((secondPoints[j].X - r.X) * Math.Cos(angleRadian) - (secondPoints[j].Y - r.Y) * Math.Sin(angleRadian) + r.X);
                        float y = (float)((secondPoints[j].X - r.X) * Math.Sin(angleRadian) + (secondPoints[j].Y - r.Y) * Math.Cos(angleRadian) + r.Y);
                        c_[j] = new PointF(x, y);
                    }
                    // Новые координаты фигуры записываем в координаты объекта 
                    firstPoints = r_; 
                    secondPoints = c_;
                    // Рисуем повернутый объект
                    DrawFromScratch(g);
                }
                pictureBox1.Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                float coef_x = (float)Convert.ToDouble(textBox2.Text);
                float coef_y = (float)Convert.ToDouble(textBox3.Text);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    PointF[] r_ = new PointF[firstPoints.Length]; // для хранения новых координат обхекта
                    PointF[] c_ = new PointF[secondPoints.Length];
                    float x_ = 0;
                    float y_ = 0;
                    for (int j = 0; j < firstPoints.Length; j++)
                    {
                        float x = firstPoints[j].X * coef_x;
                        float y = firstPoints[j].Y * coef_y;
                        if (j == 0)
                        {
                            x_ = firstPoints[j].X - x;
                            y_ = firstPoints[j].Y - y;
                        }
                        r_[j] = new PointF(x + x_, y + y_);
                    }
                    for (int j = 0; j < secondPoints.Length; j++)
                    {
                        float x = secondPoints[j].X * coef_x;
                        float y = secondPoints[j].Y * coef_y;
                        if (j == 0)
                        {
                            x_ = secondPoints[j].X - x;
                            y_ = secondPoints[j].Y - y;
                        }
                        c_[j] = new PointF(x + x_, y + y_);
                    }
                    // Новые координаты фигуры записываем в координаты объекта 
                    firstPoints = r_;
                    secondPoints = c_;
                    //Рисуем сжатый объект
                    DrawFromScratch(g);
                }
                pictureBox1.Invalidate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox5.Text != "")
            {
                float size_x = (float)Convert.ToDouble(textBox4.Text);
                float size_y = (float)Convert.ToDouble(textBox5.Text);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    PointF[] r_ = new PointF[firstPoints.Length]; //для хранения новых координат обхекта
                    PointF[] c_ = new PointF[secondPoints.Length];
                    for (int j = 0; j < firstPoints.Length; j++)
                    {
                        float x = firstPoints[j].X + size_x;
                        float y = firstPoints[j].Y + size_y;
                        r_[j] = new PointF(x, y);
                    }
                    for (int j = 0; j < secondPoints.Length; j++)
                    {
                        float x = secondPoints[j].X + size_x;
                        float y = secondPoints[j].Y + size_y;
                        c_[j] = new PointF(x, y);
                    }
                    // Новые координаты фигуры записываем в координаты объекта 
                    firstPoints = r_;
                    secondPoints = c_;
                    //Рисуем сжатый объект
                    DrawFromScratch(g);
                }
                pictureBox1.Invalidate();
            }
        }
    }
}