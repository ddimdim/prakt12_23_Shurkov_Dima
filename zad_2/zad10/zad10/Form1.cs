using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad10
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int oops = 0;
            if (textBox1.Text.Length <= 3)
            {
                MessageBox.Show("В фамилии должно быть больше букв", "Ошибка");
                oops++;
            }
            if (textBox3.Text.Length <= 3)
            {
                MessageBox.Show("В отчестве должно быть больше букв", "Ошибка");
                oops++;
            }
                for (int i = 0; i < textBox5.Text.Length; i++)
                {
                    if (!Char.IsNumber(textBox5.Text[i]))
                    {
                         MessageBox.Show("Для ввода номера кредитной карты можно использовать только цифры", "Ошибка");
                         oops++;
                         break;
                    }
                }
                for (int i = 0; i < textBox6.Text.Length; i++)
                {
                    if (!Char.IsNumber(textBox6.Text[i]))
                    {
                         MessageBox.Show("Для ввода номера банковского счета можно использовать только цифры", "Ошибка");
                         oops++;
                         break;
                    }
                }
            if (textBox5.Text.Length != 8)
            {
                MessageBox.Show("Номер кредитной карты должен состоять из 8 цифр", "Ошибка");
                oops++;
            }
            if (textBox6.Text.Length != 6)
            {
                MessageBox.Show("Номер банковского счета должен состоять из 6 цифр", "Ошибка");
                oops++;
            }
            if (oops == 0)
            {
                string surname = textBox1.Text;
                string name = textBox2.Text;
                string otchestvo = textBox3.Text;
                string adress = textBox4.Text;
                long numk = Convert.ToInt64(textBox5.Text);
                int numb = Convert.ToInt32(textBox6.Text);
                listBox1.Items.Add(surname + " " + name + " " + otchestvo + " " + adress + " " + numk + " " + numb);
                listBox1.Sorted = true;
                Buyer newBuyer = new Buyer(surname, name, otchestvo, adress, numk, numb);
                newBuyer.Set(surname, name, otchestvo, adress, numk, numb);
                newBuyer.Get(surname, name, otchestvo, adress, numk, numb);
                if (numk>=20000000 && numk<=29999999)
                {
                    listBox2.Items.Add(surname + " " + name + " " + otchestvo + " " + adress + " " + numk + " " + numb);
                }
                newBuyer.Print();
            }


        }
    }
}
