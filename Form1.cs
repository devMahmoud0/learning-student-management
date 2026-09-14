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
    public partial class Form1 : Form
    {
        public Form1()
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

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (StudentListView.SelectedItems.Count == 0)
                return;

            StudentListView.SelectedItems[0].Remove();
        }
    }
}
