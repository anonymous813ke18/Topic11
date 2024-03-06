using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter output;
            SaveFileDialog sfd = new SaveFileDialog();
            DialogResult selected = sfd.ShowDialog();
            String file;
            if (selected == DialogResult.OK)
                file = sfd.FileName;
            else
                return;

            output = new StreamWriter(file);
            output.WriteLine(txtInput.Text);
            output.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            StreamReader input;
            OpenFileDialog ofd  = new OpenFileDialog();
            DialogResult selected = ofd.ShowDialog();
            String filename;
            if (selected == DialogResult.OK)
                filename = ofd.FileName;
            else
                return;
            input = new StreamReader(filename);
            txtInput.Text = input.ReadToEnd();
            input.Close();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
