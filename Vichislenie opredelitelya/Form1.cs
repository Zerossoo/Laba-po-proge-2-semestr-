using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vichislenie_opredelitelya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")            {
                MessageBox.Show("ВВЕДИТЕ МАТРИЦУ!", "ВНИМАНИЕ");
                return;
            }
            double A1 = Convert.ToDouble(textBox1.Text);
            double A2 = Convert.ToDouble(textBox2.Text);
            double A3 = Convert.ToDouble(textBox3.Text);
            double A4 = Convert.ToDouble(textBox4.Text);
            double A5 = Convert.ToDouble(textBox5.Text);
            double A6 = Convert.ToDouble(textBox6.Text);
            double A7 = Convert.ToDouble(textBox7.Text);
            double A8 = Convert.ToDouble(textBox8.Text);
            double A9 = Convert.ToDouble(textBox9.Text);
            double opred = A1 * (A5 * A9 - A8 * A6) - A2 * (A4 * A9 - A7 * A6) + A3 * (A4 * A8 - A5 * A7);
            textBoxOpred.Text = "Ваш определитель равен:";
            textBoxOpred.AppendText(Environment.NewLine);
            textBoxOpred.Text += Convert.ToString(opred);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы можете вводить вещественные или целые числа", "Информация");
        }
    }
}
