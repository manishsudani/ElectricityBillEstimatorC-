using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Manish R Sudani
//Course: Rapid Application Developement
//Assignment: Lab 2
namespace WindowsFormProject
{
    public static class Validator
    {
        // if a text box is not empty (required field)
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true; //innocent until proven guilty
            if(tb.Text == "") //empty text box
            {
                result = false;
                MessageBox.Show(name + " is required", "data entry error");
                tb.Focus();
            }
            return result;
        }
        //tests if input is a non negative integer
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool result = true; //innocent until proven guilty
            int num; //parsed number
            if(!Int32.TryParse(tb.Text, out num))
            {
                result = false;
                MessageBox.Show(name + " has to be a non- negative integer", "data entry error");
                tb.SelectAll();// select all text to facilitate change
                tb.Focus();

            }
            else // if int value; check if non negative
            {
                if(num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "data entry error");
                    tb.SelectAll();// select all text to facilitate change
                    tb.Focus();
                }
                   
            }
            return result;
        }
            //tests if input is a non negative Double
            public static bool IsNonNegativeDouble(TextBox tb, string name)
            {
                bool result = true; //innocent until proven guilty
                Double num; //parsed number
                if (!Double.TryParse(tb.Text, out num))
                {
                    result = false;
                    MessageBox.Show(name + " has to be a non- negative integer", "data entry error");
                    tb.SelectAll();// select all text to facilitate change
                    tb.Focus();

                }
                else // if int value; check if non negative
                {
                    if (num < 0)
                    {
                        result = false;
                        MessageBox.Show(name + " needs to be positive or zero", "data entry error");
                        tb.SelectAll();// select all text to facilitate change
                        tb.Focus();
                    }

                }
                return result;
            }
    }

}
