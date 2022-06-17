
namespace Semester_Grades
{
    partial class Semester_grades_app
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_c1 = new System.Windows.Forms.Label();
            this.lbl_c2 = new System.Windows.Forms.Label();
            this.lbl_c3 = new System.Windows.Forms.Label();
            this.lbl_c4 = new System.Windows.Forms.Label();
            this.lbl_c5 = new System.Windows.Forms.Label();
            this.lbl_c6 = new System.Windows.Forms.Label();
            this.textBox_c1 = new System.Windows.Forms.TextBox();
            this.textBox_c2 = new System.Windows.Forms.TextBox();
            this.textBox_c3 = new System.Windows.Forms.TextBox();
            this.textBox_c4 = new System.Windows.Forms.TextBox();
            this.textBox_c5 = new System.Windows.Forms.TextBox();
            this.textBox_c6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_sem_avg = new System.Windows.Forms.Label();
            this.lbl_sem_grade = new System.Windows.Forms.Label();
            this.lbl_error_log = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.toolTip_Calculate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Reset = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Exit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_sem_grade = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_sem_avg_marks = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_course = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_c1
            // 
            this.lbl_c1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_c1.Location = new System.Drawing.Point(362, 51);
            this.lbl_c1.Name = "lbl_c1";
            this.lbl_c1.Size = new System.Drawing.Size(125, 27);
            this.lbl_c1.TabIndex = 0;
            // 
            // lbl_c2
            // 
            this.lbl_c2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_c2.Location = new System.Drawing.Point(362, 89);
            this.lbl_c2.Name = "lbl_c2";
            this.lbl_c2.Size = new System.Drawing.Size(125, 27);
            this.lbl_c2.TabIndex = 1;
            // 
            // lbl_c3
            // 
            this.lbl_c3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_c3.Location = new System.Drawing.Point(362, 130);
            this.lbl_c3.Name = "lbl_c3";
            this.lbl_c3.Size = new System.Drawing.Size(125, 27);
            this.lbl_c3.TabIndex = 2;
            // 
            // lbl_c4
            // 
            this.lbl_c4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_c4.Location = new System.Drawing.Point(362, 169);
            this.lbl_c4.Name = "lbl_c4";
            this.lbl_c4.Size = new System.Drawing.Size(125, 27);
            this.lbl_c4.TabIndex = 3;
            // 
            // lbl_c5
            // 
            this.lbl_c5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_c5.Location = new System.Drawing.Point(362, 209);
            this.lbl_c5.Name = "lbl_c5";
            this.lbl_c5.Size = new System.Drawing.Size(125, 27);
            this.lbl_c5.TabIndex = 4;
            // 
            // lbl_c6
            // 
            this.lbl_c6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_c6.Location = new System.Drawing.Point(362, 248);
            this.lbl_c6.Name = "lbl_c6";
            this.lbl_c6.Size = new System.Drawing.Size(125, 27);
            this.lbl_c6.TabIndex = 5;
            // 
            // textBox_c1
            // 
            this.textBox_c1.Location = new System.Drawing.Point(194, 51);
            this.textBox_c1.Name = "textBox_c1";
            this.textBox_c1.Size = new System.Drawing.Size(125, 27);
            this.textBox_c1.TabIndex = 6;
            this.toolTip_course.SetToolTip(this.textBox_c1, "Enter marks between 1 and 100");
            this.textBox_c1.Leave += new System.EventHandler(this.textBox_c1_Leave);
            // 
            // textBox_c2
            // 
            this.textBox_c2.Location = new System.Drawing.Point(194, 89);
            this.textBox_c2.Name = "textBox_c2";
            this.textBox_c2.Size = new System.Drawing.Size(125, 27);
            this.textBox_c2.TabIndex = 7;
            this.toolTip_course.SetToolTip(this.textBox_c2, "Enter marks between 1 and 100");
            this.textBox_c2.Leave += new System.EventHandler(this.textBox_c2_Leave);
            // 
            // textBox_c3
            // 
            this.textBox_c3.Location = new System.Drawing.Point(194, 130);
            this.textBox_c3.Name = "textBox_c3";
            this.textBox_c3.Size = new System.Drawing.Size(125, 27);
            this.textBox_c3.TabIndex = 8;
            this.toolTip_course.SetToolTip(this.textBox_c3, "Enter marks between 1 and 100");
            this.textBox_c3.Leave += new System.EventHandler(this.textBox_c3_Leave);
            // 
            // textBox_c4
            // 
            this.textBox_c4.Location = new System.Drawing.Point(194, 169);
            this.textBox_c4.Name = "textBox_c4";
            this.textBox_c4.Size = new System.Drawing.Size(125, 27);
            this.textBox_c4.TabIndex = 9;
            this.toolTip_course.SetToolTip(this.textBox_c4, "Enter marks between 1 and 100");
            this.textBox_c4.Leave += new System.EventHandler(this.textBox_c4_Leave);
            // 
            // textBox_c5
            // 
            this.textBox_c5.Location = new System.Drawing.Point(194, 209);
            this.textBox_c5.Name = "textBox_c5";
            this.textBox_c5.Size = new System.Drawing.Size(125, 27);
            this.textBox_c5.TabIndex = 10;
            this.toolTip_course.SetToolTip(this.textBox_c5, "Enter marks between 1 and 100");
            this.textBox_c5.Leave += new System.EventHandler(this.textBox_c5_Leave);
            // 
            // textBox_c6
            // 
            this.textBox_c6.Location = new System.Drawing.Point(194, 252);
            this.textBox_c6.Name = "textBox_c6";
            this.textBox_c6.Size = new System.Drawing.Size(125, 27);
            this.textBox_c6.TabIndex = 11;
            this.toolTip_course.SetToolTip(this.textBox_c6, "Enter marks between 1 and 100");
            this.textBox_c6.Leave += new System.EventHandler(this.textBox_c6_Leave);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(63, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Course 6:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(63, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "Course 5:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(63, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = "Course 4:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(63, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 27);
            this.label10.TabIndex = 14;
            this.label10.Text = "Course 3:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(63, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 27);
            this.label11.TabIndex = 13;
            this.label11.Text = "Course 2:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(63, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 27);
            this.label12.TabIndex = 12;
            this.label12.Text = "Course 1:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(63, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 27);
            this.label13.TabIndex = 18;
            this.label13.Text = "Semester";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sem_avg
            // 
            this.lbl_sem_avg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_sem_avg.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sem_avg.Location = new System.Drawing.Point(194, 297);
            this.lbl_sem_avg.Name = "lbl_sem_avg";
            this.lbl_sem_avg.Size = new System.Drawing.Size(125, 27);
            this.lbl_sem_avg.TabIndex = 19;
            this.toolTip_sem_avg_marks.SetToolTip(this.lbl_sem_avg, "Shows average marks of the 6 courses.");
            // 
            // lbl_sem_grade
            // 
            this.lbl_sem_grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_sem_grade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sem_grade.Location = new System.Drawing.Point(362, 297);
            this.lbl_sem_grade.Name = "lbl_sem_grade";
            this.lbl_sem_grade.Size = new System.Drawing.Size(125, 27);
            this.lbl_sem_grade.TabIndex = 20;
            this.toolTip_sem_grade.SetToolTip(this.lbl_sem_grade, "Average grade for semester.");
            // 
            // lbl_error_log
            // 
            this.lbl_error_log.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_error_log.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_error_log.Location = new System.Drawing.Point(12, 341);
            this.lbl_error_log.Name = "lbl_error_log";
            this.lbl_error_log.Size = new System.Drawing.Size(530, 245);
            this.lbl_error_log.TabIndex = 21;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(248, 608);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(94, 29);
            this.btn_Exit.TabIndex = 22;
            this.btn_Exit.Text = "&Calculate";
            this.toolTip_Calculate.SetToolTip(this.btn_Exit, "Button to calculate average and grade");
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Location = new System.Drawing.Point(348, 608);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(94, 29);
            this.btn_Reset.TabIndex = 23;
            this.btn_Reset.Text = "&Reset";
            this.toolTip_Reset.SetToolTip(this.btn_Reset, "To reset application.");
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculate.Location = new System.Drawing.Point(448, 608);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(94, 29);
            this.btn_calculate.TabIndex = 24;
            this.btn_calculate.Text = "&Exit";
            this.toolTip_Exit.SetToolTip(this.btn_calculate, "Close Application.");
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click_1);
            // 
            // Semester_grades_app
            // 
            this.AcceptButton = this.btn_calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Reset;
            this.ClientSize = new System.Drawing.Size(554, 649);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_error_log);
            this.Controls.Add(this.lbl_sem_grade);
            this.Controls.Add(this.lbl_sem_avg);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_c6);
            this.Controls.Add(this.textBox_c5);
            this.Controls.Add(this.textBox_c4);
            this.Controls.Add(this.textBox_c3);
            this.Controls.Add(this.textBox_c2);
            this.Controls.Add(this.textBox_c1);
            this.Controls.Add(this.lbl_c6);
            this.Controls.Add(this.lbl_c5);
            this.Controls.Add(this.lbl_c4);
            this.Controls.Add(this.lbl_c3);
            this.Controls.Add(this.lbl_c2);
            this.Controls.Add(this.lbl_c1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Semester_grades_app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semester Grades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_c1;
        private System.Windows.Forms.Label lbl_c2;
        private System.Windows.Forms.Label lbl_c3;
        private System.Windows.Forms.Label lbl_c4;
        private System.Windows.Forms.Label lbl_c5;
        private System.Windows.Forms.Label lbl_c6;
        private System.Windows.Forms.TextBox textBox_c1;
        private System.Windows.Forms.TextBox textBox_c2;
        private System.Windows.Forms.TextBox textBox_c3;
        private System.Windows.Forms.TextBox textBox_c4;
        private System.Windows.Forms.TextBox textBox_c5;
        private System.Windows.Forms.TextBox textBox_c6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_sem_avg;
        private System.Windows.Forms.Label lbl_sem_grade;
        private System.Windows.Forms.Label lbl_error_log;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.ToolTip toolTip_Calculate;
        private System.Windows.Forms.ToolTip toolTip_Reset;
        private System.Windows.Forms.ToolTip toolTip_Exit;
        private System.Windows.Forms.ToolTip toolTip_sem_avg_marks;
        private System.Windows.Forms.ToolTip toolTip_sem_grade;
        private System.Windows.Forms.ToolTip toolTip_course;
    }
}

