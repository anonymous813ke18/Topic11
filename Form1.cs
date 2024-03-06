using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Topic11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter output = new StreamWriter(txtLocation.Text);
            output.WriteLine(txtInput.Text);
            output.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            StreamReader input = new StreamReader(txtLocation.Text);
            txtInput.Text = input.ReadToEnd();
            input.Close();
        }
    }
}
