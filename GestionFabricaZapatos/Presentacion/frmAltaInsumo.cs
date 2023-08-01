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
        private Sucursal sucursal;
        private InsumoNegocio negocio = new InsumoNegocio();
        private Insumo actual = null;
        public frmAltaInsumo(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
        }
        public frmAltaInsumo(Sucursal sucursal,Insumo seleccionado)
        {
            InitializeComponent();
            this.sucursal = sucursal;
            actual = seleccionado;
        }

        private void frmAltaInsumo_Load(object sender, EventArgs e)
        {
            lblSucursal.Text = sucursal.Descripcion;
            if (actual != null)
            {
                txtCantidad.Text = actual.Cantidad.ToString();
                txtDescripcion.Text = actual.Descripcion;
                txtPrecio.Text = actual.Precio.ToString();
            }

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
            actual.sucursal.Id = sucursal.Id;

            if (actual.Id>0)
            {
                negocio.modificar(actual);
                MessageBox.Show("Modificado Exitosamente");
            }
            else
            {
                negocio.agregar(actual);
                MessageBox.Show("Agregado Exitosamente");
            }
        }
    }
}
