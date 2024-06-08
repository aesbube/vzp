using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balls
{
    [Serializable]
    public class Scene
    {
        public List<Ball> balls {  get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Scene(int width, int height) { 
            this.balls = new List<Ball>();
            this.width = width;
            this.height = height;
        }

        public void AddBall(Ball b) { 
            balls.Add(b);
        }

        public void DrawBalls(Graphics g)
        {
            foreach (Ball b in balls)
            {
                b.DrawCircle(g);
            }
        }

        public void isTouched(Ball ball1, Ball ball2)
        {
            if (ball1.isOnTop(ball2.center) && ball1.color == Color.Red && ball2.color == Color.Green)
            {
                ball2.toRemove = true;
            } else if (ball2.isOnTop(ball1.center) && ball2.color == Color.Red && ball1.color == Color.Green)
            {
                ball1.toRemove = true;
            }else if (ball1.center.X < 0 || ball1.center.X > width || ball1.center.Y < 0 || ball1.center.Y > height)
            {
                ball1.toRemove = true;
            } else if (ball2.center.X < 0 || ball2.center.X > width || ball2.center.Y < 0 || ball2.center.Y > height)
            {
                ball2.toRemove = true;
            } else
            {
                return;
            }
        }


    }
}
