namespace KGmyFitnessApp
{
    partial class FoodItemForm
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
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblFoodChoices = new System.Windows.Forms.Label();
            this.lblCalPerServ = new System.Windows.Forms.Label();
            this.lblServings = new System.Windows.Forms.Label();
            this.lblTotalFat = new System.Windows.Forms.Label();
            this.lblSugar = new System.Windows.Forms.Label();
            this.lblSaturatedFat = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.grpBoxNutrition = new System.Windows.Forms.GroupBox();
            this.txtBoxSugar = new System.Windows.Forms.TextBox();
            this.txtBoxProtein = new System.Windows.Forms.TextBox();
            this.txtBoxSatFat = new System.Windows.Forms.TextBox();
            this.txtBoxTotalFat = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBoxFoodName = new System.Windows.Forms.TextBox();
            this.txtBoxCalPerServ = new System.Windows.Forms.TextBox();
            this.txtBoxServings = new System.Windows.Forms.TextBox();
            this.lstBoxFoodChoices = new System.Windows.Forms.ListBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.grpBoxNutrition.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Location = new System.Drawing.Point(41, 31);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(263, 55);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "FoodName";
            // 
            // lblFoodChoices
            // 
            this.lblFoodChoices.AutoSize = true;
            this.lblFoodChoices.Location = new System.Drawing.Point(41, 280);
            this.lblFoodChoices.Name = "lblFoodChoices";
            this.lblFoodChoices.Size = new System.Drawing.Size(321, 55);
            this.lblFoodChoices.TabIndex = 0;
            this.lblFoodChoices.Text = "Food Choices";
            // 
            // lblCalPerServ
            // 
            this.lblCalPerServ.AutoSize = true;
            this.lblCalPerServ.Location = new System.Drawing.Point(41, 109);
            this.lblCalPerServ.Name = "lblCalPerServ";
            this.lblCalPerServ.Size = new System.Drawing.Size(464, 55);
            this.lblCalPerServ.TabIndex = 0;
            this.lblCalPerServ.Text = "Calories Per Serving";
            // 
            // lblServings
            // 
            this.lblServings.AutoSize = true;
            this.lblServings.Location = new System.Drawing.Point(41, 185);
            this.lblServings.Name = "lblServings";
            this.lblServings.Size = new System.Drawing.Size(211, 55);
            this.lblServings.TabIndex = 0;
            this.lblServings.Text = "Servings";
            // 
            // lblTotalFat
            // 
            this.lblTotalFat.AutoSize = true;
            this.lblTotalFat.Location = new System.Drawing.Point(30, 54);
            this.lblTotalFat.Name = "lblTotalFat";
            this.lblTotalFat.Size = new System.Drawing.Size(225, 55);
            this.lblTotalFat.TabIndex = 0;
            this.lblTotalFat.Text = "Total Fat:";
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Location = new System.Drawing.Point(13, 142);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(166, 55);
            this.lblSugar.TabIndex = 0;
            this.lblSugar.Text = "Sugar:";
            // 
            // lblSaturatedFat
            // 
            this.lblSaturatedFat.AutoSize = true;
            this.lblSaturatedFat.Location = new System.Drawing.Point(163, 54);
            this.lblSaturatedFat.Name = "lblSaturatedFat";
            this.lblSaturatedFat.Size = new System.Drawing.Size(328, 55);
            this.lblSaturatedFat.TabIndex = 0;
            this.lblSaturatedFat.Text = "Saturated Fat:";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(219, 173);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(189, 55);
            this.lblProtein.TabIndex = 0;
            this.lblProtein.Text = "Protein:";
            // 
            // grpBoxNutrition
            // 
            this.grpBoxNutrition.Controls.Add(this.txtBoxSugar);
            this.grpBoxNutrition.Controls.Add(this.txtBoxProtein);
            this.grpBoxNutrition.Controls.Add(this.txtBoxSatFat);
            this.grpBoxNutrition.Controls.Add(this.txtBoxTotalFat);
            this.grpBoxNutrition.Controls.Add(this.lblProtein);
            this.grpBoxNutrition.Controls.Add(this.lblSugar);
            this.grpBoxNutrition.Controls.Add(this.lblSaturatedFat);
            this.grpBoxNutrition.Controls.Add(this.lblTotalFat);
            this.grpBoxNutrition.Location = new System.Drawing.Point(359, 31);
            this.grpBoxNutrition.Name = "grpBoxNutrition";
            this.grpBoxNutrition.Size = new System.Drawing.Size(422, 298);
            this.grpBoxNutrition.TabIndex = 1;
            this.grpBoxNutrition.TabStop = false;
            this.grpBoxNutrition.Text = "Nutritional Information";
            // 
            // txtBoxSugar
            // 
            this.txtBoxSugar.Location = new System.Drawing.Point(90, 200);
            this.txtBoxSugar.Name = "txtBoxSugar";
            this.txtBoxSugar.Size = new System.Drawing.Size(115, 61);
            this.txtBoxSugar.TabIndex = 1;
            // 
            // txtBoxProtein
            // 
            this.txtBoxProtein.Location = new System.Drawing.Point(223, 200);
            this.txtBoxProtein.Name = "txtBoxProtein";
            this.txtBoxProtein.Size = new System.Drawing.Size(115, 61);
            this.txtBoxProtein.TabIndex = 3;
            // 
            // txtBoxSatFat
            // 
            this.txtBoxSatFat.Location = new System.Drawing.Point(167, 81);
            this.txtBoxSatFat.Name = "txtBoxSatFat";
            this.txtBoxSatFat.Size = new System.Drawing.Size(115, 61);
            this.txtBoxSatFat.TabIndex = 2;
            // 
            // txtBoxTotalFat
            // 
            this.txtBoxTotalFat.Location = new System.Drawing.Point(34, 81);
            this.txtBoxTotalFat.Name = "txtBoxTotalFat";
            this.txtBoxTotalFat.Size = new System.Drawing.Size(115, 61);
            this.txtBoxTotalFat.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(86, 447);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 49);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Add Food Item";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnAddFoodItem_Click);
            // 
            // txtBoxFoodName
            // 
            this.txtBoxFoodName.Location = new System.Drawing.Point(45, 59);
            this.txtBoxFoodName.Name = "txtBoxFoodName";
            this.txtBoxFoodName.Size = new System.Drawing.Size(189, 61);
            this.txtBoxFoodName.TabIndex = 0;
            // 
            // txtBoxCalPerServ
            // 
            this.txtBoxCalPerServ.Location = new System.Drawing.Point(45, 136);
            this.txtBoxCalPerServ.Name = "txtBoxCalPerServ";
            this.txtBoxCalPerServ.Size = new System.Drawing.Size(189, 61);
            this.txtBoxCalPerServ.TabIndex = 1;
            // 
            // txtBoxServings
            // 
            this.txtBoxServings.Location = new System.Drawing.Point(45, 212);
            this.txtBoxServings.Name = "txtBoxServings";
            this.txtBoxServings.Size = new System.Drawing.Size(189, 61);
            this.txtBoxServings.TabIndex = 2;
            // 
            // lstBoxFoodChoices
            // 
            this.lstBoxFoodChoices.FormattingEnabled = true;
            this.lstBoxFoodChoices.ItemHeight = 54;
            this.lstBoxFoodChoices.Location = new System.Drawing.Point(45, 316);
            this.lstBoxFoodChoices.Name = "lstBoxFoodChoices";
            this.lstBoxFoodChoices.Size = new System.Drawing.Size(527, 58);
            this.lstBoxFoodChoices.TabIndex = 4;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(346, 447);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(164, 49);
            this.btnSaveToFile.TabIndex = 5;
            this.btnSaveToFile.Text = "Save To File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // FoodItemForm
            // 
            this.AcceptButton = this.btnClear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 973);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.lstBoxFoodChoices);
            this.Controls.Add(this.txtBoxServings);
            this.Controls.Add(this.txtBoxCalPerServ);
            this.Controls.Add(this.txtBoxFoodName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpBoxNutrition);
            this.Controls.Add(this.lblCalPerServ);
            this.Controls.Add(this.lblServings);
            this.Controls.Add(this.lblFoodChoices);
            this.Controls.Add(this.lblFoodName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FoodItemForm";
            this.Text = "FoodItemForm";
            this.Load += new System.EventHandler(this.FoodItemForm_Load);
            this.grpBoxNutrition.ResumeLayout(false);
            this.grpBoxNutrition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblFoodChoices;
        private System.Windows.Forms.Label lblCalPerServ;
        private System.Windows.Forms.Label lblServings;
        private System.Windows.Forms.Label lblTotalFat;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.Label lblSaturatedFat;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.GroupBox grpBoxNutrition;
        private System.Windows.Forms.TextBox txtBoxSugar;
        private System.Windows.Forms.TextBox txtBoxProtein;
        private System.Windows.Forms.TextBox txtBoxSatFat;
        private System.Windows.Forms.TextBox txtBoxTotalFat;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBoxFoodName;
        private System.Windows.Forms.TextBox txtBoxCalPerServ;
        private System.Windows.Forms.TextBox txtBoxServings;
        private System.Windows.Forms.ListBox lstBoxFoodChoices;
        private System.Windows.Forms.Button btnSaveToFile;
    }
}