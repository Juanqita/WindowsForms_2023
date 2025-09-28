using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ejemploformulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int posxOriginal = 0, posyOriginal=0;

        int ctador = 0;

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            int clave;
            string clavetxt;
            clavetxt = txtclave.Text;
            clave = Convert.ToInt32(clavetxt);
            if (clavetxt.Length != 4)
            {
                MessageBox.Show("Ingrese una clave de 4 digitos");
            }
            else
            {
                MessageBox.Show("AHORA VALIDE CON EL TECLADO EN PANTALLA");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtclave.Text == string.Empty)
                btnaceptar.Enabled = false;
            posxOriginal = btnvalidar.Location.X;
            posyOriginal = btnvalidar.Location.Y;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtclave.Text == string.Empty)
                btnaceptar.Enabled = false;
            else
                btnaceptar.Enabled = true;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Salio del formulario";
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txteclado.Text.Length < 4)
                txteclado.Text = txteclado.Text + "0";
            else
                txteclado.Enabled = false;
        }


        private void btn9_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txteclado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txteclado.Text.Length < 4)
                txteclado.Text = txteclado.Text + "1";
            else
                txteclado.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txteclado.Text.Length < 4)
                txteclado.Text = txteclado.Text + "2";
            else
                txteclado.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txteclado.Text.Length < 4)
                txteclado.Text = txteclado.Text + "3";
            else
                txteclado.Enabled = false;
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            if (txteclado.Text.Length < 4)
                txteclado.Text = txteclado.Text + "4";
            else
                txteclado.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txteclado.Text.Length < 4)
                txteclado.Text = txteclado.Text + "5";
            else
                txteclado.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txteclado.Text.Length < 4)
                txteclado.Text = txteclado.Text + "6";
            else
                txteclado.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txteclado.Text.Length < 4)
                txteclado.Text = txteclado.Text + "7";
            else
                txteclado.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txteclado.Text.Length < 4)
                txteclado.Text = txteclado.Text + "8";
            else
                txteclado.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (txteclado.Text.Length < 4)
                txteclado.Text = txteclado.Text + "9";
            else
                txteclado.Enabled = false;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txteclado.Text))
            {
                txteclado.Text = txteclado.Text.Substring(0, txteclado.Text.Length - 1);
                txteclado.Enabled = true;
            }
        }

        private void btnclea_Click(object sender, EventArgs e)
        {
            txteclado.Text = "";
            txteclado.Enabled = true;
        }


        private void btnvalidar_Click(object sender, EventArgs e)
        {
            string texto = "", textovalidar;
            int clave;
            bool cons = false;
            texto = txteclado.Text;
            clave = Convert.ToInt32(texto);

            textovalidar = txtclave.Text;

            for (int i = 0; i < texto.Length - 1; i++)
            {
                if (Math.Abs(Convert.ToInt32(texto[i + 1]) - Convert.ToInt32(texto[i])) == 1 || Convert.ToInt32(texto[i + 1]) - Convert.ToInt32(texto[i]) == 0)
                {
                    cons = true;
                }

            }
            if (cons == true)
                MessageBox.Show("CLAVE CON NUMEROS CONSECUTIVOS O IGUALES, POCO SEGURA");
            else if (texto != textovalidar)
            {
                ctador++;
                this.Text = "LA CLAVE NO COINCIDE";
            }

            else if (texto == textovalidar)
                MessageBox.Show("Clave valida");

        }

        
        private void btnvalidar_MouseEnter(object sender, EventArgs e)
        {
            int posx = btnvalidar.Location.X;
            int posy = btnvalidar.Location.Y;
            Random ran = new Random();
            int ranx = ran.Next(-80, 81);
            int rany = ran.Next(-65, 66);
            if (ctador> 2)
            {
                btnvalidar.Location = new Point(posx + (1 * ranx), posy + (1 * rany));
                ctador++;
                if (ctador==6)
                {
                    btnvalidar.Location = new Point(posxOriginal, posyOriginal);
                    ctador = 0;
                }
            }

                
        }
                
            
    }
    }