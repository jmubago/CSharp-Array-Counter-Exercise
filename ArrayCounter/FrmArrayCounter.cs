using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArrayCounter
{
    public partial class FrmArrayCounter : Form
    {
        public FrmArrayCounter()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            int [] mark = new int [101];
            int [] freq = new int [101];
            int numberOfmarks =0;

            DataEntry(mark,ref numberOfmarks);
            Display(mark,numberOfmarks);
            
            frequency(mark, freq, numberOfmarks);
            DisplayFrequency(freq);

        }

        private void DataEntry(int[] sm, ref int c)
        {
            string response = "";

            while (true)
            {
                do
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have any entries y/n", "Arrays", "", 200, 200);
                }
                while (response != "y" && response != "n");

                if (response == "n")
                    break;

                
                int tempM = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter your mark", "Arrays", "", 200, 200));

                if (tempM >= 0 && tempM <= 100)
                {
                    c++;
                    sm[c] = tempM;
                }
                else
                {
                    MessageBox.Show("Not a valid mark", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void Display(int[] m, int u)
        {
            LstInfo.Items.Clear();
            LstInfo.Items.Add("Original List");
            for (int i = 1; i <= u; i++)
            {
                LstInfo.Items.Add( m[i].ToString());
            }
        }

        private void DisplayFrequency(int[] f)
        {
            LstFrequency.Items.Clear();
            LstFrequency.Items.Add("Frequency List");
            LstFrequency.Items.Add("Mark" + "\t" + "Frequency");
            
            for (int i = 0; i <= 100; i++)
            {
                if (f[i]!=0)
                    LstFrequency.Items.Add(i.ToString()+ "\t" + f[i].ToString());
            }
        }

        private void frequency(int[] m, int[] f, int u)
        {
            for (int i = 1; i <= u; i++)
            {
                f[m[i]] = f[m[i]] + 1;
            }
        }





        //Exercise 03_review
        private void BtnStudentMark_Click(object sender, EventArgs e)
        {
            string[] StudentName = new string[10];
            int[] HistoryMark = new int[10];
            int[] FrequencyMark = new int[10];
            int counter = 0;

            LstInfo.Items.Clear();
            IntroduceData(StudentName, HistoryMark, ref counter);
            PassOrFail(StudentName, HistoryMark, counter);
            BetweenMarks(StudentName, HistoryMark, counter);
            Deduct1(StudentName, ref HistoryMark, counter);
            HighLow(StudentName, HistoryMark, counter);
            CategoryCount(HistoryMark,FrequencyMark , counter);
        }

        private void IntroduceData(string[] sn,int[]hm, ref int c)
        {
            string yesOrNot = "";
            while (true)
            {
                do
                {
                    yesOrNot = Microsoft.VisualBasic.Interaction.InputBox("Do you want to continue y/n", "", "");
                }
                while (yesOrNot != "y" && yesOrNot != "n");

                if (yesOrNot == "n")
                {
                    break;
                }

                string tempName = Microsoft.VisualBasic.Interaction.InputBox("Introduce name of the student", "", "");
                int tempMarks = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce mark of the student", "", ""));

                if (tempMarks >= 0 && tempMarks <= 10)
                {
                    sn[c] = tempName;
                    hm[c] = tempMarks;
                    c++;
                }
                else
                {
                    MessageBox.Show("Please introduce a mark between 0 and 10");
                }
            }
        }

        private void PassOrFail(string[] sn, int[] hm, int c)
        {
            for(int i=0; i < c; i++)
            {
                if(hm[i]>= 5 && hm[i] <= 10)
                {
                    LstInfo.Items.Add("Student " + sn[i] + " with mark " + hm[i] + " has PASSED");
                }
                else
                {
                    LstInfo.Items.Add("Student " + sn[i] + " with mark " + hm[i] + " has FAILED");
                }
            }
        }

        private void BetweenMarks(string[] sn, int[]hm, int c)
        {
            LstInfo.Items.Add("Students with marks between 5 and 7");
            for (int i = 0; i < c; i++)
            {
                if(hm[i]>=5 && hm[i] <= 7.5)
                {
                    LstInfo.Items.Add(sn[i]);
                }
            }
        }

        private void Deduct1(string[] sn,ref int[] hm, int c)
        {
            for(int i=0; i < c; i++)
            {
                hm[i] = hm[i] - 1;
                LstInfo.Items.Add(sn[i] + " has this new mark: "+hm[i]);
            }
        }

        private void HighLow(string[] sn, int []hm,int c)
        {
            int big = -1000;
            int smallest = 1000;
            int pos1 = 0;
            int pos2 = 0;

            //Highest mark
            for (int i = 0; i < c; i++)
            {
                if (hm[i] > big)
                {
                    big = hm[i];
                    pos1 = i;
                }
            }

            //Lowest mark
            for(int x=0; x < c; x++)
            {
                if (hm[x] < smallest)
                {
                    smallest = hm[x];
                    pos2 = x;
                }
            }
            LstInfo.Items.Add(sn[pos1] + " has the highest mark: " + hm[pos1]);
            LstInfo.Items.Add(sn[pos2] + " has the lowest mark: " + hm[pos2]);
        }

        private void CategoryCount(int[]hm,int[] freq ,int c)
        {
            for (int i =0; i < c; i++)
            {
                freq[hm[i]] += 1;
            }

            for (int x=0; x < hm.Length; x++)
            {
                if(freq[x]!= 0)
                {
                    LstFrequency.Items.Add(x.ToString() + "\t" + freq[x].ToString());
                }
            }
        }
    }
}