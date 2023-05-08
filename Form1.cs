using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineDrawing
{
    public partial class Form1 : Form
    {
        private int CANVAS_WIDTH;
        private int CANVAS_HEIGHT;
        private Color color = Color.Red;
        public Form1()
        {
            InitializeComponent();
            this.lbl_height.Text = canvas.Height.ToString();
            this.lbl_width.Text = canvas.Width.ToString();
            this.CANVAS_WIDTH = canvas.Width;
            this.CANVAS_HEIGHT = canvas.Height;
        }

        private void btn_dda_Click(object sender, EventArgs e)
        {
            Point start = new Point(int.Parse(txt_start_x.Text), int.Parse(txt_start_y.Text));
            Point end = new Point(int.Parse(txt_end_x.Text), int.Parse(txt_end_y.Text));
            Bitmap bitmap = new Bitmap(this.CANVAS_WIDTH, this.CANVAS_HEIGHT);
            draw_line_dda(ref bitmap, start, end);
            this.canvas.Image = bitmap;
        }

        private void draw_line_dda(ref Bitmap bitmap, Point starting_point, Point ending_point)
        {
            int dx = Math.Abs(starting_point.X - ending_point.X);
            int dy = Math.Abs(starting_point.Y - ending_point.Y);
            int steps = (dx >= dy) ? dx : dy;
            float x_increment = dx / (float)steps;
            float y_increment = dy / (float)steps;

            PointF iPoint = new PointF();
            iPoint.X = (starting_point.X <= ending_point.X) ? starting_point.X : ending_point.X;
            iPoint.Y = (starting_point.Y <= ending_point.Y) ? starting_point.Y : ending_point.Y;

            for (int i = 0; i < steps; i++)
            {
                bitmap.SetPixel((int)Math.Ceiling(iPoint.X), (int)Math.Ceiling(iPoint.Y), Color.Red);
                iPoint.X += x_increment;
                iPoint.Y += y_increment;
            }
        }

        private void draw_line_bresenham(ref Bitmap bitmap, Point starting_point, Point ending_point)
        {
            int dx = Math.Abs(starting_point.X - ending_point.X);
            int dy = Math.Abs(starting_point.Y - ending_point.Y);
            
            Point iPoint = new Point();
            iPoint.X = (starting_point.X <= ending_point.X) ? starting_point.X : ending_point.X;
            iPoint.Y = (starting_point.Y <= ending_point.Y) ? starting_point.Y : ending_point.Y;

            int p;
            if (dx > dy) {
                p = 2 * dy - dx;
                for (int i = 0; i < dx; i++)
                {
                    bitmap.SetPixel(iPoint.X, iPoint.Y, Color.Black);
                    if (p < 0)
                    {
                        p += 2 * dy;
                    } else
                    {
                        iPoint.Y++;
                        p += 2 * dy - 2 * dx;
                    }
                    iPoint.X++;
                }
            }
            else {
                p = 2 * dx - dy;
                for (int i = 0; i < dy; i++)
                {
                    bitmap.SetPixel(iPoint.X, iPoint.Y, Color.Black);
                    if (p < 0)
                    {
                        p += 2 * dx;
                    }
                    else
                    {
                        iPoint.X++;
                        p += 2 * dx - 2 * dy;
                    }
                    iPoint.Y++;
                }
            }
        }

        private void btn_bresenham_Click(object sender, EventArgs e)
        {
            Point start = new Point(int.Parse(txt_start_x.Text), int.Parse(txt_start_y.Text));
            Point end = new Point(int.Parse(txt_end_x.Text), int.Parse(txt_end_y.Text));
            Bitmap bitmap = new Bitmap(this.CANVAS_WIDTH, this.CANVAS_HEIGHT);
            draw_line_bresenham(ref bitmap, start, end);
            this.canvas.Image = bitmap;
        }
    }
}
