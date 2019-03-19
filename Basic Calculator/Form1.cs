using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class BasicCalc : Form
    {
        double firstNumber;
        string operation;
        public BasicCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "1";
            }
            else
            {
                displayBox.Text = displayBox.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "2";
            }
            else
            {
                displayBox.Text = displayBox.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "3";
            }
            else
            {
                displayBox.Text = displayBox.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "4";
            }
            else
            {
                displayBox.Text = displayBox.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "5";
            }
            else
            {
                displayBox.Text = displayBox.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "6";
            }
            else
            {
                displayBox.Text = displayBox.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "7";
            }
            else
            {
                displayBox.Text = displayBox.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "8";
            }
            else
            {
                displayBox.Text = displayBox.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "9";
            }
            else
            {
                displayBox.Text = displayBox.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (displayBox.Text != "0")
            {
                displayBox.Text = displayBox.Text + "0";
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            displayBox.Text = displayBox.Text + ".";
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            displayBox.Text = "0";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(displayBox.Text);
            operation = "+";
            displayBox.Text = "0";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(displayBox.Text);
            operation = "-";
            displayBox.Text = "0";
        } 

        private void remainderButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(displayBox.Text);
            operation = "r";
            displayBox.Text = "0";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(displayBox.Text);
            operation = "/";
            displayBox.Text = "0";
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(displayBox.Text);
            operation = "*";
            displayBox.Text = "0";
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(displayBox.Text);
            operation = "%";
            displayBox.Text = "0";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            switch(operation)
            {
                case "+":
                    secondNumber = Convert.ToDouble(displayBox.Text);
                    result = firstNumber + secondNumber;
                    displayBox.Text = Convert.ToString(result);
                    firstNumber = result;
                    break;
                case "-":
                    secondNumber = Convert.ToDouble(displayBox.Text);
                    result = firstNumber - secondNumber;
                    displayBox.Text = Convert.ToString(result);
                    firstNumber = result;
                    break;
                case "*":
                    secondNumber = Convert.ToDouble(displayBox.Text);
                    result = firstNumber * secondNumber;
                    displayBox.Text = Convert.ToString(result);
                    firstNumber = result;
                    break;
                case "/":
                    if(displayBox.Text == "0")
                    {
                        displayBox.Text = "cannot divide by 0";
                    }
                    secondNumber = Convert.ToDouble(displayBox.Text);
                    result = firstNumber / secondNumber;
                    displayBox.Text = Convert.ToString(result);
                    firstNumber = result;
                    break;
                case "r":
                    secondNumber = Convert.ToDouble(displayBox.Text);
                    result = firstNumber % secondNumber;
                    displayBox.Text = Convert.ToString(result);
                    firstNumber = result;
                    break;
                case "%":
                    secondNumber = Convert.ToDouble(displayBox.Text);
                    if (secondNumber < 10)
                    {
                        secondNumber /= 1000;
                    } else
                    {
                        secondNumber /= 100;
                    }
                    result = firstNumber * secondNumber;
                    displayBox.Text = Convert.ToString(result);
                    firstNumber = result;
                    break;
                default:
                    displayBox.Text = "0";
                    break;
            }
        }
    }
}
