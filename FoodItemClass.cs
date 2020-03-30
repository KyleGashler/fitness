using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    /// <summary>
    /// class defined for food items
    /// </summary>
    class FoodItemClass
    {
        
        //3 Backing fields for foodname calories and servings
        private string _foodName;
        private double _calories, _servings;

        //Backing fields for nutritional info
        private int _totalFat, _saturatedFat, _sugar, _protein;

        /// <summary>
        /// simple constructor for a food with no values
        /// </summary>
        public FoodItemClass()
        {
            //set values for the constructor method for the backing fields in this instance
            _foodName = "";
            _calories = 0.0;
            _servings = 0.0;
            _totalFat = 0;
            _saturatedFat = 0;
            _sugar = 0;
            _protein = 0;
        }

        /// <summary>
        /// Class with multipule arguments for user to adjust the food info for each food
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="calories"></param>
        /// <param name="servings"></param>
        /// <param name="totalFat"></param>
        /// <param name="saturatedFat"></param>
        /// <param name="sugar"></param>
        /// <param name="protein"></param>
        public FoodItemClass( ref string foodName, double calories, double servings, int totalFat, int saturatedFat, int sugar, int protein)
        {
            //sets the user/dev inputs for each food and its own info
            _foodName = foodName;
            _calories = calories;
            _servings = servings;
            _totalFat = totalFat;
            _saturatedFat = saturatedFat;
            _sugar = sugar;
            _protein = protein;
        }

        /// <summary>
        /// another constructor method with a food array
        /// </summary>
        /// <param name="foodArray"></param>
        public FoodItemClass(string[] foodArray)
        {
            //backing fields to refference the foodarray
            _foodName = foodArray[0].ToString();
            _calories = double.Parse(foodArray[1]);
            _servings = double.Parse(foodArray[2]);
            _totalFat = int.Parse(foodArray[3]);
            _saturatedFat = int.Parse(foodArray[4]);
            _sugar = int.Parse(foodArray[5]);
            _protein = int.Parse(foodArray[6]);


        }
       
        //public read and writable for foodname
        public string FoodName
        {
            //gets or sets the values for variable based on user inputs in a different form
            get { return _foodName; }
            set { _foodName = value; }
        }

        //public read and writable for Calories
        public double Calories
        {
            //gets or sets the values for variable based on user inputs in a different form
            get { return _calories; }
            set { _calories = value; }
        }

        //public read and writable for servings
        public double Servings
        {
            //gets or sets the values for variable based on user inputs in a different form
            get { return _servings; }
            set { _servings = value; }
        }

        //public read and writable for TotalFat
        public int TotalFat
        {
            //gets or sets the values for variable based on user inputs in a different form
            get { return _totalFat; }
            set { _totalFat = value; }
        }

        //public read and writable for saturatedfat
        public int SaturatedFat
        {
            //gets or sets the values for variable based on user inputs in a different form
            get { return _saturatedFat; }
            set { _saturatedFat = value; }
        }

        //public read and writable for sugar
        public int Sugar
        {
            //gets or sets the values for variable based on user inputs in a different form
            get { return _sugar; }
            set { _sugar = value; }
        }

        //public read and writable for Protein
        public int Protein
        {
            //gets or sets the values for variable based on user inputs in a different form
            get { return _protein; }
            set { _protein = value; }
        }

        /// <summary>
        /// method that returns all the food info in a comma sperated string using proper concantonation techniques
        /// </summary>
        /// <returns></returns>
        public string ToStringFood ()
        {
            //temp string variable that holds all the variables in an concantonated string seperated by commas
            string FoodString = $"{_foodName},{_calories},{_servings},{_totalFat},{_saturatedFat},{_sugar},{_protein}";
            
            //return the food string in the method
            return FoodString;

        }   
    }
}
