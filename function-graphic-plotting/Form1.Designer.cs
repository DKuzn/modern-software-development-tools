namespace function_graphic_plotting
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.functionGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stepValue = new System.Windows.Forms.TextBox();
            this.endValue = new System.Windows.Forms.TextBox();
            this.startValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lineWidthValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonColorGreen = new System.Windows.Forms.RadioButton();
            this.buttonColorBlue = new System.Windows.Forms.RadioButton();
            this.buttonColorBlack = new System.Windows.Forms.RadioButton();
            this.buttonColorRed = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonTypeColumn = new System.Windows.Forms.RadioButton();
            this.buttonTypeLine = new System.Windows.Forms.RadioButton();
            this.buttonTypeSpline = new System.Windows.Forms.RadioButton();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.functionGraphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // functionGraphic
            // 
            chartArea2.Name = "ChartArea1";
            this.functionGraphic.ChartAreas.Add(chartArea2);
            this.functionGraphic.Location = new System.Drawing.Point(12, 242);
            this.functionGraphic.Name = "functionGraphic";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.functionGraphic.Series.Add(series2);
            this.functionGraphic.Size = new System.Drawing.Size(763, 370);
            this.functionGraphic.TabIndex = 0;
            this.functionGraphic.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stepValue);
            this.groupBox1.Controls.Add(this.endValue);
            this.groupBox1.Controls.Add(this.startValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(319, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
            // 
            // stepValue
            // 
            this.stepValue.Location = new System.Drawing.Point(41, 78);
            this.stepValue.Name = "stepValue";
            this.stepValue.Size = new System.Drawing.Size(87, 23);
            this.stepValue.TabIndex = 5;
            this.stepValue.TextChanged += new System.EventHandler(this.valueInput_TextChanged);
            // 
            // endValue
            // 
            this.endValue.Location = new System.Drawing.Point(41, 49);
            this.endValue.Name = "endValue";
            this.endValue.Size = new System.Drawing.Size(87, 23);
            this.endValue.TabIndex = 4;
            this.endValue.TextChanged += new System.EventHandler(this.valueInput_TextChanged);
            // 
            // startValue
            // 
            this.startValue.Location = new System.Drawing.Point(41, 20);
            this.startValue.Name = "startValue";
            this.startValue.Size = new System.Drawing.Size(87, 23);
            this.startValue.TabIndex = 3;
            this.startValue.TextChanged += new System.EventHandler(this.valueInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xk =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xh =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xn =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lineWidthValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonColorGreen);
            this.groupBox2.Controls.Add(this.buttonColorBlue);
            this.groupBox2.Controls.Add(this.buttonColorBlack);
            this.groupBox2.Controls.Add(this.buttonColorRed);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(459, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 119);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Свойства графика";
            // 
            // lineWidthValue
            // 
            this.lineWidthValue.Location = new System.Drawing.Point(124, 21);
            this.lineWidthValue.Name = "lineWidthValue";
            this.lineWidthValue.Size = new System.Drawing.Size(70, 23);
            this.lineWidthValue.TabIndex = 5;
            this.lineWidthValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lineWidthValue.ValueChanged += new System.EventHandler(this.lineWidthValue_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Толщина линии";
            // 
            // buttonColorGreen
            // 
            this.buttonColorGreen.BackColor = System.Drawing.Color.Green;
            this.buttonColorGreen.ForeColor = System.Drawing.Color.White;
            this.buttonColorGreen.Location = new System.Drawing.Point(104, 85);
            this.buttonColorGreen.Name = "buttonColorGreen";
            this.buttonColorGreen.Size = new System.Drawing.Size(90, 22);
            this.buttonColorGreen.TabIndex = 3;
            this.buttonColorGreen.Text = "Зеленый";
            this.buttonColorGreen.UseVisualStyleBackColor = false;
            this.buttonColorGreen.CheckedChanged += new System.EventHandler(this.buttonColor_CheckedChanged);
            // 
            // buttonColorBlue
            // 
            this.buttonColorBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonColorBlue.ForeColor = System.Drawing.Color.White;
            this.buttonColorBlue.Location = new System.Drawing.Point(9, 85);
            this.buttonColorBlue.Name = "buttonColorBlue";
            this.buttonColorBlue.Size = new System.Drawing.Size(90, 22);
            this.buttonColorBlue.TabIndex = 2;
            this.buttonColorBlue.Text = "Синий";
            this.buttonColorBlue.UseVisualStyleBackColor = false;
            this.buttonColorBlue.CheckedChanged += new System.EventHandler(this.buttonColor_CheckedChanged);
            // 
            // buttonColorBlack
            // 
            this.buttonColorBlack.BackColor = System.Drawing.Color.Black;
            this.buttonColorBlack.ForeColor = System.Drawing.Color.White;
            this.buttonColorBlack.Location = new System.Drawing.Point(104, 57);
            this.buttonColorBlack.Name = "buttonColorBlack";
            this.buttonColorBlack.Size = new System.Drawing.Size(90, 22);
            this.buttonColorBlack.TabIndex = 1;
            this.buttonColorBlack.Text = "Черный";
            this.buttonColorBlack.UseVisualStyleBackColor = false;
            this.buttonColorBlack.CheckedChanged += new System.EventHandler(this.buttonColor_CheckedChanged);
            // 
            // buttonColorRed
            // 
            this.buttonColorRed.BackColor = System.Drawing.Color.Red;
            this.buttonColorRed.Checked = true;
            this.buttonColorRed.ForeColor = System.Drawing.Color.White;
            this.buttonColorRed.Location = new System.Drawing.Point(9, 57);
            this.buttonColorRed.Name = "buttonColorRed";
            this.buttonColorRed.Size = new System.Drawing.Size(90, 22);
            this.buttonColorRed.TabIndex = 0;
            this.buttonColorRed.TabStop = true;
            this.buttonColorRed.Text = "Красный";
            this.buttonColorRed.UseVisualStyleBackColor = false;
            this.buttonColorRed.CheckedChanged += new System.EventHandler(this.buttonColor_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonTypeColumn);
            this.groupBox3.Controls.Add(this.buttonTypeLine);
            this.groupBox3.Controls.Add(this.buttonTypeSpline);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(666, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 112);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип графика";
            // 
            // buttonTypeColumn
            // 
            this.buttonTypeColumn.AutoSize = true;
            this.buttonTypeColumn.Location = new System.Drawing.Point(6, 77);
            this.buttonTypeColumn.Name = "buttonTypeColumn";
            this.buttonTypeColumn.Size = new System.Drawing.Size(73, 21);
            this.buttonTypeColumn.TabIndex = 2;
            this.buttonTypeColumn.Text = "Column";
            this.buttonTypeColumn.UseVisualStyleBackColor = true;
            this.buttonTypeColumn.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // buttonTypeLine
            // 
            this.buttonTypeLine.AutoSize = true;
            this.buttonTypeLine.Checked = true;
            this.buttonTypeLine.Location = new System.Drawing.Point(6, 50);
            this.buttonTypeLine.Name = "buttonTypeLine";
            this.buttonTypeLine.Size = new System.Drawing.Size(53, 21);
            this.buttonTypeLine.TabIndex = 1;
            this.buttonTypeLine.TabStop = true;
            this.buttonTypeLine.Text = "Line";
            this.buttonTypeLine.UseVisualStyleBackColor = true;
            this.buttonTypeLine.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // buttonTypeSpline
            // 
            this.buttonTypeSpline.AutoSize = true;
            this.buttonTypeSpline.Location = new System.Drawing.Point(6, 23);
            this.buttonTypeSpline.Name = "buttonTypeSpline";
            this.buttonTypeSpline.Size = new System.Drawing.Size(65, 21);
            this.buttonTypeSpline.TabIndex = 0;
            this.buttonTypeSpline.Text = "Spline";
            this.buttonTypeSpline.UseVisualStyleBackColor = true;
            this.buttonTypeSpline.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // buttonPlot
            // 
            this.buttonPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlot.Location = new System.Drawing.Point(12, 194);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(763, 41);
            this.buttonPlot.TabIndex = 5;
            this.buttonPlot.Text = "Нарисовать график";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(130, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(456, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Построение графика функции на интервале [Xn; Xk]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 624);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPlot);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.functionGraphic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение графика функции";
            ((System.ComponentModel.ISupportInitialize)(this.functionGraphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthValue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart functionGraphic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox stepValue;
        private System.Windows.Forms.TextBox endValue;
        private System.Windows.Forms.TextBox startValue;
        private System.Windows.Forms.NumericUpDown lineWidthValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton buttonColorGreen;
        private System.Windows.Forms.RadioButton buttonColorBlue;
        private System.Windows.Forms.RadioButton buttonColorBlack;
        private System.Windows.Forms.RadioButton buttonColorRed;
        private System.Windows.Forms.RadioButton buttonTypeColumn;
        private System.Windows.Forms.RadioButton buttonTypeLine;
        private System.Windows.Forms.RadioButton buttonTypeSpline;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.Label label5;
    }
}

