using System.Globalization;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") //não deixar o usuario usar o botão sem ter um valor registrado
            {
                labelResultado.Text = "*";
                Numero1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                Operador = "multiplicacao";
                textResultado.Text = null;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") //não deixar o usuario usar o botão sem ter um valor registrado
            {
                labelResultado.Text = "+";
                Numero1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                Operador = "soma";
                textResultado.Text = null;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") //não deixar o usuario usar o botão sem ter um valor registrado
            {
                labelResultado.Text = "-";
                Numero1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                Operador = "subtracao";
                textResultado.Text = null;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") //não deixar o usuario usar o botão sem ter um valor registrado
            {
                labelResultado.Text = "÷";
                Numero1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                Operador = "divisao";
                textResultado.Text = null;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResultado.Text = null;
            labelResultado.Text = null;
            Numero1 = 0;
            Numero2 = 0;
            Resultado = 0;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textResultado.Text = null;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Numero2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = null;

            switch (Operador)
            {
                case "soma":
                    Resultado = (Numero1 + Numero2);
                    break;

                case "subtracao":
                    Resultado = (Numero1 - Numero2);
                    break;

                case "multiplicacao":
                    Resultado = (Numero1 * Numero2);
                    break;

                case "divisao":
                    Resultado = (Numero1 / Numero2);
                    break;

            }

            textResultado.Text = Convert.ToString(Resultado("N5"));


        }


    }
}