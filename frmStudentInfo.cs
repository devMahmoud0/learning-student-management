using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo(Image PersonalPicture, string StudentID, string StudentName, string StudentEmail, string StudentPhone, string StudentGrade, string StudentGender)
        {
            InitializeComponent();

            pbPersonalPicture.BackgroundImage = PersonalPicture;
            tbStudentID.Text = StudentID;
            tbStudentName.Text = StudentName;
            tbStudentEmail.Text = StudentEmail;
            tbStudentPhone.Text = StudentPhone;
            tbStudentGrade.Text = StudentGrade;
            tbStudentGender.Text = StudentGender;
        }
    }
}
