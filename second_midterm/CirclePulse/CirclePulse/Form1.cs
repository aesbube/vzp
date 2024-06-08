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

namespace CirclePulse
{
    [Serializable]
    public partial class Form1 : Form
    {
        Scene scene {  get; set; }
        Random random {  get; set; }
        Color color { get; set; }
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.scene = new Scene(this.Width, this.Height);
            this.random = new Random();
            timer1.Interval = 100;
            timer2.Interval = 100;
            this.color = Color.Red; 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawCricles(e.Graphics);
            toolStripStatusLabel1.Text = $"Circles: {scene.circles.Count}";
            this.Text = "Pulsing game";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int radius = random.Next(5, 50);
            bool flag = (radius > 25);
            Circle circle = new Circle(e.Location, radius, Color.Red, flag);
            scene.AddCircle(circle);
            Invalidate();
        }

        private void startPulsingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startPulsingToolStripMenuItem.Text == $"Start Pulsing"){
                timer1.Start();
                startPulsingToolStripMenuItem.Text = $"Stop Pulsing";
            } else
            {
                timer1.Stop();
                startPulsingToolStripMenuItem.Text = $"Start Pulsing";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.PulseCircles();
            Invalidate();
        }

        private void startMovingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startMovingToolStripMenuItem.Text == $"Start Moving")
            {
                timer2.Start();
                foreach (var item in scene.circles)
                {
                    int dir = random.Next(0, 4);
                    item.setDirection(dir);
                }
                startMovingToolStripMenuItem.Text = $"Stop Moving";
            }
            else
            {
                timer2.Stop();
                startMovingToolStripMenuItem.Text = $"Start Moving";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            scene.MoveCircles();
            Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startPulsingToolStripMenuItem.Text = $"Start Pulsing";
            timer2.Stop();
            startMovingToolStripMenuItem.Text = $"Start Moving";
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK )
            {
                using(FileStream fs =  new FileStream(dialog.FileName, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    scene = formatter.Deserialize(fs) as Scene;
                    this.Text = dialog.FileName;
                    Invalidate();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(dialog.FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, scene);
                    this.Text = dialog.FileName;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene(Width, Height);
            Invalidate();
        }
    }
}
