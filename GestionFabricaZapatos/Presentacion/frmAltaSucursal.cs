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
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmAltaSucursal : Form
    {
        private SucursalNegocio sucursalNegocio = new SucursalNegocio();
        private Sucursal actual = new Sucursal();
        public frmAltaSucursal()
        {
            InitializeComponent();
        }

        private void frmAltaSucursal_Load(object sender, EventArgs e)
        {
            string imagenFabrica = "C:\\GIPCE-App\\14 boton fabrica.png";
            HelpPicture.cargarImagen(pbxTipoDeSucursal,imagenFabrica);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                actual.Descripcion = txtDescripcion.Text;
                actual.Ubicacion = txtUbicacion.Text;
                sucursalNegocio.agregar(actual);
                MessageBox.Show("Nueva sucursal agregada.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
