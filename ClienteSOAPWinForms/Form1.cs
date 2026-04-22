using ClienteSOAPWinForms.superCacho;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteSOAPWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear cliente SOAP
                var cliente = new superCacho.CountryInfoServiceSoapTypeClient("CountryInfoServiceSoap");

                // Obtener código ingresado por el usuario (ej: AR)
                string codigo = textBox1.Text;

                // Llamar al método con parámetro
                var info = cliente.FullCountryInfo(codigo);

                // Mostrar resultado en ventana emergente
                MessageBox.Show(
                    "Resultado:" + "\n" +
                    "País: " + info.sName + "\n" +
                    "Capital: " + info.sCapitalCity + "\n" +
                    "Moneda: " + info.sCurrencyISOCode + "\n" 
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
