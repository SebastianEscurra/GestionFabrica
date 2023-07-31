namespace Presentacion
{
    partial class frmAltaInsumo
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.BTnFiltrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(155, 122);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(99, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 14);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(155, 158);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 0;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(110, 161);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 14);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(155, 200);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(95, 203);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 14);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSucursal.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.lblSucursal.ForeColor = System.Drawing.Color.White;
            this.lblSucursal.Location = new System.Drawing.Point(0, 0);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(89, 24);
            this.lblSucursal.TabIndex = 1;
            this.lblSucursal.Text = "Sucursal";
            // 
            // BTnFiltrar
            // 
            this.BTnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.BTnFiltrar.FlatAppearance.BorderSize = 0;
            this.BTnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(86)))));
            this.BTnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BTnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTnFiltrar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.BTnFiltrar.Location = new System.Drawing.Point(102, 267);
            this.BTnFiltrar.Name = "BTnFiltrar";
            this.BTnFiltrar.Size = new System.Drawing.Size(79, 23);
            this.BTnFiltrar.TabIndex = 15;
            this.BTnFiltrar.Text = "Aceptar";
            this.BTnFiltrar.UseVisualStyleBackColor = false;
            this.BTnFiltrar.Click += new System.EventHandler(this.BTnFiltrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(86)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.button1.Location = new System.Drawing.Point(214, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAltaInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(179)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTnFiltrar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmAltaInsumo";
            this.Text = "frmAltaInsumo";
            this.Load += new System.EventHandler(this.frmAltaInsumo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Button BTnFiltrar;
        private System.Windows.Forms.Button button1;
    }
}