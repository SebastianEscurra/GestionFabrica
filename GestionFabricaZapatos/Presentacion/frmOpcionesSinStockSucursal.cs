using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmOpcionesSinStockSucursal : Form
    {
        private int cantidadFaltante;
        
        
        private Sucursal sucursalActual;
        private RelacionArticuloInsumo relacionActual;




        private InsumoNegocio insumoNegocio = new InsumoNegocio();
        private RelacionSucursal_InsumoNegocio relSucInsumoNegocio = new RelacionSucursal_InsumoNegocio();
        public frmOpcionesSinStockSucursal(RelacionArticuloInsumo relacionActual,int cantidadFaltante,Sucursal sucursalActual)
        {
            InitializeComponent();
            this.cantidadFaltante = cantidadFaltante;
            this.sucursalActual = sucursalActual;
            this.relacionActual = relacionActual;
        }
        private void frmOpcionesSinStockSucursal_Load(object sender, EventArgs e)
        {
            foreach (var sucInsumo in relSucInsumoNegocio.listar())
            {
                if (sucInsumo.Insumo.Descripcion == relacionActual.Insumo && sucInsumo.Cantidad >= cantidadFaltante)
                {
                    cmbSucursales.Items.Add(sucInsumo.Sucursal);
                }
            } // carga solo las sucursales que tengan el insumo y ademas que el stock alcance para complementar al nuevo.

            if (cmbSucursales.Items.Count == 0)
            {
                rbtnBuscarOtraSucursal.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RelacionSucursal_Insumo auxRelInsumo = new RelacionSucursal_Insumo();

            if (rbtnStokSucursalActual.Checked == true)
            {
                auxRelInsumo.Sucursal = sucursalActual;
                auxRelInsumo.Insumo = new Insumo();
                auxRelInsumo.Insumo.Id = relacionActual.IdInsumo;
                auxRelInsumo.Cantidad= cantidadFaltante;

                relSucInsumoNegocio.agregar(auxRelInsumo); 

                foreach (var insumo in insumoNegocio.listar())
                {
                    if (insumo.Id==relacionActual.IdInsumo)
                    {
                        insumo.Stock -= cantidadFaltante;
                        insumoNegocio.modificar(insumo);
                        break;
                    }
                } 
            } // agregamos nueva relacion sucInsumo y descontamos stock general
            else if (rbtnStockGeneralySucursal.Checked == true)
            {
                auxRelInsumo.Sucursal = sucursalActual;
                auxRelInsumo.Insumo = new Insumo();
                auxRelInsumo.Insumo.Id = relacionActual.IdInsumo;
                auxRelInsumo.Cantidad = cantidadFaltante;

                relSucInsumoNegocio.agregar(auxRelInsumo);
            } // solo agregamos
            else
            {
                Sucursal sucSeleccionada = (Sucursal)cmbSucursales.SelectedItem;

                foreach (var sucInsumo in relSucInsumoNegocio.listar())
                {
                    if (relacionActual.IdInsumo == sucInsumo.Insumo.Id && sucInsumo.Sucursal.Id == sucSeleccionada.Id)
                    {
                        sucInsumo.Cantidad -= cantidadFaltante;
                        relSucInsumoNegocio.modificar(sucInsumo);

                        auxRelInsumo.Sucursal = sucursalActual;
                        auxRelInsumo.Insumo = new Insumo();
                        auxRelInsumo.Insumo.Id = relacionActual.IdInsumo;
                        auxRelInsumo.Cantidad = cantidadFaltante;

                        relSucInsumoNegocio.agregar(auxRelInsumo);
                        break;
                    }
                }

            } // agregamos y descontamos stock de otra sucursal
        }


        private void rbtnBuscarOtraSucursal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBuscarOtraSucursal.Checked == true)
            {
                cmbSucursales.Visible = true;
                lblElegirSucursal.Visible = true;
            }
            else
            {
                cmbSucursales.Visible = false;
                lblElegirSucursal.Visible = false;
            }
        }
    }
}
