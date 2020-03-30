namespace KGmyFitnessApp
{
    partial class ExerciseLogForm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblExercise = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblCal = new System.Windows.Forms.Label();
            this.lblExLog = new System.Windows.Forms.Label();
            this.btnAddEx = new System.Windows.Forms.Button();
            this.btnSaveEx = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBoxExercise = new System.Windows.Forms.TextBox();
            this.txtBoxDuration = new System.Windows.Forms.TextBox();
            this.txtBoxCal = new System.Windows.Forms.TextBox();
            this.lstBoxExLog = new System.Windows.Forms.ListBox();
            this.openFDUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFDToFile = new System.Windows.Forms.SaveFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Location = new System.Drawing.Point(61, 59);
            this.lblDate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(236, 48);
            this.lblDate.TabIndex = 0;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExercise
            // 
            this.lblExercise.AutoSize = true;
            this.lblExercise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExercise.Location = new System.Drawing.Point(61, 142);
            this.lblExercise.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(95, 25);
            this.lblExercise.TabIndex = 0;
            this.lblExercise.Text = "Exercise";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDuration.Location = new System.Drawing.Point(310, 142);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(147, 25);
            this.lblDuration.TabIndex = 0;
            this.lblDuration.Text = "Duration (min)";
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCal.Location = new System.Drawing.Point(471, 142);
            this.lblCal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(91, 25);
            this.lblCal.TabIndex = 0;
            this.lblCal.Text = "Calories";
            // 
            // lblExLog
            // 
            this.lblExLog.AutoSize = true;
            this.lblExLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExLog.Location = new System.Drawing.Point(61, 240);
            this.lblExLog.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblExLog.Name = "lblExLog";
            this.lblExLog.Size = new System.Drawing.Size(172, 25);
            this.lblExLog.TabIndex = 0;
            this.lblExLog.Text = "My Exercise Log";
            // 
            // btnAddEx
            // 
            this.btnAddEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEx.Location = new System.Drawing.Point(347, 61);
            this.btnAddEx.Name = "btnAddEx";
            this.btnAddEx.Size = new System.Drawing.Size(173, 46);
            this.btnAddEx.TabIndex = 1;
            this.btnAddEx.Text = "Add Exercise";
            this.btnAddEx.UseVisualStyleBackColor = true;
            this.btnAddEx.Click += new System.EventHandler(this.btnAddEx_Click);
            // 
            // btnSaveEx
            // 
            this.btnSaveEx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEx.Location = new System.Drawing.Point(102, 487);
            this.btnSaveEx.Name = "btnSaveEx";
            this.btnSaveEx.Size = new System.Drawing.Size(179, 55);
            this.btnSaveEx.TabIndex = 1;
            this.btnSaveEx.Text = "SaveExercises";
            this.btnSaveEx.UseVisualStyleBackColor = false;
            this.btnSaveEx.Click += new System.EventHandler(this.btnSaveEx_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(345, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 55);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxExercise
            // 
            this.txtBoxExercise.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxExercise.Location = new System.Drawing.Point(66, 170);
            this.txtBoxExercise.Name = "txtBoxExercise";
            this.txtBoxExercise.Size = new System.Drawing.Size(231, 31);
            this.txtBoxExercise.TabIndex = 2;
            // 
            // txtBoxDuration
            // 
            this.txtBoxDuration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxDuration.Location = new System.Drawing.Point(321, 170);
            this.txtBoxDuration.Name = "txtBoxDuration";
            this.txtBoxDuration.Size = new System.Drawing.Size(100, 31);
            this.txtBoxDuration.TabIndex = 2;
            // 
            // txtBoxCal
            // 
            this.txtBoxCal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxCal.Location = new System.Drawing.Point(476, 170);
            this.txtBoxCal.Name = "txtBoxCal";
            this.txtBoxCal.Size = new System.Drawing.Size(100, 31);
            this.txtBoxCal.TabIndex = 2;
            // 
            // lstBoxExLog
            // 
            this.lstBoxExLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstBoxExLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxExLog.FormattingEnabled = true;
            this.lstBoxExLog.ItemHeight = 16;
            this.lstBoxExLog.Location = new System.Drawing.Point(32, 268);
            this.lstBoxExLog.Name = "lstBoxExLog";
            this.lstBoxExLog.Size = new System.Drawing.Size(544, 196);
            this.lstBoxExLog.TabIndex = 3;
            // 
            // openFDUploadFile
            // 
            this.openFDUploadFile.FileName = "openFileDialog1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(211, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 31);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Log Your Efforts!";
            // 
            // ExerciseLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(601, 554);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstBoxExLog);
            this.Controls.Add(this.txtBoxCal);
            this.Controls.Add(this.txtBoxDuration);
            this.Controls.Add(this.txtBoxExercise);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveEx);
            this.Controls.Add(this.btnAddEx);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblExLog);
            this.Controls.Add(this.lblExercise);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ExerciseLogForm";
            this.Text = "ExerciseLogForm";
            this.Load += new System.EventHandler(this.ExerciseLogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.Label lblExLog;
        private System.Windows.Forms.Button btnAddEx;
        private System.Windows.Forms.Button btnSaveEx;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBoxExercise;
        private System.Windows.Forms.TextBox txtBoxDuration;
        private System.Windows.Forms.TextBox txtBoxCal;
        private System.Windows.Forms.ListBox lstBoxExLog;
        private System.Windows.Forms.OpenFileDialog openFDUploadFile;
        private System.Windows.Forms.SaveFileDialog saveFDToFile;
        private System.Windows.Forms.Label lblTitle;
    }
}