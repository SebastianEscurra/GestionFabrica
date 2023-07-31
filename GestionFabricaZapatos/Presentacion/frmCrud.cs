using Dominio;
using Helper;
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
    public partial class frmCrud : Form
    {
        private Sucursal sucursal;
        private List<Insumo> listaInsumo;
        private InsumoNegocio insumoNeg=new InsumoNegocio();
        public frmCrud(Sucursal sucursalSelec)
        {
            InitializeComponent();
            sucursal = sucursalSelec;
        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            listaInsumo= insumoNeg.listar(sucursal);

            HelpGrid.mostrarGrid(dgvInventario, listaInsumo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaInsumo altaInsumo = new frmAltaInsumo(sucursal);
            altaInsumo.ShowDialog();
            HelpGrid.mostrarGrid(dgvInventario, insumoNeg.listar(sucursal));

        }
    }
}
