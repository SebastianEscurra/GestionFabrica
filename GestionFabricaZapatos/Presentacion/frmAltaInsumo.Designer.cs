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
            this.txtPrecioBruto = new System.Windows.Forms.TextBox();
            this.lblPrecioBruto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSucursalTitulo = new System.Windows.Forms.Label();
            this.BTnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.lblPrecioUnidad = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxImagenProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(148, 51);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(92, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 14);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtPrecioBruto
            // 
            this.txtPrecioBruto.Location = new System.Drawing.Point(148, 87);
            this.txtPrecioBruto.Name = "txtPrecioBruto";
            this.txtPrecioBruto.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioBruto.TabIndex = 1;
            this.txtPrecioBruto.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblPrecioBruto
            // 
            this.lblPrecioBruto.AutoSize = true;
            this.lblPrecioBruto.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioBruto.ForeColor = System.Drawing.Color.White;
            this.lblPrecioBruto.Location = new System.Drawing.Point(72, 90);
            this.lblPrecioBruto.Name = "lblPrecioBruto";
            this.lblPrecioBruto.Size = new System.Drawing.Size(74, 14);
            this.lblPrecioBruto.TabIndex = 1;
            this.lblPrecioBruto.Text = "Precio bruto:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(148, 123);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(88, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 14);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblSucursalTitulo
            // 
            this.lblSucursalTitulo.AutoSize = true;
            this.lblSucursalTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSucursalTitulo.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.lblSucursalTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSucursalTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblSucursalTitulo.Name = "lblSucursalTitulo";
            this.lblSucursalTitulo.Size = new System.Drawing.Size(89, 24);
            this.lblSucursalTitulo.TabIndex = 1;
            this.lblSucursalTitulo.Text = "Sucursal";
            // 
            // BTnAceptar
            // 
            this.BTnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.BTnAceptar.FlatAppearance.BorderSize = 0;
            this.BTnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(86)))));
            this.BTnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.BTnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTnAceptar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.BTnAceptar.Location = new System.Drawing.Point(101, 401);
            this.BTnAceptar.Name = "BTnAceptar";
            this.BTnAceptar.Size = new System.Drawing.Size(79, 23);
            this.BTnAceptar.TabIndex = 4;
            this.BTnAceptar.Text = "Aceptar";
            this.BTnAceptar.UseVisualStyleBackColor = false;
            this.BTnAceptar.Click += new System.EventHandler(this.BTnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(86)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnCancelar.Location = new System.Drawing.Point(213, 401);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSucursal.ForeColor = System.Drawing.Color.White;
            this.lblSucursal.Location = new System.Drawing.Point(92, 363);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(53, 14);
            this.lblSucursal.TabIndex = 1;
            this.lblSucursal.Text = "Sucursal:";
            this.lblSucursal.Visible = false;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(148, 359);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 3;
            this.cmbSucursal.Visible = false;
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(148, 159);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioUnidad.TabIndex = 2;
            // 
            // lblPrecioUnidad
            // 
            this.lblPrecioUnidad.AutoSize = true;
            this.lblPrecioUnidad.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioUnidad.ForeColor = System.Drawing.Color.White;
            this.lblPrecioUnidad.Location = new System.Drawing.Point(54, 162);
            this.lblPrecioUnidad.Name = "lblPrecioUnidad";
            this.lblPrecioUnidad.Size = new System.Drawing.Size(92, 14);
            this.lblPrecioUnidad.TabIndex = 1;
            this.lblPrecioUnidad.Text = "Precio X unidad:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(148, 198);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(121, 20);
            this.txtUrlImagen.TabIndex = 2;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUrlImagen.ForeColor = System.Drawing.Color.White;
            this.lblUrlImagen.Location = new System.Drawing.Point(78, 201);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(67, 14);
            this.lblUrlImagen.TabIndex = 1;
            this.lblUrlImagen.Text = "Url Imagen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pbxImagenProducto
            // 
            this.pbxImagenProducto.Location = new System.Drawing.Point(141, 223);
            this.pbxImagenProducto.Name = "pbxImagenProducto";
            this.pbxImagenProducto.Size = new System.Drawing.Size(130, 130);
            this.pbxImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenProducto.TabIndex = 7;
            this.pbxImagenProducto.TabStop = false;
            // 
            // frmAltaInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(179)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.pbxImagenProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BTnAceptar);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblPrecioUnidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecioBruto);
            this.Controls.Add(this.lblSucursalTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtPrecioUnidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioBruto);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmAltaInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaInsumo";
            this.Load += new System.EventHandler(this.frmAltaInsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecioBruto;
        private System.Windows.Forms.Label lblPrecioBruto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblSucursalTitulo;
        private System.Windows.Forms.Button BTnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.TextBox txtPrecioUnidad;
        private System.Windows.Forms.Label lblPrecioUnidad;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxImagenProducto;
    }
}