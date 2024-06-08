using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePulse
{
    [Serializable]
    public class Circle
    {
        public Point center {  get; set; }
        public int radius {  get; set; }
        public Color color { get; set; }
        public bool flagPulse {  get; set; }
        public int direction { get; set; }

        public Circle(Point center, int radius, Color color, bool flagPulse)
        {
            this.center = center;
            this.radius = radius;
            this.color = color;
            this.flagPulse = flagPulse;
            this.direction = 0;
        }

        public void setDirection(int direction)
        {
            this.direction = direction;
        }

        public void drawCircle(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, center.X - radius, center.Y - radius, radius*2, radius*2);
            brush.Dispose();
        }

        public void PulseCircle()
        {
            if (!flagPulse)
            {
                if (radius - 5 <= 0)
                {
                    radius = 5;
                    flagPulse = true;
                    return;
                }
                radius -= 5;
            }
            else
            {
                if (radius + 5 > 100)
                {
                    radius = 100;
                    flagPulse = false;
                    return;
                }
                radius += 5;
            }
        }

        public void Move(int Width, int Height)
        {
            if(direction == 0)
            {
                if(center.X + 5 <= Width)
                { 
                    this.center = new Point(center.X + 5, center.Y); 
                } else
                {
                    direction = 1;
                }
            } else if (direction == 1)
            {
                if (center.X - 5 >= 0)
                {
                    this.center = new Point(center.X - 5, center.Y);
                }
                else
                {
                    direction = 0;
                }
            } else if (direction == 2)
            {
                if (center.Y + 5 <= Height)
                {
                    this.center = new Point(center.X, center.Y + 5);
                }
                else
                {
                    direction = 3;
                }
            } else
            {
                if (center.Y - 5 >= 0)
                {
                    this.center = new Point(center.X, center.Y - 5);
                }
                else
                {
                    direction = 2;
                }
            }
        }

    }
}
