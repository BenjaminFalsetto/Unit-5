using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DArraysBenF
{
    public partial class frm2DArrays : Form
    {
        Random rndNumGen;

        public frm2DArrays()
        {
            InitializeComponent();
            rndNumGen = new Random();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //declare local variables
            int height;
            int width;
            int aRndNum;
            string aPieceOfText = "";

            //get the desired height and width
            height = Convert.ToInt16(this.nudHeight.Value);
            width = Convert.ToInt16(this.nudWidth.Value);

            //declare the array with the desired width and length
            int[,] anArray = new int[height, width];

            //loop through each element in the height
            for (int heightCounter = 0; heightCounter < height; heightCounter++)
            {
                //loop through each element in the width
                for (int widthCounter = 0; widthCounter < width; widthCounter++)
                {
                    //get a random number between 0 and 9
                    aRndNum = rndNumGen.Next(0, 9 + 1);

                    //insert the random number into the array at the current height and width
                    anArray[heightCounter, widthCounter] = aRndNum;

                    //add the random number to the string of array numbers
                    aPieceOfText = aPieceOfText + " " + aRndNum;
                }
                //add a line break to the end of the line to show a new row in the string
                aPieceOfText = aPieceOfText + "\r" + "\n";
            }
            //insert the string into the listbox
            this.lstNumbers.Items.Add(aPieceOfText);
        }
    }
}
