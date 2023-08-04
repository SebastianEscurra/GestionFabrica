using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using Helper;

namespace Presentacion
{
    public partial class frmSucursales : Form
    {
        private Panel panelCentral;
        private SucursalNegocio negocio = new SucursalNegocio();
        private List<Sucursal> listaSucursales = new List<Sucursal>();
        private Sucursal actual;
        public frmSucursales(Panel panelCentral)
        {
            InitializeComponent();
            this.panelCentral = panelCentral;
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            listaSucursales = negocio.listar();
            cmbSucursalFabrica.DataSource = listaSucursales;
        }


        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            Sucursal SucursalSelec = (Sucursal)cmbSucursalFabrica.SelectedItem;

            frmCrud frmInsumo= new frmCrud(SucursalSelec);
            HelpForm.abrirFormHijo(panelCentral,frmInsumo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaSucursal altaFabrica = new frmAltaSucursal();
            altaFabrica.ShowDialog();
            listaSucursales = negocio.listar();
            cmbSucursalFabrica.DataSource = listaSucursales;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actual = (Sucursal)cmbSucursalFabrica.SelectedItem;
            frmAltaSucursal altaFabrica = new frmAltaSucursal(actual);
            
            altaFabrica.ShowDialog();

            listaSucursales = negocio.listar();
            cmbSucursalFabrica.DataSource = listaSucursales;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            actual = (Sucursal)cmbSucursalFabrica.SelectedItem;

            DialogResult resultado = MessageBox.Show($"¿Desea eliminar sucursal {actual.Descripcion}?","Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                negocio.eliminar(actual.Id);
                MessageBox.Show($"Sucursal {actual.Descripcion} elminada");
                listaSucursales = negocio.listar();
                cmbSucursalFabrica.DataSource = listaSucursales;
            }
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            frmCrud verTodo = new frmCrud();
            HelpForm.abrirFormHijo(panelCentral, verTodo);
        }
    }
}
