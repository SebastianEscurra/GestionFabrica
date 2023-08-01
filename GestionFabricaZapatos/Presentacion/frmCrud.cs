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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaInsumo agregar = new frmAltaInsumo(sucursal);
            agregar.ShowDialog();
            HelpGrid.mostrarGrid(dgvInventario, insumoNegocio.listar(sucursal));

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

            dgvInventario.DataSource = listaFiltrada;
        }
    }
}
