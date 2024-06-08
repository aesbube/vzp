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

namespace CircleEater
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Scene scene {  get; set; }
        public static Random random { get; set; }
        public bool canMakeBlackCircle { get; set; }
        public bool canMoveBlackCircle { get; set; }
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            scene = new Scene(this.Width, this.Height);
            random = new Random();
            canMakeBlackCircle = true;
            canMoveBlackCircle = false;
            timer1.Interval = 1000;
            timer2.Interval = 100;
            timer1.Start();
            timer2.Start();
            for (int i = 0; i < 3; i++)
            {
                RedCircle circle = new RedCircle(new Point(random.Next(30, this.Width - 30), random.Next(30, this.Height - 30)), random.Next(0, 4));
                scene.AddRedCircle(circle);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawCircles(e.Graphics);
            if (scene.blackCircle != null) scene.blackCircle.DrawBlackCircle(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(canMakeBlackCircle)
            { 
                BlackCircle circle = new BlackCircle(new Point(e.X, e.Y));
                scene.blackCircle = circle;
                Invalidate();
                canMakeBlackCircle = false;
                canMoveBlackCircle = true;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMoveBlackCircle && scene.blackCircle !=null)
            {
                scene.blackCircle.center = e.Location;
                scene.isNear();
                if (scene.blackCircle.isBig)
                {
                    scene.blackCircle = null;
                    canMakeBlackCircle = true;
                    canMoveBlackCircle = false;
                }
                Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RedCircle circle = new RedCircle(new Point(random.Next(30, this.Width - 30), random.Next(30, this.Height - 30)), random.Next(0, 4));
            scene.AddRedCircle(circle);
            Invalidate();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            scene.MoveCircles();
            Invalidate();
        }



        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stopToolStripMenuItem.Text == "Stop")
            {
                stopToolStripMenuItem.Text = "Start";
                timer1.Stop();
                timer2.Stop();
                if (canMakeBlackCircle)
                {
                    canMakeBlackCircle = false;
                }
                canMoveBlackCircle = false;
            }
            else
            {
                stopToolStripMenuItem.Text = "Stop";
                timer1.Start();
                timer2.Start();
                if (canMakeBlackCircle == false && scene.blackCircle == null)
                {
                    canMakeBlackCircle = true;
                }
                canMoveBlackCircle = true;
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, scene);
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                scene = formatter.Deserialize(fileStream) as Scene;
                Invalidate();
            }
        }



        
    }
}
