using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// Date: 20.02.2020
/// created by Berkay Gürbüz
/// Calculator example

namespace Calculator_BerkayGürbüz
{
    public partial class Form1 : Form
    {
        string operation;
        double tempResult = 0;
        double finalResult = 0;
        List<string> _inputRecord;
        List<string> _operation;
        int flag = 0;

        void printNumber()
        {
            tempResult =Convert.ToDouble(textBox1.Text);
            _inputRecord.Add(textBox1.Text);
            _operation.Add(operation);
            label2.Text += tempResult + operation;
            textBox1.Text = "0";
            flag = 0; //to adding ",";
        }
        void updateResult(string number,string operatorType)
        {
            switch (operatorType)
            {
                case "+":
                    finalResult += Convert.ToDouble(number); 
                    break;
                case "-":
                    finalResult -= Convert.ToDouble(number);  
                    break;
                case "*":
                    finalResult *= Convert.ToDouble(number);
                    break;
                case "/":
                    finalResult /= Convert.ToDouble(number);
                    break;
                case "overx":
                    finalResult = 1 / Convert.ToDouble(number);
                    break;
                case "square":
                    finalResult = Math.Pow(Convert.ToDouble(number), 2);
                    break;
                case "sqrt":
                    finalResult = Math.Sqrt(Convert.ToDouble(number));
                    break;
                case "%":
                    finalResult %= Convert.ToDouble(number);
                    break;

            }
            
        }
        public Form1()
        {
            InitializeComponent();
            _inputRecord = new List<string>();
            _operation = new List<string>();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (operation != "=")
            {
                operation = "+";
                printNumber();
            }
            else
            {
                label2.Text = "";
                operation = "+";
                printNumber();
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (operation != "=")
            {
                operation = "-";
                printNumber();
            }
            else
            {
                label2.Text = "";
                operation = "-";
                printNumber();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (operation != "=")
            {
                operation = "*";
                printNumber();
            }
            else
            {
                label2.Text = "";
                operation = "*";
                printNumber();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (operation != "=")
            {
                operation = "/";
                printNumber();
            }
            else
            {
                label2.Text = "";
                operation = "/";
                printNumber();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            _inputRecord.Add(textBox1.Text);
            label2.Text += textBox1.Text;
            textBox1.Text = "0";
            finalResult = Convert.ToDouble(_inputRecord[0]);

            for (int i = 0; i < _operation.Count; i++)
            {
                updateResult(_inputRecord[i + 1], _operation[i]);
            }
            _inputRecord.Clear();
            _operation.Clear();
            operation = "=";
            label2.Text = label2.Text + operation + finalResult.ToString();
            listBox1.Items.Add(label2.Text);
            
        }


        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.Text == "History")
            {
                History.Visible = true;
                this.Size = new Size(565, 606);
                button25.Text = "Hide the History";
            }
            else
            {
                History.Visible = false;
                this.Size = new Size(297, 606);
                button25.Text = "History";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int temp;
            temp =Convert.ToInt32(textBox1.Text);
            temp /= 10;
            textBox1.Text = temp.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _inputRecord.Clear();
            _operation.Clear();
            label2.Text = "";
            textBox1.Text = "0";
            flag = 0; //to adding ",";
            listBox1.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            operation = "overx";
            if (operation != "=")
            {

                updateResult(number.ToString(), operation);
            }
            else
            {
                label2.Text = "";
                updateResult(number.ToString(), operation);
                
            }
            flag = 0; //to adding ",";
            label2.Text = "1/" + number + "=" + finalResult;
            textBox1.Text = "0";
            listBox1.Items.Add(label2.Text);
            operation = "=";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            operation = "square";
            if (operation != "=")
            {

                updateResult(number.ToString(), operation);
            }
            else
            {
                label2.Text = "";
                updateResult(number.ToString(), operation);
            }
            flag = 0; //to adding ",";
            label2.Text = "sqrl(" + number + ")=" + finalResult;
            textBox1.Text = "0";
            listBox1.Items.Add(label2.Text);
            operation = "=";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            operation = "sqrt";
            if (operation != "=")
            {

                updateResult(number.ToString(), operation);
            }
            else
            {
                label2.Text = "";
                updateResult(number.ToString(), operation);
            }
            flag = 0; //to adding ",";
            label2.Text = "√(" + number + ")=" + finalResult;
            textBox1.Text = "0";
            listBox1.Items.Add(label2.Text);
            operation = "=";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operation != "=")
            {
                operation = "%";
            }
            else
            {
                label2.Text ="";
                operation = "%";
               
            }
            printNumber();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tempResult = (-1) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = ""+tempResult;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
            if (flag == 0)
            {
                textBox1.Text += ",";
                flag = 1;
            }
            else
            {
                
                //do nothing
            }
        }
    }
}
