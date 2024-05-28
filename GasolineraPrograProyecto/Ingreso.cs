using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.IO;
using System.IO.Ports;

namespace GasolineraPrograProyecto
{   
    
    public partial class Ingreso : Form
    {
        List<clsDatos> datos = new List<clsDatos>();
        SerialPort serialPort;
        public Ingreso()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM5", 9600);
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsDatos dato = new clsDatos();
            dato.Nit = txtNit.Text;
            dato.Nombre = txtNombre.Text;
            dato.Fecha = dateTimeHora.Value;
            if (rbDiesel.Checked)
            {
                dato.Opcion = "Diesel";
            }
            else if (rbSuper.Checked)
            {
                dato.Opcion = "Super";
            }
            if (rdbprepago.Checked)
            {
                dato.Tipogasolina = "Prepago";
                dato.CantidadPedida = decimal.Parse(Interaction.InputBox("Ingrese la cantidad en Q "));
            }
            else if (rdbprepagolleno.Checked)
            {
                dato.Tipogasolina = "PrepagoLleno";
                
            }
            datos.Add(dato);
            GuardadoDatos();
            EnviarDatosPorSerial(dato);
        }
        void GuardadoDatos()
        {
            string DatosGuardar = JsonConvert.SerializeObject(datos);
            string Archivo = @"C:\Users\kenri\OneDrive\Desktop\Proyecto\GasolineraPrograProyecto\bin\Debug";
            System.IO.File.WriteAllText(Archivo, DatosGuardar);
        }

        void EnviarDatosPorSerial(clsDatos dato)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    string jsonData = JsonConvert.SerializeObject(dato);
                    MessageBox.Show("Enviando JSON: " + jsonData); // Para verificar el JSON
                    serialPort.WriteLine(jsonData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar datos: " + ex.Message);
            }
        }
        void limpieza()
        {
            txtNit.Text = string.Empty;
            txtNombre.Text = string.Empty;

            txtNit.Focus();
        }
    }
}
