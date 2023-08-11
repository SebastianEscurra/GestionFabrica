using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class frmAltaInsumo : Form
    {
        //Atributos
        private Sucursal sucursal=null;
        private Insumo actual = null;
        private InsumoNegocio insumoNegocio = new InsumoNegocio();
        private SucursalNegocio sucursalNegocio = new SucursalNegocio();
        private int tipoSucursal;

        // Constructores
        public frmAltaInsumo()
        {
            InitializeComponent();
        }
        public frmAltaInsumo(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
            tipoSucursal = sucursal.IdTipo;
        }
        public frmAltaInsumo(Insumo seleccionado)
        {
            InitializeComponent();
            actual = seleccionado;
        }
        public frmAltaInsumo(Sucursal sucursal,Insumo seleccionado)
        {
            InitializeComponent();
            this.sucursal = sucursal;
            actual = seleccionado;
            tipoSucursal = sucursal.IdTipo;
        }

        // Eventos
        private void frmAltaInsumo_Load(object sender, EventArgs e)
        {
            
            if (actual != null)
            {
                txtCantidad.Text = actual.Cantidad.ToString();
                txtDescripcion.Text = actual.Descripcion;
                txtPrecio.Text = actual.Precio.ToString();
                cmbSucursal.DataSource = sucursalNegocio.listar(tipoSucursal);
                cmbSucursal.ValueMember = "Id";
                cmbSucursal.DisplayMember = "Descripcion";
                cmbSucursal.SelectedValue = actual.sucursal.Id;
            }
            else
            {
                cmbSucursal.DataSource = sucursalNegocio.listar(tipoSucursal);
                cmbSucursal.ValueMember = "Id";
                cmbSucursal.DisplayMember = "Descripcion";
                cmbSucursal.SelectedValue = -1;
            }

            if (sucursal==null) // estariamos dentro del frmVertodo
            {
                lblSucursalTitulo.Visible = false;
                cmbSucursal.Visible = true;
                lblSucursal.Visible = true;
            }else
                lblSucursalTitulo.Text = sucursal.Descripcion;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTnAceptar_Click(object sender, EventArgs e)
        {
            if (actual == null)
                actual = new Insumo();

            
            actual.Cantidad = int.Parse(txtCantidad.Text);
            actual.Descripcion = txtDescripcion.Text;
            actual.Precio = decimal.Parse(txtPrecio.Text);
            actual.sucursal = new Sucursal();
            if (sucursal == null)
                actual.sucursal = (Sucursal)cmbSucursal.SelectedItem;
            else
                actual.sucursal = sucursal;



            if (actual.Id>0)
            {
                insumoNegocio.modificar(actual);
                MessageBox.Show("Modificado Exitosamente");
            }
            else
            {
                insumoNegocio.agregar(actual);
                MessageBox.Show("Agregado Exitosamente");
            }
        }
    }
}
