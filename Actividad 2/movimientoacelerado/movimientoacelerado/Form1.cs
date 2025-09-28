using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace movimientoacelerado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtecuacion_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            int ecuacion = 0;
            ecuacion = Convert.ToInt32(txtecuacion.Text);
            if (ecuacion == 1 || ecuacion == 2 || ecuacion == 3)
            {
                if (ecuacion==1)
                {
                    if (txtvar.Text == "xf")
                    {
                        txtval1.Text = "Ingrese X0 (m)";
                        txtval2.Text = "Ingrese V0 (m/s)";
                        txtval3.Text = "Ingrese t (s)";
                        txtval4.Text = "Ingrese a (m/s^2)";
                    }
                    else if (txtvar.Text == "x")
                    {
                        txtval1.Text = "Ingrese Xf (m)";
                        txtval2.Text = "Ingrese V0 (m/s)";
                        txtval3.Text = "Ingrese t (s)";
                        txtval4.Text = "Ingrese a (m/s^2)";
                    }
                    else if (txtvar.Text == "v")
                    {
                        txtval1.Text = "Ingrese X0 (m)";
                        txtval2.Text = "Ingrese Xf (m)";
                        txtval3.Text = "Ingrese t (s)";
                        txtval4.Text = "Ingrese a (m/s^2)";
                    }
                    else if (txtvar.Text == "a")
                    {
                        txtval1.Text = "Ingrese X0 (m)";
                        txtval2.Text = "Ingrese V0 (m/s)";
                        txtval3.Text = "Ingrese t (s)";
                        txtval4.Text = "Ingrese Xf (m)";
                    }
                    else if (txtvar.Text == "t")
                    {
                        MessageBox.Show("INGRESE EN ECUACION 2 PARA MENOR COMPLEJIDAD");
                    }
                    else
                        MessageBox.Show("INGRESE UNA VARIABLE VALIDA DE LA ECUACION");
                }
                if (ecuacion == 2)
                {
                    if (txtvar.Text == "vf")
                    {
                        txtval1.Text = "Ingrese V0 (m/s)";
                        txtval2.Text = "Ingrese a (m/s^2)";
                        txtval3.Text = "Ingrese t (s)";
                        txtval4.Text = "*************";
                    }
                    else if (txtvar.Text == "v")
                    {
                        txtval1.Text = "Ingrese Vf (m/s)";
                        txtval2.Text = "Ingrese a (m/s^2)";
                        txtval3.Text = "Ingrese t (s)";
                        txtval4.Text = "*************";
                    }
                    else if (txtvar.Text == "a")
                    {
                        txtval1.Text = "Ingrese V0 (m/s)";
                        txtval2.Text = "Ingrese Vf (m/s)";
                        txtval3.Text = "Ingrese t (s)";
                        txtval4.Text = "*************";
                    }
                    else if (txtvar.Text == "t")
                    {
                        txtval1.Text = "Ingrese V0 (m/s)";
                        txtval2.Text = "Ingrese Vf (m/s)";
                        txtval3.Text = "Ingrese a (m/s^2)";
                        txtval4.Text = "*************";
                    }
                    else
                        MessageBox.Show("INGRESE UNA VARIABLE VALIDA DE LA ECUACION");
                }
                if (ecuacion == 3)
                {
                    if (txtvar.Text == "vf")
                    {
                        txtval1.Text = "Ingrese V0 (m/s)";
                        txtval2.Text = "Ingrese a (m/s^2)";
                        txtval3.Text = "Ingrese X (m)";
                        txtval4.Text = "*************";
                    }
                    else if (txtvar.Text == "v")
                    {
                        txtval1.Text = "Ingrese Vf (m/s)";
                        txtval2.Text = "Ingrese a (m/s^2)";
                        txtval3.Text = "Ingrese X (m)";
                        txtval4.Text = "*************";
                    }
                    else if (txtvar.Text == "a")
                    {
                        txtval1.Text = "Ingrese V0 (m/s)";
                        txtval2.Text = "Ingrese Vf (m/s)";
                        txtval3.Text = "Ingrese X (m)";
                        txtval4.Text = "*************";
                    }
                    else if (txtvar.Text == "X")
                    {
                        txtval1.Text = "Ingrese V0 (m/s)";
                        txtval2.Text = "Ingrese Vf (m/s)";
                        txtval3.Text = "Ingrese a (m/s^2)";
                        txtval4.Text = "*************";
                    }
                    else
                        MessageBox.Show("INGRESE UNA VARIABLE VALIDA DE LA ECUACION");
                }
            }
            else
                MessageBox.Show("INGRESE UNA ECUACION DE LAS QUE SE VEN EN PANTALLA (1 AL 3)");

            Respuesta.Text = txtvar.Text + " :  ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            double xf=0, x=0, v=0, t=0, a=0, vf=0, X=0;
            int ecuacion = 0;
            ecuacion = Convert.ToInt32(txtecuacion.Text);
            if (ecuacion == 1)
                {
                    if (txtvar.Text == "xf")
                    {
                        x = Convert.ToDouble(txtval1.Text);
                        v = Convert.ToDouble(txtval2.Text);
                        t = Convert.ToDouble(txtval3.Text);
                        a = Convert.ToDouble(txtval4.Text);
                        
                        xf = x + v * t + (a * t * t) / 2;
                        txtRespuesta.Text = Convert.ToString(xf) + "    m/s";
                    }
                    else if (txtvar.Text == "x")
                    {
                        xf = Convert.ToDouble(txtval1.Text);
                        v = Convert.ToDouble(txtval2.Text);
                        t = Convert.ToDouble(txtval3.Text);
                        a = Convert.ToDouble(txtval4.Text);

                        x = xf - v * t - (a * t * t) / 2;
                        txtRespuesta.Text = Convert.ToString(x) + "    m";
                    }
                    else if (txtvar.Text == "v")
                    {
                        x = Convert.ToDouble(txtval1.Text);
                        xf = Convert.ToDouble(txtval2.Text);
                        t = Convert.ToDouble(txtval3.Text);
                        a = Convert.ToDouble(txtval4.Text);

                        v = (xf - x - (a * t * t) / 2) / t;
                        txtRespuesta.Text = Convert.ToString(v) + "    m/s";
                    }
                    else if (txtvar.Text == "a")
                    {
                        x = Convert.ToDouble(txtval1.Text);
                        v = Convert.ToDouble(txtval2.Text);
                        t = Convert.ToDouble(txtval3.Text);
                        xf = Convert.ToDouble(txtval4.Text);

                        a = 2 * (xf - x - v * t) / (t * t);
                        txtRespuesta.Text = Convert.ToString(a) + "    m/s^2";
                    }
                    else if (txtvar.Text == "t")
                    {
                        MessageBox.Show("INGRESE EN ECUACION 2 PARA MENOR COMPLEJIDAD");
                    }
                }
                if (ecuacion == 2)
                {
                    if (txtvar.Text == "vf")
                    {
                        v = Convert.ToDouble(txtval1.Text);
                        a = Convert.ToDouble(txtval2.Text);
                        t = Convert.ToDouble(txtval3.Text);
                        txtval4.Text = "*************";

                        vf = v + a * t;
                        txtRespuesta.Text = Convert.ToString(vf) + "    m/s";
                    }
                    else if (txtvar.Text == "v")
                    {
                        vf = Convert.ToDouble(txtval1.Text);
                        a = Convert.ToDouble(txtval2.Text);
                        t = Convert.ToDouble(txtval3.Text);
                        txtval4.Text = "*************";

                        v = vf - a * t;
                        txtRespuesta.Text = Convert.ToString(v) + "    m/s";
                    }
                    else if (txtvar.Text == "a")
                    {
                        v = Convert.ToDouble(txtval1.Text);
                        vf = Convert.ToDouble(txtval2.Text);
                        t = Convert.ToDouble(txtval3.Text);
                        txtval4.Text = "*************";

                        a = (vf - v) / t;
                        txtRespuesta.Text = Convert.ToString(a) + "    m/s^2";
                    }
                    else if (txtvar.Text == "t")
                    {
                        v = Convert.ToDouble(txtval1.Text);
                        vf = Convert.ToDouble(txtval2.Text);
                        a = Convert.ToDouble(txtval3.Text);
                        txtval4.Text = "*************";

                        t = (vf - v) / a;
                        txtRespuesta.Text = Convert.ToString(t) + "    s";
                    }
                }
                if (ecuacion == 3)
                {
                    if (txtvar.Text == "vf")
                    {
                        v = Convert.ToDouble(txtval1.Text);
                        a = Convert.ToDouble(txtval2.Text);
                        X = Convert.ToDouble(txtval3.Text);
                        txtval4.Text = "*************";

                        vf = Math.Sqrt(v * v + 2 * a * X);
                        txtRespuesta.Text = Convert.ToString(vf) + "    m/s";
                    }
                    else if (txtvar.Text == "v")
                    {
                        vf = Convert.ToDouble(txtval1.Text);
                        a = Convert.ToDouble(txtval2.Text);
                        X = Convert.ToDouble(txtval3.Text);
                        txtval4.Text = "*************";

                        v = Math.Sqrt(vf * vf - 2 * a * X);
                        txtRespuesta.Text = Convert.ToString(v) + "    m/s";
                    }
                    else if (txtvar.Text == "a")
                    {
                        v = Convert.ToDouble(txtval1.Text);
                        vf = Convert.ToDouble(txtval2.Text);
                        X = Convert.ToDouble(txtval3.Text);
                        txtval4.Text = "*************";

                        a = (vf * vf - v * v) / 2 * x;
                        txtRespuesta.Text = Convert.ToString(a) + "    m/s^2";
                    }
                    else if (txtvar.Text == "X")
                    {
                        v = Convert.ToDouble(txtval1.Text);
                        vf = Convert.ToDouble(txtval2.Text);
                        a = Convert.ToDouble(txtval3.Text);
                        txtval4.Text = "*************";

                        X = (vf * vf - v * v) / 2 * a;
                        txtRespuesta.Text = Convert.ToString(X) + "    m";
                    }
                }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void aproar_Click(object sender, EventArgs e)
        {
            string valor = new string(txtRespuesta.Text.Where(c => char.IsDigit(c) || c=='.' || c=='-').ToArray());
            Double aproximado = 0;
            int aprox = 0;
            aproximado = Convert.ToDouble(valor);
            aprox = (int)Math.Ceiling(aproximado);
            txtRespuesta.Text = Convert.ToString(aprox);
        }
    }
}
