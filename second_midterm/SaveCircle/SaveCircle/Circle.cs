using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveCircle
{
    [Serializable]
    public class Circle
    {
        public Point center {  get; set; }
        public bool isSaved { get; set; } = false;
        public bool isKilled { get; set; } = false;
        public Circle(Point center) {
            this.center = center;
        }

        public void DrawCircle (Graphics g)
        {
            Brush brush =  new SolidBrush(Color.Red);
            g.FillEllipse(brush, center.X - 25, center.Y - 25, 50, 50);
            brush.Dispose();
        }

        public void SaveCircle (Graphics g)
        {
            Pen pen = new Pen(Color.Yellow, 2);
            DrawCircle(g);
            g.DrawEllipse(pen, center.X - 25, center.Y - 25, 50, 50);
            pen.Dispose();
        }

        public void KillCircle (Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            DrawCircle(g);
            g.DrawEllipse(pen, center.X - 25, center.Y - 25, 50, 50);
            pen.Dispose();
        }

        public bool isOnCircle(Point point)
        {
            if (isSaved == false)
            {
                int distance = (int)Math.Sqrt(Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2));
                if (distance <= 25)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
