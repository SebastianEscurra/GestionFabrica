namespace Presentacion
{
    partial class frmOpcionesSinStockSucursal
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
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.rbtnStockGeneralySucursal = new System.Windows.Forms.RadioButton();
            this.rbtnBuscarOtraSucursal = new System.Windows.Forms.RadioButton();
            this.rbtnStokSucursalActual = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.lblElegirSucursal = new System.Windows.Forms.Label();
            this.gbxOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Controls.Add(this.rbtnStockGeneralySucursal);
            this.gbxOpciones.Controls.Add(this.rbtnBuscarOtraSucursal);
            this.gbxOpciones.Controls.Add(this.rbtnStokSucursalActual);
            this.gbxOpciones.Location = new System.Drawing.Point(28, 3);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Size = new System.Drawing.Size(253, 100);
            this.gbxOpciones.TabIndex = 0;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Seleccionar opción:";
            // 
            // rbtnStockGeneralySucursal
            // 
            this.rbtnStockGeneralySucursal.AutoSize = true;
            this.rbtnStockGeneralySucursal.Location = new System.Drawing.Point(25, 43);
            this.rbtnStockGeneralySucursal.Name = "rbtnStockGeneralySucursal";
            this.rbtnStockGeneralySucursal.Size = new System.Drawing.Size(222, 17);
            this.rbtnStockGeneralySucursal.TabIndex = 0;
            this.rbtnStockGeneralySucursal.TabStop = true;
            this.rbtnStockGeneralySucursal.Text = "Agregar al stock general y sucursal actual";
            this.rbtnStockGeneralySucursal.UseVisualStyleBackColor = true;
            // 
            // rbtnBuscarOtraSucursal
            // 
            this.rbtnBuscarOtraSucursal.AutoSize = true;
            this.rbtnBuscarOtraSucursal.Location = new System.Drawing.Point(25, 66);
            this.rbtnBuscarOtraSucursal.Name = "rbtnBuscarOtraSucursal";
            this.rbtnBuscarOtraSucursal.Size = new System.Drawing.Size(186, 17);
            this.rbtnBuscarOtraSucursal.TabIndex = 0;
            this.rbtnBuscarOtraSucursal.TabStop = true;
            this.rbtnBuscarOtraSucursal.Text = "Agregar stock desde otra sucursal";
            this.rbtnBuscarOtraSucursal.UseVisualStyleBackColor = true;
            this.rbtnBuscarOtraSucursal.CheckedChanged += new System.EventHandler(this.rbtnBuscarOtraSucursal_CheckedChanged);
            // 
            // rbtnStokSucursalActual
            // 
            this.rbtnStokSucursalActual.AutoSize = true;
            this.rbtnStokSucursalActual.Location = new System.Drawing.Point(25, 20);
            this.rbtnStokSucursalActual.Name = "rbtnStokSucursalActual";
            this.rbtnStokSucursalActual.Size = new System.Drawing.Size(174, 17);
            this.rbtnStokSucursalActual.TabIndex = 0;
            this.rbtnStokSucursalActual.TabStop = true;
            this.rbtnStokSucursalActual.Text = "Agregar stock a sucursal actual";
            this.rbtnStokSucursalActual.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(58, 148);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(181, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(89, 121);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursales.TabIndex = 2;
            this.cmbSucursales.Visible = false;
            // 
            // lblElegirSucursal
            // 
            this.lblElegirSucursal.AutoSize = true;
            this.lblElegirSucursal.Location = new System.Drawing.Point(113, 106);
            this.lblElegirSucursal.Name = "lblElegirSucursal";
            this.lblElegirSucursal.Size = new System.Drawing.Size(75, 13);
            this.lblElegirSucursal.TabIndex = 3;
            this.lblElegirSucursal.Text = "Elegir sucursal";
            this.lblElegirSucursal.Visible = false;
            // 
            // frmOpcionesSinStockSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 183);
            this.Controls.Add(this.lblElegirSucursal);
            this.Controls.Add(this.cmbSucursales);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbxOpciones);
            this.Name = "frmOpcionesSinStockSucursal";
            this.Text = "frmOpcionesSinStockSucursal";
            this.Load += new System.EventHandler(this.frmOpcionesSinStockSucursal_Load);
            this.gbxOpciones.ResumeLayout(false);
            this.gbxOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.RadioButton rbtnStockGeneralySucursal;
        private System.Windows.Forms.RadioButton rbtnBuscarOtraSucursal;
        private System.Windows.Forms.RadioButton rbtnStokSucursalActual;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.Label lblElegirSucursal;
    }
}