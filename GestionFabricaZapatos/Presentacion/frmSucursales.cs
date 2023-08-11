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
        // Atributos
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
        private Form fabricaAbierto = null;
        private Form tiendaAbierto = null;
        private Form otrosAbierto = null;

        // Constructores
        public frmSucursales(Panel panelCentral,string tipoPanel)
        {
            InitializeComponent();
            this.panelCentral = panelCentral;
            this.tipoPanel = tipoPanel;
        }
        
        //Eventos
        private void frmSucursales_Load(object sender, EventArgs e)
        {
            if (tipoPanel=="insumos")
            {
                mostrarElementosInsumos();
                cargarComboBox(fabrica);
            }
            else
            {
                mostrarElementosArticulos();
                cargarComboBox(tienda);
                cargarComboBox(fabrica);
                cargarComboBox(otros);
            }
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            if(fabricaAbierto!=null)
                fabricaAbierto.Close();
            frmCrud verTodo = new frmCrud(tipoPanel);
            fabricaAbierto=HelpForm.abrirFormHijo(panelCentral, verTodo);
            
        }
        
        // Fabrica
        private void btnAgregarFabrica_Click(object sender, EventArgs e)
        {
            frmAltaSucursal altaFabrica = new frmAltaSucursal(fabrica);
            altaFabrica.ShowDialog();
            cargarComboBox(fabrica);
        }

        private void btnModificarFabrica_Click(object sender, EventArgs e)
        {
            actual = (Sucursal)cmbSucursalFabrica.SelectedItem;
            
            frmAltaSucursal altaFabrica = new frmAltaSucursal(actual);
            altaFabrica.ShowDialog();
            cargarComboBox(fabrica);
        }

        private void btnEliminarFabrica_Click(object sender, EventArgs e)
        {
            actual = (Sucursal)cmbSucursalFabrica.SelectedItem;

            DialogResult resultado = MessageBox.Show($"¿Desea eliminar sucursal {actual.Descripcion}?","Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                negocio.eliminar(actual.Id);
                MessageBox.Show($"Sucursal {actual.Descripcion} elminada");
                cargarComboBox(fabrica);
            }
        }

        private void btnSeleccionarFabrica_Click_1(object sender, EventArgs e)
        {
            if (fabricaAbierto != null)
                fabricaAbierto.Close();
            Sucursal SucursalSelec = (Sucursal)cmbSucursalFabrica.SelectedItem;
            frmCrud frmInsumo= new frmCrud(SucursalSelec, tipoPanel);
            fabricaAbierto= HelpForm.abrirFormHijo(panelCentral,frmInsumo);

        }

        // Tienda
        private void btnAgregarTienda_Click(object sender, EventArgs e)
        {
            frmAltaSucursal altaTienda = new frmAltaSucursal(tienda);
            altaTienda.ShowDialog();
            cargarComboBox(tienda);
        }

        private void btnModificarTienda_Click(object sender, EventArgs e)
        {
            actual = (Sucursal)cmbSucursalTienda.SelectedItem;

            frmAltaSucursal altaTienda = new frmAltaSucursal(actual);
            altaTienda.ShowDialog();
            cargarComboBox(tienda);
        }

        private void btnEliminarTienda_Click(object sender, EventArgs e)
        {
            actual = (Sucursal)cmbSucursalTienda.SelectedItem;

            DialogResult resultado = MessageBox.Show($"¿Desea eliminar sucursal {actual.Descripcion}?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                negocio.eliminar(actual.Id);
                MessageBox.Show($"Sucursal {actual.Descripcion} elminada");
                cargarComboBox(tienda);
            }
            
        }

        private void btnSeleccionarTienda_Click(object sender, EventArgs e)
        {
            if (tiendaAbierto != null)
                tiendaAbierto.Close();

            actual = (Sucursal)cmbSucursalTienda.SelectedItem;
            frmCrud crudTienda = new frmCrud(actual, tipoPanel);
            tiendaAbierto=HelpForm.abrirFormHijo(panelCentral, crudTienda);
        }

        // Otros
        private void btnAgregarOtros_Click(object sender, EventArgs e)
        {
            frmAltaSucursal altaOtros = new frmAltaSucursal(otros);
            altaOtros.ShowDialog();
            cargarComboBox(otros);
        }

        private void btnModificarOtros_Click(object sender, EventArgs e)
        {
            actual = (Sucursal)cmbSucursalOtros.SelectedItem;

            frmAltaSucursal altaOtros = new frmAltaSucursal(actual);
            altaOtros.ShowDialog();
            cargarComboBox(otros);
        }

        private void btnEliminarOtros_Click(object sender, EventArgs e)
        {
            actual = (Sucursal)cmbSucursalOtros.SelectedItem;

            DialogResult resultado = MessageBox.Show($"¿Desea eliminar sucursal {actual.Descripcion}?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                negocio.eliminar(actual.Id);
                MessageBox.Show($"Sucursal {actual.Descripcion} elminada");
                cargarComboBox(otros);
            }
        }

        private void btnSeleccionarOtros_Click(object sender, EventArgs e)
        {
            if (otrosAbierto != null)
                otrosAbierto.Close();

            actual = (Sucursal)cmbSucursalOtros.SelectedItem;
            frmCrud crudOtros = new frmCrud(actual, tipoPanel);
            tiendaAbierto = HelpForm.abrirFormHijo(panelCentral, crudOtros);
        }

        // Metodos
        private void mostrarElementosInsumos()
        {
            pbxInsumo.Visible = true;
            pbxArticulo.Visible = false;
            pbxFabrica.Visible = true;
            pbxTienda.Visible = false;
            pbxOtros.Visible = false;
            cmbSucursalOtros.Visible = false;
            cmbSucursalTienda.Visible = false;
            btnAgregarTienda.Visible = false;
            btnAgregarOtros.Visible = false;
            btnModificarTienda.Visible = false;
            btnModificarOtros.Visible = false;
            btnEliminarTienda.Visible = false;
            btnEliminarOtros.Visible = false;
            btnSeleccionarTienda.Visible = false;
            btnSeleccionarOtros.Visible = false;
        }
        private void mostrarElementosArticulos()
        {
            pbxArticulo.Visible = true;
            pbxInsumo.Visible = false;
        }
        private void cargarComboBox(int TipoSucursal)
        {
            if(TipoSucursal == tienda)
            {
                listaTienda = negocio.listar(tienda);
                cmbSucursalTienda.DataSource = listaTienda;
            }
            else if (TipoSucursal==fabrica)
            {
                listaFabricas = negocio.listar(fabrica);
                cmbSucursalFabrica.DataSource = listaFabricas;
            }
            else
            {
                listaOtros = negocio.listar(otros);
                cmbSucursalOtros.DataSource = listaOtros;
            }
        }

    }
}
