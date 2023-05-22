using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomnPhil_Construction.Controller
{
    class InputUtilities
    {
        public void clearTextboxes(GroupBox control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Clear();
                }
                else
                {

                }
            }
        }
        public void clearTextboxes(Panel control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Clear();
                }
                else
                {

                }
            }
        }
        public void clearTextboxes(Form control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Clear();
                }
                else
                {

                }
            }
        }
        public bool completelyFilled(GroupBox control,ErrorProvider error)
        {
            bool result = false;
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    if (tb.Text.Length <= 0)
                    {
                        error.SetError(tb,"Please fill in this field before saving!"); 
                        return false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                        error.SetError(cb,"Please choose a value before saving!"); 
                    if (cb.Text.Length <= 0)
                    {
                        return false;
                    }
                    else
                    {
                        result = true;
                    }

                }

            }
            return result;
        }
        public bool isInteger(String input)
        {
            //Of course, the input would be string
            //But we need to convert it to an integer
            //Step 1: Declare an integer that will be wrapped inside a try-catch block
            try
            {
                int intInput;
                //Step 2: convert that input string parameter to an integer and store it as the inputInteger
                intInput = Convert.ToInt32(input);
                return true;
                //If the string input is not a number, it will emit a FormatException error.
            }
            catch (Exception ex)
            {
                //So we check the Exception ex variable
                //But before all of that, we need to know that not all FormatException errors are caused by invalid inputs
                //For example, null inputs can also emit FormatException errors
                //So, we check that first 
                if (input.Length >= 0)
                {
                    //Then, we dive into our main objective
                    //Check the input if it emits the FormatException error
                    if (ex is FormatException)
                    {
                        if (input.Length <= 1)
                        {
                            return false;
                        }
                        else
                        {
                            //Tell the user to check his input
                            System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        //Obviously, we need to also play safe. So if the error is not FormatException, we still need the user to properly input the value.
                        System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please input a value", "No input found", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
            //This'll work like a charm because I am literally the smartest programmer that has ever lived.
            return false;
        }
        public bool isIntegerNoMessage(String input)
        {
            //Of course, the input would be string
            //But we need to convert it to an integer
            //Step 1: Declare an integer that will be wrapped inside a try-catch block
            try
            {
                int intInput;
                //Step 2: convert that input string parameter to an integer and store it as the inputInteger
                intInput = Convert.ToInt32(input);
                return true;
                //If the string input is not a number, it will emit a FormatException error.
            }
            catch (Exception ex)
            {
                //So we check the Exception ex variable
                //But before all of that, we need to know that not all FormatException errors are caused by invalid inputs
                //For example, null inputs can also emit FormatException errors
                //So, we check that first 
                if (input.Length >= 0)
                {
                    //Then, we dive into our main objective
                    //Check the input if it emits the FormatException error
                    if (ex is FormatException)
                    {
                        if (input.Length <= 1)
                        {
                            return false;
                        }
                        else
                        {
                            //Tell the user to check his input
                            return false;
                        }
                    }
                    else
                    {
                        //Obviously, we need to also play safe. So if the error is not FormatException, we still need the user to properly input the value.
                        System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please input a value", "No input found", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
            //This'll work like a charm because I am literally the smartest programmer that has ever lived.
            return false;
        }


        //Next, we write a method that will check if the string input is a double
        public bool isDouble(String input)
        {
            //We do that by applying the same principles we did when checking if the input string iz a ints
            //??
            //We geets them input stringz from thems parameters
            // On God, I will spank ya ass if ya input some weird ass non-numeric values
            try
            {
                Double inputDouble = Convert.ToDouble(input);
                return true;
            }
            catch (Exception ex)
            {
                if (input.Length >= 0)
                {
                    //Check the input if it emits the FormatException error
                    if (ex is FormatException)
                    {
                        if (input.Length <= 1)
                        {
                            return false;
                        }
                        else
                        {
                            //Tell the user to check his input
                            System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        //Obviously, we need to also play safe. So if the error is not FormatException, we still need the user to properly input the value.
                        //System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }

                }
                else
                {
                }
                return false;
            }
        }
        public bool isValidPayment(String input, Double whateverTheFuckIsLeft)
        {
            //We do that by applying the same principles we did when checking if the input string iz a ints
            //??
            //We geets them input stringz from thems parameters
            // On God, I will spank ya ass if ya input some weird ass non-numeric values
            try
            {
                Double inputDouble = Convert.ToDouble(input);
                if (inputDouble <= whateverTheFuckIsLeft)
                {
                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Payment cannot be more than Credit!", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

                    return false;
                }

            }
            catch (Exception ex)
            {
                if (input.Length >= 0)
                {
                    //Check the input if it emits the FormatException error
                    if (ex is FormatException)
                    {
                        if (input.Length <= 1)
                        {
                            return false;
                        }
                        else
                        {
                            //Tell the user to check his input
                            System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        //Obviously, we need to also play safe. So if the error is not FormatException, we still need the user to properly input the value.
                        //System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }

                }
                else
                {
                }
                return false;
            }
        }
        public bool isDoubleNoMessage(String input)
        {
            //We do that by applying the same principles we did when checking if the input string iz a ints
            //??
            //We geets them input stringz from thems parameters
            // On God, I will spank ya ass if ya input some weird ass non-numeric values
            try
            {
                Double inputDouble = Convert.ToDouble(input);
                return true;
            }
            catch (Exception ex)
            {
                if (input.Length >= 0)
                {
                    //Check the input if it emits the FormatException error
                    if (ex is FormatException)
                    {
                        if (input.Length <= 1)
                        {
                            return false;
                        }
                        else
                        {
                            //Tell the user to check his input
                            return false;
                        }
                    }
                    else
                    {
                        //Obviously, we need to also play safe. So if the error is not FormatException, we still need the user to properly input the value.
                        //System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }

                }
                else
                {
                }
                return false;
            }
        }
        public bool isValidQuantity1(String input, int remaining_quantity)
        {
            //We do that by applying the same principles we did when checking if the input string iz a ints
            //??
            //We geets them input stringz from thems parameters
            // On God, I will spank ya ass if ya input some weird ass non-numeric values
            try
            {
                int inputQuantity = Convert.ToInt32(input);
                if (inputQuantity >= remaining_quantity)
                {
                    System.Windows.Forms.MessageBox.Show("Input cannot exceed the remaining amount.", "Insufficient remaining quantity", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                if (input.Length >= 0)
                {
                    //Check the input if it emits the FormatException error
                    if (ex is FormatException)
                    {
                        if (input.Length <= 0)
                        {
                            return false;
                        }
                        else
                        {
                            //Tell the user to check his input
                            System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        //Obviously, we need to also play safe. So if the error is not FormatException, we still need the user to properly input the value.
                        System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please input a value", "No input found", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                return false;
            }
        }
        public bool isValidQuantity(String input, int remaining_quantity)
        {
            //We do that by applying the same principles we did when checking if the input string iz a ints
            //??
            //We geets them input stringz from thems parameters
            // On God, I will spank ya ass if ya input some weird ass non-numeric values
            try
            {
                int inputQuantity = Convert.ToInt32(input);
                if (inputQuantity > remaining_quantity)
                {
                    System.Windows.Forms.MessageBox.Show("Input cannot exceed the remaining amount.", "Insufficient remaining quantity", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                if (input.Length >= 0)
                {
                    //Check the input if it emits the FormatException error
                    if (ex is FormatException)
                    {
                        if (input.Length <= 0)
                        {
                            return false;
                        }
                        else
                        {
                            //Tell the user to check his input
                            System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        //Obviously, we need to also play safe. So if the error is not FormatException, we still need the user to properly input the value.
                        System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please input a value", "No input found", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                return false;
            }
        }
        public bool isValidLowStockQuantity(String input, int remaining_quantity)
        {
            //We do that by applying the same principles we did when checking if the input string iz a ints
            //??
            //We geets them input stringz from thems parameters
            // On God, I will spank ya ass if ya input some weird ass non-numeric values
            try
            {
                int inputQuantity = Convert.ToInt32(input);
                if (inputQuantity > remaining_quantity)
                {
                    System.Windows.Forms.MessageBox.Show("Input cannot exceed the quantity.", "Insufficient quantity", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                if (input.Length >= 0)
                {
                    //Check the input if it emits the FormatException error
                    if (ex is FormatException)
                    {
                        if (input.Length <= 0)
                        {
                            return false;
                        }
                        else
                        {
                            //Tell the user to check his input
                            System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        //Obviously, we need to also play safe. So if the error is not FormatException, we still need the user to properly input the value.
                        System.Windows.Forms.MessageBox.Show("Please input a valid value", "Invalid input", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please input a value", "No input found", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                return false;
            }
        }


        public void disableUpdateControls(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is ComboBox || item is Button)
                {
                    item.Enabled = false;
                }

            }
        }
    }
}
