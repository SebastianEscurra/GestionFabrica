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
        private Sucursal actual = null;
        public frmAltaSucursal()
        {
            InitializeComponent();
        }
        public frmAltaSucursal(Sucursal actual)
        {
            InitializeComponent();
            this.actual = actual;
        }

        private void frmAltaSucursal_Load(object sender, EventArgs e)
        {
            string imagenFabrica = "C:\\GIPCE-App\\14 boton fabrica.png";
            HelpPicture.cargarImagen(pbxTipoDeSucursal,imagenFabrica);
            if (actual != null)
            {
                txtDescripcion.Text = actual.Descripcion;
                txtUbicacion.Text = actual.Ubicacion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTnAceptar_Click(object sender, EventArgs e)
        {
            if (actual == null)
                actual = new Sucursal();
            
            actual.Descripcion = txtDescripcion.Text;
            actual.Ubicacion = txtUbicacion.Text;

            try
            {

                if (actual.Id == 0)
                {
                    sucursalNegocio.agregar(actual);
                    MessageBox.Show("Nueva sucursal agregada.");
                }
                else
                {
                    sucursalNegocio.modificar(actual);
                    MessageBox.Show("Sucursal modoficada.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
