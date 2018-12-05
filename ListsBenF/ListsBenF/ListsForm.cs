/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/12/05
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program accepts marks between 0 and 100 and then puts it
 * into a list then into a listbox. If its not within the range it throws an error
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

namespace ListsBenF
{
    public partial class frmLists : Form
    {
        List<int> listOfMarks = new List<int>();

        public frmLists()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //declare local variables
            int userMark = -1;

            //convert toe vaue in the textboc to an integer
            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            //if the user didn't enter a valid nymber, write the error to the command line
            catch (Exception parseError)
            {
                Console.WriteLine("An error occured: '{0}'", parseError);
            }

            //check if the user entered a number between 0 and 100
            if (userMark >= 0 && userMark <= 100)
            {
                //add the ,ark to the listbox
                this.lstMarks.Items.Add(userMark);

                //add the mark to the list
                listOfMarks.Add(userMark);
            }
            //else, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100", "Invalid Number");
            }
        }
    }
}
