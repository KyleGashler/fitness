namespace KGmyFitnessApp
{
    partial class Timer
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
            this.grpBoxIntervalTimer = new System.Windows.Forms.GroupBox();
            this.grpBoxUserInput = new System.Windows.Forms.GroupBox();
            this.lblActivityDisplay = new System.Windows.Forms.Label();
            this.lblTimerDisplay = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.lblEnterEx = new System.Windows.Forms.Label();
            this.lblTimeList = new System.Windows.Forms.Label();
            this.lblIntRest = new System.Windows.Forms.Label();
            this.lblExcerciseList = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBoxExercise = new System.Windows.Forms.TextBox();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.txtBoxRestInt = new System.Windows.Forms.TextBox();
            this.lstBoxExList = new System.Windows.Forms.ListBox();
            this.lstBoxTime = new System.Windows.Forms.ListBox();
            this.grpBoxIntervalTimer.SuspendLayout();
            this.grpBoxUserInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxIntervalTimer
            // 
            this.grpBoxIntervalTimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBoxIntervalTimer.Controls.Add(this.btnClose);
            this.grpBoxIntervalTimer.Controls.Add(this.btnStart);
            this.grpBoxIntervalTimer.Controls.Add(this.lblTimerDisplay);
            this.grpBoxIntervalTimer.Controls.Add(this.lblActivityDisplay);
            this.grpBoxIntervalTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxIntervalTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxIntervalTimer.Location = new System.Drawing.Point(23, 41);
            this.grpBoxIntervalTimer.Name = "grpBoxIntervalTimer";
            this.grpBoxIntervalTimer.Size = new System.Drawing.Size(394, 566);
            this.grpBoxIntervalTimer.TabIndex = 0;
            this.grpBoxIntervalTimer.TabStop = false;
            this.grpBoxIntervalTimer.Text = "Interval Timer";
            // 
            // grpBoxUserInput
            // 
            this.grpBoxUserInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBoxUserInput.Controls.Add(this.lstBoxTime);
            this.grpBoxUserInput.Controls.Add(this.lstBoxExList);
            this.grpBoxUserInput.Controls.Add(this.txtBoxTime);
            this.grpBoxUserInput.Controls.Add(this.txtBoxRestInt);
            this.grpBoxUserInput.Controls.Add(this.txtBoxExercise);
            this.grpBoxUserInput.Controls.Add(this.btnClear);
            this.grpBoxUserInput.Controls.Add(this.btnSubmit);
            this.grpBoxUserInput.Controls.Add(this.btnAdd);
            this.grpBoxUserInput.Controls.Add(this.lblExcerciseList);
            this.grpBoxUserInput.Controls.Add(this.lblIntRest);
            this.grpBoxUserInput.Controls.Add(this.lblTimeList);
            this.grpBoxUserInput.Controls.Add(this.lblEnterEx);
            this.grpBoxUserInput.Controls.Add(this.lblEnterTime);
            this.grpBoxUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxUserInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxUserInput.Location = new System.Drawing.Point(423, 41);
            this.grpBoxUserInput.Name = "grpBoxUserInput";
            this.grpBoxUserInput.Size = new System.Drawing.Size(460, 566);
            this.grpBoxUserInput.TabIndex = 1;
            this.grpBoxUserInput.TabStop = false;
            this.grpBoxUserInput.Text = "Timer Set Up";
            // 
            // lblActivityDisplay
            // 
            this.lblActivityDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblActivityDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActivityDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActivityDisplay.Location = new System.Drawing.Point(32, 56);
            this.lblActivityDisplay.Name = "lblActivityDisplay";
            this.lblActivityDisplay.Size = new System.Drawing.Size(333, 86);
            this.lblActivityDisplay.TabIndex = 0;
            // 
            // lblTimerDisplay
            // 
            this.lblTimerDisplay.AutoSize = true;
            this.lblTimerDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTimerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimerDisplay.Location = new System.Drawing.Point(54, 198);
            this.lblTimerDisplay.Name = "lblTimerDisplay";
            this.lblTimerDisplay.Size = new System.Drawing.Size(291, 110);
            this.lblTimerDisplay.TabIndex = 0;
            this.lblTimerDisplay.Text = "00:00";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(32, 407);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 77);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(217, 407);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 77);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.AutoSize = true;
            this.lblEnterTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEnterTime.Location = new System.Drawing.Point(210, 68);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(126, 25);
            this.lblEnterTime.TabIndex = 0;
            this.lblEnterTime.Text = "Enter Time";
            // 
            // lblEnterEx
            // 
            this.lblEnterEx.AutoSize = true;
            this.lblEnterEx.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEnterEx.Location = new System.Drawing.Point(27, 68);
            this.lblEnterEx.Name = "lblEnterEx";
            this.lblEnterEx.Size = new System.Drawing.Size(178, 25);
            this.lblEnterEx.TabIndex = 0;
            this.lblEnterEx.Text = "Enter Excercise";
            // 
            // lblTimeList
            // 
            this.lblTimeList.AutoSize = true;
            this.lblTimeList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTimeList.Location = new System.Drawing.Point(240, 198);
            this.lblTimeList.Name = "lblTimeList";
            this.lblTimeList.Size = new System.Drawing.Size(148, 25);
            this.lblTimeList.TabIndex = 0;
            this.lblTimeList.Text = "Interval Time";
            // 
            // lblIntRest
            // 
            this.lblIntRest.AutoSize = true;
            this.lblIntRest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIntRest.Location = new System.Drawing.Point(30, 487);
            this.lblIntRest.Name = "lblIntRest";
            this.lblIntRest.Size = new System.Drawing.Size(152, 25);
            this.lblIntRest.TabIndex = 0;
            this.lblIntRest.Text = "Interval Rest:";
            // 
            // lblExcerciseList
            // 
            this.lblExcerciseList.AutoSize = true;
            this.lblExcerciseList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExcerciseList.Location = new System.Drawing.Point(27, 198);
            this.lblExcerciseList.Name = "lblExcerciseList";
            this.lblExcerciseList.Size = new System.Drawing.Size(148, 25);
            this.lblExcerciseList.TabIndex = 0;
            this.lblExcerciseList.Text = "Exercise List";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(355, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddEx_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(335, 475);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 37);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(335, 518);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBoxExercise
            // 
            this.txtBoxExercise.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxExercise.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxExercise.Location = new System.Drawing.Point(32, 111);
            this.txtBoxExercise.Name = "txtBoxExercise";
            this.txtBoxExercise.Size = new System.Drawing.Size(164, 31);
            this.txtBoxExercise.TabIndex = 0;
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxTime.Location = new System.Drawing.Point(215, 111);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(121, 31);
            this.txtBoxTime.TabIndex = 1;
            // 
            // txtBoxRestInt
            // 
            this.txtBoxRestInt.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxRestInt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxRestInt.Location = new System.Drawing.Point(181, 484);
            this.txtBoxRestInt.Name = "txtBoxRestInt";
            this.txtBoxRestInt.Size = new System.Drawing.Size(100, 31);
            this.txtBoxRestInt.TabIndex = 3;
            // 
            // lstBoxExList
            // 
            this.lstBoxExList.BackColor = System.Drawing.SystemColors.Control;
            this.lstBoxExList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxExList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstBoxExList.FormattingEnabled = true;
            this.lstBoxExList.ItemHeight = 20;
            this.lstBoxExList.Location = new System.Drawing.Point(32, 226);
            this.lstBoxExList.Name = "lstBoxExList";
            this.lstBoxExList.Size = new System.Drawing.Size(210, 224);
            this.lstBoxExList.TabIndex = 3;
            // 
            // lstBoxTime
            // 
            this.lstBoxTime.BackColor = System.Drawing.SystemColors.Control;
            this.lstBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstBoxTime.FormattingEnabled = true;
            this.lstBoxTime.ItemHeight = 20;
            this.lstBoxTime.Location = new System.Drawing.Point(248, 226);
            this.lstBoxTime.Name = "lstBoxTime";
            this.lstBoxTime.Size = new System.Drawing.Size(140, 224);
            this.lstBoxTime.TabIndex = 3;
            // 
            // Timer
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(895, 632);
            this.Controls.Add(this.grpBoxUserInput);
            this.Controls.Add(this.grpBoxIntervalTimer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Timer";
            this.Text = "Timer";
            this.grpBoxIntervalTimer.ResumeLayout(false);
            this.grpBoxIntervalTimer.PerformLayout();
            this.grpBoxUserInput.ResumeLayout(false);
            this.grpBoxUserInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxIntervalTimer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimerDisplay;
        private System.Windows.Forms.Label lblActivityDisplay;
        private System.Windows.Forms.GroupBox grpBoxUserInput;
        private System.Windows.Forms.ListBox lstBoxTime;
        private System.Windows.Forms.ListBox lstBoxExList;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.TextBox txtBoxRestInt;
        private System.Windows.Forms.TextBox txtBoxExercise;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblExcerciseList;
        private System.Windows.Forms.Label lblIntRest;
        private System.Windows.Forms.Label lblTimeList;
        private System.Windows.Forms.Label lblEnterEx;
        private System.Windows.Forms.Label lblEnterTime;
    }
}