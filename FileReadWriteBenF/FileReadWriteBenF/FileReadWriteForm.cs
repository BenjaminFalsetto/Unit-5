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
            //Read each line of the file into a string array
            //each element of the arrau is one line of the file
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            //array of characters that I want to take out when I split the line into words
            char[] charSeperators = new char[] { ' ', '\t' };

            //the output strings where I will put my results
            string output = "";

            //go through and compare each string on each line of the file
            foreach (string line in lines)
            {
                //split each line into words and put them into an array
                //I am assuming there are only two words on the line
                string[] words = line.Split(charSeperators, StringSplitOptions.RemoveEmptyEntries);

                if (StringsAreEqual(words[0], words[1]) == true)
            }
        }
    }
}
