namespace Student_Management
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.MaskedTextBox();
            this.tbName = new System.Windows.Forms.MaskedTextBox();
            this.tbID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gbIDCard = new System.Windows.Forms.GroupBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbPersonalPicture = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbStudentInfo.SuspendLayout();
            this.gbIDCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Managment";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.lblPhone);
            this.gbStudentInfo.Controls.Add(this.tbPhone);
            this.gbStudentInfo.Controls.Add(this.tbEmail);
            this.gbStudentInfo.Controls.Add(this.tbName);
            this.gbStudentInfo.Controls.Add(this.tbID);
            this.gbStudentInfo.Controls.Add(this.label1);
            this.gbStudentInfo.Controls.Add(this.rbFemale);
            this.gbStudentInfo.Controls.Add(this.rbMale);
            this.gbStudentInfo.Controls.Add(this.cbGrade);
            this.gbStudentInfo.Controls.Add(this.lblGrade);
            this.gbStudentInfo.Controls.Add(this.lblEmail);
            this.gbStudentInfo.Controls.Add(this.lblName);
            this.gbStudentInfo.Controls.Add(this.lblID);
            this.gbStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbStudentInfo.Location = new System.Drawing.Point(12, 54);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(349, 239);
            this.gbStudentInfo.TabIndex = 1;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Info";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 133);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(57, 17);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone :";
            // 
            // tbPhone
            // 
            this.tbPhone.HidePromptOnLeave = true;
            this.tbPhone.Location = new System.Drawing.Point(77, 130);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(254, 23);
            this.tbPhone.TabIndex = 12;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(77, 97);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(254, 23);
            this.tbEmail.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(77, 64);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(254, 23);
            this.tbName.TabIndex = 10;
            // 
            // tbID
            // 
            this.tbID.HidePromptOnLeave = true;
            this.tbID.Location = new System.Drawing.Point(77, 31);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(254, 23);
            this.tbID.TabIndex = 2;
            this.tbID.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gender :";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(157, 205);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(72, 21);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(77, 205);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 21);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "High",
            "Middle",
            "Low"});
            this.cbGrade.Location = new System.Drawing.Point(77, 164);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(254, 24);
            this.cbGrade.TabIndex = 2;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(6, 167);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(56, 17);
            this.lblGrade.TabIndex = 6;
            this.lblGrade.Text = "Grade :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(29, 17);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID :";
            // 
            // gbIDCard
            // 
            this.gbIDCard.BackColor = System.Drawing.SystemColors.Control;
            this.gbIDCard.Controls.Add(this.maskedTextBox6);
            this.gbIDCard.Controls.Add(this.maskedTextBox5);
            this.gbIDCard.Controls.Add(this.label2);
            this.gbIDCard.Controls.Add(this.maskedTextBox1);
            this.gbIDCard.Controls.Add(this.maskedTextBox2);
            this.gbIDCard.Controls.Add(this.maskedTextBox3);
            this.gbIDCard.Controls.Add(this.maskedTextBox4);
            this.gbIDCard.Controls.Add(this.label3);
            this.gbIDCard.Controls.Add(this.label4);
            this.gbIDCard.Controls.Add(this.label5);
            this.gbIDCard.Controls.Add(this.label6);
            this.gbIDCard.Controls.Add(this.label7);
            this.gbIDCard.Controls.Add(this.pbPersonalPicture);
            this.gbIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbIDCard.Location = new System.Drawing.Point(367, 54);
            this.gbIDCard.Name = "gbIDCard";
            this.gbIDCard.Size = new System.Drawing.Size(421, 239);
            this.gbIDCard.TabIndex = 2;
            this.gbIDCard.TabStop = false;
            this.gbIDCard.Text = "ID Card";
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(160, 206);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.ReadOnly = true;
            this.maskedTextBox6.Size = new System.Drawing.Size(254, 23);
            this.maskedTextBox6.TabIndex = 28;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(291, 22);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.ReadOnly = true;
            this.maskedTextBox5.Size = new System.Drawing.Size(124, 23);
            this.maskedTextBox5.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Phone :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(160, 160);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(254, 23);
            this.maskedTextBox1.TabIndex = 25;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(160, 114);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(254, 23);
            this.maskedTextBox2.TabIndex = 24;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(160, 68);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.ReadOnly = true;
            this.maskedTextBox3.Size = new System.Drawing.Size(254, 23);
            this.maskedTextBox3.TabIndex = 23;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.HidePromptOnLeave = true;
            this.maskedTextBox4.Location = new System.Drawing.Point(161, 22);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.ReadOnly = true;
            this.maskedTextBox4.Size = new System.Drawing.Size(115, 23);
            this.maskedTextBox4.TabIndex = 14;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Grade :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID :";
            // 
            // pbPersonalPicture
            // 
            this.pbPersonalPicture.Location = new System.Drawing.Point(6, 22);
            this.pbPersonalPicture.Name = "pbPersonalPicture";
            this.pbPersonalPicture.Size = new System.Drawing.Size(148, 135);
            this.pbPersonalPicture.TabIndex = 0;
            this.pbPersonalPicture.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnEmail,
            this.columnPhone,
            this.columnGrade,
            this.columnGender});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 345);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 276);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 200;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 150;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Phone";
            this.columnPhone.Width = 130;
            // 
            // columnGrade
            // 
            this.columnGrade.Text = "Grade";
            this.columnGrade.Width = 100;
            // 
            // columnGender
            // 
            this.columnGender.Text = "Gender";
            this.columnGender.Width = 100;
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::Student_Management.Properties.Resources.remove_user;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.Location = new System.Drawing.Point(259, 299);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 40);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Student_Management.Properties.Resources.add_user;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(151, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Student_Management.Properties.Resources.Printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Location = new System.Drawing.Point(12, 299);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 40);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbIDCard);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.gbIDCard.ResumeLayout(false);
            this.gbIDCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.MaskedTextBox tbEmail;
        private System.Windows.Forms.MaskedTextBox tbName;
        private System.Windows.Forms.MaskedTextBox tbID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.GroupBox gbIDCard;
        private System.Windows.Forms.PictureBox pbPersonalPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader columnGrade;
        private System.Windows.Forms.ColumnHeader columnGender;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}

