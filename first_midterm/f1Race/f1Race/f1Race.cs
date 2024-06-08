using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f1Race
{
    public partial class f1Race : Form
    {
        public f1Race()
        {
            InitializeComponent();
        }


        private void nud_seconds_ValueChanged(object sender, EventArgs e)
        {
            if (nud_seconds.Value == 60) {
                nud_seconds.Value = 0;
                nud_minutes.Value += 1;
            }

            if (nud_seconds.Value == -1 && nud_minutes.Value > 0)
            {
                nud_seconds.Value = 59;
                nud_minutes.Value -= 1;
            }
            if (nud_seconds.Value == -1 )
            {
                nud_seconds.Value = 0;
            }

        }

        private void btn_add_driver_Click(object sender, EventArgs e)
        {
            AddDriver addNewDriver = new AddDriver();
            if (addNewDriver.ShowDialog() == DialogResult.OK)
            {
                listBox_drivers.Items.Add(addNewDriver.driver);
            }
        }

        private void btn_delete_driver_Click(object sender, EventArgs e)
        {
            if (listBox_drivers.SelectedIndex != -1)
            {
                Driver driverToRemove = listBox_drivers.SelectedItem as Driver;
                DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    listBox_drivers.Items.RemoveAt(listBox_drivers.SelectedIndex);
                    
                } else
                {
                    return;
                }
            }
        }

        private void btn_add_lap_Click(object sender, EventArgs e)
        {
            if (listBox_drivers.SelectedIndex != -1)
            {
                Lap lap = new Lap((int)nud_minutes.Value, (int)nud_seconds.Value);
                Driver driver = listBox_drivers.SelectedItem as Driver;
                driver.laps.Add(lap);
                listBox_laps.Items.Add(lap);
                nud_minutes.Value = 0;
                nud_seconds.Value = 0;
                Update();
            } else
            {
                return;
            }
        }

        private void listBox_drivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_laps.Items.Clear();
            Driver driver = listBox_drivers.SelectedItem as Driver;
            if (listBox_drivers.SelectedIndex != -1) {
                Update();
                foreach (Lap lap in driver.laps)
                {
                    listBox_laps.Items.Add(lap);
                }
            }
        }

        private void Update()
        {
            tb_best_lap.Clear();
            Driver driver = listBox_drivers.SelectedItem as Driver;
            if (driver != null && driver.laps.Count > 0) {
                tb_best_lap.Text = driver.bestLap().ToString();
            }
        }

        private void num_time_ValueChanged(object sender, EventArgs e)
        {
            listBox_laps.Items.Clear();
            Driver driver = listBox_drivers.SelectedItem as Driver;
            if (listBox_drivers.SelectedIndex != -1)
            {
                Update();
                foreach (Lap lap in driver.laps)
                {
                    int secs = lap.Minutes * 60 + lap.Second;
                    if (secs > num_time.Value)
                    {
                        listBox_laps.Items.Add(lap);
                    }
                }
            }
        }
    }
}
