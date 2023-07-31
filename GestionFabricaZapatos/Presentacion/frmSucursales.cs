﻿using System;
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
            HelpForm.abrirFormHijo(panelCentral, new FrmArticulos());
        }
    }
}
