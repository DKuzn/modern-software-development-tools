using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace function_graphic_plotting_menu
{
    public partial class MainWindow : Form
    {
        private Series _plot;
        private List<double> _valuesX;
        private List<double> _valuesY;

        public MainWindow()
        {
            InitializeComponent();
            initPlot();
        }

        public void initPlot()
        {
            dataTable.Rows.Clear();
            _plot = functionGraphic.Series[0];
            _plot.Points.Clear();
            _valuesX = new List<double>();
            _valuesY = new List<double>();
        }

        private void exitProgram(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private double calculateValue(double value)
        {
            return 1 / Math.Tan(Math.Pow(3 * value - 1, 2));
        }

        private void calculatePlotValues()
        {
            initPlot();
            double startValue, endValue, stepValue;
            try
            {
                startValue = Convert.ToDouble(this.startValue.Text);
                endValue = Convert.ToDouble(this.endValue.Text);
                stepValue = Convert.ToDouble(this.stepValue.Text);
            }
            catch
            {
                return;
            }

            for (var x = startValue; x <= endValue; x += stepValue)
            {
                var y = calculateValue(x);
                _valuesX.Add(x);
                _valuesY.Add(y);
                dataTable.Rows.Add(x, y);
            }
        }

        private void findExtremums()
        {
            try
            {
                minValue.Text = Enumerable.Min(_valuesY).ToString();
                maxValue.Text = Enumerable.Max(_valuesY).ToString();
            }
            catch
            {
                return;
            }
        }

        private void plotGraphic()
        {
            _plot.Points.Clear();
            _plot.ChartType = SeriesChartType.Line;
            for (var i = 0; i < _valuesX.Count; i++) _plot.Points.AddXY(_valuesX[i], _valuesY[i]);
        }

        private void calculateStripButton_Click(object sender, EventArgs e)
        {
            calculatePlotValues();
            findExtremums();
            plotGraphic();
        }

        private void newPlot(object sender, EventArgs e)
        {
            initPlot();
            startValue.Text = "";
            stepValue.Text = "";
            endValue.Text = "";
        }

        private void pickColor(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var button = (ToolStripMenuItem)sender;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (button.Name == backgroundColor.Name)
                {
                    functionGraphic.BackColor = colorDialog.Color;
                    functionGraphic.ChartAreas[0].BackColor = colorDialog.Color;
                }
                if (button.Name == graphicColor.Name) functionGraphic.Series[0].Color = colorDialog.Color;
                if (button.Name == tableTextColor.Name) dataTable.DefaultCellStyle.ForeColor = colorDialog.Color;
            }
        }

        private void pickFont(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK) dataTable.DefaultCellStyle.Font = fontDialog.Font;

        }

        private void valueInput_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            minValue.Text = "";
            maxValue.Text = "";
            try
            {
                Convert.ToDouble(tb.Text);
                tb.BackColor = Color.White;
                tb.ForeColor = Color.Black;
                calculateStripButton.Enabled = true;
            }
            catch
            {
                tb.BackColor = Color.Red;
                tb.ForeColor = Color.White;
                calculateStripButton.Enabled = false;
            }
        }

        private bool checkCsv(string[] options)
        {
            if (options.Length != 2) return false;
            try
            {
                for (int i = 0; i < options.Length; i++) Convert.ToDouble(options[i]);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void openFile()
        {
            var fileOpen = new OpenFileDialog();
            fileOpen.Filter = "Column Value Separator|*.csv";
            int line = -1;
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                initPlot();
                using (var reader = new StreamReader(fileOpen.FileName))
                {
                    dataTable.Rows.Clear();
                    while (reader.Peek() > 0)
                    {
                        var xy = reader.ReadLine().Split('\t');
                        line++;
                        if (line == 0) continue;

                        if (!checkCsv(xy))
                        {
                            dataTable.Rows.Clear();
                            for (int i = 0; i < _valuesX.Count; i++) dataTable.Rows.Add(_valuesX[i], _valuesY[i]);
                            return;
                        }

                        if (line == 1) startValue.Text = xy[0].ToString();
                        endValue.Text = xy[0].ToString();
                        if (line == 2) stepValue.Text = Convert.ToString(Convert.ToDouble(endValue.Text) - Convert.ToDouble(startValue.Text));
                        dataTable.Rows.Add(xy);
                    }
                }
            }
            for (int i = 0; i < dataTable.Rows.Count - 1; i++)
            {
                _valuesX.Add(Convert.ToDouble(dataTable.Rows[i].Cells[0].Value));
                _valuesY.Add(Convert.ToDouble(dataTable.Rows[i].Cells[1].Value));
            }
        }

        private void saveFIle_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0) return;
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Column Value Separated|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = saveFileDialog.FileName.EndsWith(".csv") ? saveFileDialog.FileName : $"{saveFileDialog.FileName}.csv";
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine("X\tY");

                for (int i = 0; i < _valuesX.Count; i++) sw.WriteLine($"{_valuesX[i]}\t{_valuesY[i]}");

                sw.Close();
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFile();
            findExtremums();
            plotGraphic();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutWindow = new AboutWindow();
            aboutWindow.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            aboutWindow.ShowDialog();
        }
    }
}
