namespace Gestión_de_CompraAutos
{
    partial class Form1
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
            this.GVAutos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lbAnio = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // GVAutos
            // 
            this.GVAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVAutos.Location = new System.Drawing.Point(12, 12);
            this.GVAutos.Name = "GVAutos";
            this.GVAutos.Size = new System.Drawing.Size(1462, 325);
            this.GVAutos.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(681, 343);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(92, 38);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 456);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 20);
            this.txtID.TabIndex = 2;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(15, 431);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "ID";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(124, 431);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 4;
            this.lbMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(127, 456);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(80, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(228, 431);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 6;
            this.lbModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(231, 456);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(80, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(331, 431);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(26, 13);
            this.lbAnio.TabIndex = 8;
            this.lbAnio.Text = "Año";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(334, 456);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(80, 20);
            this.txtAnio.TabIndex = 9;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(441, 431);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 10;
            this.lbColor.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(444, 456);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(80, 20);
            this.txtColor.TabIndex = 11;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(556, 431);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 12;
            this.lbPrecio.Text = "Precio";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(666, 431);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 13;
            this.lbEstado.Text = "Estado";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(559, 456);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(80, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(669, 456);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(80, 20);
            this.txtEstado.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 501);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 32);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(18, 539);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 32);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 577);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 32);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(18, 615);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 32);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(657, 501);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(92, 32);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(657, 539);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(92, 32);
            this.btnImportar.TabIndex = 21;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 671);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lbAnio);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.GVAutos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GVAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVAutos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
    }
}

