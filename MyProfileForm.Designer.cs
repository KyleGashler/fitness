namespace KGmyFitnessApp
{

    // Name: Kyle Gashler
    // Class: (INFO 1200)
    // Section: (001)
    // Professor: Kody Crandall
    // Date: 9/16/2017
    // Project #: 1
    // I declare that the source code contained in this assignment was written solely by me.
    // I understand that copying any source code, in whole or in part,
    // constitutes cheating, and that I will receive a zero on this project
    // if I am found in violation of this policy.

    partial class MyProfileForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirst = new System.Windows.Forms.TextBox();
            this.lblPreferred = new System.Windows.Forms.Label();
            this.txtBoxPref = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxLast = new System.Windows.Forms.TextBox();
            this.btnCloseMyProfile = new System.Windows.Forms.Button();
            this.grpBoxName = new System.Windows.Forms.GroupBox();
            this.grpBoxMyStats = new System.Windows.Forms.GroupBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.PicBoxBefore = new System.Windows.Forms.PictureBox();
            this.PicBoxAfter = new System.Windows.Forms.PictureBox();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnAfter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBoxName.SuspendLayout();
            this.grpBoxMyStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(19, 58);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 18);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtBoxFirst
            // 
            this.txtBoxFirst.Location = new System.Drawing.Point(168, 54);
            this.txtBoxFirst.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxFirst.Name = "txtBoxFirst";
            this.txtBoxFirst.Size = new System.Drawing.Size(243, 31);
            this.txtBoxFirst.TabIndex = 0;
            // 
            // lblPreferred
            // 
            this.lblPreferred.AutoSize = true;
            this.lblPreferred.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferred.Location = new System.Drawing.Point(23, 145);
            this.lblPreferred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreferred.Name = "lblPreferred";
            this.lblPreferred.Size = new System.Drawing.Size(83, 18);
            this.lblPreferred.TabIndex = 0;
            this.lblPreferred.Text = "Preferred:";
            // 
            // txtBoxPref
            // 
            this.txtBoxPref.Location = new System.Drawing.Point(168, 132);
            this.txtBoxPref.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPref.Name = "txtBoxPref";
            this.txtBoxPref.Size = new System.Drawing.Size(243, 31);
            this.txtBoxPref.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(23, 101);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 18);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtBoxLast
            // 
            this.txtBoxLast.Location = new System.Drawing.Point(168, 93);
            this.txtBoxLast.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLast.Name = "txtBoxLast";
            this.txtBoxLast.Size = new System.Drawing.Size(243, 31);
            this.txtBoxLast.TabIndex = 1;
            // 
            // btnCloseMyProfile
            // 
            this.btnCloseMyProfile.AutoSize = true;
            this.btnCloseMyProfile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCloseMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseMyProfile.Location = new System.Drawing.Point(575, 449);
            this.btnCloseMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseMyProfile.Name = "btnCloseMyProfile";
            this.btnCloseMyProfile.Size = new System.Drawing.Size(157, 44);
            this.btnCloseMyProfile.TabIndex = 3;
            this.btnCloseMyProfile.Text = "Clo&se";
            this.btnCloseMyProfile.UseVisualStyleBackColor = false;
            this.btnCloseMyProfile.Click += new System.EventHandler(this.btnCloseMyProfile_Click);
            // 
            // grpBoxName
            // 
            this.grpBoxName.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpBoxName.Controls.Add(this.txtBoxLast);
            this.grpBoxName.Controls.Add(this.lblLastName);
            this.grpBoxName.Controls.Add(this.txtBoxPref);
            this.grpBoxName.Controls.Add(this.lblPreferred);
            this.grpBoxName.Controls.Add(this.txtBoxFirst);
            this.grpBoxName.Controls.Add(this.lblFirstName);
            this.grpBoxName.Location = new System.Drawing.Point(40, 35);
            this.grpBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxName.Name = "grpBoxName";
            this.grpBoxName.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxName.Size = new System.Drawing.Size(463, 198);
            this.grpBoxName.TabIndex = 0;
            this.grpBoxName.TabStop = false;
            this.grpBoxName.Text = "Name Info";
            // 
            // grpBoxMyStats
            // 
            this.grpBoxMyStats.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxMyStats.Controls.Add(this.txtBoxAge);
            this.grpBoxMyStats.Controls.Add(this.lblAge);
            this.grpBoxMyStats.Controls.Add(this.txtBoxHeight);
            this.grpBoxMyStats.Controls.Add(this.lblHeight);
            this.grpBoxMyStats.Controls.Add(this.txtBoxWeight);
            this.grpBoxMyStats.Controls.Add(this.lblWeight);
            this.grpBoxMyStats.Location = new System.Drawing.Point(43, 291);
            this.grpBoxMyStats.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxMyStats.Name = "grpBoxMyStats";
            this.grpBoxMyStats.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxMyStats.Size = new System.Drawing.Size(460, 202);
            this.grpBoxMyStats.TabIndex = 1;
            this.grpBoxMyStats.TabStop = false;
            this.grpBoxMyStats.Text = "My Stats";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(165, 122);
            this.txtBoxAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(243, 31);
            this.txtBoxAge.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(20, 127);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 18);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age:";
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.Location = new System.Drawing.Point(165, 83);
            this.txtBoxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(243, 31);
            this.txtBoxHeight.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(20, 91);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(61, 18);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height:";
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Location = new System.Drawing.Point(165, 44);
            this.txtBoxWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(243, 31);
            this.txtBoxWeight.TabIndex = 0;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(20, 49);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(65, 18);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight:";
            // 
            // PicBoxBefore
            // 
            this.PicBoxBefore.Image = global::KGmyFitnessApp.Properties.Resources.FullSizeRender;
            this.PicBoxBefore.Location = new System.Drawing.Point(546, 35);
            this.PicBoxBefore.Margin = new System.Windows.Forms.Padding(4);
            this.PicBoxBefore.Name = "PicBoxBefore";
            this.PicBoxBefore.Size = new System.Drawing.Size(217, 254);
            this.PicBoxBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxBefore.TabIndex = 5;
            this.PicBoxBefore.TabStop = false;
            // 
            // PicBoxAfter
            // 
            this.PicBoxAfter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxAfter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBoxAfter.Image = global::KGmyFitnessApp.Properties.Resources.FullSizeRender__1_;
            this.PicBoxAfter.Location = new System.Drawing.Point(546, 35);
            this.PicBoxAfter.Margin = new System.Windows.Forms.Padding(4);
            this.PicBoxAfter.Name = "PicBoxAfter";
            this.PicBoxAfter.Padding = new System.Windows.Forms.Padding(2);
            this.PicBoxAfter.Size = new System.Drawing.Size(217, 254);
            this.PicBoxAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxAfter.TabIndex = 5;
            this.PicBoxAfter.TabStop = false;
            this.PicBoxAfter.Visible = false;
            // 
            // btnBefore
            // 
            this.btnBefore.BackColor = System.Drawing.Color.Red;
            this.btnBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBefore.Location = new System.Drawing.Point(546, 291);
            this.btnBefore.Margin = new System.Windows.Forms.Padding(4);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(109, 40);
            this.btnBefore.TabIndex = 0;
            this.btnBefore.Text = "&Before";
            this.btnBefore.UseVisualStyleBackColor = false;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnAfter
            // 
            this.btnAfter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAfter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAfter.Location = new System.Drawing.Point(650, 291);
            this.btnAfter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(113, 40);
            this.btnAfter.TabIndex = 1;
            this.btnAfter.Text = "A&fter";
            this.btnAfter.UseVisualStyleBackColor = false;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(575, 374);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MyProfileForm
            // 
            this.AcceptButton = this.btnCloseMyProfile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(786, 538);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAfter);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.PicBoxAfter);
            this.Controls.Add(this.PicBoxBefore);
            this.Controls.Add(this.grpBoxMyStats);
            this.Controls.Add(this.grpBoxName);
            this.Controls.Add(this.btnCloseMyProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MyProfileForm";
            this.Text = "MyProfileForm";
            this.grpBoxName.ResumeLayout(false);
            this.grpBoxName.PerformLayout();
            this.grpBoxMyStats.ResumeLayout(false);
            this.grpBoxMyStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirst;
        private System.Windows.Forms.Label lblPreferred;
        private System.Windows.Forms.TextBox txtBoxPref;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxLast;
        private System.Windows.Forms.Button btnCloseMyProfile;
        private System.Windows.Forms.GroupBox grpBoxName;
        private System.Windows.Forms.GroupBox grpBoxMyStats;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.PictureBox PicBoxBefore;
        private System.Windows.Forms.PictureBox PicBoxAfter;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnAfter;
        private System.Windows.Forms.Button btnClear;
    }
}