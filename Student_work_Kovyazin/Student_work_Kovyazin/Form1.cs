using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_work_Kovyazin
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
       
        private void button1_Click(object sender, EventArgs e)
        {
            bool digit = true;
            string famname = textBox1.Text;
            if (famname == String.Empty)
                MessageBox.Show("Ячейка фамилия и имя  пуста!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (famname != String.Empty)
                {
                    foreach (char k in textBox1.Text)
                    {
                        if (char.IsDigit(k))
                        {
                            MessageBox.Show("Можно вводить только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            digit = false;
                            break;
                        }
                    }
                }
         
             if  (digit == true && famname != String.Empty)
            {


                Student stud = new Student();
                stud.name = textBox1.Text;
                stud.rost = (int)numericUpDown1.Value;
                double eda;
                MessageBox.Show(string.Format("\nСейчас: \nСтудент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()));
                eda = 1;
                stud.SetEat(eda);
                MessageBox.Show(string.Format("\n1 еда \nСтудент: {0} \nрост: {1} \nвес: {2} ", stud.name, stud.rost, stud.GetEat()));
                eda = 5;
                stud.SetEat(eda);
                MessageBox.Show(string.Format("\n5 еда \nСтудент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()));
                eda = 9;
                stud.SetEat(eda);
                MessageBox.Show(string.Format("\n9 еда \nСтудент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()));
                eda = 12;
                stud.SetEat(eda);
                MessageBox.Show(string.Format("\n12 еда \nСтудент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()));
            }

           



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
