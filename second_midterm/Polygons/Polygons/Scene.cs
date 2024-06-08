using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    [Serializable]
    public class Scene
    {
        public Polygon currPolygon { get; set; }
        public List<Polygon> currPolygons { get; set; }
        public Color colorPolygon { get; set; } = Color.Blue;
        public Scene() { 
            currPolygon = new Polygon(colorPolygon);
            currPolygons = new List<Polygon>();
        }

        public void addPoint(Point point)
        {
            currPolygon.addPoint(point);
            if (currPolygon.IsCompleted) {
                currPolygons.Add(currPolygon);
                currPolygon = new Polygon(colorPolygon);
            }
        }

        public void Draw(Graphics g)
        {
            currPolygon.Draw(g);
            foreach (var item in currPolygons) { 
                item.Draw(g);
            }
        }

        internal void updateColor(Color color)
        {
            this.colorPolygon = color;
            currPolygon.colorOfPolygon = color;
        }
    }
}
