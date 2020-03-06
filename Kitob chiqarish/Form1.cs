using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitob_chiqarish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = "";
                textBox3.Text = "";
                int n = int.Parse(textBox1.Text);
                int n1 = n % 4 == 0 ? n : n + 4 - n % 4;
                for (int i = n1, j = 1; i > n1 / 2 && j < n1 / 2; i -= 2, j += 2)
                {
                    textBox2.Text += Convert.ToString(i + "," + j + ",");
                }
                for (int i = n1 / 2, j = n1 / 2 + 1; i > 0 && j < n1; i -= 2, j += 2)
                {
                    textBox3.Text += Convert.ToString(i + "," + j + ",");
                }
                label6.Text = "Hujjatingiz oxiriga " + Convert.ToString(n1 - n) + " ta bo'sh varoq qo'shing. Varoq qo'shish: Ctrl+Enter. Shunda " + Convert.ToString(n1 / 4) + " ta varoqda " + Convert.ToString(n1) + " bet joylashadi.";
                label7.Text = "Word yoki Adobe Reader dasturida Ctrl+P tugmalarini birgalikda bosing. Kitobni 2 betini 1 ta varoqda chiqarishga sozlang.";
                label8.Text = "Quyida berilganlardan nusxa olib(Копировать), chop etish(Печать) oynasida sahifalar(Страницы) qismiga joylang(Вставить). Printerga " + Convert.ToString(n1 / 4) + " ta qog'oz qo'ying va chop etish uchun OK yoki Печать tugmasini bosing.";
                label9.Text = "Chiqqan qog'ozlarni hech qanday aylantirmasdan, bo'sh tomoni bilan yana printerga qo'ying. Yana Ctrl+P tugmalarini birgalikda bosing. Kitobni 2 betini 1 ta varoqda chiqarishga sozlang. Endi quyida berilganlarni sahifalar qismiga joylang. OK yoki Печать tugmasini bosing.";
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
            catch
            {
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox2.Text);
            }
            catch
            {
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox3.Text);
            }
            catch
            {
                textBox1.Focus();
            }
        }
        private void label10_MouseDown(object sender, MouseEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox1))
                        button1.Select();
                    else
                        button1.Select();
                }
                return;
            }
            e.Handled = true;
        }

        
        
    }
}
