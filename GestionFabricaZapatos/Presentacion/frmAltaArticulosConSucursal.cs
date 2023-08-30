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
    public partial class frmAltaArticulosConSucursal : Form
    {
        private Sucursal sucursal;

        private ArticuloNegocio articuloNegocio= new ArticuloNegocio();
        public frmAltaArticulosConSucursal(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
        }

        private void frmAltaArticulosConSucursal_Load(object sender, EventArgs e)
        {
            lblSucursal.Text = sucursal.Descripcion;
            cmbArticulo.DataSource = articuloNegocio.listar();
        }
    }
}
