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
        private RelacionSucursalArticulo relacionActual=null;

        private ArticuloNegocio articuloNegocio= new ArticuloNegocio();
        private RelacionArticuloInsumoNegocio relacionNegocio = new RelacionArticuloInsumoNegocio();
        private InsumoNegocio insumoNegocio = new InsumoNegocio();
        private RelacionSucursalArticuloNegocio relacionSucursalArtNegocio = new RelacionSucursalArticuloNegocio();

        private List<RelacionArticuloInsumo> listaRelacion;
        private List<Insumo> listaInsumo;

        // Constructores

        public frmAltaArticulosConSucursal(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
            lblSucursal.Text = sucursal.Descripcion;
            cmbArticulo.DataSource = articuloNegocio.listar();

            listaInsumo = insumoNegocio.listar(); ;
            
        }
        public frmAltaArticulosConSucursal(Sucursal sucursal,RelacionSucursalArticulo relacionActual)
        {
            InitializeComponent();
            this.sucursal = sucursal;
            lblSucursal.Text = sucursal.Descripcion;
            cmbArticulo.DataSource = articuloNegocio.listar();
            this.relacionActual = relacionActual;
            listaInsumo = insumoNegocio.listar(); ;

        }

        // Eventos

        private void frmAltaArticulosConSucursal_Load(object sender, EventArgs e)
        {
            if (relacionActual!=null)
            {
                cmbArticulo.ValueMember = "Id";
                cmbArticulo.DisplayMember=  "Nombre";
                cmbArticulo.SelectedValue = relacionActual.Articulo.Id;
               
                txtCantidad.Text = relacionActual.Cantidad.ToString();

                List<RelacionArticuloInsumo> listaRelacionActual = relacionNegocio.listarInsumos(actual);

                calcularCantidadInsumos(listaRelacionActual);
                verificarStockDisponible(listaRelacionActual);

                HelpGrid.mostrarGrid(dgvInsumosNecesarios, listaRelacionActual);
            }

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
      
            calcularCantidadInsumos(listaRelacionActual);
            verificarStockDisponible(listaRelacionActual);

            HelpGrid.mostrarGrid(dgvInsumosNecesarios, listaRelacionActual);

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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


        //Metodos
        private void calcularCantidadInsumos(List<RelacionArticuloInsumo> listaRelacionActual)
        {
            
            if (txtCantidad.Text != "")
            {
                foreach (var relacion in listaRelacionActual)
                {
                    relacion.Cantidad *= int.Parse(txtCantidad.Text);
                }
            }
        }

        private void verificarStockDisponible(List<RelacionArticuloInsumo> listaRelacionActual)
        {
            foreach (var relacion in listaRelacionActual) 
            {
                foreach (var insumoActual in listaInsumo)
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
                }


            }// corroboramos si hay stock para fabricar el articulo

        }
  
    }
}
