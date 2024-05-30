using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class Add_Student_Form : Form
    {
        Student newStudent = new Student();


        public Add_Student_Form()
        {
            InitializeComponent();
        }

        public void AddStudentbotton_Click(object sender, EventArgs e)
        {
            if (StudentIdTextbox.Text != "")
            {
                newStudent.StudentId = StudentIdTextbox.Text;
            }
            else
            {
                MessageBox.Show("Please enter Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (StudentNameTextbox.Text != "")
            {
                newStudent.StudentName = StudentNameTextbox.Text;
            }
            else
            {
                MessageBox.Show("Please enter Student Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (GpaTextbox.Text != "")
            {
                newStudent.GPA = Convert.ToDouble(GpaTextbox.Text);
            }
            else
            {
                MessageBox.Show("Please enter Student GPA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Program.studentlist.Add(newStudent);
        }
    }
}
