using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TrabajoPractico1
{
    public partial class FormCalculadora: Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        #region Eventos

        private void BotonOperar_Click( object sender, EventArgs e )
        {

            double resultado = new double();

            string operador = Convert.ToString(this.comboBoxOperadores.SelectedItem);

            resultado = Operar(this.textoNumero1.Text, this.textoNumero2.Text, operador);

            labelResultado.Text = Convert.ToString(resultado);

        }

        private void BotonLimpiar_Click( object sender, EventArgs e )
        {

            Limpiar();

        }

        private void BotonCerrar_Click( object sender, EventArgs e )
        {

            this.Close();

        }

        private void BotonCovertirABinario_Click( object sender, EventArgs e )
        {

            string numero = this.labelResultado.Text;
            string resultado = string.Empty;

            resultado = Numero.DecimalBinario(numero);

            this.labelResultado.Text = resultado;


        }

        private void BotonConvertirADecimal_Click( object sender, EventArgs e )
        {

            string numero = this.labelResultado.Text;
            string resultado = string.Empty;

            resultado = Numero.BinarioDecimal(numero);

            this.labelResultado.Text = resultado;
        }

        #endregion

        #region Metodos


        static double Operar( string n1, string n2, string operador )
        {
            double resultado = new double();
            Numero numero1 = new Numero(n1);
            Numero numero2 = new Numero(n2);

            resultado = Calculadora.Operar(numero1, numero2, operador);

            return resultado;
        }

        void Limpiar()
        {
            this.textoNumero1.Text = string.Empty;
            this.textoNumero2.Text = string.Empty;
            this.labelResultado.Text = "0";
            this.comboBoxOperadores.SelectedItem = "+";
            this.comboBoxOperadores.Text = "";
        }



        #endregion


    }
}
