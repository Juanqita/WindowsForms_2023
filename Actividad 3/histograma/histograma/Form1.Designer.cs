namespace histograma
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtagregar = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.Listadatos = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbointervalos = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnok = new System.Windows.Forms.Button();
            this.txtotro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtagregar);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.Listadatos);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 219);
            this.panel1.TabIndex = 4;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(109, 173);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESAR DATOS";
            // 
            // txtagregar
            // 
            this.txtagregar.Location = new System.Drawing.Point(57, 147);
            this.txtagregar.Name = "txtagregar";
            this.txtagregar.Size = new System.Drawing.Size(100, 20);
            this.txtagregar.TabIndex = 6;
            this.txtagregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtagregar_KeyPress_1);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(28, 173);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // Listadatos
            // 
            this.Listadatos.FormattingEnabled = true;
            this.Listadatos.Items.AddRange(new object[] {
            "0"});
            this.Listadatos.Location = new System.Drawing.Point(48, 46);
            this.Listadatos.Name = "Listadatos";
            this.Listadatos.Size = new System.Drawing.Size(120, 95);
            this.Listadatos.TabIndex = 4;
            this.Listadatos.SelectedIndexChanged += new System.EventHandler(this.Listadatos_SelectedIndexChanged);
            this.Listadatos.SelectedValueChanged += new System.EventHandler(this.Listadatos_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(246, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 244);
            this.panel2.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "HISTOGRAMA";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(339, 238);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cbointervalos
            // 
            this.cbointervalos.FormattingEnabled = true;
            this.cbointervalos.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "Otro"});
            this.cbointervalos.Location = new System.Drawing.Point(51, 18);
            this.cbointervalos.Name = "cbointervalos";
            this.cbointervalos.Size = new System.Drawing.Size(121, 21);
            this.cbointervalos.TabIndex = 6;
            this.cbointervalos.Text = "Cantidad Intervalos";
            this.cbointervalos.SelectedIndexChanged += new System.EventHandler(this.cbointervalos_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnok);
            this.panel3.Controls.Add(this.txtotro);
            this.panel3.Location = new System.Drawing.Point(51, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 28);
            this.panel3.TabIndex = 7;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(118, 3);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(39, 22);
            this.btnok.TabIndex = 8;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtotro
            // 
            this.txtotro.Location = new System.Drawing.Point(12, 3);
            this.txtotro.Name = "txtotro";
            this.txtotro.Size = new System.Drawing.Size(100, 20);
            this.txtotro.TabIndex = 0;
            this.txtotro.Text = "Ingrese";
            this.txtotro.TextAlignChanged += new System.EventHandler(this.txtotro_TextAlignChanged);
            this.txtotro.Click += new System.EventHandler(this.txtotro_Click);
            this.txtotro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtotro_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 333);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbointervalos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtagregar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ListBox Listadatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ComboBox cbointervalos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtotro;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

    }
}

