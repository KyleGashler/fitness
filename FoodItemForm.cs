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
//Date: 11/18/17
//Project #:9
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace KGmyFitnessApp
{
    public partial class FoodItemForm : Form
    {
        //object to hold the foodfilename string
        string foodFileName = "fooditems.txt";


        public FoodItemForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// calls the methods from the class to run multiple functions 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFoodItem_Click(object sender, EventArgs e)
        {
            //new instance of the food item class so we can pull from it.
            FoodItemClass fooditems = new FoodItemClass();

            //call the chack food method
            CheckFood1(fooditems);

            //use the fooditem tostring method to populate the listbox accordingly
            lstBoxFoodChoices.Items.Add(fooditems.ToStringFood());

           

        }
        
        /// <summary>
        /// my own method for clearing text boxes and focusing 
        /// </summary>
        private void CLearBoxes()
        {
            //clear all text boxes
            txtBoxCalPerServ.Clear();
            txtBoxFoodName.Clear();
            txtBoxProtein.Clear();
            txtBoxSatFat.Clear();
            txtBoxServings.Clear();
            txtBoxSugar.Clear();
            txtBoxTotalFat.Clear();

            //focus the user back to the fist text box
            txtBoxFoodName.Focus();
        }



        /// <summary>
        /// validates the user input and displays an error message if they get it wrong.
        /// </summary>
        /// <returns></returns>
        private bool CheckFood1(FoodItemClass foodz)
        {
            //constant for realistic range of input values to make sure user is within reason.
            const int REALISTIC_RANGE = 10000;

            //temp variables for method
            double calories, servings;
            int totalfat,saturatedfat,sugar,protein;

            //validate all the user input
            if (txtBoxFoodName.Text != "" &&
            double.TryParse(txtBoxCalPerServ.Text, out calories) && calories < REALISTIC_RANGE &&
            double.TryParse(txtBoxServings.Text, out servings) && servings < REALISTIC_RANGE &&
            int.TryParse(txtBoxTotalFat.Text, out totalfat) && totalfat < REALISTIC_RANGE &&
            int.TryParse(txtBoxSatFat.Text, out saturatedfat) && saturatedfat < REALISTIC_RANGE &&
            int.TryParse(txtBoxSugar.Text, out sugar) && sugar < REALISTIC_RANGE &&
            int.TryParse(txtBoxProtein.Text, out protein) && protein < REALISTIC_RANGE)
            {
                //set the values from this end to the backing spaces in the class
                foodz.Calories = calories;
                foodz.Servings = servings;
                foodz.TotalFat = totalfat;
                foodz.SaturatedFat = saturatedfat;
                foodz.Sugar = sugar;
                foodz.Protein = protein;
                foodz.FoodName = txtBoxFoodName.Text;

                //call my clearboxes method
                CLearBoxes();

                //return true for the sake of the method
                return true;
            }
            else
            {
                //call my clear boxes method
                CLearBoxes();

                //return false and error message
                MessageBox.Show("you have inputed your info incorrectly. Food name is text \n and the rest are to be intergers \n with exception to servings which can be a decimal number \n no numbers are alloud to be above 5000 either.");

                //return false so that the values aren't changed in the back of the class by error
                return false;
               

            }
        }

        /// <summary>
        /// Saves the list items to a txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            //call write food method
            WriteFood();

            //close the form
            this.Close();

        }


        /// <summary>
        /// write food method for the savetofile button
        /// </summary>
        private void WriteFood()
        {
            //streamwriter object
            StreamWriter foodFile;

            //try catch for file operations
            try
            {
                //write file to the streamwriter object
                foodFile = File.CreateText(foodFileName);

                //loop through the list box to write them to the foodfile
                for (int i = 0; i < lstBoxFoodChoices.Items.Count; i++)
                {
                    //write each file to the line
                    foodFile.WriteLine(lstBoxFoodChoices.Items[i]);

                }

                //close the file  
                foodFile.Close();

            }
            catch (Exception ex)
            {

                //message box for error detection
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// load event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoodItemForm_Load(object sender, EventArgs e)
        {
            
            //streamreader object
            StreamReader foodFile;

            //try catch for file operations
            try
            {
                //open the foodfilename text and plug it into the food file streamreader
                foodFile = File.OpenText(foodFileName);

                //clear the list box with the current food items
                lstBoxFoodChoices.Items.Clear();

                //loop to read the line items in the file
                while (!foodFile.EndOfStream)
                {
                    //add the items to the list box
                    lstBoxFoodChoices.Items.Add(foodFile.ReadLine());

                }

                //close the file
                foodFile.Close();
            
            }
            catch (Exception)
            {

                //message box for error detection
                MessageBox.Show("There is no Saved Food items so far, It's time to get started! \n\n Fill in your first food items, and save them here.");
            }
        }

    }
}
