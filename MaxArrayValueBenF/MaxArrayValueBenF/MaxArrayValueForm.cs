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
    public partial class frmMaxArrayValue : Form
    {
        public frmMaxArrayValue()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables and constants
            const int MAX_ARRAY_SIZE = 10, MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int index, randomNumber;
            Random rndNumGen = new Random();

            randomNumber = rndNumGen.Next(1, 500 + 1);
            this.lstNumbers.Items.Add(randomNumber);
            Console.WriteLine(randomNumber);
            //clear the listbox
            //this.lstNumbers.Items.Clear();

            //assign the numbers to the array
            for (index = 0; index > MAX_ARRAY_SIZE; index++)
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
        }
    }
}

