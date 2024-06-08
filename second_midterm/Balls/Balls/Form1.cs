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

namespace Balls
{
    [Serializable]
    public partial class Form1 : Form
    {
        Scene scene {  get; set; }
        Random random {  get; set; }
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.scene = new Scene(this.Width, this.Height);
            this.random = new Random();
            timer1.Interval = 50;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawBalls(e.Graphics);
            toolStripStatusLabel1.Text = $"Balls: {scene.balls.Count}";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                scene.AddBall(new Ball(e.Location, 30, Color.Red));
                Invalidate();
            }
            else
            {
                foreach (var item in scene.balls)
                {
                    foreach (var item1 in scene.balls)
                    {
                        if (item1.isMoving == true && item1.color == Color.Red)
                        {
                            return;
                        }
                    }

                    if (item.isOnTop(e.Location) && item.isMoving == false)
                    {
                        
                        int direction = random.Next(0, 4);
                        item.setDirection(direction);
                        item.isMoving = true;
                        
                        return;
                    }
                }
            }
            toolStripStatusLabel1.Text = $"Balls: {scene.balls.Count}";
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int color = random.Next(0, 2);
            if(e.Button == MouseButtons.Left)
            {
                if (color == 1)
                {
                    scene.AddBall(new Ball(e.Location, 30, Color.Blue));
                    Invalidate();
                } else
                {
                    scene.AddBall(new Ball(e.Location, 30, Color.Green));
                    Invalidate();
                }
            }
            toolStripStatusLabel1.Text = $"Balls: {scene.balls.Count}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (var item in scene.balls)
            {
                if (item.isMoving)
                {
                    if(item.color == Color.Red && flag)
                    {   
                        item.Move();
                        flag = false;
                        Invalidate();
                    } else if (item.color != Color.Red)
                    {
                        item.Move();
                        Invalidate();
                    }
                }
                foreach (var item1 in scene.balls)
                {
                    scene.isTouched(item, item1);
                }
            }
            foreach(var item in scene.balls)
            {
                if (item.toRemove && item.color == Color.Red)
                {
                    flag = true;
                    break; 
                }
            }
            scene.balls.RemoveAll(b => b.toRemove);
            Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, scene);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    scene = formatter.Deserialize(fs) as Scene;
                    Invalidate();
                }
            }
        }
    }
}
