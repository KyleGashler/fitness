using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Starts the timer after the user has inputed the necissary info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            const int ALARM_HIGH = 2;
            const int ALARM_LOW = 0;

            //loops for proper time input and measurement.
            for (int i = 0; i < lstBoxExList.Items.Count; i++)
            {
                //display first exercise in lbl
                lblActivityDisplay.Text = lstBoxExList.Items[i].ToString();

                //item i loop
                for (int j = (int)lstBoxTime.Items[i]; j >= 0; j--)
                {

                    TimeSpan currentTime = new TimeSpan(0, 0, j);
                    //display time accoringly
                    lblTimerDisplay.Text = currentTime.ToString(@"mm\:ss");
                    //Establish proper time and initialize the count
                    Application.DoEvents();
                    

                    //sound an alarm when the timer is at 2,1,0
                    if ( j >= ALARM_LOW && j <= ALARM_HIGH)
                    {
                        //system beep
                        SystemSounds.Beep.Play();
                    }
                    //Sleep the system for a full second
                    Thread.Sleep(1000);
                }

                //rest time loop
                for (int j = int.Parse(txtBoxRestInt.Text); j >= 0; j--)
                {
                    //update activity label
                    lblActivityDisplay.Text = "Rest Time";
                    TimeSpan currentTime = new TimeSpan(0, 0, j);
                    //display time accoringly
                    lblTimerDisplay.Text = currentTime.ToString(@"mm\:ss");
                    //Establish proper time and initialize the count
                    Application.DoEvents();
                    

                    //sound an alarm when the timer is at 2,1,0
                    if (j >= ALARM_LOW && j <= ALARM_HIGH)
                    {
                        //system beep
                        SystemSounds.Beep.Play();
                    }

                    //Sleep the system for a full second
                    Thread.Sleep(1000);

                }


            }

            //Notify the user that they have succesfully finsihed the workout
            lblActivityDisplay.Text = "Finished!";

        }


        /// <summary>
        /// Adds the user input for excercise and time interval to the list boxes and validate user inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEx_Click(object sender, EventArgs e)
        {
            // variable for time
            int time = 0;

            // Validate time and slide textBoxes
            if (int.TryParse(txtBoxTime.Text, out time) && time > 0)
            {
                if (txtBoxExercise.Text != "")
                {
                    // Add values to listboxes
                    lstBoxTime.Items.Add(time);
                    lstBoxExList.Items.Add(txtBoxExercise.Text);

                    //clear the values from txtboxes
                    txtBoxExercise.Clear();
                    txtBoxTime.Clear();

                    //Focus to the input boxes
                    txtBoxExercise.Focus();
                }
                else
                {
                    //error message
                    MessageBox.Show("Your exercise input is empty");
                }
            }
            else
            {
                //error message
                MessageBox.Show("Your Time box needs to be greater than one and be an interger.");
            }

        }

        /// <summary>
        /// Submits the info so that the timer can start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //variable for rest time
            int restTime = 0;

            //Validate lstboxes
            if (lstBoxExList.Items.Count > 0 && lstBoxTime.Items.Count > 0)
            {
                //validate rest time
                if (int.TryParse(txtBoxRestInt.Text, out restTime) && restTime > 0)
                {
                    // Success message
                    MessageBox.Show("Every thing looks good. Start it up!");
                    //start button visable
                }
                else
                {
                    //display error message
                    MessageBox.Show("Rest time input is not a valid interger greater than 0. Try again.");
                }

            }
            else
            {
                //display error message
                MessageBox.Show("Must be an equal number of exercise and time inputs.");
            }

        }


        /// <summary>
        /// Clears user input. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all list and text boxes
            txtBoxExercise.Clear();
            txtBoxRestInt.Clear();
            txtBoxTime.Clear();
            lstBoxExList.Items.Clear();
            lstBoxTime.Items.Clear();
            //focus the user back to the first text box
            txtBoxExercise.Focus();
        }



        /// <summary>
        /// Closes the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the app
            this.Close();
        }

    }
}
