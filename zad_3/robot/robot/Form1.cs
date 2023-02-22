using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robot
{
    public partial class Robot : Form
    {
        public Robot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                robot robot1 = new robot();
                robot robot2 = new robot();
                robot robot3 = new robot();
                Random rnd = new Random();
                int b = rnd.Next(0, 100);
                robot1.min(b);
                robot1.kollife = Convert.ToInt32(textBox1.Text);
                label1.Text = "Количество жизней 1-ого робота в начале игры " + robot1.kollife;
                robot2.kollife = Convert.ToInt32(textBox2.Text);
                label7.Text = "Количество жизней 2-ого робота в начале игры " + robot2.kollife;
                robot3.kollife = Convert.ToInt32(textBox3.Text);
                label9.Text = "Количество жизней 3-его робота в начале игры " + robot3.kollife;
                int a = robot1.kollife;
                robot1.min(robot1.kollife);
                label2.Text = "Количество жизней 1-ого робота после игры " + Convert.ToString(robot1.getlife());
                robot2.kol(a, robot1.kollife);
                label6.Text = "Количество жизней 2-ого робота после игры " + Convert.ToString(robot2.getlife());
                robot3.kol(a, robot1.kollife);
                label8.Text = "Количество жизней 3-его робота после игры " + Convert.ToString(robot3.getlife());
            }
            catch
            {
                MessageBox.Show("Неверно введены данные", "Ошибка");
            }
        }
    }
}
