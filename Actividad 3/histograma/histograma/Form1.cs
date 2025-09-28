using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace histograma
{
    public partial class Form1 : Form
    {
        private List<double> datos = new List<double>();
        
        int menor = 0;
        int mayor = int.MaxValue;
        int NoIntervalos = 10;
        int interval = 0;

        public Form1()
        {

            InitializeComponent();
            cbointervalos.SelectedIndex = 0;
            for (int i = 0; i < frecuencias.Length; i++)
            {
                frecuencias[i] = 0;
                inters[i] = 0;
            }
            graficahistograma();
        }

        private void txtagregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        int[] frecuencias = new int[0];
        double[] inters = new double[0];

        private void btnagregar_Click_1(object sender, EventArgs e)
        {

            frecuencias = new int[NoIntervalos];

            inters = new double[NoIntervalos];

            double agregue = Convert.ToDouble(txtagregar.Text);
            datos.Add(agregue);
            Listadatos.Items.Add(agregue);

            if (agregue < menor)
            {
                menor = (int)agregue;
            }
            if (agregue > mayor)
            {
                mayor = (int)agregue;
            }
            for (int i = 0; i <= NoIntervalos; i += interval)
            {
                for (int k = menor; k <= mayor; k+=interval)
                {
                    inters[i] = menor + i;
                }
            }
            for (int i=0;i<Listadatos.Items.Count;i++)
            {
                if (agregue >= inters[i] && agregue < inters[i + 1])
                {
                    frecuencias[i]++;
                }
            }
            

            graficahistograma();
        }

        private void txtagregar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (cbointervalos.SelectedIndex==-1)
            {
                e.Handled = true;
            }
        }

        private void Listadatos_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Listadatos.SelectedItem != null)
            {
                double valorAEliminar = Convert.ToDouble(Listadatos.SelectedItem);
                datos.Remove(valorAEliminar);
                Listadatos.Items.Remove(valorAEliminar);

                graficahistograma();
            }
        }

        private void cbointervalos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbointervalos.SelectedIndex == 4)
            {
                panel3.Visible = true;
            }
            else
            {
                NoIntervalos = Convert.ToInt32(cbointervalos.SelectedItem);
                panel3.Visible = false;
                graficahistograma();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Visible = false; cbointervalos.SelectedIndex = 0;
        }

        private void txtotro_Click(object sender, EventArgs e)
        {
            
        }

        private void txtotro_TextAlignChanged(object sender, EventArgs e)
        {

            NoIntervalos = Convert.ToInt32(txtotro.Text);
        }

        private void txtotro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            int intervalosIngresados = Convert.ToInt32(txtotro.Text);
            if (intervalosIngresados >= 10 && intervalosIngresados <= 24)
            {
                NoIntervalos = intervalosIngresados;
                panel3.Visible = false;
            }
            else
            {
                MessageBox.Show("Ingrese intervalos de 10 a 24");
                txtotro.Text = "";
            }
        }

        private void graficahistograma()
        {
            chart1.Series["HISTOGRAMA"].Points.DataBindY(inters);
            for (int i = 0; i < inters.Length; i++)
            {
                chart1.Series["HISTOGRAMA"].Points.AddXY(inters[i], frecuencias[i]);
            }
        }

        private void Listadatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}