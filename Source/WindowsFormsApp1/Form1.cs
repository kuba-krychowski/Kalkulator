


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

        string Liczbapierwsza, Liczbadruga;

        char Rodzajdzialania = ' ';

        private void Form1_Load(object sender, EventArgs e)
        {

        }       

        private void button0_Click(object sender, EventArgs e)
        {
            dzialanie(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dzialanie(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dzialanie(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dzialanie(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dzialanie(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dzialanie(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dzialanie(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dzialanie(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dzialanie(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dzialanie(9);
        }

        private void buttonDodawanie_Click(object sender, EventArgs e)
        {
            Rodzajdzialania = '+';
            tbWynik.Text = " ";

        }

        private void buttonOdejmowanie_Click(object sender, EventArgs e)
        {
            Rodzajdzialania = '-';
            tbWynik.Text = " ";
        }

        private void buttonMnozenie_Click(object sender, EventArgs e)
        {
            Rodzajdzialania = '*';
            tbWynik.Text = " ";
        }

        private void buttonDzielenie_Click(object sender, EventArgs e)
        {
            Rodzajdzialania = '/';
            tbWynik.Text = " ";
        }

        private void buttonWynik_Click(object sender, EventArgs e)
        {
            switch (Rodzajdzialania)  { 
                case ('+'):
                    tbWynik.Text = (int.Parse(Liczbapierwsza) + int.Parse(Liczbadruga)).ToString();
                    break;
                case ('-'):
                    tbWynik.Text = (int.Parse(Liczbapierwsza) - int.Parse(Liczbadruga)).ToString();
                    break;
                case ('/'):
                    tbWynik.Text = (int.Parse(Liczbapierwsza) / int.Parse(Liczbadruga)).ToString();
                    break;
                case ('*'):
                    tbWynik.Text = (int.Parse(Liczbapierwsza) * int.Parse(Liczbadruga)).ToString();
                    break;

             }
            Liczbapierwsza = "";
            Liczbadruga = "";
            Rodzajdzialania = ' ';
        }
        private void tbWynik_TextChanged(object sender, EventArgs e)
        {

        }
        private void dzialanie(int liczba)
        {
             if(Rodzajdzialania == ' ')
            {
                Liczbapierwsza += liczba;
                tbWynik.Text = Liczbapierwsza;
            }
            else
            {
                Liczbadruga += liczba;
                tbWynik.Text = Liczbadruga;
            }
        }      
    }    
}
