using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\source\\repos\\GPA_Calculator_App\\GPA_Calculator_App\\Database1.mdf;Integrated Security=True";

            GPA_Methods gPA_Methods = new GPA_Methods();
            List<double> scores = new List<double>();  //Lists are not fixed

            if (double.TryParse(textBox1.Text, out double s1))
            {
                scores.Add(s1);
            }

            if (double.TryParse(textBox1.Text, out double s2))
            {
                scores.Add(s2);
            }

            if (double.TryParse(textBox1.Text, out double s3))
            {
                scores.Add(s3);
            }

            if (double.TryParse(textBox1.Text, out double s4))
            {
                scores.Add(s4);
            }

            if (double.TryParse(textBox1.Text, out double s5))
            {
                scores.Add(s5);
            }

            double gpa = 0;

            switch (scores.Count)
            {
                case 1:
                    gpa = gPA_Methods.CalculateGPA(scores[0]);
                    break;

                case 2:
                    gpa = gPA_Methods.CalculateGPA(scores[0], scores[1]);
                    break;

                case 3:
                    gpa = gPA_Methods.CalculateGPA(scores[0], scores[1], scores[2]);
                    break;

                case 4:
                    gpa = gPA_Methods.CalculateGPA(scores[0], scores[1], scores[2], scores[3]);
                    break;

                case 5:
                    gpa = gPA_Methods.CalculateGPA(scores[0], scores[1], scores[2], scores[3], scores[4]);
                    break;

                default:
                    label9.Text = "Enter at least one score";
                    return;
            }

            label9.Text = $"GPA  :  {gpa:F2}";
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }
    }
}
