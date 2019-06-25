using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayApp
{
    public partial class Form1 : Form
    {


        const int size = 10;
        int[] number = new int[size];
        int index = 0;
        int sum=0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int[] number = new int[size];

            number[0] = 10;
            number[4] = 120;
            number[9] = 11;

            string message = "";
            for(int index=0;index < number.Length;index++)
            {

                if(number[index] !=0)
                    message=message+"Elements at index ["+index+ "]is: " + number[index].ToString()+"\n";

            }
            richTextBox.Text = message;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            number[index] = Convert.ToInt32(AddTextBox.Text);
            index++;
            string message = "";
            for (int index = 0; index < number.Length; index++)
            {

                if (number[index] != 0)
                    message = message + "Elements at index [" + index + "]is: " + number[index].ToString() + "\n";

            }
            richTextBox.Text = message;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
           
            string message = "";
            for (int index = number.Length; index > 0; index--)
            {

                if (number[index-1] != 0)
                    message = message + "Elements at index [" +( index -1) + "]is: " + number[index-1].ToString() + "\n";

            }
            richTextBox.Text = message;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < number.Length; index++)
                 sum = sum + number[index];
            richTextBox.Text ="Total Sum of Arrey" +sum.ToString();
         
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            int []number2 = new int[size];
            for (int index = 0; index < number2.Length; index++)
            {
                number2[index] = number[index];
            }
            string message = "";
            for (int index = 0; index < number2.Length; index++)
            {

                if (number2[index] != 0)
                    message = message + "Elements at index of [" + index + "]is: " + number2[index].ToString() + "\n";

            }
            richTextBox.Text ="Copy valu of"+ message;

        }

        private void Dupl_Click(object sender, EventArgs e)
        {
            number[index] = Convert.ToInt32(AddTextBox.Text);
            index++;
            for (int index = 0; index < number.Length; index++)
            {
                arr2[index] = arr1[iindex];
                arr3[iindex] = 0;
            }
        }
    }
}
