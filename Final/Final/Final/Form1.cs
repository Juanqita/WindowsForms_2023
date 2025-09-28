using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Final
{
    public partial class Form1 : Form
    {
        SerialPort puerto;

        Random random = new Random();
        bool temperaturaencendida = false;
        bool presionencendida = false;
        bool canal1encendido = false;
        bool canal2encendido = false;

        struct user
        {
            public string usuario;
            public string contraseña;
            public string rol;
        }

        List<user> usuarios = new List<user>();

        string rol = "";
        private StreamWriter datosStreamWriter;

        public Form1()
        {
            InitializeComponent();

            cboport.Items.AddRange(SerialPort.GetPortNames());
            configurarcharts();
            LeerUsuarios();

            lst.View = View.List;
            lst.MultiSelect = false;
            lst.FullRowSelect = false;
            lst.HeaderStyle = ColumnHeaderStyle.None;
            lst.Scrollable = true;


        }
        int minimot = 24;
        int maximot = 26;
        int minimop = 1012;
        int maximop = 1014;
        int valoraleatoriot = 0;
        int valoraleatoriop = 0;


        private void generarvalores(Chart chart)
        {
            valoraleatoriot = random.Next(minimot, maximot + 1);
            valoraleatoriop = random.Next(minimop, maximop + 1);
            chartvalor1.Series["Temperatura"].Points.AddY(valoraleatoriot);
            chartvalor2.Series["Presion"].Points.AddY(valoraleatoriop);
            if (chartvalor1.Series["Temperatura"].Points.Count > 50)
            {
                chartvalor1.Series["Temperatura"].Points.RemoveAt(0);
            }
            if (chartvalor2.Series["Presion"].Points.Count > 50)
            {
                chartvalor2.Series["Presion"].Points.RemoveAt(0);
            }
            chartvalor1.Invalidate();
            chartvalor2.Invalidate();
        }

        private void configurarcharts()
        {
            //valor1serie = new Series("Valor 1");
            //valor1serie.ChartType=SeriesChartType.Line;
            //valor1serie.BorderWidth=2;
            //chartvalor1.Series.Add(valor1serie);

            chartvalor1.Series["Temperatura"].ChartType = SeriesChartType.Line;
            chartvalor2.Series["Presion"].ChartType = SeriesChartType.Line;

            chartvalor1.ChartAreas[0].AxisX.Minimum = 0;
            chartvalor1.ChartAreas[0].AxisX.Interval = 1;
            chartvalor1.ChartAreas[0].AxisY.Minimum = 20;
            chartvalor1.ChartAreas[0].AxisY.Maximum = 30;

            chartvalor2.ChartAreas[0].AxisX.Minimum = 0;
            chartvalor2.ChartAreas[0].AxisX.Interval = 1;
            chartvalor2.ChartAreas[0].AxisY.Minimum = 1000;
            chartvalor2.ChartAreas[0].AxisY.Maximum = 1050;

        }

        string rutausuarios = @"C:\Users\juank\OneDrive\Documentos\Visual Studio 2010\Projects\Intersemestral-PTR\Proyecto final\usuarios.txt";
        string rutadatos = @"C:\Users\juank\OneDrive\Documentos\Visual Studio 2010\Projects\Intersemestral-PTR\Proyecto final\Registros.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = true;
            txtnuevacontra.UseSystemPasswordChar = true;
            chartvalor1.Visible = false;
            chartvalor2.Visible = false;
        }
        private void LeerUsuarios()
        {
            using (StreamReader leer = new StreamReader(rutausuarios))
            {
                string linea;
                while ((linea = leer.ReadLine()) != null)
                {
                    string[] datosuser = linea.Split(',');
                    user usuario = new user
                    {
                        usuario = datosuser[0].Trim(),
                        contraseña = datosuser[1].Trim(),
                        rol = datosuser[2].Trim()
                    };
                    usuarios.Add(usuario);
                }
            }
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            string usuarion = txtusuario.Text;
            string contraseñan = txtcontraseña.Text;
            rol = "Administrador";
            bool usuarioValido = false;
            foreach (user usuario in usuarios)
            {
                if (usuario.usuario == usuarion && usuario.contraseña == contraseñan && usuario.rol == "Administrador")
                {
                    usuarioValido = true;
                    break;
                }
            }
            if (usuarioValido)
            {
                panelogin.Visible = false;
                tabpostclick.Visible = true;
            }
            else
            {
                MessageBox.Show("VERIFIQUE USUARIO, CONTRASEÑA Y BOTON DE INICIO DE SESIÓN");
            }
        }

        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string lineadato = puerto.ReadLine();
                string[] valores = lineadato.Split(',');
                if (valores.Length >= 2)
                {
                    string valor1 = valores[0].Trim();
                    string valor2 = valores[1].Trim();

                    // Convertimos los datos a valores numéricos
                    double temperatura = double.Parse(valor1);
                    double humedad = double.Parse(valor2);
                    //AgregarDatoAlChart(valor1serie, temperatura, chartvalor1);
                    //AgregarDatoAlChart(valor2serie, humedad, chartvalor2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos del puerto serial: " + ex.Message);
            }
        }

        private void AgregarDatoAlChart(Series serie, double valor, Chart chart)
        {
            int indice = serie.Points.Count;
            DataPoint punto = new DataPoint(indice, valor);
            serie.Points.Add(punto);

            // Si tienes muchos datos, puedes limitar la cantidad de puntos mostrados en el Chart
            int maxPuntos = 50;
            if (serie.Points.Count > maxPuntos)
            {
                serie.Points.RemoveAt(0);
            }

            // Actualizamos el Chart
            chart.Invalidate();
        }

        private void btninvite_Click(object sender, EventArgs e)
        {
            rol = "Invitado";
            string usuarion = txtusuario.Text;
            string contraseñan = txtcontraseña.Text;
            bool usuarioValido = false;
            foreach (user usuario in usuarios)
            {
                if (usuario.usuario == usuarion && usuario.contraseña == contraseñan && usuario.rol == "Invitado")
                {
                    usuarioValido = true;
                    break;
                }
            }
            if (usuarioValido)
            {
                panelogin.Visible = false;
                tabPage2.Parent = null;
                tabPage3.Parent = null;
                tabpostclick.Visible = true;
            }
            else
            {
                MessageBox.Show("VERIFIQUE USUARIO, CONTRASEÑA Y BOTON DE INICIO DE SESIÓN");
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtnuevouser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtnuevacontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btngenerarusuario_Click(object sender, EventArgs e)
        {
            using (StreamWriter usuario = new StreamWriter(rutausuarios, true))
            {
                if (txtnuevouser.Text == "" || txtnuevacontra.Text == "" || cbonuevouser.Text == "Tipo de usuario")
                {
                    MessageBox.Show("Ingrese los datos correctamente");
                }
                else
                {
                    usuario.WriteLine(txtnuevouser.Text + ", " + txtnuevacontra.Text + ", " + cbonuevouser.Text);
                    MessageBox.Show("USUARIO AGREGADO");
                    txtnuevacontra.Text = "";
                    txtnuevouser.Text = "";
                    cbonuevouser.Text = "Tipo de usuario";
                }
            }


        }



        private void txtnuevouser_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtnuevacontra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cboport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Leerpuerto()
        {
            while (true)
            {
                try
                {
                    string lineadato = puerto.ReadLine();
                    string[] valores = lineadato.Split(',');
                    string valor1 = valores[0].Trim();
                    string valor2 = valores[1].Trim();
                    datosStreamWriter.WriteLine(valor1 + "," + valor2);
                    datosStreamWriter.Flush();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer los datos del puerto serial: " + ex.Message);
                }
            }
        }

        private void cboport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboport_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (temperaturaencendida)
            {
                generarvalores(chartvalor1);
            }
            if (presionencendida)
            {
                generarvalores(chartvalor2);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (puerto != null && puerto.IsOpen)
            //{
            //    puerto.Close();
            //}
            //datosStreamWriter.Close();
        }

        bool puedeguardar = false;
        private void btnencender_Click(object sender, EventArgs e)
        {

            timer1.Start();




            //string puertoseleecionado = cboport.SelectedItem as string;
            //if (!string.IsNullOrEmpty(puertoseleecionado))
            //{
            //    try
            //    {
            //        puerto = new SerialPort(puertoseleecionado, 9600);
            //        puerto.DtrEnable = true;
            //        puerto.Open();
            //        Thread leerpuertot = new Thread(Leerpuerto);
            //        leerpuertot.Start();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al leer el puerto serial: " + ex.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("SELECCIONE UN PUERTO");
            //}
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            puedeguardar = false;
            temperaturaencendida = false;
            presionencendida = false;
            chartvalor1.Series["Temperatura"].Points.Clear();
            chartvalor2.Series["Presion"].Points.Clear();
            chartvalor1.Visible = false;
            chartvalor2.Visible = false;
            timer1.Stop();
        }


        private void division1_Scroll(object sender, EventArgs e)
        {
            int zoom = division1.Value;
            chartvalor1.ChartAreas[0].AxisY.Maximum = 30 + zoom;
        }

        private void division2_Scroll(object sender, EventArgs e)
        {

            int zoom = division2.Value;
            chartvalor2.ChartAreas[0].AxisY.Maximum = 1000 + zoom;
        }

        private void activarcanal2_CheckedChanged(object sender, EventArgs e)
        {
            puedeguardar = true;
            presionencendida = true;
            chartvalor2.Visible = true;
        }

        private void activarcanal1_CheckedChanged(object sender, EventArgs e)
        {
            puedeguardar = true;
            temperaturaencendida = true;
            chartvalor1.Visible = true;
        }

        private void radiob_Click(object sender, EventArgs e)
        {

            RadioButton radiob = (RadioButton)sender;
            if (radiob == activarcanal1)
            {
                canal1encendido = !canal1encendido;
            }
            else if (radiob == activarcanal2)
            {
                canal2encendido = !canal2encendido;
            }
            activarcanal1.Checked = canal1encendido;
            activarcanal2.Checked = canal2encendido;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter registro = new StreamWriter(rutadatos, true))
            {

                if (puedeguardar)
                {
                    for (int i = 0; i <= chartvalor1.Series["Temperatura"].Points.Count; i++)
                    {
                        registro.WriteLine(valoraleatoriot + ", " + valoraleatoriop + ", " + i);
                    }
                }
            }
            using (StreamReader leer = new StreamReader(rutadatos))
            {
                string linea;
                while ((linea = leer.ReadLine()) != null)
                {
                    lst.Items.Add(linea);
                }
            }

        }
    }
}
