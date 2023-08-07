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
        private string tipoPanel;
        private Panel panelCentral;
        private Sucursal actual;
        private int tienda=1;
        private int fabrica=2;
        private int otros=3;

        private SucursalNegocio negocio = new SucursalNegocio();
        private List<Sucursal> listaTienda = new List<Sucursal>();
        private List<Sucursal> listaFabricas = new List<Sucursal>();
        private List<Sucursal> listaOtros = new List<Sucursal>();
        private Form abierto = null;
        public frmSucursales(Panel panelCentral,string tipoPanel)
        {
            InitializeComponent();
            this.panelCentral = panelCentral;
            this.tipoPanel = tipoPanel;
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            if (tipoPanel=="insumos")
            {
                pbxInsumo.Visible = true;
                pbxArticulo.Visible = false;
                listaFabricas = negocio.listar(fabrica);
                cmbSucursalFabrica.DataSource = listaFabricas;
            }
            else
            {
                pbxArticulo.Visible = true;
                pbxInsumo.Visible = false; 
                listaFabricas = negocio.listar(fabrica);
                cmbSucursalFabrica.DataSource = listaFabricas;
            }
        }


        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            if (abierto != null)
                abierto.Close();
            Sucursal SucursalSelec = (Sucursal)cmbSucursalFabrica.SelectedItem;
            frmCrud frmInsumo= new frmCrud(SucursalSelec);
            abierto= HelpForm.abrirFormHijo(panelCentral,frmInsumo);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaSucursal altaFabrica = new frmAltaSucursal();
            altaFabrica.ShowDialog();
            listaFabricas = negocio.listar(fabrica);
            cmbSucursalFabrica.DataSource = listaFabricas;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actual = (Sucursal)cmbSucursalFabrica.SelectedItem;
            frmAltaSucursal altaFabrica = new frmAltaSucursal(actual);
            
            altaFabrica.ShowDialog();

            listaFabricas = negocio.listar(fabrica);
            cmbSucursalFabrica.DataSource = listaFabricas;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            actual = (Sucursal)cmbSucursalFabrica.SelectedItem;

            DialogResult resultado = MessageBox.Show($"¿Desea eliminar sucursal {actual.Descripcion}?","Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                negocio.eliminar(actual.Id);
                MessageBox.Show($"Sucursal {actual.Descripcion} elminada");
                listaFabricas = negocio.listar(fabrica);
                cmbSucursalFabrica.DataSource = listaFabricas;
            }
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            if(abierto!=null)
                abierto.Close();
            frmCrud verTodo = new frmCrud();
            abierto=HelpForm.abrirFormHijo(panelCentral, verTodo);
            
        }
    }
}
