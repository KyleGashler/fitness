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
//Date: 10/28/17
//Project #:6
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace KGmyFitnessApp
{

    public partial class MyProfileForm : Form
    {
        //set variables for sending info to MyBMRform
        public int Weight { get; set; }
        public new int Height { get; set; }
        public int Age { get; set; }


        // Set the constants for the height, weight and age ranges.
        const int MAX_HEIGHT  = 96;
        const int MIN_HEIGHT = 48;
        const int MAX_WEIGHT = 1000;
        const int MIN_WEIGHT = 50;
        const int MIN_AGE = 12;
        const int MAX_AGE = 120;
        


        public MyProfileForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Closes the form on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseMyProfile_Click(object sender, EventArgs e)
        {
            int weight = 0;
            int height = 0;
            int age = 0;

            // validate the user input and make sure that it fits within the perameters established for weight
            if (int.TryParse(txtBoxWeight.Text, out weight) && weight > MIN_WEIGHT && weight < MAX_WEIGHT)
            {
                // validate the user input and make sure that it fits within the perameters established for height
                if (int.TryParse(txtBoxHeight.Text, out height) && MIN_HEIGHT < height && height < MAX_HEIGHT)
                {
                    // validate the user input and make sure that it fits within the perameters established for age
                    if (int.TryParse(txtBoxAge.Text, out age) && age < MAX_AGE && age > MIN_AGE)
                    {
                        //reset the variables to the GET SET values
                        Weight = weight;
                        Height = Height;
                        Age = age;

                        //Closes the form on click command
                        this.Close();
                    }
                    //else method if the age is no good
                    else
                    {
                        // display error message
                        MessageBox.Show("Age input must be an interger between 12 and 120");
                        //focus back to the error box
                        txtBoxAge.Focus();
                       
                    }
                    
                //else method if height is no good.
                }
                else
                {
                    // display error message
                    MessageBox.Show("Height must be an interger between 48 and 96. This is your height in inches.");
                    //focus back to the error input
                    txtBoxHeight.Focus();
                }
             //else moethod for if the weight is no good.  
            }
            else
            {
                // display error message
                MessageBox.Show("Weight must be an interger in the range of 50 -1000");
                //focus back to the error input
                txtBoxWeight.Focus();

            }
           


        }

        /// <summary>
        /// On click show the before picture if after picture visible = tru, before pic visible =  false. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBefore_Click(object sender, EventArgs e)
        {
            //hides the after picture
            PicBoxAfter.Visible = false;
            // changes the visiblity property to false

            //shows the before picture
            PicBoxBefore.Visible = true;
            //changes the visibility property to true
        }


        /// <summary>
        /// On click show the after picture. the after picture must be currently set to visiblie = false and the before code must be set to 
        /// visible = true. also display a congrats message when the after box is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfter_Click(object sender, EventArgs e)
        {
            //hides the before picture
            PicBoxBefore.Visible = false;
            // changes the visiblity property to false

            //shows the after picture
            PicBoxAfter.Visible = true;
            // changes the visiblity property to true

            //display a congrats message in a message box
            MessageBox.Show("Congratulations, She'll finally love you!");
        }

        /// <summary>
        /// Reset the form back to the original state if the user clicks on the clear button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all text boxes
            txtBoxPref.Text = "";
            txtBoxLast.Text = "";
            txtBoxFirst.Text = "";

            //Clear text boxes and reset them to 0
            txtBoxAge.Text = "0";
            txtBoxHeight.Text = "0";
            txtBoxWeight.Text = "0";

            //Focus the user back to the first name input
            txtBoxFirst.Focus();

            //Set so that the form does not close when the clear button is clicked even if it is the default exit event.
            this.DialogResult = DialogResult.None;
        }
    }
}
