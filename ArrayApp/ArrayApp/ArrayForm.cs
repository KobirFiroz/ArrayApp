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
    public partial class ArrayForm : Form
    {
        static int size = 10;
        int[] number = new int[size];

        int index = 0;

        public ArrayForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int[] number = new int[size];
            number[0] = 45;
            number[2] = 15;
            number[5] = 85;
            number[8] = 5;
            number[9] = 500;

            string message = "";
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "Element of index[" + index + "] is =" + number[index].ToString() + "\n";
                showRichTextBox.Text = message;
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string message = "";
            int temp = 0;
            number[index] = Convert.ToInt32(numberTextBox.Text);
            int[] number2 = new int[size];
            for (int index = 0; index < number2.Length; index++)
            {
                number2[index] = number[index];
            }
            for (int index = 0; index < number2.Length; index++)
            {
                for (int checkIndex = index + 1; checkIndex < number2.Length; checkIndex++)
                {
                    if (number2[index] > number2[checkIndex])
                    {
                        temp = number2[index];
                        number2[index] = number2[checkIndex];
                        number2[checkIndex] = temp;
                    }
                }
            }
            for (int index = 0; index < number.Length; index++)
            {
                if (number2[index] != 0)
                    message = message + "Your Added Element is = "+ number2[index] + "\n";
            }
            index++;
            showRichTextBox.Text = message;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";

            for (int index = number.Length - 1; index >= 0; index--)
            {
                if (number[index] != 0)
                    message = message + "Element of index[" + index + "] is =" + number[index].ToString() + "\n";
            }
            showRichTextBox.Text = message;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int index = 0; index < number.Length; index++)
            {
                sum = sum + number[index];
            }
            showRichTextBox.Text = "Total Result of array value is : " + sum.ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            int[] number2 = new int[size];
            for (int index = 0; index < number2.Length; index++)
            {
                number2[index] = number[index];
            }
            string message = "";
            for (int index = 0; index < number2.Length; index++)
            {
                if (number2[index] != 0)
                    message = message + "Element of index[" + index + "] is =" + number2[index].ToString() + "\n";
            }
            showRichTextBox.Text = "Copy value: \n" + message;
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            string message = "";
            int value = 0;
            int[] duplicate = new int[size];
            for (int startIndex = 0; startIndex < number.Length; startIndex++)
            {
                value = number[startIndex];
                for (int checkIndex = startIndex + 1; checkIndex < number.Length; checkIndex++)
                {
                    if (value == number[checkIndex])
                    {
                        for (int includeIndex = 0; includeIndex < duplicate.Length; includeIndex++)
                        {
                            if (duplicate[includeIndex] == 0 && duplicate[includeIndex] != value)
                            {
                                duplicate[includeIndex] = value;
                                break;
                            }
                            else
                            {
                                if (duplicate[includeIndex + 1] == 0)
                                {
                                    if (duplicate[includeIndex] == value)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        duplicate[includeIndex + 1] = value;
                                    }
                                }
                            }

                        }
                        break;
                    }
                }

            }
            for (int startIndex = 0; startIndex < duplicate.Length; startIndex++)
            {
                if (duplicate[startIndex] != 0)
                {
                    message = message + duplicate[startIndex] + "\n";
                }
            }
            showRichTextBox.Text = "Duplicate value is : \n" + message;
        }

        //private void UniqueButton_Click(object sender, EventArgs e)
        //{
        //    string message = "";
        //    int value = 0;
        //    int uniqueValue = 0;
        //    int[] unique = new int[size];
        //    for (int startIndex = 0; startIndex < number.Length; startIndex++)
        //    {
        //        value = number[startIndex];
        //        for (int checkIndex = startIndex+1; checkIndex < number.Length; checkIndex++)
        //        {
        //            if (value == number[checkIndex])
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                if (value != number[checkIndex - 2])
        //                {
        //                    uniqueValue = 1;
        //                }
        //                else
        //                {
        //                    break;
        //                }                        
        //            }
        //        }
        //        if (uniqueValue == 1)
        //        {
        //            for (int includeIndex = 0; includeIndex < unique.Length; includeIndex++)
        //            {
        //                if (unique[includeIndex] == 0 && unique[includeIndex] != value)
        //                {
        //                    unique[includeIndex] = value;
        //                    break;
        //                }
        //                else
        //                {
        //                    if (unique[includeIndex + 1] == 0)
        //                    {
        //                        if (unique[includeIndex] == value)
        //                        {
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            unique[includeIndex + 1] = value;
        //                        }
        //                    }
        //                }

        //            }
        //        }

        //    }
        //    for (int startIndex = 0; startIndex < unique.Length; startIndex++)
        //    {
        //        if (unique[startIndex] != 0)
        //        {
        //            message = message + unique[startIndex] + "\n";
        //        }
        //    }
        //    showRichTextBox.Text = "Unique value is : \n" + message;
        //}

        private void MaximumButton_Click(object sender, EventArgs e)
        {

            //int value = 0;
            //int maxValue = 0;
            //for(int i = 0; i < number.Length; i++)
            //{
            //    value = number[i];
            //    for(int j = i ; j < number.Length; j++)
            //    {
            //        if ((value >= number[j])&& (value>maxValue))
            //        {
            //            maxValue = value;
            //        }

            //    }
            //}
            int maxValue = number[0];
            for(int index = 1; index < number.Length; index++)
            {
                if (number[index] > maxValue)
                    maxValue = number[index];
            }
            showRichTextBox.Text ="Maximum value is : "+ maxValue.ToString();
        }

        private void MinimumButton_Click(object sender, EventArgs e)
        {
            int minValue = number[0];
            for(int index = 1; index < number.Length; index++)
            {
                if ((number[index] <= minValue)&&number[index]!=0)
                    minValue = number[index];
            }
            showRichTextBox.Text ="Minimum value : "+ minValue.ToString();
        }

        private void EvenButton_Click(object sender, EventArgs e)
        {
            string message = "";
            int[] evenValue = new int[size];
            for(int index = 0; index < number.Length; index++)
            {
                if (number[index] % 2 == 0)
                {
                    for (int includeIndex = 0; includeIndex < evenValue.Length; includeIndex++)
                    {
                        if (evenValue[includeIndex] == 0 && evenValue[includeIndex] != number[index])
                        {
                            evenValue[includeIndex] = number[index];
                            break;
                        }
                        else
                        {
                            if (evenValue[includeIndex + 1] == 0)
                            {
                                if (evenValue[includeIndex] == number[index])
                                {
                                    break;
                                }
                                else
                                {
                                    evenValue[includeIndex + 1] = number[index];
                                }
                            }
                        }

                    }
                }
                
            }
            for (int startIndex = 0; startIndex < evenValue.Length; startIndex++)
            {
                if (evenValue[startIndex] != 0)
                {
                    message = message + evenValue[startIndex] + "\n";
                }
            }
            showRichTextBox.Text = "Even value is : \n" + message;
        }

        private void OddButton_Click(object sender, EventArgs e)
        {
            string message = "";
            int[] oddValue = new int[size];
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] % 2 != 0)
                {
                    for (int includeIndex = 0; includeIndex < oddValue.Length; includeIndex++)
                    {
                        if (oddValue[includeIndex] == 0 && oddValue[includeIndex] != number[index])
                        {
                            oddValue[includeIndex] = number[index];
                            break;
                        }
                        else
                        {
                            if (oddValue[includeIndex + 1] == 0)
                            {
                                if (oddValue[includeIndex] == number[index])
                                {
                                    break;
                                }
                                else
                                {
                                    oddValue[includeIndex + 1] = number[index];
                                }
                            }
                        }
                    }
                }
            }
            for (int startIndex = 0; startIndex < oddValue.Length; startIndex++)
            {
                if (oddValue[startIndex] != 0)
                {
                    message = message + oddValue[startIndex] + "\n";
                }
            }
            showRichTextBox.Text = "Odd value is : \n" + message;
        }

        private void AscendingButton_Click(object sender, EventArgs e)
        {
            int temp = 0;
            string message = "";
            
            for(int index = 0; index < number.Length; index++)
            {
                for(int checkIndex = index + 1; checkIndex < number.Length; checkIndex++)
                {
                    if (number[index] > number[checkIndex])
                    {
                        temp = number[index];
                        number[index] = number[checkIndex];
                        number[checkIndex] = temp;
                    }
                }
            }
            for(int index = 0; index < number.Length; index++)
            {
                if(number[index]!=0)
                message = message + number[index] + "\n";
            }
            showRichTextBox.Text = "Ascending order : \n" + message;
        }

        private void Descending_Click(object sender, EventArgs e)
        {
            int temp = 0;
            string message = "";
            
            for (int index = 0; index < number.Length; index++)
            {
                for (int checkIndex = index + 1; checkIndex < number.Length; checkIndex++)
                {
                    if (number[index] < number[checkIndex])
                    {
                        temp = number[index];
                        number[index] = number[checkIndex];
                        number[checkIndex] = temp;
                    }
                }
            }
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + number[index] + "\n";
            }
            showRichTextBox.Text = "Descending order : \n" + message;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string message = "";
            message = "input Value\n";
            message = message + Show();

            message = message + "\nReverse Value\n";

            for (int index = size -1; index >= 0; index--)
            {
                if (number[index] != 0)
                    message = message + "Element of index[" + index + "] is =" + number[index].ToString() + "\n";
            }
            showRichTextBox.Text =  message;

        }

        private string Show() {

            string message = "";
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "Element of index[" + index + "] is =" + number[index].ToString() + "\n";
            }
            return message;
        }

    }
}
