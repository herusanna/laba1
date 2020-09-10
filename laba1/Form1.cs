using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please, input number");
            }
            */
        }
        //получает обратную запись двоичного числа из дсятичного
        private Int64 vvod(Int64 temp)
        {
            Int64 temp1 = 0;
            List<Int64> s = new List<Int64>();
            while (temp > 0)
            {
                temp1 = temp % 2;
                temp = temp / 2;
                s.Add(temp1);
            }
            return obrat(s);
        }
        //переворачивает число и возвращает прямую запись двоичного числа.
        private Int64 obrat(List<Int64> norm)
        {
            Int64[] s = new Int64[norm.Count];
            for (int i = norm.Count - 1; i >= 0; i--)
            {
                s[norm.Count - 1 - i] = norm[i];
            }
            return Convert.ToInt64(string.Join<Int64>("", s));
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length == 5)
            {
                int a = Convert.ToInt32(inputBox.Text);

                outputBox.Text = vvod(a) + "";
            }
            else MessageBox.Show("error");


        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
