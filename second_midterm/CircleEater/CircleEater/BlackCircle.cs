using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEater
{
    [Serializable]
    public class BlackCircle
    {
        public int radius { set; get; } = 25;
        public Point center { set; get; }
        public bool isBig { set; get; }
        public BlackCircle()
        {
            isBig = false;
        }
        public BlackCircle(Point center)
        {
            this.center = center;
        }

        public void update(int radius)
        {
            this.radius += radius;
        }

        public void DrawBlackCircle(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Black);
            g.FillEllipse(brush, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
        }
    }
}
