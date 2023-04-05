namespace FloodFill
{
    public enum Fills : int
    {
        Seed,
        Scanline
    }

    public partial class MainForm : Form
    {
        private readonly Bitmap bmp;
        private readonly Graphics graph;
        private readonly PointF[] figurePoints;
        private readonly Color blackColor = Color.FromArgb(0, 0, 1);
        private readonly Color whiteColor = Color.FromArgb(255, 255, 254);

        public MainForm()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            graph = Graphics.FromImage(bmp);
            pictureBox.Image = bmp;
            // Инициализируем вершины фигуры
            figurePoints = new PointF[]
                {
                    new PointF(120, 130),
                    new PointF(180, 130),
                    new PointF(180, 60),
                    new PointF(130, 60),
                    new PointF(160, 80)
                };
            DrawFromScratch(graph);
        }

        public void DrawFromScratch(Graphics graph)
        {
            graph.Clear(whiteColor);
            graph.DrawPolygon(new Pen(blackColor, 3), figurePoints);
            pictureBox.Refresh();
        }

        private void ScanlineFill(int x, int y, Color fillColor)
        {
            // Определим цвет в точке, с которой начнётся заливка
            Color startColor = bmp.GetPixel(x, y);
            // Создаем стек для хранения координат пикселей, которые нужно проверить
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));
            // Пока стек не пуст, будем закрашивать пиксели
            while (stack.Count > 0)
            {
                // Извлекаем координаты точки из стека
                Point p = stack.Pop();
                x = p.X;
                y = p.Y;
                // Если цвет текущей точки равен цвету начальной точки, закрашиваем ее
                if (bmp.GetPixel(x, y) == startColor)
                {
                    bmp.SetPixel(x, y, fillColor);
                    pictureBox.Refresh(); // обновляем PictureBox после каждого изменения пикселя
                    // Задержка на 1 миллисекунд для создания эффекта анимации
                    Thread.Sleep(1);
                    // Пушим новые точки для закраски
                    stack.Push(new Point(x, y - 1));
                    stack.Push(new Point(x, y + 1));
                    stack.Push(new Point(x - 1, y));
                    stack.Push(new Point(x + 1, y));
                }
            }
        }


        private void SeedFill(int x, int y, Color fillColor)
        {
            // Определим цвет в точке, с которой начнётся заливка
            Color startColor = bmp.GetPixel(x, y);
            // Если цвет пикселя совпадает с цветом затравки, то выходим из рекурсии
            if (startColor == fillColor)
                return;
            // Создаем стек для хранения координат пикселей, которые нужно проверить
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));
            // Пока стек не пуст, будем закрашивать пиксели
            while (stack.Count > 0)
            {
                // Извлекаем координаты точки из стека
                Point p = stack.Pop();
                x = p.X;
                y = p.Y;
                // Если цвет текущей точки не равен цвету заливки и не равен цвету начальной точки, закрашиваем ее
                if (bmp.GetPixel(x, y) == startColor && bmp.GetPixel(x, y) != blackColor)
                {
                    bmp.SetPixel(x, y, fillColor);
                    // Обновляем PictureBox после каждого изменения пикселя
                    pictureBox.Refresh();
                    // Задержка на 1 миллисекунд для создания эффекта анимации
                    Thread.Sleep(1);
                    // Добавляем соседние точки в стек
                    stack.Push(new Point(x + 1, y));
                    stack.Push(new Point(x - 1, y));
                    stack.Push(new Point(x, y + 1));
                    stack.Push(new Point(x, y - 1));
                }
            }
        }

        // Реализация задачи о принадлежности точки многоугольнику 
        bool IsPointInPolygon(PointF[] polygon, PointF point)
        {
            bool isInside = false;
            for (int i = 0, j = polygon.Length - 1; i < polygon.Length; j = i++)
            {
                if (((polygon[i].Y <= point.Y && point.Y < polygon[j].Y) ||
                    (polygon[j].Y <= point.Y && point.Y < polygon[i].Y)) && (polygon[j].Y - polygon[i].Y != 0) &&
                    (point.X > (polygon[j].X - polygon[i].X) * (point.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) + polygon[i].X))
                {
                    isInside = !isInside;
                }
            }
            return isInside;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Открываем окно выбора цвета
                var dlg = new ColorDialog();
                // Проверяем на выбор элемента
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // В соответствие с выбранным цветом закрасим фигуру
                    Color color = dlg.Color;
                    if (comboBox.SelectedText.Length == 0)
                        MessageBox.Show("Необходимо выбрать один из вариантов выбора заливки", "Сообщение", MessageBoxButtons.OK);
                    // Выполнить только в случае, если нажали в пределах фигуры 
                    if (IsPointInPolygon(figurePoints, new PointF(e.X, e.Y)))
                    {
                        if (comboBox.SelectedIndex == (int)Fills.Scanline)
                            ScanlineFill((int)figurePoints[0].X + 4, (int)figurePoints[0].Y - 2, color);

                        if (comboBox.SelectedIndex == (int)Fills.Seed)
                            SeedFill(e.X, e.Y, color);
                    }
                    else
                        MessageBox.Show("Необходимо выбрать область внутри фигуры", "Сообщение", MessageBoxButtons.OK);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            DrawFromScratch(graph);
        }
    }
}