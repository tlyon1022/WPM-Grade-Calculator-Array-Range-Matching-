/*
 * K9195
 * CIS 199-02
 * Oct 27th, 2019
 * Lab 6 
 * Program utilizes a parallel array and loops to generate a 
 * letter grade associated with user's input of words per minute typed
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

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Calculates the letter grade based on input
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            int[] lowGradeLimits = { 0, 16, 31, 51, 76 };//array of wpm range low-end limits
            char[] grade = { 'F', 'D', 'C', 'B', 'A' };//letter grades associated with wpm ranges 
            bool isValid = false;//bool operated in order to make loop end and move to outputting once input is found in the array
            
            int index,//initial variable to be able to start at back end of low-end limits
                wpm;//words per minute variable for input
            index = lowGradeLimits.Length - 1;// puts indedx value at the last spot of array
            if (int.TryParse(wpmTxt.Text, out wpm))
            {
                while (index >= 0 && !isValid)
                {
                    if (wpm >= lowGradeLimits[index])
                        isValid = true;
                    else index--;

                }
                if (isValid)
                    gradeOutput.Text = $"{grade[index]}";
            }
            else MessageBox.Show("Please Enter a Valid Number for your Words per Minute");
        }
    }
}
