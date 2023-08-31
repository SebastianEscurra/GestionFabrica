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
        private int tienda=1;
        private int fabrica=2;
        private int otros=3;
        private Panel panelCentral;
        private Sucursal actual;

        private SucursalNegocio negocio = new SucursalNegocio();
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();

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
                btnAgregarGenerico.Visible = false;
                btnModificarGenerico.Visible = false;
                btnEliminarGenerico.Visible = false;
            }
            else
            {
                mostrarElementosArticulos();
                cargarComboBox(tienda);
                cargarComboBox(fabrica);
                cargarComboBox(otros);
                btnAgregarGenerico.Visible = true;
                btnModificarGenerico.Visible = true;
                btnEliminarGenerico.Visible = true;

            }
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
            if (tipoPanel!="insumos")
            {
                tipoPanel = "sucursalArticulos";
            }
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
            tipoPanel = "sucursalArticulos";
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
            tipoPanel = "sucursalArticulos";

            if (otrosAbierto != null)
                otrosAbierto.Close();

            actual = (Sucursal)cmbSucursalOtros.SelectedItem;
            frmCrud crudOtros = new frmCrud(actual, tipoPanel);
            tiendaAbierto = HelpForm.abrirFormHijo(panelCentral, crudOtros);
        }

        // Genericos

        private void btnAgregarGenerico_Click(object sender, EventArgs e)
        {
            if (tipoPanel=="insumos")
            {

            }
            else
            {
                frmAltaArticulo altaArticulo = new frmAltaArticulo();
                altaArticulo.ShowDialog();
            }
        }

        private void btnModificarGenerico_Click(object sender, EventArgs e)
        {
            if (tipoPanel == "insumos")
            {
                
            }
            else
            {
                cmbEliminarItem.Visible = false;
                cmbSeleccionarItem.DataSource = articuloNegocio.listar();
                cmbSeleccionarItem.Visible = true;
            }
        }

        private void cmbSeleccionarItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeleccionarItem.Visible)
            {
                Articulo seleccionado = (Articulo)cmbSeleccionarItem.SelectedItem;
                frmAltaArticulo altaArticulo = new frmAltaArticulo(seleccionado);
                altaArticulo.ShowDialog();
                cmbSeleccionarItem.Visible = false;
                cmbSeleccionarItem.DataSource = articuloNegocio.listar();
            }
        }

        private void btnEliminarGenerico_Click(object sender, EventArgs e)
        {
            if (tipoPanel == "insumos")
            {

            }
            else
            {
                cmbSeleccionarItem.Visible = false;
                cmbEliminarItem.DataSource = articuloNegocio.listar();
                cmbEliminarItem.Visible = true;
            }
        }

        private void cmbEliminarItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEliminarItem.Visible)
            {
                if (tipoPanel == "insumos")
                {
                    /*Insumo seleccionado = (Insumo)dgvInventario.CurrentRow.DataBoundItem;

                    DialogResult resultado = MessageBox.Show("¿Desea eliminar el insumo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.Yes)
                    {
                        insumoNegocio.eliminar(seleccionado.Id);
                        MessageBox.Show("Eliminado Exitosamente");
                    }
                    actualizarListaInsumo();
                    HelpGrid.mostrarGrid(dgvInventario, listaInsumos);*/
                }
                else
                {

                    Articulo seleccionado = (Articulo)cmbEliminarItem.SelectedItem;

                    DialogResult resultado = MessageBox.Show("¿Desea eliminar el Articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.Yes)
                    {
                        articuloNegocio.eliminarLogico(seleccionado.Id);
                        MessageBox.Show("Eliminado Exitosamente");
                        cmbEliminarItem.Visible = false;
                        cmbEliminarItem.DataSource = articuloNegocio.listar();
                    }
                }
            }
        }

        //Gestion de articulos

        private void pbxArticulo_MouseEnter(object sender, EventArgs e)
        {

            HelpPicture.cargarImagen(pbxArticulo, "C:\\GIPCE-App\\Engranaje.png");
        }

        private void pbxArticulo_MouseLeave(object sender, EventArgs e)
        {
            HelpPicture.cargarImagen(pbxArticulo, "C:\\GIPCE-App\\13Articulos.png");

        }

        private void pbxArticulo_MouseDown(object sender, MouseEventArgs e)
        {
            HelpPicture.cargarImagen(pbxArticulo, "C:\\GIPCE-App\\engranaje 2.png");
            tipoPanel = "articulos";
            if (fabricaAbierto != null) // Si es = null hay un panel abierto, entonces lo cierra evitando que se generen muchas instancias del mismo frm.
                fabricaAbierto.Close();
            frmCrud crudArticulos = new frmCrud(tipoPanel);
            fabricaAbierto = HelpForm.abrirFormHijo(panelCentral, crudArticulos);
        }

        private void pbxArticulo_MouseUp(object sender, MouseEventArgs e)
        {
            HelpPicture.cargarImagen(pbxArticulo, "C:\\GIPCE-App\\Engranaje.png");
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
