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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.txtID.Location = new System.Drawing.Point(38, 433);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 20);
            this.txtID.TabIndex = 2;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(35, 408);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "ID";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(144, 408);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 4;
            this.lbMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(147, 433);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(80, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(248, 408);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 6;
            this.lbModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(251, 433);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(80, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modelo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 671);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

