using Dominio;
using Helper;
using Negocio;
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Text;

namespace Presentacion
{
    public partial class frmCrud : Form
    {
        private string tipoPanel;

        private Sucursal sucursal=null;

        private List<Insumo> listaInsumos;
        private List<Articulo> listaArticulos;
        private List<RelacionSucursalArticulo> listaRelacionArticulos;
        private List<RelacionSucursal_Insumo> listaRelacionInsumos;

        private InsumoNegocio insumoNegocio=new InsumoNegocio();
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        private RelacionSucursalArticuloNegocio relacionSucArticuloNegocio = new RelacionSucursalArticuloNegocio();
        private RelacionSucursal_InsumoNegocio relacionSucInsumoNegocio = new RelacionSucursal_InsumoNegocio();


        // Constructores
        public frmCrud(string tipoPanel)
        {
            InitializeComponent();
            this.tipoPanel = tipoPanel;

        }
        public frmCrud(Sucursal sucursalSelec,string tipoPanel)
        {
            InitializeComponent();
            sucursal = sucursalSelec;
            this.tipoPanel = tipoPanel;
        }

        // Eventos
        private void frmCrud_Load(object sender, EventArgs e)
        {
            if (tipoPanel == "insumos")
            {
                actualizarListaInsumo();
                HelpGrid.mostrarGrid(dgvInventario, listaInsumos);
            }
            else if (tipoPanel=="sucursalInsumos")
            {
                actualizarListaRelacionInsumos();
                HelpGrid.mostrarGrid(dgvInventario, listaRelacionInsumos);
            }
            else if(tipoPanel=="articulos")
            {
                actualizarListaArticulos();
                HelpGrid.mostrarGrid(dgvInventario, listaArticulos);
            }
            else
            {
                actualizarListaRelacionArticulos();
                HelpGrid.mostrarGrid(dgvInventario, listaRelacionArticulos);
            }


            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Precio");
            cmbCampo.Items.Add("Cantidad");
        }

        private void btnAgregar_Click(object sender, EventArgs e) 
        {
            if (tipoPanel == "insumos")
            {
                frmAltaInsumo altaInsumo = new frmAltaInsumo();
                altaInsumo.ShowDialog();
                actualizarListaInsumo();
                HelpGrid.mostrarGrid(dgvInventario, listaInsumos);
                
            }
            else if (tipoPanel== "articulos")
            {
                frmAltaArticulo altaArticulo = new frmAltaArticulo();
                altaArticulo.ShowDialog();
                actualizarListaArticulos();
                HelpGrid.mostrarGrid(dgvInventario, listaArticulos);

            }
            else if (tipoPanel == "sucursalArticulos")
            {
                frmAltaArticulosConSucursal altaArticuloSucursal = new frmAltaArticulosConSucursal(sucursal);
                altaArticuloSucursal.ShowDialog();
                actualizarListaRelacionArticulos();
                HelpGrid.mostrarGrid(dgvInventario, listaRelacionArticulos);

            }
            else
            {
                frmAltaInsumosConSucursal altaInsumoConSucursal = new frmAltaInsumosConSucursal(sucursal);
                altaInsumoConSucursal.ShowDialog();
                actualizarListaRelacionInsumos();
                HelpGrid.mostrarGrid(dgvInventario, listaRelacionInsumos);

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tipoPanel=="insumos")
            {
                Insumo seleccionado = (Insumo)dgvInventario.CurrentRow.DataBoundItem;
                frmAltaInsumo altaInsumo = new frmAltaInsumo(seleccionado);
                altaInsumo.ShowDialog();
                actualizarListaInsumo();
                HelpGrid.mostrarGrid(dgvInventario, listaInsumos);
            }
            else if (tipoPanel=="articulos")
            {
                Articulo seleccionado = (Articulo)dgvInventario.CurrentRow.DataBoundItem;
                frmAltaArticulo altaArticulo = new frmAltaArticulo(seleccionado);
                altaArticulo.ShowDialog();
                actualizarListaArticulos();
                HelpGrid.mostrarGrid(dgvInventario, listaArticulos);
            }
            else if(tipoPanel== "sucursalArticulos")
            {
                RelacionSucursalArticulo relacionActual=(RelacionSucursalArticulo) dgvInventario.CurrentRow.DataBoundItem;
                frmAltaArticulosConSucursal altaArticuloConSucursal = new frmAltaArticulosConSucursal(sucursal,relacionActual);
                altaArticuloConSucursal.ShowDialog();
                actualizarListaRelacionArticulos();
                HelpGrid.mostrarGrid(dgvInventario, listaRelacionArticulos);

            }
            else
            {
                RelacionSucursal_Insumo relacionActual = (RelacionSucursal_Insumo)dgvInventario.CurrentRow.DataBoundItem;
                frmAltaInsumosConSucursal altaInsumoConSucursal = new frmAltaInsumosConSucursal(relacionActual);
                altaInsumoConSucursal.ShowDialog();
                actualizarListaRelacionInsumos();
                HelpGrid.mostrarGrid(dgvInventario, listaRelacionInsumos);
            }
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (tipoPanel=="insumos")
            {
                Insumo seleccionado = (Insumo)dgvInventario.CurrentRow.DataBoundItem;
            
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el insumo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
                if(resultado==DialogResult.Yes)
                {
                    insumoNegocio.eliminar(seleccionado.Id);
                    MessageBox.Show("Eliminado Exitosamente");
                }
                actualizarListaInsumo();
                HelpGrid.mostrarGrid(dgvInventario, listaInsumos);
            }
            else if(tipoPanel=="articulos")
            {

                Articulo seleccionado = (Articulo)dgvInventario.CurrentRow.DataBoundItem;

                DialogResult resultado = MessageBox.Show("¿Desea eliminar el Articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultado == DialogResult.Yes)
                {
                    articuloNegocio.eliminarLogico(seleccionado.Id);
                    MessageBox.Show("Eliminado Exitosamente");
                }

                actualizarListaArticulos();
                HelpGrid.mostrarGrid(dgvInventario, listaArticulos);
            }
            else
            {
                //configurar
            }
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Insumo> listaFiltrada=new List<Insumo>();
            string filtro = txtFiltroRapido.Text.ToUpper();
            if (filtro.Length > 1)
            {
                listaFiltrada = listaInsumos.FindAll(x=> x.Cantidad.ToString().ToUpper().Contains(filtro) || x.Descripcion.ToUpper().Contains(filtro) || x.Precio.ToString().ToUpper().Contains(filtro)) ;
            }
            else
            {
                listaFiltrada = listaInsumos;
            }

            dgvInventario.DataSource = null;
            HelpGrid.mostrarGrid(dgvInventario, listaFiltrada);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            cmbCampo.Visible = true;
        }

        private void cmbCampo_MouseEnter(object sender, EventArgs e)
        {
            cmbCampo.DroppedDown = true;
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCriterio.Visible = true;
            if (cmbCampo.SelectedIndex==0)
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.DroppedDown=true;
                cmbCriterio.Items.Add("A-Z");
                cmbCriterio.Items.Add("Z-A");
            }
            else
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.DroppedDown=true;
                cmbCriterio.Items.Add("Menor a mayor");
                cmbCriterio.Items.Add("Mayor a menor"); 
            }
        }

