namespace KGmyFitnessApp
{
    partial class MealPlannerForm
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
            this.lblDisplayDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCalCountDisplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelectFoodItem = new System.Windows.Forms.Label();
            this.lblSelectMealType = new System.Windows.Forms.Label();
            this.lblItemCal = new System.Windows.Forms.Label();
            this.lblItemCalDisplay = new System.Windows.Forms.Label();
            this.lstBoxSelectFoodItem = new System.Windows.Forms.ListBox();
            this.lstBoxMealType = new System.Windows.Forms.ListBox();
            this.lstBoxBreakfast = new System.Windows.Forms.ListBox();
            this.lstBoxLunch = new System.Windows.Forms.ListBox();
            this.lstBoxSnacks = new System.Windows.Forms.ListBox();
            this.lstBoxDinner = new System.Windows.Forms.ListBox();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblSnacks = new System.Windows.Forms.Label();
            this.btnAddNewFoodItem = new System.Windows.Forms.Button();
            this.btnAddToMeal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplayDate
            // 
            this.lblDisplayDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDate.Location = new System.Drawing.Point(152, 9);
            this.lblDisplayDate.Name = "lblDisplayDate";
            this.lblDisplayDate.Size = new System.Drawing.Size(156, 40);
            this.lblDisplayDate.TabIndex = 0;
            this.lblDisplayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 61);
            this.label2.TabIndex = 0;
            this.label2.Text = "Today\'s Date:";
            // 
            // lblCalCountDisplay
            // 
            this.lblCalCountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalCountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalCountDisplay.Location = new System.Drawing.Point(521, 9);
            this.lblCalCountDisplay.Name = "lblCalCountDisplay";
            this.lblCalCountDisplay.Size = new System.Drawing.Size(114, 40);
            this.lblCalCountDisplay.TabIndex = 0;
            this.lblCalCountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "Daily Calorie Count:";
            // 
            // lblSelectFoodItem
            // 
            this.lblSelectFoodItem.AutoSize = true;
            this.lblSelectFoodItem.Location = new System.Drawing.Point(274, 85);
            this.lblSelectFoodItem.Name = "lblSelectFoodItem";
            this.lblSelectFoodItem.Size = new System.Drawing.Size(425, 61);
            this.lblSelectFoodItem.TabIndex = 0;
            this.lblSelectFoodItem.Text = "Select Food Item";
            // 
            // lblSelectMealType
            // 
            this.lblSelectMealType.AutoSize = true;
            this.lblSelectMealType.Location = new System.Drawing.Point(16, 85);
            this.lblSelectMealType.Name = "lblSelectMealType";
            this.lblSelectMealType.Size = new System.Drawing.Size(478, 61);
            this.lblSelectMealType.TabIndex = 0;
            this.lblSelectMealType.Text = "Select a Meal Type";
            // 
            // lblItemCal
            // 
            this.lblItemCal.AutoSize = true;
            this.lblItemCal.Location = new System.Drawing.Point(548, 85);
            this.lblItemCal.Name = "lblItemCal";
            this.lblItemCal.Size = new System.Drawing.Size(355, 61);
            this.lblItemCal.TabIndex = 0;
            this.lblItemCal.Text = "Item Calories:";
            // 
            // lblItemCalDisplay
            // 
            this.lblItemCalDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemCalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCalDisplay.Location = new System.Drawing.Point(553, 135);
            this.lblItemCalDisplay.Name = "lblItemCalDisplay";
            this.lblItemCalDisplay.Size = new System.Drawing.Size(173, 40);
            this.lblItemCalDisplay.TabIndex = 0;
            this.lblItemCalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxSelectFoodItem
            // 
            this.lstBoxSelectFoodItem.FormattingEnabled = true;
            this.lstBoxSelectFoodItem.ItemHeight = 59;
            this.lstBoxSelectFoodItem.Location = new System.Drawing.Point(279, 113);
            this.lstBoxSelectFoodItem.Name = "lstBoxSelectFoodItem";
            this.lstBoxSelectFoodItem.Size = new System.Drawing.Size(222, 122);
            this.lstBoxSelectFoodItem.TabIndex = 1;
            this.lstBoxSelectFoodItem.SelectedIndexChanged += new System.EventHandler(this.lstBoxSelectFoodItem_SelectedIndexChanged);
            // 
            // lstBoxMealType
            // 
            this.lstBoxMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxMealType.FormattingEnabled = true;
            this.lstBoxMealType.ItemHeight = 46;
            this.lstBoxMealType.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snack"});
            this.lstBoxMealType.Location = new System.Drawing.Point(21, 113);
            this.lstBoxMealType.Name = "lstBoxMealType";
            this.lstBoxMealType.Size = new System.Drawing.Size(120, 142);
            this.lstBoxMealType.TabIndex = 1;
            // 
            // lstBoxBreakfast
            // 
            this.lstBoxBreakfast.FormattingEnabled = true;
            this.lstBoxBreakfast.ItemHeight = 59;
            this.lstBoxBreakfast.Location = new System.Drawing.Point(61, 353);
            this.lstBoxBreakfast.Name = "lstBoxBreakfast";
            this.lstBoxBreakfast.Size = new System.Drawing.Size(332, 63);
            this.lstBoxBreakfast.TabIndex = 1;
            // 
            // lstBoxLunch
            // 
            this.lstBoxLunch.FormattingEnabled = true;
            this.lstBoxLunch.ItemHeight = 59;
            this.lstBoxLunch.Location = new System.Drawing.Point(428, 353);
            this.lstBoxLunch.Name = "lstBoxLunch";
            this.lstBoxLunch.Size = new System.Drawing.Size(332, 63);
            this.lstBoxLunch.TabIndex = 1;
            // 
            // lstBoxSnacks
            // 
            this.lstBoxSnacks.FormattingEnabled = true;
            this.lstBoxSnacks.ItemHeight = 59;
            this.lstBoxSnacks.Location = new System.Drawing.Point(428, 491);
            this.lstBoxSnacks.Name = "lstBoxSnacks";
            this.lstBoxSnacks.Size = new System.Drawing.Size(329, 63);
            this.lstBoxSnacks.TabIndex = 1;
            // 
            // lstBoxDinner
            // 
            this.lstBoxDinner.FormattingEnabled = true;
            this.lstBoxDinner.ItemHeight = 59;
            this.lstBoxDinner.Location = new System.Drawing.Point(61, 491);
            this.lstBoxDinner.Name = "lstBoxDinner";
            this.lstBoxDinner.Size = new System.Drawing.Size(332, 63);
            this.lstBoxDinner.TabIndex = 1;
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Location = new System.Drawing.Point(56, 325);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(251, 61);
            this.lblBreakfast.TabIndex = 0;
            this.lblBreakfast.Text = "Breakfast";
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Location = new System.Drawing.Point(423, 325);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(170, 61);
            this.lblLunch.TabIndex = 0;
            this.lblLunch.Text = "Lunch";
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Location = new System.Drawing.Point(56, 463);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(183, 61);
            this.lblDinner.TabIndex = 0;
            this.lblDinner.Text = "Dinner";
            // 
            // lblSnacks
            // 
            this.lblSnacks.AutoSize = true;
            this.lblSnacks.Location = new System.Drawing.Point(423, 463);
            this.lblSnacks.Name = "lblSnacks";
            this.lblSnacks.Size = new System.Drawing.Size(201, 61);
            this.lblSnacks.TabIndex = 0;
            this.lblSnacks.Text = "Snacks";
            // 
            // btnAddNewFoodItem
            // 
            this.btnAddNewFoodItem.Location = new System.Drawing.Point(279, 273);
            this.btnAddNewFoodItem.Name = "btnAddNewFoodItem";
            this.btnAddNewFoodItem.Size = new System.Drawing.Size(222, 35);
            this.btnAddNewFoodItem.TabIndex = 2;
            this.btnAddNewFoodItem.Text = "Add New Food Item";
            this.btnAddNewFoodItem.UseVisualStyleBackColor = true;
            this.btnAddNewFoodItem.Click += new System.EventHandler(this.btnAddNewFoodItem_Click);
            // 
            // btnAddToMeal
            // 
            this.btnAddToMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToMeal.Location = new System.Drawing.Point(553, 202);
            this.btnAddToMeal.Name = "btnAddToMeal";
            this.btnAddToMeal.Size = new System.Drawing.Size(273, 65);
            this.btnAddToMeal.TabIndex = 2;
            this.btnAddToMeal.Text = "Add To Meal";
            this.btnAddToMeal.UseVisualStyleBackColor = true;
            this.btnAddToMeal.Click += new System.EventHandler(this.btnAddToMeal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(636, 630);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(238, 630);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 42);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MealPlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(30F, 59F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 1071);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddToMeal);
            this.Controls.Add(this.btnAddNewFoodItem);
            this.Controls.Add(this.lstBoxDinner);
            this.Controls.Add(this.lstBoxSnacks);
            this.Controls.Add(this.lstBoxLunch);
            this.Controls.Add(this.lstBoxBreakfast);
            this.Controls.Add(this.lstBoxMealType);
            this.Controls.Add(this.lstBoxSelectFoodItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSelectMealType);
            this.Controls.Add(this.lblSnacks);
            this.Controls.Add(this.lblDinner);
            this.Controls.Add(this.lblLunch);
            this.Controls.Add(this.lblBreakfast);
            this.Controls.Add(this.lblItemCalDisplay);
            this.Controls.Add(this.lblItemCal);
            this.Controls.Add(this.lblSelectFoodItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCalCountDisplay);
            this.Controls.Add(this.lblDisplayDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MealPlannerForm";
            this.Text = "MealPlannerForm";
            this.Load += new System.EventHandler(this.MealPlannerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCalCountDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelectFoodItem;
        private System.Windows.Forms.Label lblSelectMealType;
        private System.Windows.Forms.Label lblItemCal;
        private System.Windows.Forms.Label lblItemCalDisplay;
        private System.Windows.Forms.ListBox lstBoxSelectFoodItem;
        private System.Windows.Forms.ListBox lstBoxMealType;
        private System.Windows.Forms.ListBox lstBoxBreakfast;
        private System.Windows.Forms.ListBox lstBoxLunch;
        private System.Windows.Forms.ListBox lstBoxSnacks;
        private System.Windows.Forms.ListBox lstBoxDinner;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblSnacks;
        private System.Windows.Forms.Button btnAddNewFoodItem;
        private System.Windows.Forms.Button btnAddToMeal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}