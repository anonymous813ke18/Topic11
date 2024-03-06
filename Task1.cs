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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter output;
            SaveFileDialog sfd = new SaveFileDialog();
            Random random = new Random();
            DialogResult selected = sfd.ShowDialog();
            String file, filePath;
            if (selected == DialogResult.OK)
                file = sfd.FileName;
            else
                return;

            filePath = Path.GetFullPath(file);

            output = new StreamWriter(file);
            for (int i = 0;i < int.Parse(textInput.Text); i++)
            {
                int num = random.Next(int.Parse(textInput.Text));
                output.WriteLine(num + "\n");
            }
            output.Close();

            textOutput.Text = "";
            StreamReader input;
            //OpenFileDialog ofd = new OpenFileDialog();
            //DialogResult selected1 = ofd.ShowDialog();
            //String filename;
            //if (selected == DialogResult.OK)
            //    filename = ofd.FileName;
            //else
            //    return;
            input = new StreamReader(filePath);
            textOutput.Text = input.ReadToEnd();
            input.Close();
        }
    }
}
