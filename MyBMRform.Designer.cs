namespace KGmyFitnessApp
{
    partial class MyBMRform
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
            this.btnCalcBMR = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.lstBoxActivity = new System.Windows.Forms.ListBox();
            this.lblActivityLevel = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblMyBMR = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.grpBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcBMR
            // 
            this.btnCalcBMR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCalcBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcBMR.Location = new System.Drawing.Point(36, 277);
            this.btnCalcBMR.Name = "btnCalcBMR";
            this.btnCalcBMR.Size = new System.Drawing.Size(190, 50);
            this.btnCalcBMR.TabIndex = 0;
            this.btnCalcBMR.Text = "Calculate BMR";
            this.btnCalcBMR.UseVisualStyleBackColor = false;
            this.btnCalcBMR.Click += new System.EventHandler(this.btnCalcBMR_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(75, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(31, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "BMR is the amount of calories your body burns without any additional excercise. F" +
    "ill out your info, close the form and we will see where your are at!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.rbtnFemale);
            this.grpBoxGender.Controls.Add(this.rbtnMale);
            this.grpBoxGender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpBoxGender.Location = new System.Drawing.Point(335, 72);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Size = new System.Drawing.Size(155, 157);
            this.grpBoxGender.TabIndex = 3;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Gender";
            // 
            // lstBoxActivity
            // 
            this.lstBoxActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxActivity.FormattingEnabled = true;
            this.lstBoxActivity.ItemHeight = 20;
            this.lstBoxActivity.Items.AddRange(new object[] {
            "Little to no exercise",
            "Light exercise (1-3 days per week)",
            "Moderate exercise (3-5 days per week)",
            "Heavy exercise (6-7 days per week)",
            "Very heavy exercise (twice per day)"});
            this.lstBoxActivity.Location = new System.Drawing.Point(17, 85);
            this.lstBoxActivity.Name = "lstBoxActivity";
            this.lstBoxActivity.Size = new System.Drawing.Size(286, 144);
            this.lstBoxActivity.TabIndex = 4;
            // 
            // lblActivityLevel
            // 
            this.lblActivityLevel.AutoSize = true;
            this.lblActivityLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblActivityLevel.Location = new System.Drawing.Point(12, 43);
            this.lblActivityLevel.Name = "lblActivityLevel";
            this.lblActivityLevel.Size = new System.Drawing.Size(255, 25);
            this.lblActivityLevel.TabIndex = 5;
            this.lblActivityLevel.Text = "Choose an Activity Level:";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(6, 46);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(77, 29);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(7, 95);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(101, 29);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblMyBMR
            // 
            this.lblMyBMR.AutoSize = true;
            this.lblMyBMR.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMyBMR.Location = new System.Drawing.Point(280, 290);
            this.lblMyBMR.Name = "lblMyBMR";
            this.lblMyBMR.Size = new System.Drawing.Size(100, 25);
            this.lblMyBMR.TabIndex = 6;
            this.lblMyBMR.Text = "My BMR:";
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResults.Location = new System.Drawing.Point(268, 333);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(148, 31);
            this.lblResults.TabIndex = 7;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCalories.Location = new System.Drawing.Point(432, 339);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(91, 25);
            this.lblCalories.TabIndex = 8;
            this.lblCalories.Text = "Calories";
            // 
            // MyBMRform
            // 
            this.AcceptButton = this.btnCalcBMR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblMyBMR);
            this.Controls.Add(this.lblActivityLevel);
            this.Controls.Add(this.lstBoxActivity);
            this.Controls.Add(this.grpBoxGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalcBMR);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MyBMRform";
            this.Text = "MyBMR";
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcBMR;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.ListBox lstBoxActivity;
        private System.Windows.Forms.Label lblActivityLevel;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label lblMyBMR;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblCalories;
    }
}