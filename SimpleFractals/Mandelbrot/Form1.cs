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
            Brush brush = (Brush)Brushes.Black;

            for (int y = 0; y < 400; y++)
            {
                for (int x = 0; x < 400; x++)
                {
                    check = new Complex((Convert.ToDouble(x) / 100 - 2), (Convert.ToDouble(y) / 100 - 2));
                    if (IsBound(check, iterations))
                    {
                        g.FillRectangle(brush, x, y, 1, 1);
                        //Console.WriteLine(check.ToString() + " bounds");
                    }
                    else
                    {
                        //Console.WriteLine(check.ToString() + " doesn't bound");
                    }
                }
            }



            pictureBox1.Image = surface;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();


            /*
            Complex check = new Complex(0.0, 0.0);
            Bitmap surface = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(surface);
            Brush brush = (Brush)Brushes.Black;
            int iterations = 100;

            for (int y = 0; y < 400; y++)
            {
                for (int x = 0; x < 400; x++)
                {
                    check = new Complex((Convert.ToDouble(x) / 100 - 2), (Convert.ToDouble(y) / 100 - 2));
                    if (IsBound(check, iterations))
                    {
                        g.FillRectangle(brush, x, y, 1, 1);
                        //Console.WriteLine(check.ToString() + " bounds");
                    }
                    else
                    {
                        //Console.WriteLine(check.ToString() + " doesn't bound");
                    }
                }
            }
            


            pictureBox1.Image = surface;
            */
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
    }
}
