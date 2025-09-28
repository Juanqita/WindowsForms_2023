namespace ejemploformulario
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnclea = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.txteclado = new System.Windows.Forms.TextBox();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(124, 32);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 0;
            this.btnaceptar.Tag = "Aceptar";
            this.btnaceptar.Text = "Ingresar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(182, 6);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(44, 20);
            this.txtclave.TabIndex = 1;
            this.txtclave.Tag = "txtedad";
            this.txtclave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clave a validar: ";
            // 
            // btncerrar
            // 
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncerrar.Location = new System.Drawing.Point(234, 32);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(102, 109);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(44, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(214, 172);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(44, 23);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn9_MouseClick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(155, 172);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(44, 23);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(102, 172);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(44, 23);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(214, 143);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(44, 23);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(155, 143);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(44, 23);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(102, 143);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(44, 23);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(214, 109);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(44, 23);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(155, 109);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(44, 23);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnclea
            // 
            this.btnclea.Location = new System.Drawing.Point(214, 201);
            this.btnclea.Name = "btnclea";
            this.btnclea.Size = new System.Drawing.Size(44, 23);
            this.btnclea.TabIndex = 13;
            this.btnclea.Text = "C";
            this.btnclea.UseVisualStyleBackColor = true;
            this.btnclea.Click += new System.EventHandler(this.btnclea_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(155, 201);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(44, 23);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(102, 201);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(44, 23);
            this.btnborrar.TabIndex = 15;
            this.btnborrar.Text = "<--";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // txteclado
            // 
            this.txteclado.Location = new System.Drawing.Point(102, 83);
            this.txteclado.Name = "txteclado";
            this.txteclado.Size = new System.Drawing.Size(156, 20);
            this.txteclado.TabIndex = 16;
            this.txteclado.Tag = "txtedad";
            this.txteclado.TextChanged += new System.EventHandler(this.txteclado_TextChanged);
            // 
            // btnvalidar
            // 
            this.btnvalidar.Location = new System.Drawing.Point(134, 235);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(75, 23);
            this.btnvalidar.TabIndex = 17;
            this.btnvalidar.Text = "Validar";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 270);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.txteclado);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnclea);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.btnaceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnclea;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.TextBox txteclado;
        private System.Windows.Forms.Button btnvalidar;
    }
}

