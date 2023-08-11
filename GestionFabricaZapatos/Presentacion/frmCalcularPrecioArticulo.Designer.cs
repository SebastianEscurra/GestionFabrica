namespace Presentacion
{
    partial class frmCalcularPrecioArticulo
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
            this.lblPrecioComercial = new System.Windows.Forms.Label();
            this.txtPrecioComercial = new System.Windows.Forms.TextBox();
            this.lblPrecioMayorista = new System.Windows.Forms.Label();
            this.txtPrecioMayorista = new System.Windows.Forms.TextBox();
            this.lblPrecioFabricacion = new System.Windows.Forms.Label();
            this.txtPrecioFabricacion = new System.Windows.Forms.TextBox();
            this.dgvInsumosNecesarios = new System.Windows.Forms.DataGridView();
            this.lblInsumos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BTnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosNecesarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecioComercial
            // 
            this.lblPrecioComercial.AutoSize = true;
            this.lblPrecioComercial.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioComercial.ForeColor = System.Drawing.Color.White;
            this.lblPrecioComercial.Location = new System.Drawing.Point(119, 207);
            this.lblPrecioComercial.Name = "lblPrecioComercial";
            this.lblPrecioComercial.Size = new System.Drawing.Size(94, 14);
            this.lblPrecioComercial.TabIndex = 27;
            this.lblPrecioComercial.Text = "Precio comercial:";
            // 
            // txtPrecioComercial
            // 
            this.txtPrecioComercial.Location = new System.Drawing.Point(215, 204);
            this.txtPrecioComercial.Name = "txtPrecioComercial";
            this.txtPrecioComercial.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioComercial.TabIndex = 28;
            // 
            // lblPrecioMayorista
            // 
            this.lblPrecioMayorista.AutoSize = true;
            this.lblPrecioMayorista.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioMayorista.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMayorista.Location = new System.Drawing.Point(117, 241);
            this.lblPrecioMayorista.Name = "lblPrecioMayorista";
            this.lblPrecioMayorista.Size = new System.Drawing.Size(96, 14);
            this.lblPrecioMayorista.TabIndex = 25;
            this.lblPrecioMayorista.Text = "Precio mayorista:";
            // 
            // txtPrecioMayorista
            // 
            this.txtPrecioMayorista.Location = new System.Drawing.Point(215, 238);
            this.txtPrecioMayorista.Name = "txtPrecioMayorista";
            this.txtPrecioMayorista.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioMayorista.TabIndex = 26;
            // 
            // lblPrecioFabricacion
            // 
            this.lblPrecioFabricacion.AutoSize = true;
            this.lblPrecioFabricacion.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioFabricacion.ForeColor = System.Drawing.Color.White;
            this.lblPrecioFabricacion.Location = new System.Drawing.Point(95, 173);
            this.lblPrecioFabricacion.Name = "lblPrecioFabricacion";
            this.lblPrecioFabricacion.Size = new System.Drawing.Size(118, 14);
            this.lblPrecioFabricacion.TabIndex = 23;
            this.lblPrecioFabricacion.Text = "Precio de fabricacion:";
            // 
            // txtPrecioFabricacion
            // 
            this.txtPrecioFabricacion.Location = new System.Drawing.Point(215, 170);
            this.txtPrecioFabricacion.Name = "txtPrecioFabricacion";
            this.txtPrecioFabricacion.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioFabricacion.TabIndex = 24;
            // 
            // dgvInsumosNecesarios
            // 
            this.dgvInsumosNecesarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumosNecesarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInsumosNecesarios.Location = new System.Drawing.Point(360, 89);
            this.dgvInsumosNecesarios.Name = "dgvInsumosNecesarios";
            this.dgvInsumosNecesarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumosNecesarios.Size = new System.Drawing.Size(121, 225);
            this.dgvInsumosNecesarios.TabIndex = 30;
            // 
            // lblInsumos
            // 
            this.lblInsumos.AutoSize = true;
            this.lblInsumos.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInsumos.ForeColor = System.Drawing.Color.White;
            this.lblInsumos.Location = new System.Drawing.Point(363, 72);
            this.lblInsumos.Name = "lblInsumos";
            this.lblInsumos.Size = new System.Drawing.Size(111, 14);
            this.lblInsumos.TabIndex = 29;
            this.lblInsumos.Text = "Insumos necesarios:";
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
            this.btnCancelar.Location = new System.Drawing.Point(311, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 23);
            this.btnCancelar.TabIndex = 32;
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
            this.BTnAceptar.Location = new System.Drawing.Point(199, 329);
            this.BTnAceptar.Name = "BTnAceptar";
            this.BTnAceptar.Size = new System.Drawing.Size(79, 23);
            this.BTnAceptar.TabIndex = 31;
            this.BTnAceptar.Text = "Aceptar";
            this.BTnAceptar.UseVisualStyleBackColor = false;
            // 
            // frmCalcularPrecioArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(179)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BTnAceptar);
            this.Controls.Add(this.dgvInsumosNecesarios);
            this.Controls.Add(this.lblInsumos);
            this.Controls.Add(this.lblPrecioComercial);
            this.Controls.Add(this.txtPrecioComercial);
            this.Controls.Add(this.lblPrecioMayorista);
            this.Controls.Add(this.txtPrecioMayorista);
            this.Controls.Add(this.lblPrecioFabricacion);
            this.Controls.Add(this.txtPrecioFabricacion);
            this.Name = "frmCalcularPrecioArticulo";
            this.Text = "frmCalcularPrecioArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosNecesarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioComercial;
        private System.Windows.Forms.TextBox txtPrecioComercial;
        private System.Windows.Forms.Label lblPrecioMayorista;
        private System.Windows.Forms.TextBox txtPrecioMayorista;
        private System.Windows.Forms.Label lblPrecioFabricacion;
        private System.Windows.Forms.TextBox txtPrecioFabricacion;
        private System.Windows.Forms.DataGridView dgvInsumosNecesarios;
        private System.Windows.Forms.Label lblInsumos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BTnAceptar;
    }
}