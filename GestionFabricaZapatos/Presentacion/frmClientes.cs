using Dominio;
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
    public partial class frmClientes : Form
    {
        private List<Cliente> listaClientes;
        private ClienteNegocio negocio=new ClienteNegocio();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            listaClientes = negocio.listar();
            dgvClientes.DataSource = listaClientes;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente();
            nuevo.Nombre = "asd";
            nuevo.ContactoEmail = "12321";
            nuevo.ContactoTelefono = 1132132;
            nuevo.Ubicacion = "sdfs";

            negocio.agregar(nuevo);
            dgvClientes.DataSource = negocio.listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente actual =(Cliente) dgvClientes.CurrentRow.DataBoundItem;
            actual.Nombre = "aaa";
            actual.ContactoEmail = "aaa";

            negocio.modificar(actual);
            dgvClientes.DataSource = negocio.listar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            Cliente actual = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            negocio.eliminarLogico(actual.Id);
            dgvClientes.DataSource = negocio.listar();
        }
    }
}
