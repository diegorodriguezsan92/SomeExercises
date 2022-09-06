using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5
    }

    public partial class Calculator : Form
    {
        double valor1 = 0;
        double valor2 = 0;

        Operacion operador = Operacion.NoDefinida;
        bool numeroLeido = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void ReadNumber(string number)
        {
            numeroLeido = true;
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = number;
            }
            else
            {
                resultBox.Text += number;
            }
        }

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;

                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;

                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        //MessageBox.Show("Math ERROR: no puede dividir entre 0");  Esta opción nos muestra un mensaje emergente.
                        lblHistorial.Text = "Math ERROR: no puede dividir entre 0";
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;

                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;

                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btt0_Click(object sender, EventArgs e)
        {
            numeroLeido = true;
            if (resultBox.Text == "0")
            {
                return;
            }
            else
            {
                resultBox.Text += "0";
            }
        }

        private void btt1_Click(object sender, EventArgs e)
        {
            ReadNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadNumber("2");
        }
        private void btt3_Click(object sender, EventArgs e)
        {
            ReadNumber("3");
        }

        private void btt4_Click(object sender, EventArgs e)
        {
            ReadNumber("4");
        }

        private void btt5_Click(object sender, EventArgs e)
        {
            ReadNumber("5");
        }

        private void btt6_Click(object sender, EventArgs e)
        {
            ReadNumber("6");
        }

        private void btt7_Click(object sender, EventArgs e)
        {
            ReadNumber("7");
        }

        private void btt8_Click(object sender, EventArgs e)
        {
            ReadNumber("8");
        }

        private void btt9_Click(object sender, EventArgs e)
        {
            ReadNumber("9");
        }


        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(resultBox.Text);
            lblHistorial.Text = resultBox.Text + operador;
            resultBox.Text = "0";
        }

        private void bttAddition_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");

        }

        private void bttResult_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && numeroLeido)
            {
                valor2 = Convert.ToDouble(resultBox.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                numeroLeido = false;
                resultBox.Text = Convert.ToString(resultado);
            }
        }

        private void bttSubstract_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void bttMultiply_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void bttDiv_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void bttModule_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void bttReset_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            lblHistorial.Text = "";
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 1)
            {
                string txtResultado = resultBox.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    resultBox.Text = "0";
                }

                else
                {
                    resultBox.Text = txtResultado;
                }

            }
            else
            {
                resultBox.Text = "0";
            }
        }

        private void bttDot_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Contains(","))
            {
                return;
            }
            resultBox.Text += ",";
        }
    }
}
