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

namespace Presentacion
{
    public partial class frmCrud : Form
    {
        private Sucursal sucursal;
        private List<Insumo> listaInsumo;
        private InsumoNegocio insumoNegocio=new InsumoNegocio();
        public frmCrud(Sucursal sucursalSelec)
        {
            InitializeComponent();
            sucursal = sucursalSelec;
        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            listaInsumo= insumoNegocio.listar(sucursal);

            HelpGrid.mostrarGrid(dgvInventario, listaInsumo);

            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Precio");
            cmbCampo.Items.Add("Cantidad");
            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaInsumo agregar = new frmAltaInsumo(sucursal);
            agregar.ShowDialog();
            listaInsumo = insumoNegocio.listar(sucursal);
            HelpGrid.mostrarGrid(dgvInventario, listaInsumo);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Insumo seleccionado = (Insumo)dgvInventario.CurrentRow.DataBoundItem;
            frmAltaInsumo modificar = new frmAltaInsumo(sucursal,seleccionado);
            modificar.ShowDialog();
            listaInsumo = insumoNegocio.listar(sucursal);
            HelpGrid.mostrarGrid(dgvInventario, listaInsumo);
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            Insumo seleccionado = (Insumo)dgvInventario.CurrentRow.DataBoundItem;
            
            DialogResult resultado = MessageBox.Show("¿Desea eliminar el insumo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
            if(resultado==DialogResult.Yes)
            {
                insumoNegocio.eliminar(seleccionado.Id);
                MessageBox.Show("Eliminado Exitosamente");
            }
            listaInsumo = insumoNegocio.listar(sucursal);
            HelpGrid.mostrarGrid(dgvInventario, listaInsumo);

        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Insumo> listaFiltrada=new List<Insumo>();
            string filtro = txtFiltroRapido.Text.ToUpper();
            if (filtro.Length > 1)
            {
                listaFiltrada = listaInsumo.FindAll(x=> x.Cantidad.ToString().ToUpper().Contains(filtro) || x.Descripcion.ToUpper().Contains(filtro) || x.Precio.ToString().ToUpper().Contains(filtro)) ;
            }
            else
            {
                listaFiltrada = listaInsumo;
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
            List<Insumo> insumosordenados;

            if (cmbCampo.SelectedIndex == 0 && cmbCriterio.SelectedIndex==0)
                insumosordenados = listaInsumo.OrderBy(x => x.Descripcion).ToList();
            else if (cmbCampo.SelectedIndex == 0)
                insumosordenados = listaInsumo.OrderByDescending(x => x.Descripcion).ToList();
            else if(cmbCampo.SelectedIndex==1 && cmbCriterio.SelectedIndex==0)
                insumosordenados = listaInsumo.OrderBy(x => x.Precio).ToList();
            else if(cmbCampo.SelectedIndex==1)
                insumosordenados = listaInsumo.OrderByDescending(x => x.Precio).ToList();
            else if(cmbCriterio.SelectedIndex==0)
                insumosordenados = listaInsumo.OrderBy(x => x.Cantidad).ToList();
            else
                insumosordenados = listaInsumo.OrderByDescending(x => x.Cantidad).ToList();

            HelpGrid.mostrarGrid(dgvInventario, insumosordenados);

        }
    }
}
