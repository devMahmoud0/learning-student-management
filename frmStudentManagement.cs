using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Management
{
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "" || tbName.Text == "" || tbEmail.Text == "" || tbPhone.Text == "" || cbGrade.Text == "" || (rbMale.Checked == false && rbFemale.Checked == false))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem Item = new ListViewItem(tbID.Text.Trim());

            Item.SubItems.Add(tbName.Text.Trim());
            Item.SubItems.Add(tbEmail.Text.Trim());
            Item.SubItems.Add(tbPhone.Text.Trim());
            Item.SubItems.Add(cbGrade.Text);

            if (rbMale.Checked)
            {
                Item.ImageIndex = 0;
                Item.SubItems.Add(rbMale.Text);
            }
            else
            {
                Item.SubItems.Add(rbFemale.Text);
                Item.ImageIndex = 1;
            }

            StudentListView.Items.Add(Item);

            tbID.Clear();
            tbName.Clear();
            tbEmail.Clear();
            tbPhone.Clear();
            cbGrade.SelectedIndex = -1;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            tbID.Focus();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (StudentListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StudentListView.SelectedItems[0].Remove();
        }

        private void StudentListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected == false)
            {
                pbPersonalPicture.BackgroundImage = null;
                tbStudentID.Text = "";
                tbStudentName.Text = "";
                tbStudentEmail.Text = "";
                tbStudentPhone.Text = "";
                tbStudentGrade.Text = "";
                tbStudentGender.Text = "";
                return;
            }

            pbPersonalPicture.BackgroundImage = LargeImageList.Images[e.Item.ImageIndex];

            tbStudentID.Text = e.Item.SubItems[0].Text;
            tbStudentName.Text = e.Item.SubItems[1].Text;
            tbStudentEmail.Text = e.Item.SubItems[2].Text;
            tbStudentPhone.Text = e.Item.SubItems[3].Text;
            tbStudentGrade.Text = e.Item.SubItems[4].Text;
            tbStudentGender.Text = e.Item.SubItems[5].Text;
        }

        // Fill the listview for testing
        private void btnFillStudents_Click(object sender, EventArgs e)
        {
            // Person 1 - Male
            ListViewItem Item1 = new ListViewItem("1001");
            Item1.SubItems.Add("Ahmed Hassan");
            Item1.SubItems.Add("ahmed.hassan@example.com");
            Item1.SubItems.Add("01012345678");
            Item1.SubItems.Add("Grade 10");
            Item1.ImageIndex = 0;
            Item1.SubItems.Add("Male");
            StudentListView.Items.Add(Item1);


            // Person 2 - Female
            ListViewItem Item2 = new ListViewItem("1002");
            Item2.SubItems.Add("Mariam Ali");
            Item2.SubItems.Add("mariam.ali@example.com");
            Item2.SubItems.Add("01123456789");
            Item2.SubItems.Add("Grade 11");
            Item2.ImageIndex = 1;
            Item2.SubItems.Add("Female");
            StudentListView.Items.Add(Item2);


            // Person 3 - Male
            ListViewItem Item3 = new ListViewItem("1003");
            Item3.SubItems.Add("Omar Mohamed");
            Item3.SubItems.Add("omar.mohamed@example.com");
            Item3.SubItems.Add("01234567890");
            Item3.SubItems.Add("Grade 12");
            Item3.ImageIndex = 0;
            Item3.SubItems.Add("Male");
            StudentListView.Items.Add(Item3);


            // Person 4 - Female
            ListViewItem Item4 = new ListViewItem("1004");
            Item4.SubItems.Add("Sara Ibrahim");
            Item4.SubItems.Add("sara.ibrahim@example.com");
            Item4.SubItems.Add("01098765432");
            Item4.SubItems.Add("Grade 10");
            Item4.ImageIndex = 1;
            Item4.SubItems.Add("Female");
            StudentListView.Items.Add(Item4);


            // Person 5 - Male
            ListViewItem Item5 = new ListViewItem("1005");
            Item5.SubItems.Add("Youssef Mahmoud");
            Item5.SubItems.Add("youssef.mahmoud@example.com");
            Item5.SubItems.Add("01187654321");
            Item5.SubItems.Add("Grade 11");
            Item5.ImageIndex = 0;
            Item5.SubItems.Add("Male");
            StudentListView.Items.Add(Item5);


            // Person 6 - Female
            ListViewItem Item6 = new ListViewItem("1006");
            Item6.SubItems.Add("Nour Ahmed");
            Item6.SubItems.Add("nour.ahmed@example.com");
            Item6.SubItems.Add("01276543210");
            Item6.SubItems.Add("Grade 12");
            Item6.ImageIndex = 1;
            Item6.SubItems.Add("Female");
            StudentListView.Items.Add(Item6);


            // Person 7 - Male
            ListViewItem Item7 = new ListViewItem("1007");
            Item7.SubItems.Add("Mostafa Adel");
            Item7.SubItems.Add("mostafa.adel@example.com");
            Item7.SubItems.Add("01065432109");
            Item7.SubItems.Add("Grade 10");
            Item7.ImageIndex = 0;
            Item7.SubItems.Add("Male");
            StudentListView.Items.Add(Item7);


            // Person 8 - Female
            ListViewItem Item8 = new ListViewItem("1008");
            Item8.SubItems.Add("Hana Samir");
            Item8.SubItems.Add("hana.samir@example.com");
            Item8.SubItems.Add("01154321098");
            Item8.SubItems.Add("Grade 11");
            Item8.ImageIndex = 1;
            Item8.SubItems.Add("Female");
            StudentListView.Items.Add(Item8);


            // Person 9 - Male
            ListViewItem Item9 = new ListViewItem("1009");
            Item9.SubItems.Add("Karim Tarek");
            Item9.SubItems.Add("karim.tarek@example.com");
            Item9.SubItems.Add("01243210987");
            Item9.SubItems.Add("Grade 12");
            Item9.ImageIndex = 0;
            Item9.SubItems.Add("Male");
            StudentListView.Items.Add(Item9);


            // Person 10 - Female
            ListViewItem Item10 = new ListViewItem("1010");
            Item10.SubItems.Add("Laila Mostafa");
            Item10.SubItems.Add("laila.mostafa@example.com");
            Item10.SubItems.Add("01032109876");
            Item10.SubItems.Add("Grade 10");
            Item10.ImageIndex = 1;
            Item10.SubItems.Add("Female");
            StudentListView.Items.Add(Item10);
        }

        private void ShowStudentInfoForm(bool IsCanEdit = false, ListViewItem item = null)
        {
            if (StudentListView.Items.Count == 0)
            {
                MessageBox.Show("There are no students to print!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StudentListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Form frm = new frmStudentInfo(pbPersonalPicture.BackgroundImage, tbStudentID.Text,
            //    tbStudentName.Text, tbStudentEmail.Text, tbStudentPhone.Text, tbStudentGrade.Text, tbStudentGender.Text, IsCanEdit);
            Form frm = new frmStudentInfo(this, item, IsCanEdit);
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ShowStudentInfoForm();
        }

        private void StudentListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowStudentInfoForm();
        }

        public Image PersonalPicture
        {
            get { return pbPersonalPicture.BackgroundImage; }
            set { pbPersonalPicture.BackgroundImage = value; }
        }

        public string StudentID
        {
            get { return tbStudentID.Text; }
            set { tbStudentID.Text = value; }
        }

        public string StudentName
        {
            get { return tbStudentName.Text; }
            set { tbStudentName.Text = value; }
        }

        public string StudentEmail
        {
            get { return tbStudentEmail.Text; }
            set { tbStudentEmail.Text = value; }
        }

        public string StudentPhone
        {
            get { return tbStudentPhone.Text; }
            set { tbStudentPhone.Text = value; }
        }

        public string StudentGrade
        {
            get { return tbStudentGrade.Text; }
            set { tbStudentGrade.Text = value; }
        }

        public string StudentGender
        {
            get { return tbStudentGender.Text; }
            set { tbStudentGender.Text = value; }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            ListViewItem item = StudentListView.SelectedItems[0];
            ShowStudentInfoForm(true, item);
        }
    }
}
