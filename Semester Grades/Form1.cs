using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Grades
{
    public partial class Semester_grades_app : Form
    {
        double[] courses_marks = new double[6];

        public Semester_grades_app()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private bool validate(string number)
        {
            try {
                double number1 = double.Parse(number);
                if (number1 < 0 || number1 > 100)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        private string convert_marks(double marks)
        {
            if (marks < 50)
                return "F";
            else if (marks < 53)
                return "D-";
            else if (marks < 57)
                return "D";
            else if (marks < 60)
                return "D+";
            else if (marks < 63)
                return "C-";
            else if (marks < 67)
                return "C";
            else if (marks < 70)
                return "C+";
            else if (marks < 73)
                return "B-";
            else if (marks < 77)
                return "B";
            else if (marks < 80)
                return "B+";
            else if (marks < 85)
                return "A-";
            else if (marks < 90)
                return "A";
            else
                return "A+";
        }

        private void textBox_c1_Leave(object sender, EventArgs e)
        {
            lbl_c1.Text = "";
            if (validate(textBox_c1.Text))
            {
                double marks = double.Parse(textBox_c1.Text);
                lbl_c1.Text = convert_marks(marks);
                courses_marks[0] = marks;
            }
            else
            {
                textBox_c1.Clear();
                if (lbl_error_log.Text.Length > 100)
                    lbl_error_log.Text = "Errors";

                lbl_error_log.Text = lbl_error_log.Text + "\n please ensure what you input in course 1 is a number between 0 and 100!";
            }

        }

        private void textBox_c2_Leave(object sender, EventArgs e)
        {
            lbl_c2.Text = "";
            if (validate(textBox_c2.Text))
            {
                double marks = double.Parse(textBox_c2.Text);
                lbl_c2.Text = convert_marks(marks);
                courses_marks[1] = marks;
            }
            else
            {
                textBox_c2.Clear();
                if (lbl_error_log.Text.Length > 100)
                    lbl_error_log.Text = "Errors";

                lbl_error_log.Text = lbl_error_log.Text + "\n please ensure what you input in course 2 is a number between 0 and 100!";
            }


        }

        private void textBox_c3_Leave(object sender, EventArgs e)
        {
            lbl_c3.Text = "";
            if (validate(textBox_c3.Text))
            {
                double marks = double.Parse(textBox_c3.Text);
                lbl_c3.Text = convert_marks(marks);
                courses_marks[2] = marks;
            }
            else
            {
                textBox_c3.Clear();
                if (lbl_error_log.Text.Length > 100)
                    lbl_error_log.Text = "Errors";

                lbl_error_log.Text = lbl_error_log.Text + "\n please ensure what you input in course 3 is a number between 0 and 100!";
            }

        }

        private void textBox_c4_Leave(object sender, EventArgs e)
        {
            lbl_c4.Text = "";
            if (validate(textBox_c4.Text))
            {
                double marks = double.Parse(textBox_c4.Text);
                lbl_c4.Text = convert_marks(marks);
                courses_marks[3] = marks;
            }
            else
            {
                textBox_c4.Clear();
                if (lbl_error_log.Text.Length > 100)
                    lbl_error_log.Text = "Errors";
                lbl_error_log.Text = lbl_error_log.Text +  "\n please ensure what you input in course 4 is a number between 0 and 100!";
            }

        }

        private void textBox_c5_Leave(object sender, EventArgs e)
        {
            lbl_c5.Text = "";
            if (validate(textBox_c5.Text))
            {
                double marks = double.Parse(textBox_c5.Text);
                lbl_c5.Text = convert_marks(marks);
                courses_marks[4] = marks;
            }
            else
            {
                textBox_c5.Clear();
                if (lbl_error_log.Text.Length > 100)
                    lbl_error_log.Text = "Errors";

                lbl_error_log.Text = lbl_error_log.Text + "\n please ensure what you input in course 5 is a number between 0 and 100!";
            }

        }

        private void textBox_c6_Leave(object sender, EventArgs e)
        {
            lbl_c6.Text = "";
            if (validate(textBox_c6.Text))
            {
                double marks = double.Parse(textBox_c6.Text);
                lbl_c6.Text = convert_marks(marks);
                courses_marks[5] = marks;
            }
            else
            {
                textBox_c6.Clear();
                if (lbl_error_log.Text.Length > 100)
                    lbl_error_log.Text = "Errors";

                lbl_error_log.Text = lbl_error_log.Text + "\n please ensure what you input in course 6 is a number between 0 and 100!";
            }

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

            if (textBox_c1.Text == "" || textBox_c2.Text == "" || textBox_c3.Text == "" || textBox_c4.Text == "" || textBox_c5.Text == "" || textBox_c6.Text == "")
            {
                if (lbl_error_log.Text.Length > 100)
                    lbl_error_log.Text = "Errors";

                lbl_error_log.Text = lbl_error_log.Text + " \nplease ensure what you input in course 1 -6 are a number between 0 and 100! ";
            }
            else
            {
                textBox_c1.Enabled = false;
                textBox_c2.Enabled = false;
                textBox_c3.Enabled = false;
                textBox_c4.Enabled = false;
                textBox_c5.Enabled = false;
                textBox_c6.Enabled = false;

                double average = courses_marks.Average();
                string sem_grade = convert_marks(Math.Round(average, 2));
                lbl_sem_avg.Text = Math.Round(average,2) + "";
                lbl_sem_grade.Text = sem_grade;

            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            courses_marks = new double[6];
            textBox_c1.Clear();
            textBox_c2.Clear();
            textBox_c3.Clear();
            textBox_c4.Clear();
            textBox_c5.Clear();
            textBox_c6.Clear();


            textBox_c1.Enabled = true;
            textBox_c2.Enabled = true;
            textBox_c3.Enabled = true;
            textBox_c4.Enabled = true;
            textBox_c5.Enabled = true;
            textBox_c6.Enabled = true;
            
            lbl_c1.Text = "";
            lbl_c2.Text = "";
            lbl_c3.Text = "";
            lbl_c4.Text = "";
            lbl_c5.Text = "";
            lbl_c6.Text = "";

            lbl_error_log.Text = "";
            lbl_sem_avg.Text = "";
            lbl_sem_grade.Text = "";
        }

        private void btn_calculate_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
