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
//Date: 12/01/17
//Project #:10
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
namespace KGmyFitnessApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Display todays date in the lblDate box
            lblDate.Text = DateTime.Now.ToString("d");

        }

        

        /// <summary>
        /// Button Link to My profile Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            MyProfileForm myprofile = new MyProfileForm();
            //Calls the form's constructor.
            //must match form exactly
            myprofile.ShowDialog();
            //shows the form as a dialog

        }
        
        
        /// <summary>
        /// Exits the app on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Commands the app to exit and closes the form
            this.Close();

        }


        /// <summary>
        /// Takes user to BMR Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBMRlink_Click(object sender, EventArgs e)
        {
            //Onclick pull up BMR form
            // puts form in RAM memory
            MyBMRform BMRform = new MyBMRform();
            //calls the form's constructor.
            //must match form title exactly
            BMRform.ShowDialog();

        }

        /// <summary>
        /// Connect the timer form on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimer_Click(object sender, EventArgs e)
        {
            //puts form in RAM
            Timer Timer = new Timer();
            Timer.Show();

        }

        /// <summary>
        /// opens the my exercise log form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExLogForm_Click(object sender, EventArgs e)
        {
            //Puts room in ram and opens the form
            ExerciseLogForm Log = new ExerciseLogForm();
            Log.ShowDialog();

        }

        /// <summary>
        /// initialize the my water form and contsruct it in memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyWater_Click(object sender, EventArgs e)
        {
            //constructor called on click
            MyWaterForm myWaterForm = new MyWaterForm();

            //open the my water form
            myWaterForm.ShowDialog();

        }

        /// <summary>
        /// button fot initialize the food log form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            //create a new instance in memory of the food item form
            FoodItemForm food = new FoodItemForm();

            //open the food item form
            food.ShowDialog();
        }

        private void btnMyMealPlan_Click(object sender, EventArgs e)
        {
            //new instance of food planner form
            MealPlannerForm planner = new MealPlannerForm();

            //show the dialog of the planner form.
            planner.ShowDialog();
        }
    }
}
