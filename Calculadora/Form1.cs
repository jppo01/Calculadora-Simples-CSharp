using System.Globalization;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        //Determina��o dos n�meros aos bot�es
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
            if (textResultado.Text != "") //n�o deixar o usuario usar o bot�o sem ter um valor registrado
            {
                labelResultado.Text = "+";
                Numero1 = Numero1 + decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                Operador = "soma";
                textResultado.Text = null;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") //n�o deixar o usuario usar o bot�o sem ter um valor registrado
            {
                labelResultado.Text = "-";
                Numero1 = Numero1 - decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                Operador = "subtracao";
                textResultado.Text = null;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") //n�o deixar o usuario usar o bot�o sem ter um valor registrado
            {
                if (Numero1 != 0)
                {
                    labelResultado.Text = "*";
                    Numero1 = Numero1 * decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                    Operador = "multiplicacao";
                    textResultado.Text = null;
                }
                else
                {
                    labelResultado.Text = "*";
                    Numero1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                    Operador = "multiplicacao";
                    textResultado.Text = null;
                }

                }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") //n�o deixar o usuario usar o bot�o sem ter um valor registrado
            {
                if (Numero1 != 0)
                    {
                        labelResultado.Text = "�";
                        Numero1 = Numero1 / decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                        Operador = "divisao";
                        textResultado.Text = null;
                    } else
                {
                        labelResultado.Text = "�";
                        Numero1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                        Operador = "divisao";
                        textResultado.Text = null;
                }
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

        // bot�o =
        private void button11_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") // n�o deixa o usu�rio entrar na op��o de igual sem informar valor
            {
                Numero2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
            }

            //identificando qual � o tipo de opera��o e realizando-a
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
                    if (Numero2 == 0)
                    {
                        MessageBox.Show("N�o se divide por Zero!");

                    } else
                    {
                        Resultado = (Numero1 / Numero2);
                    }
                    break;
                // informa ao usu�rio que nenhum valor foi informado
                default: 
                    MessageBox.Show("Nenhum valor foi informado!");
                    break;

            }

            textResultado.Text = Convert.ToString(Resultado);
            labelResultado.Text = "";
            Numero1 = 0;
            Numero2 = 0;
            Resultado = 0;


        }


    }
}