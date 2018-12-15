using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReadWriteBenF
{
    public partial class frmFileReadWrite : Form
    {
        public frmFileReadWrite()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //read each line of the file into a string array
            //each element of the array is one line of the file
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            //array of characters that I want to take out when I split the line into words (spaces, tabs)
            char[] charSeperators = new char[] { ' ', '\t' };

            //the output string where I will pull my results
            string output = "";

            //go through and compare each string on each line of the file
            foreach (string line in lines)
            {
                //split each line into wods and put them into an array
                //assuming there are only two words on the line
                string[] words = line.Split(charSeperators, StringSplitOptions.RemoveEmptyEntries);

                if (StringsAreEqual(words[0], words[1]) == true)
                {
                    //concatenate the output to the string
                    //there must be \r\n so that is goes onto a new line in the text file
                    output += "True \r\n";
                }
                else
                {
                    //split each line into wods and put them into an array
                    //assuming there are only two words on the line
                    output += "False \r\n";

                    //WriteAllText creates a file, writes the specified string to the file,
                    //and then closes the file
                    System.IO.File.WriteAllText(@"output.txt", output);

                    //show the label telling the user that the process is done
                    this.lblOutput.Show();
                }
            }
        }

        private bool StringsAreEqual(string string1, string string2)
        {
            if (string1 == string2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
