﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    string input = string.Empty;
    string operand1 = string.Empty;
    string operand2 = string.Empty;
    string tempText = string.Empty;
    char operation;
    double result = 0.0;
    bool opFlag = false;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void zero_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || this.screen.Text == "0" || !opFlag)
        {
            input += "0";
            this.screen.Text = input;
        }
        else
        {
            this.screen.Text += "0";
            input += "0";
            opFlag = true;
        }
    }

    protected void Button5_Click(object sender, EventArgs e) //Botón 1
    {
        if (this.screen.Text == "" || !opFlag)
        {
            input += "1";
            this.screen.Text = input;
        }
        else
        {
            this.screen.Text += "1";
            input += "1";
            opFlag = true;
        }
    }

    protected void two_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            input += "2";
            this.screen.Text = input;
        }
        else
        {
            this.screen.Text += "2";
            input += "2";
            opFlag = true;
        }
    }

    protected void three_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            input += "3";
            this.screen.Text = input;
        }
        else
        {
            this.screen.Text += "3";
            input += "3";
            opFlag = true;
        }
    }

    protected void four_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            input += "4";
            this.screen.Text = input;
        }
        else
        {
            this.screen.Text += "4";
            input += "4";
            opFlag = true;
        }
    }

    protected void five_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            input += "5";
            this.screen.Text = input;
        }
        else
        {
            this.screen.Text += "5";
            input += "5";
            opFlag = true;
        }
    }

    protected void six_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            input += "6";
            this.screen.Text = input;
        }
        else
        {
            this.screen.Text += "6";
            input += "6";
            opFlag = true;
        }
    }

    protected void seven_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            input += "7";
            this.screen.Text = input;
        }
        else
        {
            this.screen.Text += "7";
            input += "7";
            opFlag = true;
        }
    }

    protected void eight_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            input += "8";
            this.screen.Text = input;
        }
        else
        {
            this.screen.Text += "8";
            input += "8";
            opFlag = true;
        }
    }

    protected void nine_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            input += "9";
            this.screen.Text = input;
        }
        else
        {
            this.screen.Text += "9";
            input += "9";
            opFlag = true;
        }
    }

    protected void sum_Click(object sender, EventArgs e)
    {
        if (!opFlag)
        {
            if (operand1 == string.Empty)
            {
                operand1 = input;
                this.screen.Text += " + ";
                tempText = this.screen.Text;
                operation = '+';
                input = string.Empty;
                opFlag = true;
            }
            else
            {
                this.screen.Text += " + ";
                operation = '+';
                input = string.Empty;
                opFlag = true;
            }
        }
        else
        {
            calculate();
            this.screen.Text += " + ";
            operation = '+';
            input = string.Empty;
        }
    }

    protected void sub_Click(object sender, EventArgs e)
    {
        if (!opFlag)
        {
            if (operand1 == string.Empty)
            {
                operand1 = input;
                this.screen.Text += " - ";
                operation = '-';
                input = string.Empty;
                opFlag = true;
            }
            else
            {
                this.screen.Text += " - ";
                operation = '-';
                input = string.Empty;
                opFlag = true;
            }
        }
        else
        {
            calculate();
            this.screen.Text += " - ";
            operation = '-';
            input = string.Empty;
        }
    }

    protected void div_Click(object sender, EventArgs e)
    {
        if (!opFlag)
        {
            if (operand1 == string.Empty)
            {
                operand1 = input;
                this.screen.Text += " / ";
                tempText = this.screen.Text;
                operation = '/';
                input = string.Empty;
                opFlag = true;
            }
            else
            {
                this.screen.Text += " / ";
                operation = '/';
                input = string.Empty;
                opFlag = true;
            }
        }
        else
        {
            calculate();
            this.screen.Text += " / ";
            operation = '/';
            input = string.Empty;
        }
    }

    protected void mul_Click(object sender, EventArgs e)
    {
        if (!opFlag)
        {
            if (operand1 == string.Empty)
            {
                operand1 = input;
                this.screen.Text += " * ";
                tempText = this.screen.Text;
                operation = '*';
                input = string.Empty;
                opFlag = true;
            }
            else
            {
                this.screen.Text += " * ";
                operation = '*';
                input = string.Empty;
                opFlag = true;
            }
        }
        else
        {
            calculate();
            this.screen.Text += " * ";
            operation = '*';
            input = string.Empty;
        }
    }

    protected void dot_Click(object sender, EventArgs e)
    {
        if (input == "")
        {
            this.screen.Text = "0.";
            input += "0.";
        }
        else
        {
            if (!input.Contains("."))
            {
                this.screen.Text += ".";
                input += ".";
            }
        }
    }

    protected void equals_Click(object sender, EventArgs e)
    {
        if (!(operation == 'n'))//n es operador nulo. Si el operador no es nulo, calculamos.
        {
            calculate();
        }
        opFlag = false;
        tempText = "";
    }

    protected void backspace_Click(object sender, EventArgs e)
    {
        if (input.Length > 0)
        {
            input = input.Remove(input.Length - 1);
            this.screen.Text = tempText + input;
        }
    }

    protected void clear_Click(object sender, EventArgs e)
    {
        clearStuff();
    }

    private void calculate()
    {
        operand2 = input;
        double num1, num2;
        double.TryParse(operand1, out num1);
        double.TryParse(operand2, out num2);

        if (operation == '+')
        {
            result = num1 + num2;
            this.screen.Text = result.ToString();
            operand1 = result.ToString();
            tempText = operand1;
        }
        else if (operation == '-')
        {
            result = num1 - num2;
            this.screen.Text = result.ToString();
            operand1 = result.ToString();
            tempText = operand1;
        }
        else if (operation == '*')
        {
            result = num1 * num2;
            this.screen.Text = result.ToString();
            operand1 = result.ToString();
            tempText = operand1;
        }
        else if (operation == '/')
        {
            if (num2 == 0)
            {
                this.screen.Text = "Error: Div by 0.";
                operand1 = "0";
                tempText = "";
            }
            else
            {
                result = num1 / num2;
                this.screen.Text = result.ToString();
                operand1 = result.ToString();
                tempText = operand1;
            }
        }
    }

    private void clearStuff()
    {
        this.screen.Text = string.Empty;
        this.operand1 = string.Empty;
        this.operand2 = string.Empty;
        result = 0;
        tempText = "";
        operation = 'n';
        this.input = "";
    }
}