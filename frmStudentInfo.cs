using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_Management
{
    public partial class frmStudentInfo : Form
    {
        private frmStudentManagement _BaseForm;
        private ListViewItem _item;

        public frmStudentInfo(frmStudentManagement BaseForm, ListViewItem item = null, bool IsCanEdit = false)
        {
            InitializeComponent();

            if (IsCanEdit)
            {
                this.Size = new Size(461, 355);
                this.Text = "Edit Student Info";
                _item = item;
                btnSave.Enabled = true;
                btnSave.Visible = true;
                btnClose.Enabled = true;
                btnClose.Visible = true;
                tbStudentID.ReadOnly = false;
                tbStudentName.ReadOnly = false;
                tbStudentEmail.ReadOnly = false;
                tbStudentPhone.ReadOnly = false;
                tbStudentGrade.ReadOnly = false;
                tbStudentGender.ReadOnly = false;
            }

            _BaseForm = BaseForm;

            pbPersonalPicture.BackgroundImage = _BaseForm.PersonalPicture;
            tbStudentID.Text = _BaseForm.StudentID;
            tbStudentName.Text = _BaseForm.StudentName;
            tbStudentEmail.Text = _BaseForm.StudentEmail;
            tbStudentPhone.Text = _BaseForm.StudentPhone;
            tbStudentGrade.Text = _BaseForm.StudentGrade;
            tbStudentGender.Text = _BaseForm.StudentGender;
        }

        private void UpdateStudentInfoCard()
        {
            _BaseForm.StudentID = tbStudentID.Text.Trim();
            _BaseForm.StudentName = tbStudentName.Text.Trim();
            _BaseForm.StudentEmail = tbStudentEmail.Text.Trim();
            _BaseForm.StudentPhone = tbStudentPhone.Text.Trim();
            _BaseForm.StudentGrade = tbStudentGrade.Text.Trim();
            _BaseForm.StudentGender = tbStudentGender.Text.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbStudentID.Text == "" || tbStudentName.Text == "" || tbStudentEmail.Text == "" || tbStudentPhone.Text == "" || tbStudentGrade.Text == "" || tbStudentGender.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _item.SubItems[0].Text = tbStudentID.Text.Trim();
            _item.SubItems[1].Text = tbStudentName.Text.Trim();
            _item.SubItems[2].Text = tbStudentEmail.Text.Trim();
            _item.SubItems[3].Text = tbStudentPhone.Text.Trim();
            _item.SubItems[4].Text = tbStudentGrade.Text.Trim();
            _item.SubItems[5].Text = tbStudentGender.Text.Trim();

            UpdateStudentInfoCard();

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
