namespace KGmyFitnessApp
{

    // Name: Kyle Gashler
    // Class: (INFO 1200)
    // Section: (001)
    // Professor: Kody Crandall
    // Date: 9/16/2017
    // Project #: 2
    // I declare that the source code contained in this assignment was written solely by me.
    // I understand that copying any source code, in whole or in part,
    // constitutes cheating, and that I will receive a zero on this project
    // if I am found in violation of this policy.

    partial class MainForm
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
            this.lblFrontPage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnBMRlink = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnExLogForm = new System.Windows.Forms.Button();
            this.btnMyWater = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnMyMealPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrontPage
            // 
            this.lblFrontPage.AutoSize = true;
            this.lblFrontPage.Font = new System.Drawing.Font("Mistral", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrontPage.Location = new System.Drawing.Point(116, 77);
            this.lblFrontPage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFrontPage.Name = "lblFrontPage";
            this.lblFrontPage.Size = new System.Drawing.Size(319, 44);
            this.lblFrontPage.TabIndex = 0;
            this.lblFrontPage.Text = "Kyle\'s Fitness Kick 1.0";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(359, 426);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMyProfile.Location = new System.Drawing.Point(63, 226);
            this.btnMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(202, 46);
            this.btnMyProfile.TabIndex = 0;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = false;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.Location = new System.Drawing.Point(118, 163);
            this.lblTodayDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(109, 25);
            this.lblTodayDate.TabIndex = 4;
            this.lblTodayDate.Text = "Today is:";
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Location = new System.Drawing.Point(242, 156);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(233, 38);
            this.lblDate.TabIndex = 5;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBMRlink
            // 
            this.btnBMRlink.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnBMRlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMRlink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBMRlink.Location = new System.Drawing.Point(298, 226);
            this.btnBMRlink.Name = "btnBMRlink";
            this.btnBMRlink.Size = new System.Drawing.Size(215, 46);
            this.btnBMRlink.TabIndex = 1;
            this.btnBMRlink.Text = "My BMR";
            this.btnBMRlink.UseVisualStyleBackColor = false;
            this.btnBMRlink.Click += new System.EventHandler(this.btnBMRlink_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.Black;
            this.btnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTimer.Location = new System.Drawing.Point(63, 286);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(202, 46);
            this.btnTimer.TabIndex = 6;
            this.btnTimer.Text = "Exercise Timer";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnExLogForm
            // 
            this.btnExLogForm.BackColor = System.Drawing.Color.Black;
            this.btnExLogForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExLogForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExLogForm.Location = new System.Drawing.Point(298, 286);
            this.btnExLogForm.Name = "btnExLogForm";
            this.btnExLogForm.Size = new System.Drawing.Size(215, 46);
            this.btnExLogForm.TabIndex = 7;
            this.btnExLogForm.Text = "My Exercise Log";
            this.btnExLogForm.UseVisualStyleBackColor = false;
            this.btnExLogForm.Click += new System.EventHandler(this.btnExLogForm_Click);
            // 
            // btnMyWater
            // 
            this.btnMyWater.BackColor = System.Drawing.Color.Black;
            this.btnMyWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyWater.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMyWater.Location = new System.Drawing.Point(298, 352);
            this.btnMyWater.Name = "btnMyWater";
            this.btnMyWater.Size = new System.Drawing.Size(215, 46);
            this.btnMyWater.TabIndex = 8;
            this.btnMyWater.Text = "My Water";
            this.btnMyWater.UseVisualStyleBackColor = false;
            this.btnMyWater.Click += new System.EventHandler(this.btnMyWater_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Black;
            this.btnAddFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddFood.Location = new System.Drawing.Point(63, 352);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(202, 46);
            this.btnAddFood.TabIndex = 9;
            this.btnAddFood.Text = "Food Log";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnMyMealPlan
            // 
            this.btnMyMealPlan.BackColor = System.Drawing.Color.Black;
            this.btnMyMealPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMyMealPlan.Location = new System.Drawing.Point(63, 413);
            this.btnMyMealPlan.Name = "btnMyMealPlan";
            this.btnMyMealPlan.Size = new System.Drawing.Size(202, 46);
            this.btnMyMealPlan.TabIndex = 10;
            this.btnMyMealPlan.Text = "My Meal Plan";
            this.btnMyMealPlan.UseVisualStyleBackColor = false;
            this.btnMyMealPlan.Click += new System.EventHandler(this.btnMyMealPlan_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 501);
            this.Controls.Add(this.btnMyMealPlan);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnMyWater);
            this.Controls.Add(this.btnExLogForm);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnBMRlink);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.btnMyProfile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFrontPage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "My Fitness App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrontPage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnBMRlink;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnExLogForm;
        private System.Windows.Forms.Button btnMyWater;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnMyMealPlan;
    }
}

