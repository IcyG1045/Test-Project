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

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void grade_Click(object sender, EventArgs e)
        {
            string[] A = new string[20];
            StreamReader ifile = File.OpenText("answerkey.txt");

            string line;
            int x = 0;
            while( (line = ifile.ReadLine() ) != null)
            {
                A[x] = line;
                x++;
            }


            string[] B = new string[20];
            StreamReader ifile2 = File.OpenText("response.txt");





            int correct = 0;
            int incorrect = 0;
            //string i1 = ifile.ReadLine();
            //string i2 = ifile2.ReadLine();

            string incorrectLines = "";

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == B[i])
                {
                    correct++;
                }
                else
                {
                    incorrectLines += (i + 1) + ", ";
                    incorrect++;
                }
            }


            if (correct >= 14)
            {
                passfail.Text = "Passed";
            }
            else
            {
                passfail.Text = "Failed";
            }

            correctbox.Text = correct.ToString();
            incorrectbox.Text = incorrect.ToString();
        }
    }
}
