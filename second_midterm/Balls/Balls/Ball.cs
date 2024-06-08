using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balls
{
    [Serializable]
    public class Ball
    {
        public Point center {  get; set; }
        public int radius {  get; set; }    
        public Color color { get; set; }
        public int direction { get; set; }
        public bool isMoving { get; set; }
        public bool toRemove { get; set; }
        public Ball(Point center, int radius, Color color) {
            this.center = center;
            this.radius = radius;
            this.color = color;
            this.direction = 0;
            this.isMoving = false;
            this.toRemove = false;
        }
        
        public void setDirection(int direction)
        {
            this.direction = direction;
        }

        public void DrawCircle(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, center.X - radius, center.Y - radius, radius * 2, radius * 2);
            brush.Dispose();
        }

        public void Move()
        {
            if (direction == 0)
            {
                this.center = new Point(center.X + 10, center.Y);
            } else if (direction == 1)
            {
                this.center = new Point(center.X - 10, center.Y);
            } else if (direction == 2)
            {
                this.center = new Point(center.X, center.Y + 10);
            } else
            {
                this.center = new Point(center.X, center.Y - 10);
            }
        }

        public bool isOnTop(Point point)
        {
            int distance = (int)Math.Sqrt(Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2));
            if (distance <= radius)
            {
                return true;
            }
            return false;
        }

        
    }
}
