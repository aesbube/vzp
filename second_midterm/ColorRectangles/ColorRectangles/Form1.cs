using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorRectangles
{
    [Serializable]
    public partial class Form1 : Form
    {
        Scene scene {  get; set; }
        public Point currPoint { get; set; }
        public Rectangle currRectangle { get; set; }
        Color color { get; set; }
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            scene = new Scene();
            this.currPoint = Point.Empty;
            this.currRectangle = null;
            this.color = Color.Blue;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawRectangles(e.Graphics);
            toolStripStatusLabel1.Text = $"Rectangles: {scene.rectangles.Count}";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (currPoint.IsEmpty && e.Button == MouseButtons.Left)
            {
                currPoint = e.Location;
            } else if (e.Button == MouseButtons.Left)
            {
                scene.pom.Clear();
                int x = Math.Min(currPoint.X, e.X);
                int y = Math.Min(currPoint.Y, e.Y);
                currRectangle = new Rectangle(new Point(x, y), Math.Abs(e.Location.X - currPoint.X), Math.Abs(e.Location.Y - currPoint.Y), color);
                currRectangle.isDone = true;
                scene.AddRectangle(currRectangle);
                currPoint = Point.Empty;
                currRectangle = null;
                scene.point_1 = Point.Empty;
                scene.point_2 = Point.Empty;
                Invalidate();
            } 
            if (e.Button == MouseButtons.Right)
            {
                foreach (var item in scene.rectangles)
                {
                    item.check(e.Location);
                    Invalidate();
                }
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!currPoint.IsEmpty) {
                int x = Math.Min(currPoint.X, e.X);
                int y = Math.Min(currPoint.Y, e.Y);
                currRectangle = new Rectangle(new Point(x, y), Math.Abs(e.Location.X - currPoint.X), Math.Abs(e.Location.Y - currPoint.Y), color);
                scene.pom.Add(currRectangle);
                scene.point_1 = currPoint;
                scene.point_2 = e.Location;
                Invalidate();
            }

            toolStripStatusLabel1.Text = $"Rectangles: {scene.rectangles.Count}";
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                this.color = dlg.Color;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                for (int i = scene.rectangles.Count - 1;  i >= 0; i--) 
                {
                    if (scene.rectangles[i].isSelected)
                    {
                        scene.rectangles.RemoveAt(i);
                    }
                }
                Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
                Invalidate();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                scene = formatter.Deserialize(fs) as Scene;
            }
        }
    }
}
