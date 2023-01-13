using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form4 : Form
    {
        private System.Windows.Forms.Timer holder;
        private int i = 0;

        public void SysInfo()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start(); stopWatch.Stop();
            MessageBox.Show("Время выполнени метода в миллисекундах " + System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + stopWatch.Elapsed + " или " + stopWatch.ElapsedTicks + " тактов");
        }
        public Form4()
        {
            InitializeComponent();
            label1.Text = "Ожидайте выполнение заказа, данные отправляются на сервер...";


            progressBar1.Maximum = 100;
            progressBar1.Value = 30;

            holder = new Timer { Interval = 1000 };
            holder.Tick += HolderTick;
            holder.Enabled = true;

        }
        private void HolderTick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                label1.Text = "Данные обрабатываются...";
                progressBar1.Value = 60;
                i++;
            }
            if (i == 1)
            {
                label1.Text = "Заказ подтверждается...";
                progressBar1.Value = 80;
                i++;
            }
            else
            {
                label1.Text = "Заказ успешно подтверждён! Благодарим за покупку!";
                progressBar1.Value = 100;
                holder.Enabled = false;
                SysInfo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
