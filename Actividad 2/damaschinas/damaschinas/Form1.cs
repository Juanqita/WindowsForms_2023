using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace damaschinas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ocupado1 = false, ocupado2 = false;
        PictureBox[] zonas = new PictureBox[8];
        PictureBox[] posib = new PictureBox[8];

        private void Form1_Load(object sender, EventArgs e)
        {
            posib1.Visible = false;
            posib[0] = posib1;
            posib2.Visible = false;
            posib[1] = posib2;
            posib3.Visible = false;
            posib[2] = posib3;
            posib4.Visible = false;
            posib[3] = posib4;
            posib5.Visible = false;
            posib[4] = posib5;
            posib6.Visible = false;
            posib[5] = posib6;

            PictureBox zona1 = new PictureBox();
            zona1.Size = new Size(50, 50);
            zona1.Location = new Point(50, 0);
            zonas[0] = zona1;

            PictureBox zona2 = new PictureBox();
            zona2.Size = new Size(50, 50);
            zona2.Location = new Point(100, 0);
            zonas[1] = zona2;

            PictureBox zona3 = new PictureBox();
            zona3.Size = new Size(50, 50);
            zona3.Location = new Point(50, 50);
            zonas[2] = zona3;

            PictureBox zona4 = new PictureBox();
            zona4.Size = new Size(50, 50);
            zona4.Location = new Point(150, 50);
            zonas[3] = zona4;

            PictureBox zona5 = new PictureBox();
            zona5.Size = new Size(50, 50);
            zona5.Location = new Point(0, 100);
            zonas[4] = zona5;

            PictureBox zona6 = new PictureBox();
            zona6.Size = new Size(50, 50);
            zona6.Location = new Point(100, 100);
            zonas[5] = zona6;

            PictureBox zona7 = new PictureBox();
            zona7.Size = new Size(50, 50);
            zona7.Location = new Point(50, 150);
            zonas[6] = zona7;

            PictureBox zona8 = new PictureBox();
            zona8.Size = new Size(50, 50);
            zona8.Location = new Point(150, 150);
            zonas[7] = zona8;
            panel1.Controls.Add(zona1);
            panel1.Controls.Add(zona2);
            panel1.Controls.Add(zona3);
            panel1.Controls.Add(zona4);
            panel1.Controls.Add(zona5);
            panel1.Controls.Add(zona6);
            panel1.Controls.Add(zona7);
            panel1.Controls.Add(zona8);

            Button zonades1 = new Button();
            zonades1.Enabled = false;
            zonades1.Location = new Point(50, 0);
            zonades1.Size = new Size(50, 50);
            panel1.Controls.Add(zonades1);

            Button zonades2 = new Button();
            zonades2.Enabled = false;
            zonades2.Location = new Point(50, 0);
            zonades2.Size = new Size(150, 0);
            panel1.Controls.Add(zonades2);

            Button zonades3 = new Button();
            zonades3.Enabled = false;
            zonades3.Location = new Point(0, 50);
            zonades1.Size = new Size(50, 50);
            panel1.Controls.Add(zonades3);

            Button zonades4 = new Button();
            zonades4.Enabled = false;
            zonades4.Location = new Point(100, 50);
            zonades4.Size = new Size(50, 50);
            panel1.Controls.Add(zonades4);

            Button zonades5 = new Button();
            zonades5.Enabled = false;
            zonades5.Location = new Point(50, 100);
            zonades5.Size = new Size(50, 50);
            panel1.Controls.Add(zonades5);

            Button zonades6 = new Button();
            zonades6.Enabled = false;
            zonades6.Location = new Point(150, 100);
            zonades6.Size = new Size(50, 50);
            panel1.Controls.Add(zonades6);

            Button zonades7 = new Button();
            zonades7.Enabled = false;
            zonades7.Location = new Point(0, 150);
            zonades7.Size = new Size(50, 50);
            panel1.Controls.Add(zonades7);

            Button zonades8 = new Button();
            zonades8.Enabled = false;
            zonades8.Location = new Point(100, 150);
            zonades8.Size = new Size(50, 50);
            panel1.Controls.Add(zonades8);

            
        }

        private void proja_Click(object sender, EventArgs e)
        {
            if (proja.ImageLocation == zonas[1].ImageLocation)
            {
                posib3.Visible = true;
                posib2.Visible = true;
            }
            else if (proja.ImageLocation == zonas[2].ImageLocation)
            {
                posib4.Visible = true;
                posib5.Visible = true;
            }
        }

        private void posib2_Click(object sender, EventArgs e)
        {
            posib2.Visible = false;
            posib3.Visible = false;
            proja.Location = posib2.Location;
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void posib3_Click(object sender, EventArgs e)
        {
            posib2.Visible = false;
            posib3.Visible = false;
            proja.Location = posib3.Location;
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void pnegra_Click(object sender, EventArgs e)
        {
            if (pnegra.ImageLocation == zonas[7].ImageLocation)
            {
                posib4.Visible = true;
                posib5.Visible = true;
            }
            else if (pnegra.ImageLocation == zonas[5].ImageLocation)
            {
                posib2.Visible = true;
                posib3.Visible = true;
            }
        }

        private void posib5_Click(object sender, EventArgs e)
        {
            posib4.Visible = false;
            posib5.Visible = false;
            pnegra.Location = posib5.Location;
        }

        private void posib4_Click(object sender, EventArgs e)
        {
            posib4.Visible = false;
            posib5.Visible = false;
            pnegra.Location = posib5.Location;
        }

       
    }
}
