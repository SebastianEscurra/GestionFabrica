namespace Presentacion
{
    partial class frmVerDetalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxImagenProducto = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecioBruto = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagenProducto
            // 
            this.pbxImagenProducto.Location = new System.Drawing.Point(87, 69);
            this.pbxImagenProducto.Name = "pbxImagenProducto";
            this.pbxImagenProducto.Size = new System.Drawing.Size(200, 200);
            this.pbxImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenProducto.TabIndex = 29;
            this.pbxImagenProducto.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Gadugi", 22F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(179, 36);
            this.lblDescripcion.TabIndex = 28;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecioBruto
            // 
            this.lblPrecioBruto.AutoSize = true;
            this.lblPrecioBruto.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.lblPrecioBruto.ForeColor = System.Drawing.Color.White;
            this.lblPrecioBruto.Location = new System.Drawing.Point(118, 272);
            this.lblPrecioBruto.Name = "lblPrecioBruto";
            this.lblPrecioBruto.Size = new System.Drawing.Size(122, 24);
            this.lblPrecioBruto.TabIndex = 28;
            this.lblPrecioBruto.Text = "PrecioBruto";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioUnitario.ForeColor = System.Drawing.Color.White;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(12, 358);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(81, 14);
            this.lblPrecioUnitario.TabIndex = 28;
            this.lblPrecioUnitario.Text = "PrecioUnitario";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(12, 388);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(54, 14);
            this.lblCantidad.TabIndex = 28;
            this.lblCantidad.Text = "Cantidad";
            // 
            // frmVerDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(179)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.pbxImagenProducto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblPrecioBruto);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmVerDetalles";
            this.Text = "frmVerDetalles";
            this.Load += new System.EventHandler(this.frmVerDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagenProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecioBruto;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblCantidad;
    }
}