using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEater
{
    [Serializable]
    public class RedCircle
    {
        public Point center { get; set; }
        public int direction { get; set; }
        public bool isEaten { get; set; }
        public RedCircle(Point center, int direction) { 
            isEaten = false;
            this.center = center;
            this.direction = direction;
        }

        public void DrawRedCircle(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, center.X - 15, center.Y - 15, 30, 30);
        }
    }
}
