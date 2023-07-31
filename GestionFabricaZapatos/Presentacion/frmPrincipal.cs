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
            
            HelpForm.abrirFormHijo(panelCentral, new frmSucursales(panelCentral));
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
