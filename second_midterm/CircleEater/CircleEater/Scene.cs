using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEater
{
    [Serializable]
    public class Scene
    {
        public List<RedCircle> redCircles {  get; set; }
        public BlackCircle blackCircle { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public Scene(int width, int height) {
            this.width = width;
            this.height = height;
            redCircles = new List<RedCircle>();
            blackCircle = new BlackCircle();
        }

        public void AddRedCircle(RedCircle redCircle)
        {
            redCircles.Add(redCircle);
        }

        public void DrawCircles(Graphics g)
        {
            foreach (var item in redCircles)
            {
                item.DrawRedCircle(g);
            }
        }

        public void MoveCircles()
        {
            foreach (RedCircle item in redCircles)
            {
                if (item.direction == 0)
                {
                    if (item.center.X - 15 >= 0)
                    {
                        item.center = new Point(item.center.X - 15, item.center.Y);
                    } else
                    {
                        item.direction = 1;
                    }
                }
                else if (item.direction == 1)
                {
                    if (item.center.X + 15 <= width) {
                        item.center = new Point(item.center.X + 15, item.center.Y);
                    } else
                    {
                        item.direction = 0;
                    }
                } 
                else if (item.direction == 2)
                {
                    if(item.center.Y - 15 > 0)
                    {
                        item.center = new Point(item.center.X, item.center.Y - 15);
                    } else
                    {
                        item.direction = 3;
                    }
                }
                else if (item.direction == 3)
                {
                    if (item.center.Y + 15 <= height)
                    {
                        item.center = new Point(item.center.X, item.center.Y + 15);
                    }
                    else
                    {
                        item.direction = 2;
                    }
                }
            }
        }

        public void isNear()
        {
            foreach (var item in redCircles)
            {
                int distance = (int)Math.Sqrt(Math.Pow(item.center.X - blackCircle.center.X, 2) + Math.Pow(item.center.Y -  blackCircle.center.Y, 2));
                if (distance <= 15)
                {
                    blackCircle.update(5);
                    if (blackCircle.radius > 70) { blackCircle.isBig = true; }
                    item.isEaten = true;
                }
            }
            for (int i = redCircles.Count-1; i >= 0; i--)
            {
                if (redCircles[i].isEaten)
                {
                    redCircles.RemoveAt(i);
                }
            }
        }
    }
}
