using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePulse
{
    [Serializable]
    public class Scene
    {
        public List<Circle> circles {  get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Scene(int Width, int Height) { 
            this.circles = new List<Circle>();
            this.Width = Width;
            this.Height = Height;
        }

        public void AddCircle(Circle circle)
        {
            circles.Add(circle);    
        }

        public void DrawCricles(Graphics graphics)
        {
            foreach (var circle in this.circles)
            {
                circle.drawCircle(graphics);
            }
        }

        public void PulseCircles()
        {
            foreach (var circle in this.circles)
            {
                circle.PulseCircle();
            }
        }

        public void MoveCircles()
        {
            
            foreach (var circle in this.circles)
            {
                circle.Move(Width, Height);
            }
        }
    }
}
