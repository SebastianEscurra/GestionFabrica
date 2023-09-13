using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAltaInsumosConSucursal : Form
    {
        private int tipoSucursal = 2;
        private Sucursal sucursalActual;
        private double cantidad;

        private RelacionSucursal_Insumo relacionSucursalActual = null;

        private InsumoNegocio insumoNegocio=new InsumoNegocio();
        private SucursalNegocio sucursalNegocio = new SucursalNegocio();
        private RelacionSucursal_InsumoNegocio relacionSucInsumoNegocio = new RelacionSucursal_InsumoNegocio();

        public frmAltaInsumosConSucursal(Sucursal sucursalActual)
        {
            InitializeComponent();
            this.sucursalActual = sucursalActual;
        }
        public frmAltaInsumosConSucursal(RelacionSucursal_Insumo relacionSucursalActual)
        {
            InitializeComponent();
            this.relacionSucursalActual = relacionSucursalActual;
        }

        private void frmAltaInsumosConSucursal_Load(object sender, EventArgs e)
        {
            cmbInsumo.DataSource = insumoNegocio.listar();
            cmbSucursal.DataSource = sucursalNegocio.listar(tipoSucursal);

            if (relacionSucursalActual!=null)
            {
                cmbSucursal.Visible = true;
                lblSucursal.Visible = true;

                cmbInsumo.ValueMember = "Id";
                cmbInsumo.DisplayMember = "Descripcion";
                cmbInsumo.SelectedValue = relacionSucursalActual.Insumo.Id;

                cmbSucursal.ValueMember = "Id";
                cmbSucursal.DisplayMember = "Descripcion";
                cmbSucursal.SelectedValue = relacionSucursalActual.Sucursal.Id;

                txtCantidad.Text = relacionSucursalActual.Cantidad.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTnAceptar_Click(object sender, EventArgs e)
        {
            if (relacionSucursalActual == null)
            {
                relacionSucursalActual = new RelacionSucursal_Insumo();
                relacionSucursalActual.Sucursal = sucursalActual;
            }
            else
            {
                relacionSucursalActual.Sucursal = (Sucursal)cmbSucursal.SelectedItem;
            }

            relacionSucursalActual.Insumo = (Insumo)cmbInsumo.SelectedItem;
            relacionSucursalActual.Cantidad = int.Parse(txtCantidad.Text); 

            try
            {
                if (relacionSucursalActual.Id==0)
                {
                    relacionSucInsumoNegocio.agregar(relacionSucursalActual);
                    MessageBox.Show("Insumo Agregado a sucursal");
                }
                else
                {
                    relacionSucInsumoNegocio.modificar(relacionSucursalActual);
                    MessageBox.Show("Insumo Modificado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            Insumo seleccionado = (Insumo)cmbInsumo.SelectedItem;
            lblMensajeCantidadDisponible.Text = "Unidades disponibles: " + seleccionado.Cantidad.ToString();
            lblMensajeCantidadDisponible.Visible = true;
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            lblMensajeCantidadDisponible.Visible = false;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Insumo seleccionado = (Insumo)cmbInsumo.SelectedItem;
            if (txtCantidad.Text!="")
            {
                cantidad = seleccionado.Cantidad - int.Parse(txtCantidad.Text);
                lblMensajeCantidadDisponible.Text = "Unidades disponibles: " + cantidad;
            }
            else
            {
                lblMensajeCantidadDisponible.Text = "Unidades disponibles: " + seleccionado.Cantidad.ToString();
            }
        }

        private void lblMensajeCantidadDisponible_TextChanged(object sender, EventArgs e)
        {
            Insumo seleccionado = (Insumo)cmbInsumo.SelectedItem;
            if (txtCantidad.Text!="")
            {
                cantidad = seleccionado.Cantidad - int.Parse(txtCantidad.Text);

                if (cantidad < 0)
                {
                    lblMensajeCantidadDisponible.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblMensajeCantidadDisponible.ForeColor = Color.DimGray;
                }
            }
        }
    }
}
