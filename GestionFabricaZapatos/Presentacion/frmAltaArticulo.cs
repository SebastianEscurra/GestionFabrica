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
    public partial class frmAltaArticulo : Form
    {
        // Atributos

        private int  porcentajeComercial = 100;
        private int  porcentajeMayorista = 50;

        private Articulo articuloActual = null;
        private List<RelacionArticuloInsumo> listaRelacionActual = null;
        private List<RelacionArticuloInsumo> auxListaRelacion = new List<RelacionArticuloInsumo>();
        private Sucursal sucursal = null;

        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        private InsumoNegocio insumoNegocio = new InsumoNegocio();
        private SucursalNegocio sucursalNegocio = new SucursalNegocio();
        private TipoCalzadoNegocio tipoCalzadoNeg = new TipoCalzadoNegocio();
        private RelacionArticuloInsumoNegocio relacionNegocio = new RelacionArticuloInsumoNegocio();

        private List<TipoCalzado> listaTipoCalzado;
        private List<Sucursal> listaSucursales;
        private List<Insumo> listaInsumo;
        private List<Insumo> listaInsumoAgregados=new List<Insumo>();

        // Constructores
        public frmAltaArticulo(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
            listaTipoCalzado = tipoCalzadoNeg.listar();
            listaSucursales = sucursalNegocio.listar(sucursal.IdTipo);
            listaInsumo = insumoNegocio.listar(sucursal);
        }

        // Eventos
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {

            if (sucursal != null) // se selecciono sucursal
            {
                cmbSucursal.Visible = false;
                cmbTipoCalzado.DataSource = listaTipoCalzado;
                cmbSucursal.DataSource = listaSucursales;
                dgvInsumosNecesarios.DataSource = listaInsumo;
                cmbSucursal.DisplayMember = "Descripcion";
                cmbSucursal.ValueMember = "Id";
                cmbSucursal.SelectedValue = sucursal;
            }
        }
        private void BTnAceptar_Click(object sender, EventArgs e)
        {
            if (articuloActual == null) // estamos agregando nuevo
            {
                articuloActual = new Articulo();
                listaRelacionActual = new List<RelacionArticuloInsumo>();
            }

            articuloActual.Nombre = txtDescripcion.Text;
            articuloActual.Modelo = (TipoCalzado)cmbTipoCalzado.SelectedItem;
            articuloActual.Sucursal = sucursal;
            

            if (articuloActual.Id == 0) //estamos agregando
            {
                try
                {
                    articuloNegocio.agregar(articuloActual); //agregado pero solo con nombre y modelo
                    MessageBox.Show("articulo agregado"); 

                    articuloActual.Id = articuloNegocio.obtenerId(articuloActual.Nombre); //obtenemos id del articulo
                    articuloActual.Cantidad = int.Parse(txtCantidad.Text);
                    articuloActual.PrecioFabricacion = decimal.Parse(txtPrecioFabricacion.Text);
                    articuloActual.PrecioComercial = decimal.Parse(txtPrecioComercial.Text);
                    articuloActual.Preciomayorista = decimal.Parse(txtPrecioMayorista.Text);
                    //articuloActual.Sucursal = (Sucursal)cmbSucursal.SelectedItem;

                    articuloNegocio.modificar(articuloActual); // actualizamos los datos del articulo con los campos faltantes
                    MessageBox.Show("actualizacion Realizada");

                    foreach (var item in auxListaRelacion) // agregamos idarticulo a los items y luego lo agregamos a la listaRelacionActual
                    {
                        item.IdArticulo = articuloActual.Id;
                        item.Articulo = articuloActual.Nombre;
                        listaRelacionActual.Add(item);
                    }
                    foreach (var item in listaRelacionActual) // uno a uno cargamos las relaciones a la DB
                    {
                        relacionNegocio.agregar(item);
                    }
                    MessageBox.Show("Relacion ArticuloInsumo Agregada");
                    MessageBox.Show("");


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }

        }
        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            Insumo insumoSeleccionado = (Insumo)dgvInsumosNecesarios.CurrentRow.DataBoundItem; 
            listaInsumoAgregados.Add(insumoSeleccionado);
            cmbInsumosAgregados.Items.Add(insumoSeleccionado);
            
            RelacionArticuloInsumo aux = new RelacionArticuloInsumo(); //tomamos los datos del insumo y la cantidad, y agregamos la nueva relacion a la lista aux
            aux.IdInsumo = insumoSeleccionado.Id;
            aux.Insumo = insumoSeleccionado.Descripcion;
            aux.Cantidad = int.Parse(txtCantidad.Text);
            auxListaRelacion.Add(aux);

            calcularPrecios();
        }

        private void btnEliminarinsumo_Click(object sender, EventArgs e)
        {
            Insumo seleccionado = (Insumo)cmbInsumosAgregados.SelectedItem;

            Insumo eliminarArticulo = new Insumo();
            foreach (var item in listaInsumoAgregados)
            {
                if (item.Id == seleccionado.Id)
                {
                    eliminarArticulo = item;
                }
            }
            

            RelacionArticuloInsumo eliminarRelacion = new RelacionArticuloInsumo();
            foreach (var item in auxListaRelacion)
            {
                if (item.IdInsumo == eliminarArticulo.Id)
                    eliminarRelacion = item;
            }

            listaInsumoAgregados.Remove(eliminarArticulo);
            cmbInsumosAgregados.Items.Remove(eliminarArticulo);
            auxListaRelacion.Remove(eliminarRelacion);

            calcularPrecios();
        }

        // Metodos
        private void calcularPrecios()
        {
            decimal precioFabricacion = 0;
            foreach (var item in listaInsumoAgregados)
            {
                precioFabricacion += item.Precio * decimal.Parse(txtCantidadInsumo.Text);
            }


            decimal precioMayorista = ((precioFabricacion / 100) * porcentajeMayorista) + precioFabricacion;
            decimal precioComercial = ((precioFabricacion / 100) * porcentajeComercial) + precioFabricacion;


            txtPrecioFabricacion.Text = precioFabricacion.ToString("00");
            txtPrecioComercial.Text = precioComercial.ToString("00");
            txtPrecioMayorista.Text = precioMayorista.ToString("00");
        }
    }
}
