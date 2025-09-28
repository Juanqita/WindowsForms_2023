namespace movimientoacelerado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtecuacion = new System.Windows.Forms.TextBox();
            this.txtvar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.txtval4 = new System.Windows.Forms.TextBox();
            this.txtval3 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.Respuesta = new System.Windows.Forms.Label();
            this.aproar = new System.Windows.Forms.Button();
            this.btnred = new System.Windows.Forms.Button();
            this.aproab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1)  xf = x + v * t+a * t^2 / 2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "3) vf^2 = v^2 +2 * a *X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2) vf = v + a * t";
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(184, 85);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 3;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // txtecuacion
            // 
            this.txtecuacion.HideSelection = false;
            this.txtecuacion.Location = new System.Drawing.Point(172, 25);
            this.txtecuacion.Name = "txtecuacion";
            this.txtecuacion.Size = new System.Drawing.Size(100, 20);
            this.txtecuacion.TabIndex = 4;
            this.txtecuacion.Text = "Ecuacion";
            this.txtecuacion.TextChanged += new System.EventHandler(this.txtecuacion_TextChanged);
            // 
            // txtvar
            // 
            this.txtvar.Location = new System.Drawing.Point(172, 59);
            this.txtvar.Name = "txtvar";
            this.txtvar.Size = new System.Drawing.Size(100, 20);
            this.txtvar.TabIndex = 5;
            this.txtvar.Text = "Variable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "INGRESE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(12, 119);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(100, 20);
            this.txtval1.TabIndex = 7;
            // 
            // txtval4
            // 
            this.txtval4.Location = new System.Drawing.Point(12, 202);
            this.txtval4.Name = "txtval4";
            this.txtval4.Size = new System.Drawing.Size(100, 20);
            this.txtval4.TabIndex = 8;
            // 
            // txtval3
            // 
            this.txtval3.Location = new System.Drawing.Point(12, 171);
            this.txtval3.Name = "txtval3";
            this.txtval3.Size = new System.Drawing.Size(100, 20);
            this.txtval3.TabIndex = 9;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(12, 145);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(100, 20);
            this.txtval2.TabIndex = 10;
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(22, 228);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(75, 23);
            this.btncal.TabIndex = 12;
            this.btncal.Text = "Calcular";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "INGRESE";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(172, 135);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(100, 20);
            this.txtRespuesta.TabIndex = 14;
            // 
            // Respuesta
            // 
            this.Respuesta.AutoSize = true;
            this.Respuesta.Location = new System.Drawing.Point(143, 138);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(35, 13);
            this.Respuesta.TabIndex = 15;
            this.Respuesta.Text = "label6";
            this.Respuesta.Click += new System.EventHandler(this.label6_Click);
            // 
            // aproar
            // 
            this.aproar.Location = new System.Drawing.Point(184, 168);
            this.aproar.Name = "aproar";
            this.aproar.Size = new System.Drawing.Size(75, 23);
            this.aproar.TabIndex = 16;
            this.aproar.Text = "Aprox. Arriba";
            this.aproar.UseVisualStyleBackColor = true;
            this.aproar.Click += new System.EventHandler(this.aproar_Click);
            // 
            // btnred
            // 
            this.btnred.Location = new System.Drawing.Point(184, 199);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(75, 23);
            this.btnred.TabIndex = 17;
            this.btnred.Text = "Redondear";
            this.btnred.UseVisualStyleBackColor = true;
            // 
            // aproab
            // 
            this.aproab.Location = new System.Drawing.Point(184, 226);
            this.aproab.Name = "aproab";
            this.aproab.Size = new System.Drawing.Size(75, 23);
            this.aproab.TabIndex = 18;
            this.aproab.Text = "Aprox. Abajo";
            this.aproab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.aproab);
            this.Controls.Add(this.btnred);
            this.Controls.Add(this.aproar);
            this.Controls.Add(this.Respuesta);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval3);
            this.Controls.Add(this.txtval4);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtvar);
            this.Controls.Add(this.txtecuacion);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtecuacion;
        private System.Windows.Forms.TextBox txtvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.TextBox txtval4;
        private System.Windows.Forms.TextBox txtval3;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label Respuesta;
        private System.Windows.Forms.Button aproar;
        private System.Windows.Forms.Button btnred;
        private System.Windows.Forms.Button aproab;
    }
}

