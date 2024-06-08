using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveCircle
{
    [Serializable]
    public class Scene
    {
        public List<Circle> circles {  get; set; }
        public int Points { get; set; }
        public Circle currCircle { get; set; }
        public Random random { get; set; }
        public Scene() {
            this.circles = new List<Circle>();
            this.currCircle = null;
            this.Points = 0;
            this.random = new Random();
        }

        public void AddCircle(Circle circle)
        {
            this.circles.Add(circle);
        }

        public void DrawCircles(Graphics g)
        {
            foreach (Circle c in this.circles)
            {
                if (c.isSaved)
                {
                    c.SaveCircle(g);
                } 
                else if (c.isKilled)
                {
                    c.KillCircle(g);
                }
                else
                {
                    c.DrawCircle(g);
                }
                
            }
        }

        public void UpdateCircle(Point point)
        {
            foreach(Circle c in this.circles)
            {
                if (!c.isKilled && !c.isSaved && c.isOnCircle(point)) {
                    c.isSaved = true;
                    Points += 5;
                    return;
                } 
            }
        }

        public void KillCircle()
        {
            if(circles.Count == 0) {
                return;
            }
            if (currCircle != null)
            {
                circles.Remove(currCircle);
                Points -= 10;
                currCircle = null;
                return;
            }
            Circle circle = circles[random.Next(0, circles.Count)];
            if (!circle.isSaved && !circle.isKilled) {
                circle.isKilled = true;
                currCircle = circle;
                return;
            }

        }

        public bool checkIfGameOver()
        {
            bool flag = true;
            foreach (var circle in circles)
            {
                if ((circle.isKilled && !circle.isSaved) || (!circle.isKilled && !circle.isSaved))
                {
                    flag = false;
                }
            }
            if (flag)
            {
                return true;
                
            }
            return false;
        }


    }
}
