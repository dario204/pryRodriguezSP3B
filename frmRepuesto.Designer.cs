namespace pryRodriguezSP3B
{
    partial class frmRepuesto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mcrRepuestos = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rtxDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.mcrIngresados = new System.Windows.Forms.GroupBox();
            this.lblDescripcionIngresados = new System.Windows.Forms.Label();
            this.rtxDescripcionIngresados = new System.Windows.Forms.RichTextBox();
            this.txtPrecioIngresados = new System.Windows.Forms.TextBox();
            this.txtNumeroIngresados = new System.Windows.Forms.TextBox();
            this.lblPrecioIngresados = new System.Windows.Forms.Label();
            this.lblNumeroIngresados = new System.Windows.Forms.Label();
            this.mcrOrigen = new System.Windows.Forms.GroupBox();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblMarcaIngresados = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboMarcaRepuesto = new System.Windows.Forms.ComboBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.mcrRepuestos.SuspendLayout();
            this.mcrIngresados.SuspendLayout();
            this.mcrOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcrRepuestos
            // 
            this.mcrRepuestos.Controls.Add(this.cboOrigen);
            this.mcrRepuestos.Controls.Add(this.cboMarcaRepuesto);
            this.mcrRepuestos.Controls.Add(this.lblDescripcion);
            this.mcrRepuestos.Controls.Add(this.rtxDescripcion);
            this.mcrRepuestos.Controls.Add(this.txtPrecio);
            this.mcrRepuestos.Controls.Add(this.txtNumero);
            this.mcrRepuestos.Controls.Add(this.lblPrecio);
            this.mcrRepuestos.Controls.Add(this.lblNumero);
            this.mcrRepuestos.Controls.Add(this.lblOrigen);
            this.mcrRepuestos.Controls.Add(this.lblMarca);
            this.mcrRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrRepuestos.Location = new System.Drawing.Point(26, 51);
            this.mcrRepuestos.Name = "mcrRepuestos";
            this.mcrRepuestos.Size = new System.Drawing.Size(489, 301);
            this.mcrRepuestos.TabIndex = 0;
            this.mcrRepuestos.TabStop = false;
            this.mcrRepuestos.Text = "Datos del Repuesto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(260, 169);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // rtxDescripcion
            // 
            this.rtxDescripcion.Location = new System.Drawing.Point(207, 200);
            this.rtxDescripcion.MaxLength = 50;
            this.rtxDescripcion.Name = "rtxDescripcion";
            this.rtxDescripcion.Size = new System.Drawing.Size(193, 95);
            this.rtxDescripcion.TabIndex = 9;
            this.rtxDescripcion.Text = "";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(337, 103);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(337, 35);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(268, 111);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(268, 36);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 16);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Numero";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(16, 111);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(47, 16);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(16, 36);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 16);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // mcrIngresados
            // 
            this.mcrIngresados.Controls.Add(this.lblDescripcionIngresados);
            this.mcrIngresados.Controls.Add(this.rtxDescripcionIngresados);
            this.mcrIngresados.Controls.Add(this.txtPrecioIngresados);
            this.mcrIngresados.Controls.Add(this.txtNumeroIngresados);
            this.mcrIngresados.Controls.Add(this.lblPrecioIngresados);
            this.mcrIngresados.Controls.Add(this.lblNumeroIngresados);
            this.mcrIngresados.Controls.Add(this.mcrOrigen);
            this.mcrIngresados.Controls.Add(this.cboMarca);
            this.mcrIngresados.Controls.Add(this.lblMarcaIngresados);
            this.mcrIngresados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrIngresados.Location = new System.Drawing.Point(26, 389);
            this.mcrIngresados.Name = "mcrIngresados";
            this.mcrIngresados.Size = new System.Drawing.Size(489, 342);
            this.mcrIngresados.TabIndex = 2;
            this.mcrIngresados.TabStop = false;
            this.mcrIngresados.Text = "Repuestos Ingresados";
            // 
            // lblDescripcionIngresados
            // 
            this.lblDescripcionIngresados.AutoSize = true;
            this.lblDescripcionIngresados.Location = new System.Drawing.Point(260, 197);
            this.lblDescripcionIngresados.Name = "lblDescripcionIngresados";
            this.lblDescripcionIngresados.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionIngresados.TabIndex = 8;
            this.lblDescripcionIngresados.Text = "Descripcion";
            // 
            // rtxDescripcionIngresados
            // 
            this.rtxDescripcionIngresados.Location = new System.Drawing.Point(207, 229);
            this.rtxDescripcionIngresados.MaxLength = 50;
            this.rtxDescripcionIngresados.Name = "rtxDescripcionIngresados";
            this.rtxDescripcionIngresados.ReadOnly = true;
            this.rtxDescripcionIngresados.Size = new System.Drawing.Size(193, 95);
            this.rtxDescripcionIngresados.TabIndex = 7;
            this.rtxDescripcionIngresados.Text = "";
            // 
            // txtPrecioIngresados
            // 
            this.txtPrecioIngresados.Location = new System.Drawing.Point(356, 126);
            this.txtPrecioIngresados.Name = "txtPrecioIngresados";
            this.txtPrecioIngresados.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioIngresados.TabIndex = 6;
            // 
            // txtNumeroIngresados
            // 
            this.txtNumeroIngresados.Location = new System.Drawing.Point(356, 53);
            this.txtNumeroIngresados.Name = "txtNumeroIngresados";
            this.txtNumeroIngresados.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroIngresados.TabIndex = 5;
            // 
            // lblPrecioIngresados
            // 
            this.lblPrecioIngresados.AutoSize = true;
            this.lblPrecioIngresados.Location = new System.Drawing.Point(284, 132);
            this.lblPrecioIngresados.Name = "lblPrecioIngresados";
            this.lblPrecioIngresados.Size = new System.Drawing.Size(46, 16);
            this.lblPrecioIngresados.TabIndex = 4;
            this.lblPrecioIngresados.Text = "Precio";
            // 
            // lblNumeroIngresados
            // 
            this.lblNumeroIngresados.AutoSize = true;
            this.lblNumeroIngresados.Location = new System.Drawing.Point(284, 51);
            this.lblNumeroIngresados.Name = "lblNumeroIngresados";
            this.lblNumeroIngresados.Size = new System.Drawing.Size(55, 16);
            this.lblNumeroIngresados.TabIndex = 3;
            this.lblNumeroIngresados.Text = "Numero";
            // 
            // mcrOrigen
            // 
            this.mcrOrigen.Controls.Add(this.optImportado);
            this.mcrOrigen.Controls.Add(this.optNacional);
            this.mcrOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrOrigen.Location = new System.Drawing.Point(22, 126);
            this.mcrOrigen.Name = "mcrOrigen";
            this.mcrOrigen.Size = new System.Drawing.Size(139, 92);
            this.mcrOrigen.TabIndex = 2;
            this.mcrOrigen.TabStop = false;
            this.mcrOrigen.Text = "Origen";
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(7, 69);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(86, 20);
            this.optImportado.TabIndex = 1;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(7, 29);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(79, 20);
            this.optNacional.TabIndex = 0;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Items.AddRange(new object[] {
            "R",
            "P",
            "F"});
            this.cboMarca.Location = new System.Drawing.Point(87, 51);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 24);
            this.cboMarca.TabIndex = 1;
            // 
            // lblMarcaIngresados
            // 
            this.lblMarcaIngresados.AutoSize = true;
            this.lblMarcaIngresados.Location = new System.Drawing.Point(19, 51);
            this.lblMarcaIngresados.Name = "lblMarcaIngresados";
            this.lblMarcaIngresados.Size = new System.Drawing.Size(45, 16);
            this.lblMarcaIngresados.TabIndex = 0;
            this.lblMarcaIngresados.Text = "Marca";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(536, 61);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(91, 42);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(536, 145);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(536, 416);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 37);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboMarcaRepuesto
            // 
            this.cboMarcaRepuesto.FormattingEnabled = true;
            this.cboMarcaRepuesto.Items.AddRange(new object[] {
            "R",
            "P",
            "F"});
            this.cboMarcaRepuesto.Location = new System.Drawing.Point(75, 35);
            this.cboMarcaRepuesto.Name = "cboMarcaRepuesto";
            this.cboMarcaRepuesto.Size = new System.Drawing.Size(121, 24);
            this.cboMarcaRepuesto.TabIndex = 10;
            // 
            // cboOrigen
            // 
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Items.AddRange(new object[] {
            "N",
            "I"});
            this.cboOrigen.Location = new System.Drawing.Point(75, 109);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(121, 24);
            this.cboOrigen.TabIndex = 11;
            // 
            // frmRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 743);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mcrIngresados);
            this.Controls.Add(this.mcrRepuestos);
            this.Name = "frmRepuesto";
            this.Text = "Repuestos";
            this.mcrRepuestos.ResumeLayout(false);
            this.mcrRepuestos.PerformLayout();
            this.mcrIngresados.ResumeLayout(false);
            this.mcrIngresados.PerformLayout();
            this.mcrOrigen.ResumeLayout(false);
            this.mcrOrigen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mcrRepuestos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox rtxDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox mcrIngresados;
        private System.Windows.Forms.Label lblDescripcionIngresados;
        private System.Windows.Forms.RichTextBox rtxDescripcionIngresados;
        private System.Windows.Forms.TextBox txtPrecioIngresados;
        private System.Windows.Forms.TextBox txtNumeroIngresados;
        private System.Windows.Forms.Label lblPrecioIngresados;
        private System.Windows.Forms.Label lblNumeroIngresados;
        private System.Windows.Forms.GroupBox mcrOrigen;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblMarcaIngresados;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.ComboBox cboMarcaRepuesto;
    }
}

