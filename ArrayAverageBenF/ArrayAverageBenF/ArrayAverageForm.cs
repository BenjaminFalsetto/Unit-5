/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/11/29
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program generates 10 random numbers, puts them in an array, then calculates the average of all of the
 * numbers and places them in a label
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

namespace ArrayAverageBenF
{
    public partial class frmArrayAverage : Form
    {
        //declare global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];
        
        public frmArrayAverage()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            int randomNumber;
            int index;
            Random randomNumberGenerator = new Random();

            //clear the listbox
            lstNumbers.Items.Clear();

            for (index = 0; index < MAX_ARRAY_SIZE; index++)
            {
                //generate a random number between 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);

                // assign the random number to the cell at position "index" in the array
                arrayOfNumbers[index] = randomNumber;

                //add the random number to the list
                this.lstNumbers.Items.Add(randomNumber);

                //refresh the form to display the new item in the listbox
                this.Refresh();
            }
            
        }

        private void btnCalculateAvg_Click(object sender, EventArgs e)
        {
            //declare local variables
            double average = 0;
            double sum = 0;
            int index;

            //calculate the sum of all the values in the array
            for (index = 0; index < arrayOfNumbers.Length; index++)
            {
                sum = sum + arrayOfNumbers[index];
            }

            //calculate the average of the values in the array
            average = sum / arrayOfNumbers.Length;

            //display the average in the label
            this.lblAvg.Text = "Average: " + average;

            //show the label
            this.lblAvg.Show();
        }
    }
}