        private void cmbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCriterio.Visible = false;
            cmbCampo.Visible = false;

            if (tipoPanel=="insumos")
            {
                List<Insumo> insumosOrdenados;

                if (cmbCampo.SelectedIndex == 0 && cmbCriterio.SelectedIndex==0) 
                    insumosOrdenados = listaInsumos.OrderBy(x => x.Descripcion).ToList();
                else if (cmbCampo.SelectedIndex == 0)
                    insumosOrdenados = listaInsumos.OrderByDescending(x => x.Descripcion).ToList();
                else if(cmbCampo.SelectedIndex==1 && cmbCriterio.SelectedIndex==0)
                    insumosOrdenados = listaInsumos.OrderBy(x => x.Precio).ToList();
                else if(cmbCampo.SelectedIndex==1)
                    insumosOrdenados = listaInsumos.OrderByDescending(x => x.Precio).ToList();
                else if(cmbCriterio.SelectedIndex==0)
                    insumosOrdenados = listaInsumos.OrderBy(x => x.Cantidad).ToList();
                else
                    insumosOrdenados = listaInsumos.OrderByDescending(x => x.Cantidad).ToList();

                HelpGrid.mostrarGrid(dgvInventario, insumosOrdenados);
            }
            else
            {
                List<Articulo> aticulosOrdenados;

                if (cmbCampo.SelectedIndex == 0 && cmbCriterio.SelectedIndex == 0)
                    aticulosOrdenados = listaArticulos.OrderBy(x => x.Nombre).ToList();
                else if (cmbCampo.SelectedIndex == 0)
                    aticulosOrdenados = listaArticulos.OrderByDescending(x => x.Nombre).ToList();
                else if (cmbCampo.SelectedIndex == 1 && cmbCriterio.SelectedIndex == 0)
                    aticulosOrdenados = listaArticulos.OrderBy(x => x.PrecioFabricacion).ToList();
                else 
                    aticulosOrdenados = listaArticulos.OrderByDescending(x => x.PrecioFabricacion).ToList();
                

                HelpGrid.mostrarGrid(dgvInventario, aticulosOrdenados);
            }
        }
        //
        //metodos
        //
        private void actualizarListaInsumo()
        {
            listaInsumos = insumoNegocio.listar();
        }
        private void actualizarListaRelacionInsumos()
        {
            listaRelacionInsumos = relacionSucInsumoNegocio.listar(sucursal);
        }
        private void actualizarListaArticulos()
        {
            listaArticulos = articuloNegocio.listar();
        }
        private void actualizarListaRelacionArticulos()
        {
            listaRelacionArticulos = relacionSucArticuloNegocio.listar(sucursal);
        }

    }
}
