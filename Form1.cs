using System;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        bool znak = false;
        double? Memory = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 2;
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
            }

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 1;
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
            }

        }

        private void three_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 3;
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
            }

        }

        private void four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 4;
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
            }

        }

        private void five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 5;
            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
            }

        }

        private void six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 6;
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
            }

        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 7;
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
            }

        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 8;
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
            }
            
        }

        private void nein_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 9;
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
            }

        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
                
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
            }
            

        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",") && textBox1.Text != "∞" && textBox1.Text != "не число")
                textBox1.Text = textBox1.Text + ",";
            //if (textBox1.Text.IndexOf(",") == -1)
            //{
            //    textBox1.Text += ",";
            //}
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = "0";
                count = 1;
                label1.Text = a.ToString() + "+";
                znak = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = "0";
                count = 2;
                label1.Text = a.ToString() + "-";
                znak = true;
            }
        }


        private void multiplication_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = "0";
                count = 3;
                label1.Text = a.ToString() + "*";
                znak = true;
            }

        }

        private void division_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = "0";
                count = 4;
                label1.Text = a.ToString() + "/";
                znak = true;
            }

        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    if (float.Parse(textBox1.Text) == 0)
                    {
                        MessageBox.Show("Деление на ноль");
                        textBox1.Text = "";
                    }
                    else
                    {
                        b = a / float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    break;

                case 5:
                    {
                        b = a / 100 * float.Parse(textBox1.Text);
                        break;
                    }
                default:
                    break;
            }
        }

        private void equally_Click(object sender, EventArgs e)
        {

            calculate();

        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text !="0")
            {
                double ch, rez;
                ch = Convert.ToDouble(textBox1.Text);
                if (textBox1.Text != "∞")
                {
                    rez = -ch;
                    textBox1.Text = rez.ToString();
                }
            }

        }

        private void backspace_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "" || textBox1.Text == "-" || textBox1.Text.Contains("E"))
                textBox1.Text = "0";
            //if (textBox1.Text != "0")
            //{
            //    int lenght = textBox1.Text.Length - 1;
            //    string text = textBox1.Text;
            //    textBox1.Clear();
            //    for (int i = 0; i < lenght; i++)
            //    {
            //        textBox1.Text = textBox1.Text + text[i];
            //    }
            //}

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Focus();
                textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
            }

        }


        private void Clear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = "0";
                label1.Text = "";

            }
        }

        private void MC_Click(object sender, EventArgs e)
        {
            Memory = null;
        }

        private void MR_Click(object sender, EventArgs e)
        {
            if (Memory != null)
            {
                textBox1.Text = Memory.ToString();
            }
            else
            {
                MessageBox.Show("Память пуста", "Пусто", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void MS_Click(object sender, EventArgs e)
        {
            try
            {
                //конвертируем строку в число, заполняем память
                Memory = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                //в классе Exception (переменная ex) - параметры ошибки
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox1.Text = "";
                label1.Text = "";
                return; //ушли
            }
        }

        private void MPlus_Click(object sender, EventArgs e)
        {
            try
            {
                //конвертируем строку в число, заполняем память
                Memory = Memory + Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                //в классе Exception (переменная ex) - параметры ошибки
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox1.Text = "";
                label1.Text = "";
                return; //ушли
            }
        }

        private void MMinus_Click(object sender, EventArgs e)
        {
            try
            {
                //конвертируем строку в число, заполняем память
                Memory = Memory - Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                //в классе Exception (переменная ex) - параметры ошибки
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox1.Text = "";
                label1.Text = "";
                return; //ушли
            }
        }

        private void quadrat_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Focus();
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Focus();
                textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             textBox1.Text = "0";
             

          
        }
    }
}