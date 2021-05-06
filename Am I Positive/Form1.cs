using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Am_I_Positive
{
    
    
    public partial class amIPositive : Form
    {
        //Global variables
        int input;
        int remainder;
        public amIPositive()
        {
            InitializeComponent();
            
        }

        private void enter_Click(object sender, EventArgs e)
        {
            input = Convert.ToInt32(integerInput.Text);
            if (input >= 0)
            {
                positiveNegative.Text = $"{input} is a positive number";
            }
            else
            {
                positiveNegative.Text = $"{input} is a negative number";
            }

            remainder = input % 7;

            if (remainder == 0)
            {
                divisible.Text = $"{input} is divisile by 7";
            }
            else
            {
                divisible.Text = $"{input} is not divisible by 7";
            }
        }
    }
}
