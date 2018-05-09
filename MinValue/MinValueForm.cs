/*
 * Created by: Allison Cook
 * Created on: 9 May, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Find Min Value
 * This program finds the min value out of ten randomly generated numbers.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinValue
{
    public partial class frmMinValue : Form
    {
        //create golbal array size
        const int ARRAY_SIZE = 10;

        public frmMinValue()
        {
            InitializeComponent();
        }

        private int GetMinValue(int[] tmpArrayOfNumbers)
        {
            //declare local variables
            int tmpMinValue = 501;
            int currentValue;
            int counter = 0;

            foreach (int ARRAY_SIZE in tmpArrayOfNumbers)
            {
                //getting the current number from array
                currentValue = tmpArrayOfNumbers[counter];

                //checking if the min is bigger than current number
                if (tmpMinValue > currentValue)
                {
                    //setting the maxVAlue to be the higher number
                    tmpMinValue = currentValue;
                }

                //add to the counter
                counter++;

            }

            return tmpMinValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declaring local variables and constants
            const int MAX_RANDOM_NUMBER = 500;
            int randomNumber;
            int counter;
            int minValue;
            Random randomNumberGenerator = new Random();

            //creating an array
            int[] arrayOfNumbers = new int[ARRAY_SIZE];

            //clearing the list box
            lstNumbers.Items.Clear();

            //creating random numbers and adding them to the array
            for (counter = 0; counter < ARRAY_SIZE; counter++)
            {
                //generate the random number
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER);

                //assign the random number to the array at the index of counter
                arrayOfNumbers[counter] = randomNumber;

                //add the random number to the list box
                this.lstNumbers.Items.Add(randomNumber);

                //refresh the form to show the updated list box
                this.Refresh();
            }

            //calling the function to find max value
            minValue = GetMinValue(arrayOfNumbers);

            //showing the maxValue
            this.lblMin.Text = "The min value is " + minValue;
        }
    }
}
