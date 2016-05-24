using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Mandelbrot
{
    public partial class Mandelbrot : Form
    {
        public Mandelbrot()
        {
            InitializeComponent();
        }

        public static ColorRGB HSL2RGB(double h, double sl, double l)
        {
            double v;
            double r, g, b;

            r = l;   // default to gray
            g = l;
            b = l;
            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);
            if (v > 0)
            {
                double m;
                double sv;
                int sextant;
                double fract, vsf, mid1, mid2;

                m = l + l - v;
                sv = (v - m) / v;
                h *= 6.0;
                sextant = (int)h;
                fract = h - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;
                switch (sextant)
                {
                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;
                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;
                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;
                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;
                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;
                }
            }
            ColorRGB rgb;
            rgb.R = Convert.ToByte(r * 255.0f);
            rgb.G = Convert.ToByte(g * 255.0f);
            rgb.B = Convert.ToByte(b * 255.0f);
            return rgb;
        }


        private Complex Function(Complex z, Complex c)
        {
            return (z * z) + c;
        }

        private bool IsBound(Complex check, int iterations)
        {
            Complex z = new Complex(0.0, 0.0);

            for (int i = 0; i < iterations; i++)
            {
                z = Function(z, check);

                if (z.Magnitude > 2)
                {
                    return false;
                }

            }
            return true;

        }

        private void Render(int iterations)
        {
            Complex check = new Complex(0.0, 0.0);
            Bitmap surface = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(surface);
            Brush brush;
            double zoomLevel = Math.Pow((double) zoomLevelIn.Value, 2.0);
            double xPan = double.Parse(xPanIn.Text);
            double yPan = double.Parse(yPanIn.Text);

            
            for (int i = 0; i < iterations; i++)
            {
                brush = new SolidBrush(HSL2RGB(Convert.ToDouble(i) / iterations, 1, 0.5));
                if (i == iterations - 1)
                {
                    brush = new SolidBrush(Color.Black);
                }
                for (double y = (-2.0 / zoomLevel) + yPan; y < (2.0 / zoomLevel) + yPan; y += 0.01 / zoomLevel)
                {
                    for (double x = (-2.0 / zoomLevel) + xPan; x < (2.0 / zoomLevel) + xPan; x += 0.01 / zoomLevel)
                    {
                        check = new Complex(x, y);
                        if (IsBound(check, i))
                        {
                            g.FillRectangle(brush, Convert.ToSingle((x * (100 * zoomLevel)) + 200 - (100 * xPan * zoomLevel)), Convert.ToSingle((y * (100 * zoomLevel)) + 200 - (100 * yPan * zoomLevel)), 1, 1);
                            //Console.WriteLine(check.ToString() + " bounds");
                        }
                        else
                        {
                            //Console.WriteLine(check.ToString() + " doesn't bound");
                        }
                    }
                }

            }
                



            pictureBox1.Image = surface;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();

            Render(int.Parse(Iterations.Text));
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void button1_Click(object sender, EventArgs e)
        {
            Render(int.Parse(Iterations.Text));
        }

        private void Iterations_Enter(object sender, EventArgs e)
        {
            Render(int.Parse(Iterations.Text));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
