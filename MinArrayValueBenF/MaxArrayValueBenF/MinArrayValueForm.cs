/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/12/03
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program randomly generates 10 numbers and finds the min value
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

namespace MaxArrayValueBenF
{
    public partial class frmMinArrayValue : Form
    {
        Random rndNumGen;
        public frmMinArrayValue()
        {
            InitializeComponent();
            rndNumGen = new Random();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables and constants
            const int MAX_ARRAY_SIZE = 10, MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int index, randomNumber, currentMinVal = 501;

            //clear the listbox
            this.lstNumbers.Items.Clear();

            //assign the numbers to the array
            for (index = 0; index < MAX_ARRAY_SIZE; index++)
            {
                //generate a random number between 1 and the max array size
                randomNumber = rndNumGen.Next(1, MAX_RANDOM_NUMBER + 1);

                //Console.WriteLine("The random number is " + randomNumber);

                //assign the random number to the cell at position index in the array
                arrayOfIntegers[index] = randomNumber;

                //add the random number to the listbox
                this.lstNumbers.Items.Add(randomNumber);

                //refresh the form to display the new item in the listbox
                this.Refresh();
            }

            //check to see which number is the least
            for (index = 0; index < MAX_ARRAY_SIZE; index++)
            {
                //check to see if the value at current index is larger than the highest found value
                if (arrayOfIntegers[index] < currentMinVal)
                {
                    currentMinVal = arrayOfIntegers[index];
                }
            }

            //display the max value in a label
            this.lblMinVal.Text = ("The min value is " + currentMinVal);
            this.lblMinVal.Show();
        }
    }
}