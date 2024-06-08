using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    [Serializable]
    public class Polygon
    {
        public List<Point> points { get; set; }

        public bool IsCompleted { get; set; } = false;

        public Point Cursor {  get; set; }

        public Color colorOfPolygon { get; set; }


        public Polygon(Color color) { 
            points = new List<Point>();
            this.colorOfPolygon = color;
        }

        public void addPoint(Point point) {
            if (isNearStart()) {
                points.Add(points[0]);
                IsCompleted = true;
            }
            else
            {
                points.Add(point);
            }
        }

        public bool isNearStart() {
            if (points.Count >= 3)
            {
                return Math.Sqrt(Math.Pow(points[0].X - Cursor.X, 2) + Math.Pow(points[0].Y - Cursor.Y, 2)) < 10;
            } else
            {
                return false;
            }
        }

        public void Draw(Graphics g)
        {
            if (points.Count >= 1)    
            {   
                Pen pen = new Pen(Color.Black, 2);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(pen, points.ToArray().Last(), Cursor);
                pen.Dispose();
                if (points.Count >= 2)
                {
                    pen = new Pen(Color.Black, 2);
                    g.DrawLines(pen, points.ToArray());
                    //g.DrawPolygon(pen, points.ToArray());
                    pen.Dispose();

                    if (isNearStart() && !IsCompleted)
                    {
                        pen = new Pen(Color.Black, 2);
                        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        g.DrawRectangle(pen, points[0].X - 5, points[0].Y - 5, 10, 10);
                        pen.Dispose();
                    }
                }
            }
            if (IsCompleted)
            {
                Brush brush = new SolidBrush(colorOfPolygon);
                g.FillPolygon(brush, points.ToArray());
                brush.Dispose();
            }
           
        }

        internal void MoveLeft()
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X - 5, points[i].Y);
            }
        }

        internal void MoveRight()
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X + 5, points[i].Y);
            }
        }

        internal void MoveUp()
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X, points[i].Y - 5);
            }
        }

        internal void MoveDown()
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X, points[i].Y + 5);
            }
        }
    }
}
