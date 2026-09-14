namespace Student_Management
{
    partial class frmStudentInfo
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
            this.gbIDCard = new System.Windows.Forms.GroupBox();
            this.tbStudentGrade = new System.Windows.Forms.MaskedTextBox();
            this.tbStudentGender = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStudentPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbStudentEmail = new System.Windows.Forms.MaskedTextBox();
            this.tbStudentName = new System.Windows.Forms.MaskedTextBox();
            this.tbStudentID = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbPersonalPicture = new System.Windows.Forms.PictureBox();
            this.gbIDCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIDCard
            // 
            this.gbIDCard.BackColor = System.Drawing.SystemColors.Control;
            this.gbIDCard.Controls.Add(this.tbStudentGrade);
            this.gbIDCard.Controls.Add(this.tbStudentGender);
            this.gbIDCard.Controls.Add(this.label2);
            this.gbIDCard.Controls.Add(this.tbStudentPhone);
            this.gbIDCard.Controls.Add(this.tbStudentEmail);
            this.gbIDCard.Controls.Add(this.tbStudentName);
            this.gbIDCard.Controls.Add(this.tbStudentID);
            this.gbIDCard.Controls.Add(this.label3);
            this.gbIDCard.Controls.Add(this.label4);
            this.gbIDCard.Controls.Add(this.label5);
            this.gbIDCard.Controls.Add(this.label6);
            this.gbIDCard.Controls.Add(this.label7);
            this.gbIDCard.Controls.Add(this.pbPersonalPicture);
            this.gbIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbIDCard.Location = new System.Drawing.Point(12, 12);
            this.gbIDCard.Name = "gbIDCard";
            this.gbIDCard.Size = new System.Drawing.Size(421, 239);
            this.gbIDCard.TabIndex = 3;
            this.gbIDCard.TabStop = false;
            this.gbIDCard.Text = "ID Card";
            // 
            // tbStudentGrade
            // 
            this.tbStudentGrade.Location = new System.Drawing.Point(160, 206);
            this.tbStudentGrade.Name = "tbStudentGrade";
            this.tbStudentGrade.ReadOnly = true;
            this.tbStudentGrade.Size = new System.Drawing.Size(254, 23);
            this.tbStudentGrade.TabIndex = 28;
            // 
            // tbStudentGender
            // 
            this.tbStudentGender.Location = new System.Drawing.Point(291, 22);
            this.tbStudentGender.Name = "tbStudentGender";
            this.tbStudentGender.ReadOnly = true;
            this.tbStudentGender.Size = new System.Drawing.Size(124, 23);
            this.tbStudentGender.TabIndex = 27;
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
            // tbStudentPhone
            // 
            this.tbStudentPhone.Location = new System.Drawing.Point(160, 160);
            this.tbStudentPhone.Name = "tbStudentPhone";
            this.tbStudentPhone.ReadOnly = true;
            this.tbStudentPhone.Size = new System.Drawing.Size(254, 23);
            this.tbStudentPhone.TabIndex = 25;
            // 
            // tbStudentEmail
            // 
            this.tbStudentEmail.Location = new System.Drawing.Point(160, 114);
            this.tbStudentEmail.Name = "tbStudentEmail";
            this.tbStudentEmail.ReadOnly = true;
            this.tbStudentEmail.Size = new System.Drawing.Size(254, 23);
            this.tbStudentEmail.TabIndex = 24;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(160, 68);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.ReadOnly = true;
            this.tbStudentName.Size = new System.Drawing.Size(254, 23);
            this.tbStudentName.TabIndex = 23;
            // 
            // tbStudentID
            // 
            this.tbStudentID.HidePromptOnLeave = true;
            this.tbStudentID.Location = new System.Drawing.Point(161, 22);
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.ReadOnly = true;
            this.tbStudentID.Size = new System.Drawing.Size(115, 23);
            this.tbStudentID.TabIndex = 14;
            this.tbStudentID.ValidatingType = typeof(int);
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
            this.pbPersonalPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonalPicture.Location = new System.Drawing.Point(6, 22);
            this.pbPersonalPicture.Name = "pbPersonalPicture";
            this.pbPersonalPicture.Size = new System.Drawing.Size(148, 135);
            this.pbPersonalPicture.TabIndex = 0;
            this.pbPersonalPicture.TabStop = false;
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 262);
            this.Controls.Add(this.gbIDCard);
            this.Name = "frmStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info";
            this.gbIDCard.ResumeLayout(false);
            this.gbIDCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIDCard;
        private System.Windows.Forms.MaskedTextBox tbStudentGrade;
        private System.Windows.Forms.MaskedTextBox tbStudentGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbStudentPhone;
        private System.Windows.Forms.MaskedTextBox tbStudentEmail;
        private System.Windows.Forms.MaskedTextBox tbStudentName;
        private System.Windows.Forms.MaskedTextBox tbStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbPersonalPicture;
    }
}