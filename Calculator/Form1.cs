using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public bool equalPressed = false;
        public bool dotPressed = false;
        public int signPressedCounter = 0;
        public double number;
        public double tempFirstNumber,tempSecondNumber;
        public int signIndicator = 0;
        public bool plusminusPressed = false;

        public Calculator()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox1.ReadOnly = true;
            plus.Enabled = true;
            minus.Enabled = true;
            multiply.Enabled = true;
            divison.Enabled = true;
            backspace.Enabled = true;
            inverse.Enabled = true;
            square.Enabled = true;
            root.Enabled = true;
            plusminus.Enabled = true;
            equal.Enabled = true;
        }

        public void allClear()
        {
            textBox1.ResetText();
            equalPressed = false;
            signPressedCounter = 0;
        }

        private void on_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void off_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox1.Enabled = false;
            number = 0;
            tempFirstNumber = tempSecondNumber = 0;
            signIndicator = 0;
            dotPressed = false;
            equalPressed = false;
        }
        
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            number = 0;
            tempFirstNumber = tempSecondNumber = 0;
            signIndicator = 0;
            dotPressed = false;
            equalPressed = false;
            signPressedCounter = 0;
        }

        private void root_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (equalPressed == false && signIndicator == 0)
                {
                    tempFirstNumber = Math.Sqrt(double.Parse(textBox1.Text));
                    textBox1.Text = tempFirstNumber.ToString();
                }
                else if (equalPressed == true && signIndicator != 0)
                {
                    tempFirstNumber = Math.Sqrt(tempFirstNumber);
                    textBox1.Text = tempFirstNumber.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please give a number first");
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (equalPressed == false || dotPressed == true)
            {
                textBox1.Text += "0";
            }
            else if (equalPressed == true)
            {
                allClear();
                textBox1.Text += "0";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (equalPressed == false || dotPressed == true)
            {
                textBox1.Text += "1";
            }
            else if (equalPressed == true)
            {
                allClear();
                textBox1.Text += "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (equalPressed == false || dotPressed == true)
            {
                textBox1.Text += "2";
            }
            else if (equalPressed == true)
            {
                allClear();
                textBox1.Text += "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (equalPressed == false || dotPressed == true)
            {
                textBox1.Text += "3";
            }
            else if (equalPressed == true)
            {
                allClear();
                textBox1.Text += "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (equalPressed == false || dotPressed == true)
            {
                textBox1.Text += "4";
            }
            else if (equalPressed == true)
            {
                allClear();
                textBox1.Text += "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (equalPressed == false)
            {
                textBox1.Text += "5";
            }
            else if (equalPressed == true)
            {
                allClear();
                textBox1.Text += "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (equalPressed == false || dotPressed == true)
            {
                textBox1.Text += "6";
            }
            else if (equalPressed == true)
            {
                allClear();
                textBox1.Text += "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (equalPressed == false || dotPressed == true)
            {
                textBox1.Text += "7";
            }
            else if (equalPressed == true)
            {
                allClear();
                textBox1.Text += "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (equalPressed == false || dotPressed == true)
            {
                textBox1.Text += "8";
            }
            else if (equalPressed == true)
            {
                allClear();
                textBox1.Text += "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (equalPressed == false || dotPressed == true)
            {
                textBox1.Text += "9";
            }
            else if (equalPressed == true)
            {
                allClear();
                textBox1.Text += "9";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (equalPressed == false)
                {
                    tempFirstNumber = double.Parse(textBox1.Text);
                    signIndicator = 1;
                    textBox1.ResetText();
                    signPressedCounter++;
                }
                else
                {
                    signIndicator = 1;
                    textBox1.ResetText();
                    signPressedCounter++;
                }
            }
            else
            {
                MessageBox.Show("Please give a number first");
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (equalPressed == false)
                {
                    tempFirstNumber = double.Parse(textBox1.Text);
                    signIndicator = 2;
                    textBox1.ResetText();
                    signPressedCounter++;
                }
                else
                {
                    signIndicator = 2;
                    textBox1.ResetText();
                    signPressedCounter++;
                }
            }
            else
            {
                MessageBox.Show("Please give a number first");
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (equalPressed == false)
                {
                    tempFirstNumber = double.Parse(textBox1.Text);
                    signIndicator = 3;
                    textBox1.ResetText();
                    signPressedCounter++;
                }
                else
                {
                    signIndicator = 3;
                    textBox1.ResetText();
                    signPressedCounter++;
                }
            }
            else
            {
                MessageBox.Show("Please give a number first");
            }
        }

        private void divison_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (equalPressed == false)
                {
                    tempFirstNumber = double.Parse(textBox1.Text);
                    signIndicator = 4;
                    textBox1.ResetText();
                    signPressedCounter++;
                }
                else
                {
                    signIndicator = 4;
                    textBox1.ResetText();
                    signPressedCounter++;
                }
            }
            else
            {
                MessageBox.Show("Please give a number first");
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                tempSecondNumber = double.Parse(textBox1.Text);

                equalPressed = true;

                if (signIndicator == 1)
                {
                    tempFirstNumber = tempFirstNumber + tempSecondNumber;
                    textBox1.Text = tempFirstNumber.ToString();
                }
                else if (signIndicator == 2)
                {
                    tempFirstNumber = tempFirstNumber - tempSecondNumber;
                    textBox1.Text = tempFirstNumber.ToString();
                }
                else if (signIndicator == 3)
                {
                    tempFirstNumber = tempFirstNumber * tempSecondNumber;
                    textBox1.Text = tempFirstNumber.ToString();
                }
                else if (signIndicator == 4)
                {
                    tempFirstNumber = tempFirstNumber / tempSecondNumber;
                    textBox1.Text = tempFirstNumber.ToString();
                }
                else if (signIndicator == 0)
                {
                    tempFirstNumber = double.Parse(textBox1.Text);
                }
            }
            else
            {
                MessageBox.Show("Please give a number first");
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            dotPressed = true;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "0";
                textBox1.Text += ".";
            }
            else
                textBox1.Text += ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Aqua;
            textBox1.ForeColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.Fixed3D;
            textBox1.ReadOnly = true;
            textBox1.TextAlign = HorizontalAlignment.Right;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                plus.Enabled = true;
                minus.Enabled = true;
                multiply.Enabled = true;
                divison.Enabled = true;
                backspace.Enabled = true;
                inverse.Enabled = true;
                square.Enabled = true;
                root.Enabled = true;
                plusminus.Enabled = true;
                equal.Enabled = true;
            }
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (equalPressed == true)
                {
                    tempFirstNumber = tempFirstNumber * (-1);
                    textBox1.Text = tempFirstNumber.ToString();
                }
                else if (signPressedCounter >= 1)
                {
                    tempSecondNumber = double.Parse(textBox1.Text) * (-1);
                }
                else if (equalPressed == false)
                {
                    number = double.Parse(textBox1.Text) * (-1);
                    textBox1.Text = number.ToString();
                }
                plusminusPressed = true;
            }
            else
            {
                MessageBox.Show("Please give a number first");
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string str;
                str = textBox1.Text.Substring(textBox1.Text.Length - 1);
                if (str == ".")
                {
                    dotPressed = false;
                    int loc = textBox1.Text.Length;
                    textBox1.Text = textBox1.Text.Remove(loc - 1, 1);
                }
                else
                {
                    int loc = textBox1.Text.Length;
                    textBox1.Text = textBox1.Text.Remove(loc - 1, 1);
                }
            }
            else
            {
                MessageBox.Show("Please give a number first");
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (equalPressed == false && signIndicator == 0)
                {
                    tempFirstNumber = double.Parse(textBox1.Text);
                    tempFirstNumber = Math.Pow(tempFirstNumber, 2);
                    textBox1.Text = tempFirstNumber.ToString();
                }
                else if (equalPressed == true && signIndicator != 0)
                {
                    tempFirstNumber = Math.Pow(tempFirstNumber, 2);
                    textBox1.Text = tempFirstNumber.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please give a number first");
            }
        }

        private void inverse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (equalPressed == false && signIndicator == 0)
                {
                    tempFirstNumber = double.Parse(textBox1.Text);
                    tempFirstNumber = 1 / tempFirstNumber;
                    textBox1.Text = tempFirstNumber.ToString();
                }
                else if (equalPressed == true && signIndicator != 0)
                {
                    tempFirstNumber = 1 / tempFirstNumber;
                    textBox1.Text = tempFirstNumber.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please give a number first");
            }
        }
 
    }
}
