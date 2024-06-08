using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ColorRectangles
{
    [Serializable]
    public class Rectangle
    {
        public Point point {  get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool isSelected { get; set; }
        public bool isDone { get; set; }
        public Color color { get; set; }

        public Rectangle(Point point, int width, int height, Color color)
        {
            this.point = point;
            this.width = width;
            this.height = height;
            this.isSelected = false;
            this.isDone = false;
            this.color = color;
        }

        public void DrawRectangle(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            if (isSelected)
            {
                Pen pen = new Pen(Color.Red, 2);   
                g.DrawRectangle(pen, point.X, point.Y, width, height);
                pen.Dispose();
            }
            g.FillRectangle(brush, point.X, point.Y, width, height);
            brush.Dispose();
        }

        public void check(Point point)
        {
            if (point.X >= this.point.X && point.X <= this.point.X + width && point.Y >= this.point.Y && point.Y <= this.point.Y + height)
            {
                if (!isSelected)
                {
                    isSelected = true;
                } else
                {
                    isSelected = false;
                }
            }
        }
    }
}
