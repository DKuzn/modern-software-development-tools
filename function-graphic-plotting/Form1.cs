using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace function_graphic_plotting
{
    public partial class Form1 : Form
    {
        private Series _plot;
        public Form1()
        {
            InitializeComponent();
            _plot = functionGraphic.Series[0];
            _plot.Color = Color.Red;
            _plot.ChartType = SeriesChartType.Line;
        }

        private double calculateValue(double value)
        {
            return 1 / Math.Tan(Math.Pow(3 * value - 1, 2));
        }

        private void buttonColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            _plot.Color = rb.BackColor;
        }

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            try
            {
                _plot.Points.Clear();
                double startValue = Convert.ToDouble(this.startValue.Text);
                double endValue = Convert.ToDouble(this.endValue.Text);
                double stepValue = Convert.ToDouble(this.stepValue.Text);
                this.startValue.BackColor = Color.White;
                this.endValue.BackColor = Color.White;
                this.stepValue.BackColor = Color.White;
                this.startValue.ForeColor = Color.Black;
                this.endValue.ForeColor = Color.Black;
                this.stepValue.ForeColor = Color.Black;
                for (var i = startValue; i <= endValue; i += stepValue)
                {
                    _plot.Points.AddXY(i, calculateValue(i));
                }
            }
            catch
            {
                this.startValue.BackColor = Color.Red;
                this.endValue.BackColor = Color.Red;
                this.stepValue.BackColor = Color.Red;
                this.startValue.ForeColor = Color.White;
                this.endValue.ForeColor = Color.White;
                this.stepValue.ForeColor = Color.White;
                this.buttonPlot.Enabled = false;
            }

        }

        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            _plot.ChartTypeName = rb.Text;
        }

        private void lineWidthValue_ValueChanged(object sender, EventArgs e)
        {
            _plot.BorderWidth = Convert.ToInt32(lineWidthValue.Value);
        }

        private void valueInput_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            try
            {
                Convert.ToDouble(tb.Text);
                tb.BackColor = Color.White;
                tb.ForeColor = Color.Black;
                buttonPlot.Enabled = true;
            }
            catch
            {
                tb.BackColor = Color.Red;
                tb.ForeColor = Color.White;
                buttonPlot.Enabled = false;
            }
        }
    }
}
