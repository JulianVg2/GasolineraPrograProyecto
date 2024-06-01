using Newtonsoft.Json;
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
            string fileJSon = File.ReadAllText(@"C:\Users\kenri\OneDrive\Desktop\Proyecto\GasolineraPrograProyecto\bin\Debug\Datos.json");
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
            cargarClientes();
            List<clsDatos> reportes = new List<clsDatos>();
            string busqueda = "PrepagoLleno";
            IEnumerable<clsDatos> tanquesLlenos = Datoss.Where(p => p.Opcion == busqueda);

            foreach (clsDatos tanquelleno in tanquesLlenos)
            {
                clsDatos reporte = new clsDatos
                {
                    Nit = tanquelleno.Nit,
                    Nombre = tanquelleno.Nombre,
                    Fecha = tanquelleno.Fecha,
                    Opcion = tanquelleno.Opcion,
                    Tipogasolina = tanquelleno.Tipogasolina,
                    CantidadServida = tanquelleno.CantidadServida,
                };
                reportes.Add(reporte);
            }

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = reportes;
            dataGridView3.Refresh();

        }


        private void button3_Click(object sender, EventArgs e)
        {
           
            cargarClientes();
            List<clsDatos> reportespre = new List<clsDatos>();
            string busqueda = "Prepago";
            IEnumerable<clsDatos> prepagos = Datoss.Where(p => p.Opcion == busqueda);

            foreach (clsDatos Prepago in prepagos)
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

          
            int contadorSuper = Datoss.Count(p => p.Tipogasolina == "Super");
            int contadorDiesel = Datoss.Count(p => p.Tipogasolina == "Diesel");

           
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
                contador = contadorSuper; 
            }

            ConfigurarDataGridView(dataGridView4);
            LlenarDataGridView(dataGridView4, tipoGasolinaMasUtilizada, contador);
        }

        public void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView4.Columns.Clear();
            dataGridView4.Columns.Add("TipoGasolina", "Tipo de Gasolina");
            dataGridView4.Columns.Add("Ventas realizadas", "Ventas realizadas");
            dataGridView4.Columns.Add("Cantidad servida", "Cantidad servida");
        }

        public void LlenarDataGridView(DataGridView dataGridView, string tipoGasolina, int contador)
        {
            dataGridView4.Rows.Clear();
            dataGridView4.Rows.Add(tipoGasolina, contador);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cargarClientes();

            var datosOrdenados = Datoss.OrderBy(p => p.Tipogasolina).ToList();

            dataGridView4.DataSource = null;
            dataGridView4.DataSource = datosOrdenados;
            dataGridView4.Refresh();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var datosActuales = (List<clsDatos>)dataGridView4.DataSource;


            var datosOrdenados = datosActuales.OrderByDescending(p => p.Tipogasolina).ToList();

            dataGridView4.DataSource = null;
            dataGridView4.DataSource = datosOrdenados;
            dataGridView4.Refresh();
        }
    }
    
    
    
    
}
