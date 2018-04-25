


using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string firstnumber, secondnumber;

        char typeoperation = ' ';

        private void Form1_Load(object sender, EventArgs e)
        {

        }       

        private void button0_Click(object sender, EventArgs e)
        {
            action(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            action(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            action(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            action(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            action(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            action(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            action(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            action(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            action(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            action(9);
        }

        private void buttonDodawanie_Click(object sender, EventArgs e)
        {
            typeoperation = '+';
            tbWynik.Text = " ";

        }

        private void buttonOdejmowanie_Click(object sender, EventArgs e)
        {
            typeoperation = '-';
            tbWynik.Text = " ";
        }

        private void buttonMnozenie_Click(object sender, EventArgs e)
        {
            typeoperation = '*';
            tbWynik.Text = " ";
        }

        private void buttonDzielenie_Click(object sender, EventArgs e)
        {
            typeoperation = '/';
            tbWynik.Text = " ";
        }

        private void buttonWynik_Click(object sender, EventArgs e)
        {
            switch (typeoperation)  { 
                case ('+'):
                    tbWynik.Text = (int.Parse(firstnumber) + int.Parse(secondnumber)).ToString();
                    break;
                case ('-'):
                    tbWynik.Text = (int.Parse(firstnumber) - int.Parse(secondnumber)).ToString();
                    break;
                case ('/'):
                    tbWynik.Text = (int.Parse(firstnumber) / int.Parse(secondnumber)).ToString();
                    break;
                case ('*'):
                    tbWynik.Text = (int.Parse(firstnumber) * int.Parse(secondnumber)).ToString();
                    break;

             }
           firstnumber = "";
            secondnumber = "";
            typeoperation = ' ';
        }
        private void tbWynik_TextChanged(object sender, EventArgs e)
        {

        }
        private void action(int liczba)
        {
             if(typeoperation == ' ')
            {
                firstnumber += liczba;
                tbWynik.Text = firstnumber;
            }
            else
            {
                secondnumber += liczba;
                tbWynik.Text = secondnumber;
            }
        }      
    }    
}
