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
                var cliente = new superCacho.CountryInfoServiceSoapTypeClient("CountryInfoServiceSoap"); // ESTO CREA UNA INSTANCIA DEL CLIENTE SOAP UTILIZANDO LA CONFIGURACIÓN DEFINIDA EN EL ARCHIVO App.config

                string codigo = textBox1.Text; // ESTO OBTIENE EL CÓDIGO DEL PAÍS INGRESADO POR EL USUARIO

                var resultado = cliente.FullCountryInfo(codigo); // ESTO HACE LA LLAMADA AL SERVICIO SOAP


                MessageBox.Show(
                    "Nombre del país: " + resultado.sName +
                    "\nCódigo telefónico: +" + resultado.sPhoneCode +
                    "\nCiudad capital: " + resultado.sCapitalCity +
                    "\nCódigo del continente: " + resultado.sContinentCode,
                    "Información del país",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
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
