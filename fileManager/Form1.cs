using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string lsWords = txtWords.Text;


            if (String.IsNullOrEmpty(lsWords))
            {

                MessageBox.Show("Please enter a word or words into the text box.", "Error");
                return;

            }
            else
            {
                

                words(lsWords);

            }

            



        }


        private void words(string rsWords)
        {

            //string lsWords = txtWords.Text;



            MessageBox.Show(rsWords, "Generic Dialog Title, yo!");

        }


    }
}
