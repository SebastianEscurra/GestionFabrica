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
    public partial class Form1 : Form
    {
        private ArticuloNegocio negocio = new ArticuloNegocio();
        private List<Articulo> articulos=new List<Articulo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            articulos = negocio.listar();
            dgvArticulos.DataSource = articulos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            nuevo.Nombre = "cod123123";
            nuevo.Insumo = new Insumo();
            nuevo.Insumo.id = 1;
            nuevo.Modelo = new Tipo();
            nuevo.Modelo.Id = 1;
            nuevo.Sucursal = new Sucursal();
            nuevo.Sucursal.Id = 1;
            negocio.agregar(nuevo);
            dgvArticulos.DataSource = negocio.listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo modificado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            modificado.Nombre = "abc";
            modificado.Cantidad = 12132132;
            modificado.PrecioFabricacion = 12313213;
            modificado.PrecioComercial = 123;
            
            negocio.modificar(modificado);
            dgvArticulos.DataSource = negocio.listar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            Articulo seleccionado =(Articulo) dgvArticulos.CurrentRow.DataBoundItem;
            negocio.eliminarLogico(seleccionado.Id);
            dgvArticulos.DataSource = negocio.listar();

        }
    }
}
