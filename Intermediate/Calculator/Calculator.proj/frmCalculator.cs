using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.BusinessLayer;

namespace Calculator.proj
{
    public partial class frmCalculator : Form
    {

        //Declares the variables.
        decimal Operand1 = 0;
        decimal Operand2 = 0;
        decimal LastNumber = 0;
        decimal Total = 0;
        string Operator;
        bool Repeat = false;
        bool DivideByZero = false;
        double SqrtDouble;
        

        //Declare the Calculator object.
        CCalculator oCalculator;
        

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {//Clears the 'Output' text box. And Resets the Variables.
            txtOutput.Text = string.Empty;
            Operand1 = 0;
            Operand2 = 0;
            Total = 0;
            Operator = string.Empty;
            SqrtDouble = 0;

            DivideByZero = false;
            Repeat = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {//Removes the last number the user added, and does nothing if the text box is empty.
            if (txtOutput.Text == "" & DivideByZero == false)
            {
                return;
            }

            else if (DivideByZero == false)
	        {
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.Length - 1);

                Repeat = false;
	        }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {//Adds a Decimal point.
            if (txtOutput.Text.Contains(".") & DivideByZero == false)
            {
                return;
            }

            else if (DivideByZero == false)
            {
              txtOutput.Text = txtOutput.Text + ".";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {//Sets the Operator to +
            if(DivideByZero == false)
        {  Operator = "+";

            decimal.TryParse(txtOutput.Text, out Operand1);

            txtOutput.Text = string.Empty;

            Repeat = false;
        }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {//Sets the Operator to -
            if (DivideByZero == false)
            {Operator = "-";

            decimal.TryParse(txtOutput.Text, out Operand1);

            txtOutput.Text = string.Empty;

            Repeat = false;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {//Sets the Operator to *
            if (DivideByZero == false)
            {
                Operator = "*";

                decimal.TryParse(txtOutput.Text, out Operand1);

                txtOutput.Text = string.Empty;

                Repeat = false;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {//Sets the Operator to /
            if (DivideByZero == false)
            {
                Operator = "/";

                decimal.TryParse(txtOutput.Text, out Operand1);

                txtOutput.Text = string.Empty;

                Repeat = false;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            //Calls various functions from the business layer.
            if (DivideByZero == false)
            {
                try
                {

                    if (Operator == "+" || Operator == "-" || Operator == "*" || Operator == "/")
                    {
                        oCalculator = new CCalculator();

                        decimal.TryParse(txtOutput.Text, out Operand2);


                        //Calls and uses the 'Plus' function.
                        if (Operator == "+" & Repeat == false)
                        {
                            oCalculator.CalcPlus(Operand1, Operand2, out Total);

                            LastNumber = Operand2;
                            txtOutput.Text = Total.ToString();

                            Repeat = true;
                            return;
                        }

                        if (Operator == "+" & Repeat == true)
                        {
                            oCalculator.CalcPlus(LastNumber, Operand2, out Total);
                            txtOutput.Text = Total.ToString();

                            Repeat = true;
                        }



                        //Calls and uses the 'Minus' function.
                        if (Operator == "-" & Repeat == false)
                        {
                            oCalculator.CalcMinus(Operand1, Operand2, out Total);

                            LastNumber = Operand2;
                            txtOutput.Text = Total.ToString();

                            Repeat = true;
                            return;
                        }

                        if (Operator == "-" & Repeat == true)
                        {
                            oCalculator.CalcMinus(Total, LastNumber, out Total);

                            txtOutput.Text = Total.ToString();

                            Repeat = true;
                        }



                        //Calls and uses the 'Multiply' function.
                        if (Operator == "*" & Repeat == false)
                        {
                            oCalculator.CalcMultiply(Operand1, Operand2, out Total);

                            LastNumber = Operand2;
                            txtOutput.Text = Total.ToString();

                            Repeat = true;
                            return;
                        }

                        if (Operator == "*" & Repeat == true)
                        {
                            oCalculator.CalcMultiply(LastNumber, Operand2, out Total);
                            txtOutput.Text = Total.ToString();

                            Repeat = true;
                        }



                        //Calls and uses the 'Divide' function.
                        if (Operator == "/" & Repeat == false)
                        {
                            oCalculator.CalcDivide(Operand1, Operand2, out Total);

                            LastNumber = Operand2;
                            txtOutput.Text = Total.ToString();

                            Repeat = true;
                            return;
                        }

                        if (Operator == "/" & Repeat == true)
                        {
                            oCalculator.CalcDivide(Total, LastNumber, out Total);
                            txtOutput.Text = Total.ToString();

                            Repeat = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = ex.Message;
                    DivideByZero = true;
                }
            }

            
        }


        private void btnOne_Click(object sender, EventArgs e)
        {
            if (DivideByZero == false)
            { txtOutput.Text = txtOutput.Text + "1"; }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (DivideByZero == false)
            { txtOutput.Text = txtOutput.Text + "2"; }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (DivideByZero == false)
            { txtOutput.Text = txtOutput.Text + "3"; }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (DivideByZero == false)
            { txtOutput.Text = txtOutput.Text + "4"; }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (DivideByZero == false)
            { txtOutput.Text = txtOutput.Text + "5"; }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (DivideByZero == false)
            { txtOutput.Text = txtOutput.Text + "6"; }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (DivideByZero == false)
            {txtOutput.Text = txtOutput.Text + "7";}
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (DivideByZero == false)
            {txtOutput.Text = txtOutput.Text + "8";}
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (DivideByZero == false)
            {txtOutput.Text = txtOutput.Text + "9";}
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (DivideByZero == false)
            {txtOutput.Text = txtOutput.Text + "0";}
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {//Calculates the square root of either the total, or the first Operand.

            if (DivideByZero == false)
            {
                try
                {
                    double Sqrt;

                    if (Repeat == true)
                    {

                        decimal.TryParse(txtOutput.Text, out Total);

                        SqrtDouble = System.Convert.ToDouble(Total);

                        Sqrt = Math.Sqrt(SqrtDouble);

                        txtOutput.Text = Sqrt.ToString();
                    }

                    if (Repeat == false)
                    {

                        decimal.TryParse(txtOutput.Text, out Operand1);

                        SqrtDouble = System.Convert.ToDouble(Operand1);

                        Sqrt = Math.Sqrt(SqrtDouble);

                        txtOutput.Text = Sqrt.ToString();
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = ex.Message;
                    DivideByZero = true;
                }

            }

        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {//Calls the 'Reciprocal' function to find the reciprocal of either the Total, or the first operand.

            if (DivideByZero == false)
            {
                oCalculator = new CCalculator();

                try
                {
                    if (Repeat == false)
                    {
                        decimal.TryParse(txtOutput.Text, out Operand1);

                        oCalculator.CalcReciprocal(Operand2, Operand1, out Total);

                        txtOutput.Text = Total.ToString();

                    }

                    if (Repeat == true)
                    {
                        decimal.TryParse(txtOutput.Text, out LastNumber);

                        oCalculator.CalcReciprocal(Operand2, LastNumber, out Total);

                        txtOutput.Text = Total.ToString();
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = ex.Message;
                    DivideByZero = true;
                }
            }
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {//Sets the number to either positve or negative.
            if (DivideByZero == false)
            {
                if (txtOutput.Text == string.Empty || txtOutput.Text == "")
                {
                    return;
                }

                if (txtOutput.Text.Contains("-") & Repeat == true)
                {
                    Total = Math.Abs(Total);

                    txtOutput.Text = Total.ToString();

                    return;

                }

                if (Repeat == true)
                {
                    Total = Total * -1;

                    txtOutput.Text = Total.ToString();
                    return;
                }


                if (txtOutput.Text.Contains("-") & Repeat == false)
                {
                    decimal.TryParse(txtOutput.Text, out Operand1);

                    Operand1 = Math.Abs(Operand1);

                    txtOutput.Text = Operand1.ToString();
                    return;
                }

                if (Repeat == false)
                {
                    decimal.TryParse(txtOutput.Text, out Operand1);

                    Operand1 = Operand1 * -1;

                    txtOutput.Text = Operand1.ToString();
                    return;
                }
            }
        }
    }
}
