using System;
using System.Windows.Forms;

namespace bt4._3
{
    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (isOperationPerformed))
            {
                txtDisplay.Clear();
            }

            isOperationPerformed = false;
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operationPerformed = btn.Text;
            resultValue = double.Parse(txtDisplay.Text);
            isOperationPerformed = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
            operationPerformed = "";
            isOperationPerformed = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtDisplay.Text = (resultValue + double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultValue - double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultValue * double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(txtDisplay.Text) != 0)
                    {
                        txtDisplay.Text = (resultValue / double.Parse(txtDisplay.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Khong the chia cho 0", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(txtDisplay.Text);
            operationPerformed = "";
        }
    }
}