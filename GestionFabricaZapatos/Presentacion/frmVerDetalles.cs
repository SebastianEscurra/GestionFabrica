using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmVerDetalles : Form
    {
        private string tipoPanel;

        private Insumo insumo;
        private Articulo articulo;
        public frmVerDetalles(Insumo seleccionado,string tipoPanel)
        {
            InitializeComponent();
            insumo = seleccionado;
            this.tipoPanel = tipoPanel;
        }
        public frmVerDetalles(Articulo seleccionado, string tipoPanel)
        {
            InitializeComponent();
            articulo = seleccionado;
            this.tipoPanel = tipoPanel;
        }

        private void frmVerDetalles_Load(object sender, EventArgs e)
        {
            if (tipoPanel=="insumos")
            {
                lblDescripcion.Text =insumo.Descripcion;
                lblCantidad.Text = "Cantidad: " + insumo.Cantidad.ToString() + " unidades.";
                lblPrecioBruto.Text = "$" + insumo.PrecioBruto.ToString();
                lblPrecioUnitario.Text ="Precio Unitario: $" +  insumo.PrecioUnidad.ToString();
                Helper.HelpPicture.cargarImagen(pbxImagenProducto, insumo.UrlImagen);
            }
            else if (tipoPanel=="articulos")
            {
                
            }
            else if (tipoPanel== "sucursalArticulos")
            {

            }
            else
            {

            }
        }
    }
}
