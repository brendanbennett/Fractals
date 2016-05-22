using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFractals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PointF DrawDynamicLine(Graphics g, Pen pen, PointF point1, double angle, float length, bool Visible)
        {
            double angleRad = (angle - 90) * (Math.PI / 180);
            PointF point2 = new PointF(Convert.ToSingle(point1.X + Math.Cos(angleRad) * length), Convert.ToSingle(point1.Y + Math.Sin(angleRad) * length));

            if (Visible)
            {
                g.DrawLine(pen, point1, point2);
            }
            
            return point2;
        }

        private PointF[] DrawPoly(Graphics g, Pen pen, PointF start, double angleOffset, float sideLength, int numberOfSides, bool Visible)
        {
            PointF point = start;
            PointF[] points = new PointF[numberOfSides];


            for (int i = 0; i < numberOfSides; i++)
            {
                if (Visible)
                {
                    point = DrawDynamicLine(g, pen, point, 90 + angleOffset - ((360 / numberOfSides)*i), sideLength, true);
                }
                else
                {
                    point = DrawDynamicLine(g, pen, point, 90 + angleOffset - ((360 / numberOfSides) * i), sideLength, false);
                }
                points[i] = point;
            }
            return points;
        }

        private PointF[] DrawInTriangle(Graphics g, Pen pen, PointF start, float sideLength, bool Visible)
        {
            PointF[] points;
            if (Visible)
            {
                points = DrawPoly(g, pen, start, 0, sideLength / 2, 3, true);

                DrawPoly(g, pen, points[0], 0, sideLength / 2, 3, true);
                DrawPoly(g, pen, points[1], 0, sideLength / 2, 3, true);
            }
            else
            {
                points = DrawPoly(g, pen, start, 0, sideLength / 2, 3, false);
            }
            return points;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.Red, 1);
            PointF start = new PointF(50,200);
            PointF[] starts;
            /*
            for (int i = 100; i > 0; i -= 5)
            {
                start = DrawDynamicLine(g, pen, start, i*5, i);
            }
            */

            starts = DrawInTriangle(g, pen, start, 200, false);

            for (int j = 2; j < 10; j*=2)
            {
                for (int i = 0; i < 3; i++)
                {
                    DrawInTriangle(g, pen, starts[i], 200/j, true);
                }
            }
                
        }

    }
}
