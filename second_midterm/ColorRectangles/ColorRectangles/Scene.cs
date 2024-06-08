using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ColorRectangles
{
    [Serializable]
    public class Scene
    {
        public List<Rectangle> rectangles {  get; set; }
        public List<Rectangle> pom {  get; set; }
        public Point point_1 { get; set; }
        public Point point_2 { get; set; }
        public Scene() { 
            this.rectangles = new List<Rectangle>();
            this.pom = new List<Rectangle>();
            this.point_1 = Point.Empty;
            this.point_2 = Point.Empty; 
        }

        public void AddRectangle(Rectangle rectangle)
        {
            this.rectangles.Add(rectangle);
        }

        public void DrawRectangles(Graphics g)
        {
            foreach (Rectangle rectangle in this.rectangles)
            {
                rectangle.DrawRectangle(g);
            }
            foreach (Rectangle rectangle in this.pom)
            {
                TraceRectange(g);
            }
        }

        public void TraceRectange(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            int x = Math.Min(point_1.X, point_2.X);
            int y = Math.Min(point_1.Y, point_2.Y);
            g.DrawRectangle(pen, x, y, Math.Abs(point_2.X - point_1.X), Math.Abs(point_2.Y - point_1.Y));
            pen.Dispose();
        }
    }
}
