using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_scales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Создаем список
            comboBox1.Items.Add("Градус Цельсия(C)");
            comboBox1.Items.Add("Градус Фаренгейта (F)");
            comboBox1.Items.Add("Кельвин (K)");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Объявляем переменные
            double C, F, K;
            bool fl1 = false;
            bool fl2 = false;
            bool fl3 = false;
            //Делаем проверку, чтоб все поля были заполнены
            if (textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Не все данные введены!");

            }
            else
            {
                switch ((short)comboBox1.SelectedIndex)
                {
                    //Изменяем флаги при разных выборах списка
                    case 0:
                        {
                            fl1 = true;
                            break;
                        }
                    case 1:
                        {
                            fl2 = true;
                            break;
                        }
                    case 2:
                        {
                            fl3 = true;
                            break;
                        }
                    default:
                        {
                            fl1 = false;
                            fl2 = false;
                            fl3 = false;
                            break;
                        }
                }
                //Проверка
                if (fl1 == true && fl2 == false && fl3 == false)
                {
                    // Проверка на правильность введения значения в поле
                    try
                    {
                        C = double.Parse(textBox1.Text);//Считываем "С"
                        F = ((C * 9 / 5) + 32);//Считаем "F"
                        K = (C + 273.2);//Считаем "K
                        label1.Text = F.ToString("f1") + " " + "F";//Выводим "F"
                        label2.Text = K.ToString("f1") + " " + "K";//Выводим "К"
                    }
                    catch
                    {
                        MessageBox.Show("Некорректный ввод данных!");
                    }
                   
                   

                }
                //Проверка
                if (fl1 == false && fl2 == true && fl3 == false)
                {
                    // Проверка на правильность введения значения в поле
                    try
                    {
                        F = double.Parse(textBox1.Text);
                        C = ((F - 32) * 5 / 9);
                        K = C + 273.2;
                        label1.Text = C.ToString("f1") + " " + "C";//Выводим "С"
                        label2.Text = K.ToString("f1") + " " + "K";//Выводим "К"
                    }
                    catch
                    {
                        MessageBox.Show("Некорректный ввод данных!");
                    }
                   
                }
                //Проверка
                if (fl1 == false && fl2 == false && fl3 == true)
                {
                    // Проверка на правильность введения значения в поле
                    try
                    {
                        K = double.Parse(textBox1.Text);
                        C = K - 273.2;
                        F = F = ((C * 9 / 5) + 32);
                        label1.Text = C.ToString("f1") + " " + "C";//Выводим "С"
                        label2.Text = F.ToString("f1") + " " + "F";//Выводим "F"
                    }
                    catch
                    {
                        MessageBox.Show("Некорректный ввод данных!");
                    }
                }
            }
           




            }
        }
     
    }

