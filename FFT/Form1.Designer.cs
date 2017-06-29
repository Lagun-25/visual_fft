namespace serialPort
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.com_comboBox = new System.Windows.Forms.ComboBox();
            this.findports_button = new System.Windows.Forms.Button();
            this.baudrate_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.write_textBox = new System.Windows.Forms.TextBox();
            this.read_textBox = new System.Windows.Forms.TextBox();
            this.write_button = new System.Windows.Forms.Button();
            this.read_button = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // com_comboBox
            // 
            this.com_comboBox.FormattingEnabled = true;
            this.com_comboBox.Location = new System.Drawing.Point(95, 41);
            this.com_comboBox.Name = "com_comboBox";
            this.com_comboBox.Size = new System.Drawing.Size(67, 21);
            this.com_comboBox.TabIndex = 0;
            // 
            // findports_button
            // 
            this.findports_button.Location = new System.Drawing.Point(95, 68);
            this.findports_button.Name = "findports_button";
            this.findports_button.Size = new System.Drawing.Size(67, 23);
            this.findports_button.TabIndex = 1;
            this.findports_button.Text = "Find ports";
            this.findports_button.UseVisualStyleBackColor = true;
            this.findports_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.findports_button_MouseClick);
            // 
            // baudrate_Box
            // 
            this.baudrate_Box.Location = new System.Drawing.Point(174, 41);
            this.baudrate_Box.Name = "baudrate_Box";
            this.baudrate_Box.Size = new System.Drawing.Size(67, 20);
            this.baudrate_Box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Baudrate";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(174, 68);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(67, 23);
            this.connect_button.TabIndex = 14;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // write_textBox
            // 
            this.write_textBox.Location = new System.Drawing.Point(47, 138);
            this.write_textBox.Name = "write_textBox";
            this.write_textBox.Size = new System.Drawing.Size(111, 20);
            this.write_textBox.TabIndex = 15;
            // 
            // read_textBox
            // 
            this.read_textBox.Location = new System.Drawing.Point(183, 138);
            this.read_textBox.Multiline = true;
            this.read_textBox.Name = "read_textBox";
            this.read_textBox.ReadOnly = true;
            this.read_textBox.Size = new System.Drawing.Size(111, 20);
            this.read_textBox.TabIndex = 16;
            // 
            // write_button
            // 
            this.write_button.Location = new System.Drawing.Point(68, 164);
            this.write_button.Name = "write_button";
            this.write_button.Size = new System.Drawing.Size(67, 23);
            this.write_button.TabIndex = 17;
            this.write_button.Text = "Write";
            this.write_button.UseVisualStyleBackColor = true;
            this.write_button.Click += new System.EventHandler(this.write_button_Click);
            // 
            // read_button
            // 
            this.read_button.Location = new System.Drawing.Point(205, 164);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(67, 23);
            this.read_button.TabIndex = 18;
            this.read_button.Text = "Read";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 289);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(552, 148);
            this.chart.TabIndex = 19;
            this.chart.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.read_button);
            this.Controls.Add(this.write_button);
            this.Controls.Add(this.read_textBox);
            this.Controls.Add(this.write_textBox);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudrate_Box);
            this.Controls.Add(this.findports_button);
            this.Controls.Add(this.com_comboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_comboBox;
        private System.Windows.Forms.Button findports_button;
        private System.Windows.Forms.TextBox baudrate_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect_button;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox write_textBox;
        private System.Windows.Forms.TextBox read_textBox;
        private System.Windows.Forms.Button write_button;
        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label3;
    }
}

