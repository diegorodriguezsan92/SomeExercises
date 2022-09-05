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

    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;

        Operacion operador = Operacion.NoDefinida;


        public Form1()
        {
            InitializeComponent();
        }

        private void ReadNumber(string number)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = number;
            }
            else
            {
                resultBox.Text += number;
            }
        }

        private double EjecutarOperacion(string operador)
        {
            double resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
            }
            return resultado;
        }




    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btt0_Click(object sender, EventArgs e)
        {
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


        private void ObtenerValor (string operador)
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
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(resultBox.Text);
                lblHistorial.Text += valor2 + "+";
                double resultado = EjecutarOperacion("+");
                valor1 = 0;
                valor2 = 0;
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
    }
}
