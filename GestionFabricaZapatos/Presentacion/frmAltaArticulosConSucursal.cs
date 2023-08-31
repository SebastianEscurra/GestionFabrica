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
    public partial class frmAltaArticulosConSucursal : Form
    {
        // Atributos 

        private Sucursal sucursal;
        private Articulo actual;

        private ArticuloNegocio articuloNegocio= new ArticuloNegocio();
        private RelacionArticuloInsumoNegocio relacionNegocio = new RelacionArticuloInsumoNegocio();
        private InsumoNegocio insumoNegocio = new InsumoNegocio();

        private List<RelacionArticuloInsumo> listaRelacion;

        // Constructores

        public frmAltaArticulosConSucursal(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
        }

        // Eventos

        private void frmAltaArticulosConSucursal_Load(object sender, EventArgs e)
        {
            lblSucursal.Text = sucursal.Descripcion;
            cmbArticulo.DataSource = articuloNegocio.listar();
        }

        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actual = (Articulo)cmbArticulo.SelectedItem;
            listaRelacion = relacionNegocio.listarInsumos(actual);
            HelpGrid.mostrarGrid(dgvInsumosNecesarios, listaRelacion );
            txtCantidad.Text = "";
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            List<RelacionArticuloInsumo> aux = relacionNegocio.listarInsumos(actual);
            if (txtCantidad.Text != "")
            {
                foreach (var item in aux)
                {
                    item.Cantidad *= int.Parse(txtCantidad.Text);
                }
            }

            verificarStockDisponible(aux);

            HelpGrid.mostrarGrid(dgvInsumosNecesarios, aux);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //Metodos

        private void verificarStockDisponible(List<RelacionArticuloInsumo> aux)
        {
            foreach (var insumoGeneral in insumoNegocio.listar())
            {
                foreach (var relacion in aux)
                {
                    if (relacion.IdInsumo == insumoGeneral.Id)
                    {
                        if (relacion.Cantidad <= insumoGeneral.Cantidad)
                            relacion.StocDisponible = true;
                        else
                            relacion.StocDisponible = false;
                    }
                }
            }// corroboramos si hay stock para fabricar el articulo

        }

    }
}
