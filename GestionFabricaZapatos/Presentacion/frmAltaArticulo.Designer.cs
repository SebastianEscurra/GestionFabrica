namespace Presentacion
{
    partial class frmAltaArticulo
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
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BTnAceptar = new System.Windows.Forms.Button();
            this.lblSucursalDato = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioFabricacion = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioFabricacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPrecioMayorista = new System.Windows.Forms.Label();
            this.txtPrecioMayorista = new System.Windows.Forms.TextBox();
            this.lblPrecioComercial = new System.Windows.Forms.Label();
            this.txtPrecioComercial = new System.Windows.Forms.TextBox();
            this.lblInsumos = new System.Windows.Forms.Label();
            this.dgvInsumosNecesarios = new System.Windows.Forms.DataGridView();
            this.cmbTipoCalzado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadInsumo = new System.Windows.Forms.TextBox();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.cmbInsumosAgregados = new System.Windows.Forms.ComboBox();
            this.btnEliminarinsumo = new System.Windows.Forms.Button();
            this.lblListaInsumos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosNecesarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(121, 369);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 14;
            this.cmbSucursal.Visible = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(244, 411);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.BTnAceptar.Location = new System.Drawing.Point(132, 411);
            this.BTnAceptar.Name = "BTnAceptar";
            this.BTnAceptar.Size = new System.Drawing.Size(79, 23);
            this.BTnAceptar.TabIndex = 15;
            this.BTnAceptar.Text = "Aceptar";
            this.BTnAceptar.UseVisualStyleBackColor = false;
            this.BTnAceptar.Click += new System.EventHandler(this.BTnAceptar_Click);
            // 
            // lblSucursalDato
            // 
            this.lblSucursalDato.AutoSize = true;
            this.lblSucursalDato.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSucursalDato.ForeColor = System.Drawing.Color.White;
            this.lblSucursalDato.Location = new System.Drawing.Point(66, 373);
            this.lblSucursalDato.Name = "lblSucursalDato";
            this.lblSucursalDato.Size = new System.Drawing.Size(53, 14);
            this.lblSucursalDato.TabIndex = 7;
            this.lblSucursalDato.Text = "Sucursal:";
            this.lblSucursalDato.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(61, 127);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 14);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecioFabricacion
            // 
            this.lblPrecioFabricacion.AutoSize = true;
            this.lblPrecioFabricacion.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioFabricacion.ForeColor = System.Drawing.Color.White;
            this.lblPrecioFabricacion.Location = new System.Drawing.Point(15, 280);
            this.lblPrecioFabricacion.Name = "lblPrecioFabricacion";
            this.lblPrecioFabricacion.Size = new System.Drawing.Size(118, 14);
            this.lblPrecioFabricacion.TabIndex = 9;
            this.lblPrecioFabricacion.Text = "Precio de fabricacion:";
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
            this.lblSucursal.TabIndex = 10;
            this.lblSucursal.Text = "Sucursal";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(66, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 14);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(121, 124);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 13;
            // 
            // txtPrecioFabricacion
            // 
            this.txtPrecioFabricacion.Location = new System.Drawing.Point(12, 297);
            this.txtPrecioFabricacion.Name = "txtPrecioFabricacion";
            this.txtPrecioFabricacion.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioFabricacion.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(121, 56);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(67, 93);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(51, 14);
            this.lblModelo.TabIndex = 18;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblPrecioMayorista
            // 
            this.lblPrecioMayorista.AutoSize = true;
            this.lblPrecioMayorista.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioMayorista.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMayorista.Location = new System.Drawing.Point(177, 280);
            this.lblPrecioMayorista.Name = "lblPrecioMayorista";
            this.lblPrecioMayorista.Size = new System.Drawing.Size(96, 14);
            this.lblPrecioMayorista.TabIndex = 19;
            this.lblPrecioMayorista.Text = "Precio mayorista:";
            // 
            // txtPrecioMayorista
            // 
            this.txtPrecioMayorista.Location = new System.Drawing.Point(167, 297);
            this.txtPrecioMayorista.Name = "txtPrecioMayorista";
            this.txtPrecioMayorista.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioMayorista.TabIndex = 20;
            // 
            // lblPrecioComercial
            // 
            this.lblPrecioComercial.AutoSize = true;
            this.lblPrecioComercial.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioComercial.ForeColor = System.Drawing.Color.White;
            this.lblPrecioComercial.Location = new System.Drawing.Point(329, 280);
            this.lblPrecioComercial.Name = "lblPrecioComercial";
            this.lblPrecioComercial.Size = new System.Drawing.Size(94, 14);
            this.lblPrecioComercial.TabIndex = 21;
            this.lblPrecioComercial.Text = "Precio comercial:";
            // 
            // txtPrecioComercial
            // 
            this.txtPrecioComercial.Location = new System.Drawing.Point(320, 297);
            this.txtPrecioComercial.Name = "txtPrecioComercial";
            this.txtPrecioComercial.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioComercial.TabIndex = 22;
            // 
            // lblInsumos
            // 
            this.lblInsumos.AutoSize = true;
            this.lblInsumos.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInsumos.ForeColor = System.Drawing.Color.White;
            this.lblInsumos.Location = new System.Drawing.Point(1, 161);
            this.lblInsumos.Name = "lblInsumos";
            this.lblInsumos.Size = new System.Drawing.Size(115, 14);
            this.lblInsumos.TabIndex = 23;
            this.lblInsumos.Text = "Seleccionar Insumos:";
            // 
            // dgvInsumosNecesarios
            // 
            this.dgvInsumosNecesarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumosNecesarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInsumosNecesarios.Location = new System.Drawing.Point(4, 178);
            this.dgvInsumosNecesarios.Name = "dgvInsumosNecesarios";
            this.dgvInsumosNecesarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumosNecesarios.Size = new System.Drawing.Size(238, 78);
            this.dgvInsumosNecesarios.TabIndex = 24;
            // 
            // cmbTipoCalzado
            // 
            this.cmbTipoCalzado.FormattingEnabled = true;
            this.cmbTipoCalzado.Location = new System.Drawing.Point(121, 91);
            this.cmbTipoCalzado.Name = "cmbTipoCalzado";
            this.cmbTipoCalzado.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCalzado.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 14);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cantidad necesaria:";
            // 
            // txtCantidadInsumo
            // 
            this.txtCantidadInsumo.Location = new System.Drawing.Point(244, 195);
            this.txtCantidadInsumo.Name = "txtCantidadInsumo";
            this.txtCantidadInsumo.Size = new System.Drawing.Size(108, 20);
            this.txtCantidadInsumo.TabIndex = 27;
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.btnAgregarInsumo.FlatAppearance.BorderSize = 0;
            this.btnAgregarInsumo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(86)))));
            this.btnAgregarInsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnAgregarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarInsumo.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnAgregarInsumo.Location = new System.Drawing.Point(246, 221);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(66, 23);
            this.btnAgregarInsumo.TabIndex = 28;
            this.btnAgregarInsumo.Text = "Agregar";
            this.btnAgregarInsumo.UseVisualStyleBackColor = false;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // cmbInsumosAgregados
            // 
            this.cmbInsumosAgregados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsumosAgregados.FormattingEnabled = true;
            this.cmbInsumosAgregados.Location = new System.Drawing.Point(375, 194);
            this.cmbInsumosAgregados.Name = "cmbInsumosAgregados";
            this.cmbInsumosAgregados.Size = new System.Drawing.Size(137, 21);
            this.cmbInsumosAgregados.TabIndex = 29;
            // 
            // btnEliminarinsumo
            // 
            this.btnEliminarinsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.btnEliminarinsumo.FlatAppearance.BorderSize = 0;
            this.btnEliminarinsumo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(86)))));
            this.btnEliminarinsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnEliminarinsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarinsumo.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarinsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnEliminarinsumo.Location = new System.Drawing.Point(377, 221);
            this.btnEliminarinsumo.Name = "btnEliminarinsumo";
            this.btnEliminarinsumo.Size = new System.Drawing.Size(66, 23);
            this.btnEliminarinsumo.TabIndex = 31;
            this.btnEliminarinsumo.Text = "Eliminar";
            this.btnEliminarinsumo.UseVisualStyleBackColor = false;
            this.btnEliminarinsumo.Click += new System.EventHandler(this.btnEliminarinsumo_Click);
            // 
            // lblListaInsumos
            // 
            this.lblListaInsumos.AutoSize = true;
            this.lblListaInsumos.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblListaInsumos.ForeColor = System.Drawing.Color.White;
            this.lblListaInsumos.Location = new System.Drawing.Point(374, 178);
            this.lblListaInsumos.Name = "lblListaInsumos";
            this.lblListaInsumos.Size = new System.Drawing.Size(97, 14);
            this.lblListaInsumos.TabIndex = 32;
            this.lblListaInsumos.Text = "Lista de Insumos:";
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(179)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(518, 460);
            this.Controls.Add(this.lblListaInsumos);
            this.Controls.Add(this.btnEliminarinsumo);
            this.Controls.Add(this.cmbInsumosAgregados);
            this.Controls.Add(this.btnAgregarInsumo);
            this.Controls.Add(this.txtCantidadInsumo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoCalzado);
            this.Controls.Add(this.dgvInsumosNecesarios);
            this.Controls.Add(this.lblInsumos);
            this.Controls.Add(this.lblPrecioComercial);
            this.Controls.Add(this.txtPrecioComercial);
            this.Controls.Add(this.lblPrecioMayorista);
            this.Controls.Add(this.txtPrecioMayorista);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BTnAceptar);
            this.Controls.Add(this.lblSucursalDato);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecioFabricacion);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioFabricacion);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmAltaArticulo";
            this.Text = "frmAltaArticulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosNecesarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BTnAceptar;
        private System.Windows.Forms.Label lblSucursalDato;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioFabricacion;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioFabricacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPrecioMayorista;
        private System.Windows.Forms.TextBox txtPrecioMayorista;
        private System.Windows.Forms.Label lblPrecioComercial;
        private System.Windows.Forms.TextBox txtPrecioComercial;
        private System.Windows.Forms.Label lblInsumos;
        private System.Windows.Forms.DataGridView dgvInsumosNecesarios;
        private System.Windows.Forms.ComboBox cmbTipoCalzado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadInsumo;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.ComboBox cmbInsumosAgregados;
        private System.Windows.Forms.Button btnEliminarinsumo;
        private System.Windows.Forms.Label lblListaInsumos;
    }
}