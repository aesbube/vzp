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

namespace Polygons
{
    public partial class Form1 : Form
    {
        Scene scene;
        int X;
        int Y;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            this.Text = "Draw Polygons - Untitled*";
            this.DoubleBuffered = true;
            this.X = 0;
            this.Y = 0;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.addPoint(e.Location);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scene.currPolygon.Cursor = e.Location;
            X = e.X; Y = e.Y;
            updateStatus();
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) {
                scene.currPolygon.MoveLeft();
                scene.currPolygons.ForEach(i => i.MoveLeft());
            } else if (e.KeyCode == Keys.Right)
            {
                scene.currPolygon.MoveRight();
                scene.currPolygons.ForEach(i => i.MoveRight());
            } else if ((e.KeyCode == Keys.Up)) {
                scene.currPolygon.MoveUp();
                scene.currPolygons.ForEach(i => i.MoveUp());
            } else
            {
                scene.currPolygon.MoveDown();
                scene.currPolygons.ForEach(i => i.MoveDown());
            }
            Invalidate();
        }

        void SaveToFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, scene);
            fs.Close();
        }

        void LoadFromFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = formatter.Deserialize(fs) as Scene;
            fs.Close();
        }

        void FileNew()
        {
            scene = new Scene();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK) 
            { 
                SaveToFile(saveFileDialog.FileName);
                ChangeName(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadFromFile(openFileDialog.FileName);  
                ChangeName(openFileDialog.FileName);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(saveFileDialog.FileName);
                ChangeName(saveFileDialog.FileName);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadFromFile(openFileDialog.FileName);
                ChangeName(openFileDialog.FileName);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            FileNew();
            ChangeName("Untitled*");
        }

        private void ChangeName(string name)
        {
            this.Text = $"Draw Polygons - {name}";
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                scene.updateColor(colorDialog.Color);
            }
        }
        
        private void updateStatus()
        {
            int number = scene.currPolygons.Count;
            this.status.Text = $"# Polygons: {number} {X}, {Y}";
        }
    }
}
