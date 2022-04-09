using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        int[] mas = new int[25];
        int[] changed_mas = new int[25];
        public Form1()
        {
            InitializeComponent();
        }
        public void output_mas(int[] b, TextBox textBox)
        {
            textBox.Clear();
            for (int i = 0; i < b.Length; i++)
            {
                textBox.Text += ("mas[" + i + "] = " + b[i]);
                textBox.Text += Environment.NewLine;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i<mas.Length; i++)
            {
                mas[i] = random.Next(-20, 20);
            }
            output_mas(mas, textBox1);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<mas.Length; i++)
            {
                if (mas[i] < 0) changed_mas[i] = mas[i] * mas[i];
                else
                    if (mas[i] > 0) changed_mas[i] = mas[i] + 7;
                else
                    changed_mas[i] = 0;
            }
            output_mas(changed_mas, textBox2);
        }
    }
}
