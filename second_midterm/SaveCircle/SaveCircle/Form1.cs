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

namespace SaveCircle
{
    [Serializable]
    public partial class Form1 : Form
    {
        Scene scene {  get; set; }
        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
            scene = new Scene();
            timer1.Interval = 1000;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawCircles(e.Graphics);
            UpdateStatusBar();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && startToolStripMenuItem.Text == "Start"){
                Circle circle = new Circle(e.Location);
                scene.AddCircle(circle);
                Invalidate();
            }
            else if(e.Button == MouseButtons.Left && startToolStripMenuItem.Text == "Stop")
            {
                scene.UpdateCircle(e.Location);
                Invalidate();
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text == "Start")
            {
                startToolStripMenuItem.Text = "Stop";
                timer1.Start();
            } else
            {
                startToolStripMenuItem.Text = "Start";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateStatusBar();
            scene.KillCircle();
            Invalidate();

            if (scene.checkIfGameOver())
            {
                timer1.Stop();
                if(MessageBox.Show("Game over", "Want to start over?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scene = new Scene();
                    startToolStripMenuItem.Text = "Start";
                    Invalidate();

                } else
                {
                    this.Close();
                }
            }
        }

        public void UpdateStatusBar() {
            toolStripStatusLabel1.Text = $"Points: {scene.Points}";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            startToolStripMenuItem.Text = "Start";
            Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               using(FileStream fs = new FileStream(dialog.FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    scene = formatter.Deserialize(fs) as Scene;
                    Invalidate();
                }
                
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(dialog.FileName, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, scene);
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(startToolStripMenuItem.Text == "Stop")
            {
                timer1.Stop();
                startToolStripMenuItem.Text = "Start";
            }
        }
    }
}
