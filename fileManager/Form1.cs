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
            string lsMessage = txtMessage.Text;

            if (String.IsNullOrEmpty(lsMessage))
            {
                MessageBox.Show("Please enter a message in the text box.", "Error...");
                return;
            }
            else 
            {
                showMessage(lsMessage);
            }

        }

        private void showMessage(string rsMessage)
        {


            MessageBox.Show(rsMessage, "Generic Dialog Title, yo!");
        }
    }
}
