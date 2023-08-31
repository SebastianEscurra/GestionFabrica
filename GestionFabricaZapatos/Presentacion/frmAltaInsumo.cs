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
        private Insumo actual = null;
        private InsumoNegocio insumoNegocio = new InsumoNegocio();
        

        // Constructores
        public frmAltaInsumo()
        {
            InitializeComponent();
        }
        public frmAltaInsumo(Insumo seleccionado)
        {
            InitializeComponent();
            actual = seleccionado;
        }


        // Eventos
        private void frmAltaInsumo_Load(object sender, EventArgs e)
        {
            
            if (actual != null)
            {
                txtCantidad.Text = actual.Cantidad.ToString();
                txtDescripcion.Text = actual.Descripcion;
                txtPrecio.Text = actual.Precio.ToString();
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTnAceptar_Click(object sender, EventArgs e)
        {
            if (actual == null)
                actual = new Insumo();

            
            actual.Cantidad = int.Parse(txtCantidad.Text);
            actual.Descripcion = txtDescripcion.Text;
            actual.Precio = decimal.Parse(txtPrecio.Text);
            actual.sucursal = new Sucursal();

            if (actual.Id>0)
            {
                insumoNegocio.modificar(actual);
                MessageBox.Show("Modificado Exitosamente");
            }
            else
            {
                insumoNegocio.agregar(actual);
                MessageBox.Show("Agregado Exitosamente");
            }
        }
    }
}
