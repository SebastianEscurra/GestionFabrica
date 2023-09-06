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
        private RelacionSucursalArticuloNegocio relacionSucursalArtNegocio = new RelacionSucursalArticuloNegocio();

        private List<RelacionArticuloInsumo> listaRelacion;
        private List<Insumo> listaInsumoActual;

        // Constructores

        public frmAltaArticulosConSucursal(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
            lblSucursal.Text = sucursal.Descripcion;
            cmbArticulo.DataSource = articuloNegocio.listar();

            listaInsumoActual = new List<Insumo>();
            cargarInsumosDeSucursal();
        }

        // Eventos

        private void frmAltaArticulosConSucursal_Load(object sender, EventArgs e)
        {
            

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
            List<RelacionArticuloInsumo> listaRelacionActual = relacionNegocio.listarInsumos(actual);
            if (txtCantidad.Text != "")
            {
                foreach (var relacion in listaRelacionActual)
                {
                    relacion.Cantidad *= int.Parse(txtCantidad.Text);
                }
            }

            verificarStockDisponible(listaRelacionActual);

            HelpGrid.mostrarGrid(dgvInsumosNecesarios, listaRelacionActual);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //Metodos

        private void verificarStockDisponible(List<RelacionArticuloInsumo> listaRelacionActual)
        {
            foreach (var relacion in listaRelacionActual) 
            {
                foreach (var insumoActual in listaInsumoActual)
                {
                    if (relacion.IdInsumo == insumoActual.Id)
                    {
                        if (relacion.Cantidad <= insumoActual.Cantidad)
                        {
                            relacion.StocDisponible = true;
                            relacion.Observaciones = "";
                        }
                        else
                        {
                            relacion.StocDisponible = false;
                            relacion.Observaciones = "El stock disponible no alcanza";
                        }
                        break;
                    }
                    else
                    {
                        relacion.StocDisponible = false;
                        relacion.Observaciones = "Insumo no disponible en esta sucursal";
                    }
                 
                }


            }// corroboramos si hay stock para fabricar el articulo

        }
        private void cargarInsumosDeSucursal()
        {
            foreach (var item in insumoNegocio.listar())
            {
                if (item.sucursal.Id == sucursal.Id)
                {
                    listaInsumoActual.Add(item);
                }
            }
        }

        private void BTnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                RelacionSucursalArticulo nuevo = new RelacionSucursalArticulo();
                nuevo.Articulo = (Articulo)cmbArticulo.SelectedItem;
                nuevo.Cantidad = int.Parse(txtCantidad.Text);
                nuevo.Sucursal = sucursal;
                relacionSucursalArtNegocio.agregar(nuevo);
                MessageBox.Show("Articulo agregado asucursal");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
