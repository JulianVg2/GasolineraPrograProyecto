﻿using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasolineraPrograProyecto
{
    public partial class Informes : Form
    {
        List<clsDatos> Datoss = new List<clsDatos>();
        public Informes()
        {
            InitializeComponent();
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconorestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconorestaurar.Visible = false;
            iconomaximizar.Visible = true;
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconomaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconorestaurar.Visible = true;
            iconomaximizar.Visible = false;
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form1 Menu = new Form1();
            Menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso FormIngreso = new Ingreso();
            FormIngreso.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileJSon = File.ReadAllText(@"C:\Users\Julian Vg\source\repos\GasolineraPrograProyecto\GasolineraPrograProyecto\bin\Debug\Datos.json");
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(fileJSon,typeof(DataTable));
            dataGridView1.DataSource = dt;


        }


        void cargarClientes()
        {
            string archivo = "Datos.json";

            using (StreamReader jsonStream = File.OpenText(archivo))
            {
                string json = jsonStream.ReadToEnd();
                Datoss = JsonConvert.DeserializeObject<List<clsDatos>>(json);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {

            List<clsDatos> reportes = new List<clsDatos>();

            cargarClientes();
            string busqueda = "PrepagoLleno";
            clsDatos tanquelleno = Datoss.FirstOrDefault(p => p.Opcion == busqueda);

            if (tanquelleno != null)
            {
                clsDatos reporte = new clsDatos
                {
                    Nit = tanquelleno.Nit,
                    Nombre = tanquelleno.Nombre,
                    Fecha = tanquelleno.Fecha,
                    Opcion =tanquelleno.Opcion,
                    Tipogasolina = tanquelleno.Tipogasolina,

                };
                reportes.Add(reporte);
            }

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = reportes;
            dataGridView3.Refresh();


        }


        private void button3_Click(object sender, EventArgs e)
        {
            List<clsDatos> reportespre = new List<clsDatos>();

            cargarClientes();
            string busqueda = "Prepago";
            clsDatos Prepago = Datoss.FirstOrDefault(p => p.Opcion == busqueda);

            if (Prepago != null)
            {
                clsDatos reporte = new clsDatos
                {
                    Nit = Prepago.Nit,
                    Nombre = Prepago.Nombre,
                    Fecha = Prepago.Fecha,
                    Opcion = Prepago.Opcion,
                    Tipogasolina = Prepago.Tipogasolina,

                };
                reportespre.Add(reporte);
            }

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = reportespre;
            dataGridView2.Refresh();  
   


        }

        private void button5_Click(object sender, EventArgs e)
        {

            cargarClientes();

            // Contadores para los tipos de gasolina
            int contadorSuper = Datoss.Count(p => p.Tipogasolina == "Super");
            int contadorDiesel = Datoss.Count(p => p.Tipogasolina == "Diesel");

            // Determinar cuál tipo de gasolina se utilizó más
            string tipoGasolinaMasUtilizada;
            int contador;
            if (contadorSuper > contadorDiesel)
            {
                tipoGasolinaMasUtilizada = "Super";
                contador = contadorSuper;
            }
            else if (contadorDiesel > contadorSuper)
            {
                tipoGasolinaMasUtilizada = "Diesel";
                contador = contadorDiesel;
            }
            else
            {
                tipoGasolinaMasUtilizada = "Ambos tipos de gasolina se utilizaron la misma cantidad de veces";
                contador = contadorSuper; // Puede ser cualquiera ya que son iguales
            }

            // Configurar y llenar el DataGridView con los resultados
            ConfigurarDataGridView(dataGridView4);
            LlenarDataGridView(dataGridView4, tipoGasolinaMasUtilizada, contador);
        }

        // Métodos para configurar y llenar el DataGridView
        public void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView4.Columns.Clear();
            dataGridView4.Columns.Add("TipoGasolina", "Tipo de Gasolina");
            dataGridView4.Columns.Add("Contador", "Contador");
        }

        public void LlenarDataGridView(DataGridView dataGridView, string tipoGasolina, int contador)
        {
            dataGridView4.Rows.Clear();
            dataGridView4.Rows.Add(tipoGasolina, contador);
        }
    }
    
    
}
