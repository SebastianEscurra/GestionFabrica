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
        public frmAltaInsumo(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
        }

        private void frmAltaInsumo_Load(object sender, EventArgs e)
        {
            lblSucursal.Text = sucursal.Descripcion;
        }

        private void BTnFiltrar_Click(object sender, EventArgs e)
        {
            Insumo nuevo = new Insumo();
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Cantidad = int.Parse(txtCantidad.Text);
            nuevo.Precio = decimal.Parse(txtPrecio.Text);
            nuevo.sucursal = new Sucursal();
            nuevo.sucursal.Id = sucursal.Id;
            negocio.agregar(nuevo);
            MessageBox.Show("Agregado Exitosamente");
        }
    }
}
