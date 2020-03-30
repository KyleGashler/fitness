using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Kyle Gashler
//Class: (INFO 1200)
//Section: (001)
//Professor: Kody Crandall
//Date: 11/3/17
//Project #:7
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace KGmyFitnessApp
{
    public partial class ExerciseLogForm : Form
    {
        public ExerciseLogForm()
        {
            InitializeComponent();
        }

        string CurrentFile ="";

        /// <summary>
        /// series of events to load when the form is opened -- trying to see if the user wants to load a file or make a new one, also loading and displaying that file in the lst box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExerciseLogForm_Load(object sender, EventArgs e)
        {
            //Display todays date in the lblDate box
            lblDate.Text = DateTime.Now.ToString("d");

            //try to create an input file with stream reader

            try
            {
                //clear any items in the exercise dialoge box
                lstBoxExLog.Items.Clear();

                //stream reader input file
                StreamReader inputFile;


                //opent the file dialog and get file from the user
                if (openFDUploadFile.ShowDialog() == DialogResult.OK)
                {
                    //open the file
                    inputFile = File.OpenText(openFDUploadFile.FileName);
                    CurrentFile = openFDUploadFile.FileName;

                    //use the file and display it in the list box
                    while (!inputFile.EndOfStream)
                    {
                        //add exercise info from file 
                        lstBoxExLog.Items.Add(inputFile.ReadLine());
                    }

                    //Close the file
                    inputFile.Close();
                }
                else
                {
                    //error message that the file opening event was canceled
                    MessageBox.Show("You chose not to open a file. I assume you want to make anew one?", "Heads up");
                }

             

            }
            catch (Exception ex)
            {
                //display error message if the files are not loaded correctly
                MessageBox.Show(ex.Message);
            }

        }


        /// <summary>
        /// Adds excercises to the lst box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEx_Click(object sender, EventArgs e)
        {
            //validate user input with an if statment
            if (txtBoxCal.Text != "" && txtBoxDuration.Text != "" && txtBoxExercise.Text != "")
            {
                lstBoxExLog.Items.Add($"{lblDate.Text},{txtBoxExercise.Text},{txtBoxDuration.Text},{txtBoxCal.Text}");
            }
            else
            {
                //display error message
                MessageBox.Show("One of the input boxes is empty. Try again");

                //Clear the txt boxes
                txtBoxCal.Clear();
                txtBoxDuration.Clear();
                txtBoxExercise.Clear();
                //focus back to the first box
                txtBoxExercise.Focus();

            }
            //Clear the txt boxes
            txtBoxCal.Clear();
            txtBoxDuration.Clear();
            txtBoxExercise.Clear();

        }


        /// <summary>
        /// saves the contents of the list box to a designated file location for future ref
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveEx_Click(object sender, EventArgs e)
        {
            //create output file streamwriter
            StreamWriter OutputFile;

            //try catch for debugging
            try
            {
                //detect whether or not a file has been opened
                if (CurrentFile != "")
                {
                    //Use teh current file to creat a text file using the output file object
                    OutputFile = File.CreateText(CurrentFile);
                    //create a loop to write each line of the lst box to the new file
                    for (int i = 0; i < lstBoxExLog.Items.Count; i++)
                    {
                        // write each item to the file
                        OutputFile.WriteLine(lstBoxExLog.Items[i]);
                    }

                    //close the output file
                    OutputFile.Close();

                }
                //allow the user to save a new file because one has not been selected to begin with.
                else
                {
                    
                    //if else to make sure the user chooses a file path to save
                    if (saveFDToFile.ShowDialog() == DialogResult.OK)
                    {
                        //open the output file with createText
                        OutputFile = File.CreateText(saveFDToFile.FileName);

                        //reset the current file to user selected output file
                        CurrentFile = saveFDToFile.FileName;

                        //write a loop for the output file
                        for (int i = 0; i < lstBoxExLog.Items.Count; i++)
                        {
                            // write each item to the file
                            OutputFile.WriteLine(lstBoxExLog.Items[i]);
                        }

                        //close the file
                        OutputFile.Close();

                    }
                    else
                    {
                        //message box to show they cancelled the file opperation
                        MessageBox.Show("You canceled out of the save file operation, try again");
                    }
                }

            }
            catch (Exception ex)
            {
                //error message
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the app
            this.Close();

        }


    }
}
