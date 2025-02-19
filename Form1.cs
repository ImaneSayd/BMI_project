namespace BMI_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double result = 0.0;

            result = weight / (height * height);
            if (result < 16.0)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.#") + "\r\n" + "You are Underweight (Severely thin)";
            }
            else 
                if (result is >= 16.0 and <= 16.9)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.#") + "\r\n" + "You are Underweight (Moderately thin)";
            }
            else 
                if (result is >= 17.0 and <= 18.4)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.#") + "\r\n" + "You are Underweight (Mildly thin)";
            }
            else 
                if (result is >= 18.5 and <= 24.9)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.#") + "\r\n" + "You are in Normal range";
            }
            else
                if (result is >= 25.0 and <= 29.9)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.#") + "\r\n" + "You are Overweight (Pre-obese)";
            }
            else 
                if (result is >= 30.0 and <= 34.9)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.#") + "\r\n" + "You are Obese (Class I)";
            }
            else 
                if (result is >= 35.0 and <= 39.9)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.#") + "\r\n" + "You are Obese (Class II)";
            }
            else 
                if (result is >= 40.0)
            {
                txtResult.Text = "Your BMI is : " + result.ToString("#.#") + "\r\n" + "You are Obese (Class III)";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Text = "";
            txtHeight.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
