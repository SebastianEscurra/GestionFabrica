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
    }
}
