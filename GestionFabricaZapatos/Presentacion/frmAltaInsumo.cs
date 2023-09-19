using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class frmAltaInsumo : Form
    {
        //Atributos
        private Insumo insumoActual = null;
        private InsumoNegocio insumoNegocio = new InsumoNegocio();
        

        // Constructores
        public frmAltaInsumo()
        {
            InitializeComponent();
        }
        public frmAltaInsumo(Insumo seleccionado)
        {
            InitializeComponent();
            insumoActual = seleccionado;
        }


        // Eventos
        private void frmAltaInsumo_Load(object sender, EventArgs e)
        {
            
            if (insumoActual != null)
            {
                lblStock.Visible = true;
                txtStock.Visible = true;
                txtStock.Text = insumoActual.Stock.ToString();
                txtCantidad.Text = insumoActual.Cantidad.ToString();
                txtDescripcion.Text = insumoActual.Descripcion;
                txtPrecioBruto.Text = insumoActual.PrecioBruto.ToString();
                txtUrlImagen.Text = insumoActual.UrlImagen;
                Helper.HelpPicture.cargarImagen(pbxImagenProducto,insumoActual.UrlImagen);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTnAceptar_Click(object sender, EventArgs e)
        {
            if (insumoActual == null)
                insumoActual = new Insumo();

            
            insumoActual.Cantidad = int.Parse(txtCantidad.Text);
            insumoActual.Descripcion = txtDescripcion.Text;
            insumoActual.PrecioBruto = decimal.Parse(txtPrecioBruto.Text);
            insumoActual.PrecioUnidad = decimal.Parse(txtPrecioUnidad.Text);
            insumoActual.UrlImagen = txtUrlImagen.Text;
            insumoActual.Stock = int.Parse(txtStock.Text);
            

            if (insumoActual.Id>0)
            {
                insumoNegocio.modificar(insumoActual);
                MessageBox.Show("Modificado Exitosamente");
            }
            else
            {
                insumoNegocio.agregar(insumoActual);
                MessageBox.Show("Agregado Exitosamente");
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioBruto.Text != "" && txtCantidad.Text != "")
            {
                txtPrecioUnidad.Text = (double.Parse(txtPrecioBruto.Text) / double.Parse(txtCantidad.Text)).ToString(); 
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioBruto.Text != "" && txtCantidad.Text != "")
            {
                txtPrecioUnidad.Text = (double.Parse(txtPrecioBruto.Text) / double.Parse(txtCantidad.Text)).ToString();
            }
            if (txtCantidad.Text != "" && insumoActual==null)
            {
                txtStock.Text= txtCantidad.Text;
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            string url = txtUrlImagen.Text;
            Helper.HelpPicture.cargarImagen(pbxImagenProducto, url);
        }
    }
}
