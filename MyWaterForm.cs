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
//Date: 11/10/17
//Project #:8
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace KGmyFitnessApp
{
    public partial class MyWaterForm : Form
    {
        // constant for daily water goal and empty water count
        public const int DAILY_GOAL = 8;
        public const int EMPTY_TANK = 0;

        //variable for watwr count
        int waterCount;

        public MyWaterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a running count to of the water consumed and displays the images accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddWater_Click(object sender, EventArgs e)
        {


            //make sure the label displaying the water count is valid
            if (int.TryParse(lblCurrnetCount.Text, out waterCount) && DAILY_GOAL > waterCount )
            {
                //incrament the water count
                waterCount++;

                //display water count in the label
                lblCurrnetCount.Text = waterCount.ToString();

                //call the write water method to pass the count
                WriteWater(waterCount);

                //call the show water method, passing the current count to show the correct number of picture boxes
                ShowWater(waterCount);

            }

            //reset the water count to 0 so the user can start over
            else
            {
              

                //reset the current water count
                waterCount = EMPTY_TANK;

                //reset the label to zero
                lblCurrnetCount.Text = waterCount.ToString();

                //write the new water count so the user can start over
                WriteWater(waterCount);

                //HIDE THE WATER AGAIN 
                HideWater();

                //error message
                MessageBox.Show("You drank all the water you needed today! lets start over.", "Congratulations!");
            }

        }


        /// <summary>
        /// closes the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();

        }


        /// <summary>
        /// Get the file name and return it as a string
        /// </summary>
        /// <returns></returns>
        private string GetFileName()
        {
            //store today's date in a string
            string today = DateTime.Now.ToString("d");
            //replace illegal / characters with legal _ characters. 
            today = today.Replace('/', '_');
            //concatenate a filename using the today's legal date string with rest of filename
            string filename = today+"water" + ".txt";

            //return the file name for the method
            return filename;
        }


        /// <summary>
        /// Hides the water picture boxes
        /// </summary>
        private void HideWater()
        {
            //hide each of the eight water pictures
            picBoxWater1.Hide();
            picBoxWater2.Hide();
            picBoxWater3.Hide();
            picBoxWater4.Hide();
            picBoxWater5.Hide();
            picBoxWater6.Hide();
            picBoxWater7.Hide();
            picBoxWater8.Hide();
        }


        /// <summary>
        /// displays the appropriate pic boxes displaying the waters
        /// </summary>
        private void ShowWater(int waterCount)
        {
            //show the associated number of water pictures according to the water count
            switch (waterCount)
            {
                // dont display any waters if the count is 0
                case 0:
                    break;
                //display 1 water pic if the count is 1
                case 1 :
                    picBoxWater1.Show();
                    break;
                //display 2 water pic if the count is 2
                case 2 :
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    break;
                //display 3 water pic if the count is 3
                case 3:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    break;
                //etc
                case 4:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    break;
                case 5:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    break;
                case 6:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Show();
                    break;
                case 7:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Show();
                    picBoxWater7.Show();
                    break;
                case 8:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Show();
                    picBoxWater7.Show();
                    picBoxWater8.Show();
                    break;
                //if a number greater than 8 is displayed, just hit them with the full stack
                default:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Show();
                    picBoxWater7.Show();
                    picBoxWater8.Show();
                    break;
            }
        }

        /// <summary>
        /// Write the water count to a file
        /// </summary>
        /// <param name="waterCount"></param>
        private void WriteWater(int waterCount)
        {
            //call the getfilename method to get the filename and store it as a string
            string filename = GetFileName();

            //create stream writer object
            StreamWriter outputfile;

            //try catch block to get the file if there is one and open it
            try
            {
                //create a new file using the filename pulled from the previous method and put it into the value for outputfile
                outputfile = File.CreateText(filename);

                //write the water count to the output file
                outputfile.WriteLine(waterCount);

                //close the output file
                outputfile.Close();

            }
            catch (Exception ex)
            {

                //display an error message
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// method to keep a count of the waters drank
        /// </summary>
        /// <param name="waterCount"></param>
        private void ReadWater(ref int waterCount)
        {
            //call the getfilename method to get the filename and store it as a string
            string filename = GetFileName();


            //try catch block to get the file if there is one and open it
            try
            {
                if (filename != "")
                {
                    //temperary variable for water count set to proper scope
                    string waterCountTemp;

                    //create a stream reader instance
                    StreamReader currentFile;

                    //open the current file is there is one and store it in the currentfile stream reader instance 
                    currentFile = File.OpenText(filename);

                    //read the current file contents to the new text file
                    while (!currentFile.EndOfStream)
                    {
                        
                        //set the temp variable to the file input usin the readline methoe
                        waterCountTemp = (currentFile.ReadLine());

                        //try to parse the file input for water count
                        if (int.TryParse(waterCountTemp, out waterCount))
                        {
                            //diaplay the water count in the proper label
                            lblCurrnetCount.Text = waterCount.ToString();
                        }
                        else
                        {
                            //error message if the string read in via the file is not a valid interger
                            MessageBox.Show("the previous file read in contained an improper character. It must be a valid Interger in order to use the previous file");
                        }

                    }

                    //close the current file instance
                    currentFile.Close();
 
            
                }
                else
                {
                    //display error message
                    MessageBox.Show("the first time your file is run, there may not yet exist a file for the day");
                }

            }
            //catch block if the try attempt fails
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// show the current date in the date label, call the starting methods to display the correct status of the user consumption
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyWaterForm_Load(object sender, EventArgs e)
        {
            //show the current date in the date label
            lblDate.Text = DateTime.Now.ToString("d");

            //call the hidewater method
            HideWater();

            //call the read water method
            ReadWater(ref waterCount);

            //call the show water method
            ShowWater(waterCount);
        }
    }
}
