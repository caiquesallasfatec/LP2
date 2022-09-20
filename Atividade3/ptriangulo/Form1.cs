using System.Drawing;
using System.Drawing.Drawing2D;

namespace ptriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            draw(5, 16, 20);
        }

        private void draw(int L1, int L2, int L3)
        {            
            int a, b, c;

            int[] inputs = { L1, L2, L3 };

            Array.Sort(inputs);

            MessageBox.Show(inputs[0].ToString() + inputs[1].ToString() + inputs[2].ToString());

            a = inputs[0];
            b = inputs[1];
            c = inputs[2];                        

            if (a == b)
            {
                drawIsoscelesTriangle(a, c);
            } else if (b == c)
            {
                drawIsoscelesTriangle(b, a);
            } else
            {
                drawScalanoTriangle(a, b, c);
            }
            // MessageBox.Show(ponto1.ToString() + ponto2.ToString() + ponto3.ToString());            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            draw(5, 16, 20);
        }

        private bool isTriangule(int a, int b, int c)
        {
            int[] inputs = { a, b, c };

            int aux = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (Math.Abs(inputs[0] - inputs[1]) > inputs[2] || (inputs[0] + inputs[1]) < inputs[2] )
                {
                    return false;
                }

                aux = inputs[0];

                inputs[0] = inputs[1];
                inputs[1] = inputs[2];
                inputs[2] = aux;
            }

            return true;
        }

        private void drawIsoscelesTriangle(int a, int b)
        {
            Graphics g = CreateGraphics();

            Point ponto1;
            Point ponto2;
            Point ponto3;
            Point[] point = { };
            int y, height, width, downLine, sideHeight;

            y = a * 2 + b;
            height = 270;
            width = 568;
            downLine = 500 * b / y;
            sideHeight = getHeightFromTriangleRectangle(500 * a / y, downLine / 2);

            ponto1 = new Point(width, height);
            ponto2 = new Point(width + downLine / 2, height - sideHeight);
            ponto3 = new Point(width + downLine, height);

            point = new Point[] { ponto1, ponto2, ponto3 };

            g.FillPolygon(Brushes.Black, point);
        }

        private void drawScalanoTriangle(int min, int med, int max)
        {
            Graphics g = CreateGraphics();

            Point ponto1;
            Point ponto2;
            Point ponto3;
            Point[] point = { };
            int y, height, width, downLine, minWidth, sideHeight;

            y = min + med + max;

            height = 270;
            width = 568;

            downLine = 500 * max / y;

            minWidth = min * downLine / (min + med);

            sideHeight = getHeightFromTriangleRectangle(500 * min / y, minWidth);

            ponto1 = new Point(width, height);
            ponto2 = new Point(width + minWidth, height - sideHeight);
            ponto3 = new Point(width + downLine, height);

            point = new Point[] { ponto1, ponto2, ponto3 };

            g.FillPolygon(Brushes.Black, point);
        }

        private int getHeightFromTriangleRectangle(int hypotenuse, int side)
        {
            return (int) Math.Round(Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(side, 2)));
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            draw(9, 9, 9);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}