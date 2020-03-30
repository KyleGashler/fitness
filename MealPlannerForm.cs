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
//Date: 12/01/17
//Project #:10
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace KGmyFitnessApp
{

    public partial class MealPlannerForm : Form
    {

        public MealPlannerForm()
        {
            InitializeComponent();

            //constant for food size to limit the array
            int FOOD_SIZE = 1000;

            //array limit for the food size
            myfoods = new FoodItemClass[FOOD_SIZE];
        }

        //string for the food filename
        string foodFileName = "fooditems.txt";

        //refference to the food item array
        private FoodItemClass[] myfoods;



        private void LoadFoods()
        {
            //string object to hold food items
            string foodItem = "";

            //string array for the token results of the split method
            string[] splitFoodArray;

            //local variable to help assign each food item read from file to the food item array
            int indexCount = 0;

            //streamreader object
            StreamReader streamFoodFile;


            //try block to loop throught the file untill end of stream, split them at the commas to add them to the array
            try
            {
                //open the food items file
                streamFoodFile = File.OpenText(foodFileName);
                //end of stream loop
                while (!streamFoodFile.EndOfStream)
                {
                    //read a line from the file and assign tif to the food item string
                    foodItem = streamFoodFile.ReadLine();

                    //split the string using the ',' character
                    splitFoodArray = foodItem.Split(',');

                    //add the name of the food to the list box
                    lstBoxSelectFoodItem.Items.Add(splitFoodArray[0]);
                    myfoods[indexCount] = new FoodItemClass(splitFoodArray);
                    indexCount++;

                }


                //close the file for reading
                streamFoodFile.Close();

            }
            catch (Exception)
            {
                //error message
                MessageBox.Show("There was a problem reading the food items from the file");
            }

        }



        /// <summary>
        /// add a new food item to the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewFoodItem_Click(object sender, EventArgs e)
        {
            //open the food items form and display it.
            FoodItemForm foodss = new FoodItemForm();
            foodss.ShowDialog();
            //close the form so it can reaload the new food items
            this.Close();
        }

        /// <summary>
        /// add the food item to the overall meal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToMeal_Click(object sender, EventArgs e)
        {
            //variable for bad selected index
            int badIndex = -1;
            //make sure that a meal type has been selected from the meal type list box and food item list box
            if (lstBoxSelectFoodItem.SelectedIndex != badIndex && lstBoxMealType.SelectedIndex != badIndex)
            {
                //add food name and cal to appropriate lst box
                switch (lstBoxMealType.SelectedIndex)
                {
                    case 0:
                        lstBoxBreakfast.Items.Add($"{lstBoxSelectFoodItem.SelectedItem} for {lblItemCalDisplay.Text} calories.");
                        break;
                    case 1:
                        lstBoxLunch.Items.Add($"{lstBoxSelectFoodItem.SelectedItem} for {lblItemCalDisplay.Text} calories.");
                        break;
                    case 2:
                        lstBoxDinner.Items.Add($"{lstBoxSelectFoodItem.SelectedItem} for {lblItemCalDisplay.Text} calories.");
                        break;
                    case 3:
                        lstBoxSnacks.Items.Add($"{lstBoxSelectFoodItem.SelectedItem} for {lblItemCalDisplay.Text} calories.");
                        break;

                }
            }
            else
            {
                //error message
                MessageBox.Show("please select a meal item and a food item to add to the appropriate meal");
            }

            //error catch for int.parse 
            try
            {
                //update the calorie count in the calorie label. 
                int runningCalTotal = int.Parse(lblCalCountDisplay.Text);

                //add to the running total cal
                int NewCalTotal = runningCalTotal + int.Parse(lblItemCalDisplay.Text);

                //display the new cal count
                lblCalCountDisplay.Text = NewCalTotal.ToString();
            }
            catch (Exception ex)
            {
                //error message
                MessageBox.Show($"{ex}");
            }



        }

        /// <summary>
        /// generate and save a completed meal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all items
            lblCalCountDisplay.Text = "0";
            lblItemCalDisplay.Text = "0";
            lstBoxBreakfast.Items.Clear();
            lstBoxDinner.Items.Clear();
            lstBoxLunch.Items.Clear();
            lstBoxSnacks.Items.Clear();

        }


        /// <summary>
        /// exit form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit form
            this.Close();

        }

        /// <summary>
        /// load event handler for form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MealPlannerForm_Load(object sender, EventArgs e)
        {
            //get todays date and show it in the appropriate label
            lblDisplayDate.Text = DateTime.Now.ToString();

            //call the load foods method
            LoadFoods();

            //temp value if there is no value in the current calorie count
            if (lblCalCountDisplay.Text == "")
            {
                lblCalCountDisplay.Text = "0";
            }


        }

        /// <summary>
        /// selected index changed event handler for foood items list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBoxSelectFoodItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selected index validations
            if (lstBoxSelectFoodItem.SelectedIndex != -1)
            {
                //variable for the the array call
                int selectedFood = lstBoxSelectFoodItem.SelectedIndex;

                // label display the calories based on the selected index in the Array
                lblItemCalDisplay.Text = myfoods[selectedFood].Calories.ToString();

            }
        }
    }
}
