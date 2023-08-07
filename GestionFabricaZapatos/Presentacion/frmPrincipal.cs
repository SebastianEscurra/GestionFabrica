using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        private Form abierto = null;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnNormalizar.Visible = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNormalizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormalizar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            if (abierto != null)
                HelpForm.abrirFormHijo(panelCentral, abierto);

            frmSucursales frmSucursales = new frmSucursales(panelCentral, "insumos");
            abierto = HelpForm.abrirFormHijo(panelCentral, frmSucursales);
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            if (abierto != null)
                abierto.Close();
           
            frmSucursales frmSucursales = new frmSucursales(panelCentral, "articulos");
            abierto = HelpForm.abrirFormHijo(panelCentral, frmSucursales);
        }
    }
}
