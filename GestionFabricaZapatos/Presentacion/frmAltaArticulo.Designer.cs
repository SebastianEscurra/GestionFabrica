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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BTnAceptar = new System.Windows.Forms.Button();
            this.lblPrecioFabricacion = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
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
            this.btnCalcularPrecios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosNecesarios)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(244, 424);
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
            this.BTnAceptar.Location = new System.Drawing.Point(132, 424);
            this.BTnAceptar.Name = "BTnAceptar";
            this.BTnAceptar.Size = new System.Drawing.Size(79, 23);
            this.BTnAceptar.TabIndex = 15;
            this.BTnAceptar.Text = "Aceptar";
            this.BTnAceptar.UseVisualStyleBackColor = false;
            this.BTnAceptar.Click += new System.EventHandler(this.BTnAceptar_Click);
            // 
            // lblPrecioFabricacion
            // 
            this.lblPrecioFabricacion.AutoSize = true;
            this.lblPrecioFabricacion.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioFabricacion.ForeColor = System.Drawing.Color.White;
            this.lblPrecioFabricacion.Location = new System.Drawing.Point(364, 162);
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
            this.lblNombre.Location = new System.Drawing.Point(8, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 14);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtPrecioFabricacion
            // 
            this.txtPrecioFabricacion.Location = new System.Drawing.Point(361, 179);
            this.txtPrecioFabricacion.Name = "txtPrecioFabricacion";
            this.txtPrecioFabricacion.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioFabricacion.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(63, 57);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(193, 63);
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
            this.lblPrecioMayorista.Location = new System.Drawing.Point(371, 221);
            this.lblPrecioMayorista.Name = "lblPrecioMayorista";
            this.lblPrecioMayorista.Size = new System.Drawing.Size(96, 14);
            this.lblPrecioMayorista.TabIndex = 19;
            this.lblPrecioMayorista.Text = "Precio mayorista:";
            // 
            // txtPrecioMayorista
            // 
            this.txtPrecioMayorista.Location = new System.Drawing.Point(361, 237);
            this.txtPrecioMayorista.Name = "txtPrecioMayorista";
            this.txtPrecioMayorista.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioMayorista.TabIndex = 20;
            // 
            // lblPrecioComercial
            // 
            this.lblPrecioComercial.AutoSize = true;
            this.lblPrecioComercial.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioComercial.ForeColor = System.Drawing.Color.White;
            this.lblPrecioComercial.Location = new System.Drawing.Point(370, 279);
            this.lblPrecioComercial.Name = "lblPrecioComercial";
            this.lblPrecioComercial.Size = new System.Drawing.Size(94, 14);
            this.lblPrecioComercial.TabIndex = 21;
            this.lblPrecioComercial.Text = "Precio comercial:";
            // 
            // txtPrecioComercial
            // 
            this.txtPrecioComercial.Location = new System.Drawing.Point(361, 295);
            this.txtPrecioComercial.Name = "txtPrecioComercial";
            this.txtPrecioComercial.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioComercial.TabIndex = 22;
            // 
            // lblInsumos
            // 
            this.lblInsumos.AutoSize = true;
            this.lblInsumos.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInsumos.ForeColor = System.Drawing.Color.White;
            this.lblInsumos.Location = new System.Drawing.Point(8, 86);
            this.lblInsumos.Name = "lblInsumos";
            this.lblInsumos.Size = new System.Drawing.Size(115, 14);
            this.lblInsumos.TabIndex = 23;
            this.lblInsumos.Text = "Seleccionar Insumos:";
            // 
            // dgvInsumosNecesarios
            // 
            this.dgvInsumosNecesarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumosNecesarios.Location = new System.Drawing.Point(11, 103);
            this.dgvInsumosNecesarios.MultiSelect = false;
            this.dgvInsumosNecesarios.Name = "dgvInsumosNecesarios";
            this.dgvInsumosNecesarios.ReadOnly = true;
            this.dgvInsumosNecesarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInsumosNecesarios.Size = new System.Drawing.Size(333, 290);
            this.dgvInsumosNecesarios.TabIndex = 24;
            this.dgvInsumosNecesarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumosNecesarios_CellClick);
            this.dgvInsumosNecesarios.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvInsumosNecesarios_CellValidating);
            // 
            // cmbTipoCalzado
            // 
            this.cmbTipoCalzado.FormattingEnabled = true;
            this.cmbTipoCalzado.Location = new System.Drawing.Point(247, 56);
            this.cmbTipoCalzado.Name = "cmbTipoCalzado";
            this.cmbTipoCalzado.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCalzado.TabIndex = 25;
            // 
            // btnCalcularPrecios
            // 
            this.btnCalcularPrecios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.btnCalcularPrecios.FlatAppearance.BorderSize = 0;
            this.btnCalcularPrecios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(86)))));
            this.btnCalcularPrecios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnCalcularPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPrecios.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPrecios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnCalcularPrecios.Location = new System.Drawing.Point(367, 342);
            this.btnCalcularPrecios.Name = "btnCalcularPrecios";
            this.btnCalcularPrecios.Size = new System.Drawing.Size(108, 23);
            this.btnCalcularPrecios.TabIndex = 33;
            this.btnCalcularPrecios.Text = "Calcular Precios";
            this.btnCalcularPrecios.UseVisualStyleBackColor = false;
            this.btnCalcularPrecios.Click += new System.EventHandler(this.btnCalcularPrecios_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(179)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(518, 460);
            this.Controls.Add(this.btnCalcularPrecios);
            this.Controls.Add(this.cmbTipoCalzado);
            this.Controls.Add(this.dgvInsumosNecesarios);
            this.Controls.Add(this.lblInsumos);
            this.Controls.Add(this.lblPrecioComercial);
            this.Controls.Add(this.txtPrecioComercial);
            this.Controls.Add(this.lblPrecioMayorista);
            this.Controls.Add(this.txtPrecioMayorista);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BTnAceptar);
            this.Controls.Add(this.lblPrecioFabricacion);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblNombre);
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BTnAceptar;
        private System.Windows.Forms.Label lblPrecioFabricacion;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblNombre;
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
        private System.Windows.Forms.Button btnCalcularPrecios;
    }
}