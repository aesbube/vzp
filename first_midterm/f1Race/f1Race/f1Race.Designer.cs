namespace f1Race
{
    partial class f1Race
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_drivers = new System.Windows.Forms.ListBox();
            this.listBox_laps = new System.Windows.Forms.ListBox();
            this.groupBox_drivers = new System.Windows.Forms.GroupBox();
            this.btn_delete_driver = new System.Windows.Forms.Button();
            this.btn_add_driver = new System.Windows.Forms.Button();
            this.groupBox_laps = new System.Windows.Forms.GroupBox();
            this.btn_add_lap = new System.Windows.Forms.Button();
            this.tb_best_lap = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            this.label_best_lap = new System.Windows.Forms.Label();
            this.label_seconds = new System.Windows.Forms.Label();
            this.label_minutes = new System.Windows.Forms.Label();
            this.nud_seconds = new System.Windows.Forms.NumericUpDown();
            this.num_time = new System.Windows.Forms.NumericUpDown();
            this.nud_minutes = new System.Windows.Forms.NumericUpDown();
            this.groupBox_drivers.SuspendLayout();
            this.groupBox_laps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_drivers
            // 
            this.listBox_drivers.FormattingEnabled = true;
            this.listBox_drivers.ItemHeight = 16;
            this.listBox_drivers.Location = new System.Drawing.Point(6, 21);
            this.listBox_drivers.Name = "listBox_drivers";
            this.listBox_drivers.Size = new System.Drawing.Size(364, 324);
            this.listBox_drivers.TabIndex = 0;
            this.listBox_drivers.SelectedIndexChanged += new System.EventHandler(this.listBox_drivers_SelectedIndexChanged);
            // 
            // listBox_laps
            // 
            this.listBox_laps.FormattingEnabled = true;
            this.listBox_laps.ItemHeight = 16;
            this.listBox_laps.Location = new System.Drawing.Point(10, 21);
            this.listBox_laps.Name = "listBox_laps";
            this.listBox_laps.Size = new System.Drawing.Size(364, 276);
            this.listBox_laps.TabIndex = 1;
            // 
            // groupBox_drivers
            // 
            this.groupBox_drivers.Controls.Add(this.btn_delete_driver);
            this.groupBox_drivers.Controls.Add(this.btn_add_driver);
            this.groupBox_drivers.Controls.Add(this.listBox_drivers);
            this.groupBox_drivers.Location = new System.Drawing.Point(23, 12);
            this.groupBox_drivers.Name = "groupBox_drivers";
            this.groupBox_drivers.Size = new System.Drawing.Size(374, 446);
            this.groupBox_drivers.TabIndex = 2;
            this.groupBox_drivers.TabStop = false;
            this.groupBox_drivers.Text = "Drivers";
            // 
            // btn_delete_driver
            // 
            this.btn_delete_driver.Location = new System.Drawing.Point(6, 404);
            this.btn_delete_driver.Name = "btn_delete_driver";
            this.btn_delete_driver.Size = new System.Drawing.Size(362, 30);
            this.btn_delete_driver.TabIndex = 2;
            this.btn_delete_driver.Text = "Delete dirver";
            this.btn_delete_driver.UseVisualStyleBackColor = true;
            this.btn_delete_driver.Click += new System.EventHandler(this.btn_delete_driver_Click);
            // 
            // btn_add_driver
            // 
            this.btn_add_driver.Location = new System.Drawing.Point(6, 360);
            this.btn_add_driver.Name = "btn_add_driver";
            this.btn_add_driver.Size = new System.Drawing.Size(362, 30);
            this.btn_add_driver.TabIndex = 1;
            this.btn_add_driver.Text = "Add driver";
            this.btn_add_driver.UseVisualStyleBackColor = true;
            this.btn_add_driver.Click += new System.EventHandler(this.btn_add_driver_Click);
            // 
            // groupBox_laps
            // 
            this.groupBox_laps.Controls.Add(this.btn_add_lap);
            this.groupBox_laps.Controls.Add(this.tb_best_lap);
            this.groupBox_laps.Controls.Add(this.label_time);
            this.groupBox_laps.Controls.Add(this.label_best_lap);
            this.groupBox_laps.Controls.Add(this.label_seconds);
            this.groupBox_laps.Controls.Add(this.label_minutes);
            this.groupBox_laps.Controls.Add(this.nud_seconds);
            this.groupBox_laps.Controls.Add(this.num_time);
            this.groupBox_laps.Controls.Add(this.nud_minutes);
            this.groupBox_laps.Controls.Add(this.listBox_laps);
            this.groupBox_laps.Location = new System.Drawing.Point(414, 12);
            this.groupBox_laps.Name = "groupBox_laps";
            this.groupBox_laps.Size = new System.Drawing.Size(374, 446);
            this.groupBox_laps.TabIndex = 3;
            this.groupBox_laps.TabStop = false;
            this.groupBox_laps.Text = "Laps";
            // 
            // btn_add_lap
            // 
            this.btn_add_lap.Location = new System.Drawing.Point(258, 316);
            this.btn_add_lap.Name = "btn_add_lap";
            this.btn_add_lap.Size = new System.Drawing.Size(116, 30);
            this.btn_add_lap.TabIndex = 3;
            this.btn_add_lap.Text = "Add lap";
            this.btn_add_lap.UseVisualStyleBackColor = true;
            this.btn_add_lap.Click += new System.EventHandler(this.btn_add_lap_Click);
            // 
            // tb_best_lap
            // 
            this.tb_best_lap.Location = new System.Drawing.Point(10, 360);
            this.tb_best_lap.Name = "tb_best_lap";
            this.tb_best_lap.Size = new System.Drawing.Size(364, 22);
            this.tb_best_lap.TabIndex = 9;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(7, 385);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(38, 16);
            this.label_time.TabIndex = 8;
            this.label_time.Text = "Time";
            // 
            // label_best_lap
            // 
            this.label_best_lap.AutoSize = true;
            this.label_best_lap.Location = new System.Drawing.Point(7, 341);
            this.label_best_lap.Name = "label_best_lap";
            this.label_best_lap.Size = new System.Drawing.Size(56, 16);
            this.label_best_lap.TabIndex = 7;
            this.label_best_lap.Text = "Best lap";
            // 
            // label_seconds
            // 
            this.label_seconds.AutoSize = true;
            this.label_seconds.Location = new System.Drawing.Point(136, 297);
            this.label_seconds.Name = "label_seconds";
            this.label_seconds.Size = new System.Drawing.Size(61, 16);
            this.label_seconds.TabIndex = 6;
            this.label_seconds.Text = "Seconds";
            // 
            // label_minutes
            // 
            this.label_minutes.AutoSize = true;
            this.label_minutes.Location = new System.Drawing.Point(7, 297);
            this.label_minutes.Name = "label_minutes";
            this.label_minutes.Size = new System.Drawing.Size(53, 16);
            this.label_minutes.TabIndex = 5;
            this.label_minutes.Text = "Minutes";
            // 
            // nud_seconds
            // 
            this.nud_seconds.Location = new System.Drawing.Point(139, 316);
            this.nud_seconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_seconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nud_seconds.Name = "nud_seconds";
            this.nud_seconds.Size = new System.Drawing.Size(96, 22);
            this.nud_seconds.TabIndex = 4;
            this.nud_seconds.ValueChanged += new System.EventHandler(this.nud_seconds_ValueChanged);
            // 
            // num_time
            // 
            this.num_time.Location = new System.Drawing.Point(10, 404);
            this.num_time.Name = "num_time";
            this.num_time.Size = new System.Drawing.Size(96, 22);
            this.num_time.TabIndex = 3;
            this.num_time.ValueChanged += new System.EventHandler(this.num_time_ValueChanged);
            // 
            // nud_minutes
            // 
            this.nud_minutes.Location = new System.Drawing.Point(10, 316);
            this.nud_minutes.Name = "nud_minutes";
            this.nud_minutes.Size = new System.Drawing.Size(96, 22);
            this.nud_minutes.TabIndex = 2;
            // 
            // f1Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.groupBox_laps);
            this.Controls.Add(this.groupBox_drivers);
            this.Name = "f1Race";
            this.Text = "F1 Race";
            this.groupBox_drivers.ResumeLayout(false);
            this.groupBox_laps.ResumeLayout(false);
            this.groupBox_laps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_drivers;
        private System.Windows.Forms.ListBox listBox_laps;
        private System.Windows.Forms.GroupBox groupBox_drivers;
        private System.Windows.Forms.Button btn_delete_driver;
        private System.Windows.Forms.Button btn_add_driver;
        private System.Windows.Forms.GroupBox groupBox_laps;
        private System.Windows.Forms.NumericUpDown nud_seconds;
        private System.Windows.Forms.NumericUpDown num_time;
        private System.Windows.Forms.NumericUpDown nud_minutes;
        private System.Windows.Forms.TextBox tb_best_lap;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_best_lap;
        private System.Windows.Forms.Label label_seconds;
        private System.Windows.Forms.Label label_minutes;
        private System.Windows.Forms.Button btn_add_lap;
    }
}