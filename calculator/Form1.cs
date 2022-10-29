using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        double resultValue;
        string operation = "";
        bool opPerf = false;
        bool op = false;
        //string rs;
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
           
        }
        int flag = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //all digits
        private void n1_Click(object sender, EventArgs e)
        {
            cnt = 0;
            Button button = (Button)sender;
           
            if (onopPerf.Text == "" && op == true)
            {
                //resultValue = 0;
                textBox1.Text = "0";
                textBox1.Clear();
                // onopPerf.Text = "";
                bc.PerformClick();
                Console.WriteLine("executing this 1");
            }
            if(button == bdot && textBox1.Text == "0")
            {
                //textBox1.Clear();
                textBox1.Text = "0";
                Console.WriteLine("executing this 2");
            }

           else if ((textBox1.Text == "0") || (opPerf) || flag == 0)
            {
                textBox1.Clear();
                // textBox1.Text = "0";
                Console.WriteLine("executing this 3");
            }

            button2.Enabled = bad.Enabled = bsub.Enabled = bmul.Enabled = bdot.Enabled = bdiv.Enabled = true;
            opPerf = false;
            
            if (textBox1.Text == ".")
            {
                // if (!textBox1.Text.Contains("."))
                // {
                //     textBox1.Text = textBox1.Text + button.Text;
                // }
                textBox1.Text ="0"+textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
            flag = 1;
            op = false;
        }

        //c
        private void bc_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "0";
            resultValue = 0;
            //rs = resultValue.ToString();
            onopPerf.Text = "";
            flag = 1;
            cnt = 0;
        }

        //equal
        private void bequal_Click(object sender, EventArgs e)
        {

            op = true;
            cnt = 0;
            switch (operation)
            {
                case "+":
                    textBox1.Text = (resultValue + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    double res2 = (resultValue * double.Parse(textBox1.Text));
                    textBox1.Text = res2.ToString();
                    break;
                case "/":
   
                    if (double.Parse(textBox1.Text) == 0)
                    {
                        if (onopPerf.Text == ("0 /").ToString())
                        {
                            textBox1.Text = "Result is Undefined";
                            button2.Enabled = bad.Enabled = bsub.Enabled = bmul.Enabled = bdot.Enabled = bdiv.Enabled = false;
                            flag = 0;
                            break;
                        }     
                        textBox1.Text = "Can't Divide By Zero"; 
                        button2.Enabled = bad.Enabled= bsub.Enabled= bmul.Enabled= bdot.Enabled = bdiv.Enabled=false;
                        flag = 0;
                        break;
                    }
                    double res3 =(resultValue / double.Parse(textBox1.Text));
                    textBox1.Text = res3.ToString();
                    break;
                case "%":
                    textBox1.Text = (resultValue / 100).ToString();
                    break;
                default:
                   // textBox1.Text = (resultValue - double.Parse(textBox1.Text)).ToString();
                    break;
            }
            if (flag == 0)
            {
                resultValue = 0;
                //rs = resultValue.ToString();
                onopPerf.Text = "";
                
            }
            else
            {
                resultValue =double.Parse(textBox1.Text);
                if(Math.Ceiling(resultValue) == 0)
                {
                    resultValue = 0;
                    textBox1.Text = resultValue.ToString();
                }
                //rs = resultValue.ToString();
               // resultValue = Math.Round(resultValue);
                onopPerf.Text = "";
            }
        }

        //all operators
        private void bad_Click(object sender, EventArgs e)
        {
            cnt = 0;
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                //bequal.PerformClick();
                operation = button.Text;
                onopPerf.Text = resultValue + " " + operation;
                //rs = onopPerf.Text;
                opPerf = true;
            }

            else
            {
                operation = button.Text;
                resultValue = double.Parse(textBox1.Text);
               // rs = resultValue.ToString();
                onopPerf.Text = resultValue + " " + operation;
                opPerf = true;
            }
            flag = 1;
            op = false;
        }

        //ce
        private void button1_Click(object sender, EventArgs e)
        {
            cnt = 0;
            if (op == true)
            {
                bc.PerformClick();
            }
            if (onopPerf.Text == "")
            {
                resultValue = 0;
                textBox1.Text = "0";
                textBox1.Clear();
                flag = 1;
               
            }
            else
            {
                textBox1.Text = "0";
                textBox1.Clear();
                flag = 1;
            }
            op = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //System.Windows.Forms.SendKeys.Send("{}");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 42 && e.KeyChar <= 57) || e.KeyChar ==61 || e.KeyChar== 37 || e.KeyChar==13)
            {
                switch (e.KeyChar)
                {
                    case '1':
                        n1.PerformClick();
                        break;
                    case '2':
                        n2.PerformClick();
                        break;
                    case '3':
                        n3.PerformClick();
                        break;
                    case '4':
                        n4.PerformClick();
                        break;
                    case '5':
                        n5.PerformClick();
                        break;
                    case '6':
                        n6.PerformClick();
                        break;
                    case '7':
                        n7.PerformClick();
                        break;
                    case '8':
                        n8.PerformClick();
                        break;
                    case '9':
                        n9.PerformClick();
                        break;
                    case '0':
                        n0.PerformClick();
                        break;
                    case '.':
                        bdot.PerformClick();
                        break;
                    case '+':
                        bad.PerformClick();
                        break;
                    case '-':
                        bsub.PerformClick();
                        break;
                    case '*':
                        bmul.PerformClick();
                        break;
                    case '/':
                        bdiv.PerformClick();
                        break;
                    case '=':
                        bequal.PerformClick();
                        break;
                    case '%':
                        button2.PerformClick();
                        break;
                    case '\r':
                        bequal.PerformClick();
                        break;
                    default:
                        break;

                }
            }
            cnt = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnt++;
            Console.WriteLine("cnt =" + cnt);
            if (cnt % 2 != 0)
            {
                Console.WriteLine("if in cl");
                textBox1.Text = "-" + textBox1.Text;
            }
            else if(cnt%2==0)
            {
                Console.WriteLine("else if in cl");
                double rs1 = Convert.ToDouble(textBox1.Text);
                rs1 = rs1 * -1;
                textBox1.Text = rs1.ToString();
                textBox1.Text = ""+textBox1.Text;
            }
        }
    }
}
