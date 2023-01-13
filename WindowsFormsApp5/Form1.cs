using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world (Да, Да... Опять...)");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {;
            label2.Text = "1. Samsung Galaxy S557";
            label3.Text = "2. Xiaomi Note 345";
            label4.Text = "3. Nokia 3310";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "1. Игровой компьютер Celeron 3 + NVIDIA GT 8200 GTS";
            label3.Text = "2. Домашний компьютер I9 12900f + NVIDIA RTX 4090";
            label4.Text = "3. Офисный компьютер Ryzen R5 5600 + AMD RX 6600";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "1. Игровая видеокарта NVIDIA GT 8200 GTS";
            label3.Text = "2. Процессор Intel i7 12700f";
            label4.Text = "3. Оперативная память 256gb 7Ggz";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "1. Типичное зарядное устройство на 1кВ";
            label3.Text = "2. Роутер WIFI 11 234Ghz";
            label4.Text = "3. Кабель";
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();
            f3.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем Вас с приобретением товара!");
        }
        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем Вас с приобретением товара!");
        }

    }
}
