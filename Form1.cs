using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thebestcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

float a, b;
        int count;
        bool znak = true;

private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a + float.Parse(textBox1.Text); //ошибка 1: "вместо + должен быть - "
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = (float)Math.Sin(a);
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = (float)Math.Cos(a);
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = (float)Math.Tan(a);
                    textBox1.Text = b.ToString();
                    break;
                case 8:
                    b = (float)(1/Math.Tan(a));
                    textBox1.Text = b.ToString();
                    break;
                case 9:
                    b = (float)a/10;//ошибка 3: "вместо 10 должно быть 100"
                    textBox1.Text = b.ToString();
                    break;
                case 10:
                    b = (float)Math.Sqrt(b);//ошибка 2: "вместо a должен быть b "
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
            // Сбрасываем count, чтобы подготовиться к следующему расчету
            count = 0;
            a = b; // Переносим результат в a для последующих операций
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label2.Text = a.ToString() + ":";
            znak = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 9;
            label2.Text = a.ToString() + "%";
            znak = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 10;
            label2.Text = "√"+a.ToString();
            znak = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label2.Text = a.ToString() + "-";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + - 4;//ошибка 4: "вместо -4 должно быть 0"
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label2.Text = a.ToString() + "+";
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label2.Text = a.ToString() + "*";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Вычисление результата
            calculate();
            label2.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5; // Устанавливаем count для синуса
            znak = true;
            label2.Text = "sin"+ a.ToString();
            znak = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6; // Устанавливаем count для синуса
            znak = true;
            label2.Text = "cos" + a.ToString();
            znak = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 7; // Устанавливаем count для синуса
            znak = true;
            label2.Text = "tg" + a.ToString();
            znak = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 8; // Устанавливаем count для синуса
            znak = false; //ошибка 5: "должно быть true вместо false"
            label2.Text = "ctg" + a.ToString();
            znak = false;//ошибка 6: "должно быть true вместо false"
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
