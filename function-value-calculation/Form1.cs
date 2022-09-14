namespace function_value_calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double calculateValue(double value)
        {
            return 1 / Math.Tan(Math.Pow((3 *  value - 1), 2));
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double inputValue = Convert.ToDouble(textInputValue.Text);
                double calculatedValue = Math.Round(calculateValue(inputValue), 3);
                labelFunctionValue.Text = Convert.ToString(calculatedValue);
            }
            catch (FormatException)
            {
                labelFunctionValue.Text = "¬ведены неверные данные";
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}