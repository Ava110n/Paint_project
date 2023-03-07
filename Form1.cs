using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Paint_3._0
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        Color New_Color;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 3);
        Pen Eraser = new Pen(Color.White, 10);
        int index;
        int x, y, sx, sy, cx, cy;
        ColorDialog cd = new ColorDialog();
        int test_param;


        public Form1()
        {
            InitializeComponent();
            Rectangle rec = Screen.PrimaryScreen.Bounds;
            bm = new Bitmap(rec.Width, rec.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Pic.Image = bm;
        }

//         private void btneraser_Click(object sender, EventArgs e)
//         {
//             index = 5;
//         }

        private void btnellipse_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btnrect_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnline_Click(object sender, EventArgs e)
        {

        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cx, cy, x, y);
                }
            }

        }

        private void btnfill_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void btnpen_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(Eraser, px, py);
                    py = px;
                }
            }
            Pic.Refresh();

            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

    

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sx = x - cx;
            sy = y - cy;
            if (index == 3)
            {
                g.DrawEllipse(p,cx,cy,sx,sy);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
            if (index == 5)
            {
                g.DrawLine(p, cx,cy,x,y);
            }
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            New_Color = cd.Color;
            Pic.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void Pic_Click(object sender, EventArgs e)
        {

        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cx = e.X;
            cy = e.Y;
        }

        
        static Point set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }
        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color New_Clr)
        {
            Color Old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, New_Clr);
            if (Old_Color == New_Clr) { return; }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_Clr);
                }
            }
        }
        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {

            if (index == 6)
                {   

                    Point point = set_Point(Pic, e.Location);
                    Color Old_color = bm.GetPixel(e.X,e.Y);
                    if (Old_color != New_Color)
                    {
                        Fill(bm, point.X, point.Y, New_Color);
                    }
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
