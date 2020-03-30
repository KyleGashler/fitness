using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Kyle Gashler
//Class: (INFO 1200)
//Section: (001)
//Professor: Kody Crandall
//Date: 11/18/17
//Project #:9
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace KGmyFitnessApp
{
    public partial class MyBMRform : Form
    {
        //Set constants for BMR calculation
        const double FEM_WEIGHT_CALC = 4.35, FEM_HEIGHT_CALC = 4.7, FEM_AGE_CALC = 4.7, FEM_BASE = 655;
        const double MALE_WEIGHT_CALC = 6.23, MALE_HEIGHT_CALC = 12.7, MALE_AGE_CALC = 6.8, MALE_BASE = 66;
        const double LITTLE_EX = 1.2, LIGHT_EX = 1.375, MOD_EX = 1.55, HEAVY_EX = 1.725, VERY_EX = 1.9;

     
        public MyBMRform()
        {
            InitializeComponent();

            //select an index for the list box default
            lstBoxActivity.SelectedIndex = 0;
        }




        /// <summary>
        /// Calculate the BMR for both Female and Male
        /// and display in appropriate labels.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcBMR_Click(object sender, EventArgs e)
        {      

            // create a new object for the myprofile form and display it.
              MyProfileForm profile = new MyProfileForm();

          
            //must match form exactly
            profile.ShowDialog();
            //shows the form as a dialog

            //declare variables for BMR calc
            double BMRcalc;

            // IF statement to decide which calculation to use
            BMRcalc = rbtnFemale.Checked ?  FEM_BASE + (FEM_WEIGHT_CALC * profile.Weight) + (FEM_HEIGHT_CALC * profile.Height) - (FEM_AGE_CALC * profile.Age) :
                      BMRcalc = MALE_BASE + (MALE_WEIGHT_CALC * profile.Weight) + (MALE_HEIGHT_CALC * profile.Height) - (MALE_AGE_CALC * profile.Age);

            // if (rbtnFemale.Checked)
            // {
            //Calculate Female BMR
            //      BMRcalc = FEM_BASE + (FEM_WEIGHT_CALC * profile.Weight) + (FEM_HEIGHT_CALC * profile.Height) - (FEM_AGE_CALC * profile.Age);

            // }
            // else
            // {
            //Calculate male bmr
            //      BMRcalc = MALE_BASE + (MALE_WEIGHT_CALC * profile.Weight) + (MALE_HEIGHT_CALC * profile.Height) - (MALE_AGE_CALC * profile.Age);
            // }
            //Display the results

            //select a variable for user input on the list box activity level to establish the switch case
            int selectedActivity;
            selectedActivity = lstBoxActivity.SelectedIndex;

            //switch case to apply the excercise levels to the BMR calc 
            switch (selectedActivity)
            {
                case 0:
                    BMRcalc = (BMRcalc * LITTLE_EX);
                    break;
                case 1:
                    BMRcalc = (BMRcalc * LIGHT_EX);
                    break;
                case 2:
                    BMRcalc = (BMRcalc * MOD_EX);
                    break;
                case 3:
                    BMRcalc = (BMRcalc * HEAVY_EX);
                    break;
                case 4:
                    BMRcalc = (BMRcalc * VERY_EX);
                    break;
                 
                default :
                    BMRcalc = (BMRcalc * LITTLE_EX);
                    break;
            }

            //Display the appropriate BMR calc in the label results.
            lblResults.Text = BMRcalc.ToString("n2");

          
        }


        /// <summary>
        /// Closes the MYBMRFORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close on click
            this.Close();

        }
    }
}
