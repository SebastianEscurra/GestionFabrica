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
        

        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        private InsumoNegocio insumoNegocio = new InsumoNegocio();
        private TipoCalzadoNegocio tipoCalzadoNeg = new TipoCalzadoNegocio();
        private RelacionArticuloInsumoNegocio relacionNegocio = new RelacionArticuloInsumoNegocio();

        private List<TipoCalzado> listaTipoCalzado;
        private List<Insumo> listaInsumo;
        private List<Insumo> listaInsumoAgregados=new List<Insumo>();

        // Constructores
        public frmAltaArticulo()
        {
            InitializeComponent();
            listaTipoCalzado = tipoCalzadoNeg.listar();
            listaInsumo = insumoNegocio.listar();
            
        }
        public frmAltaArticulo(Articulo actual)
        {
            InitializeComponent();
            listaTipoCalzado = tipoCalzadoNeg.listar();
            listaInsumo = insumoNegocio.listar();
            this.articuloActual = actual;
            listaRelacionActual = relacionNegocio.listar(actual.Id);
        }

        // Eventos
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            cmbTipoCalzado.DataSource = listaTipoCalzado;
            //cmbSucursal.DataSource = listaSucursales;
            dgvInsumosNecesarios.DataSource = listaInsumo;

            /*if (sucursal != null) // se selecciono sucursal
            {
                lblSucursal.Text = sucursal.Descripcion;
                cmbSucursal.Visible = false;
            }
            else
            {
                lblSucursal.Text = "";
                cmbSucursal.Visible = true;
            }*/

            if (articuloActual!= null)
            {
                txtCantidad.Text = articuloActual.Cantidad.ToString();
                txtDescripcion.Text = articuloActual.Nombre;
                txtPrecioComercial.Text = articuloActual.PrecioComercial.ToString();
                txtPrecioFabricacion.Text = articuloActual.PrecioFabricacion.ToString();
                txtPrecioMayorista.Text = articuloActual.Preciomayorista.ToString();
                foreach (var itemRel in listaRelacionActual)
                {
                    foreach (var itemIns in listaInsumo)
                    {
                        if (itemIns.Id==itemRel.IdInsumo)
                        {
                            listaInsumoAgregados.Add(itemIns);
                        }
                    }
                } // cargamos la lista de insumos agregados
                foreach (var item in listaInsumoAgregados)
                {
                    cmbInsumosAgregados.Items.Add(item);
                } // cargamos cmbInsumosAgregados

                cmbTipoCalzado.DisplayMember= "Descripcion";
                cmbTipoCalzado.ValueMember = "Id";
                cmbTipoCalzado.SelectedValue = articuloActual.Modelo.Id;
                cmbSucursal.DisplayMember = "Descripcion";
                cmbSucursal.ValueMember = "Id";
                cmbSucursal.SelectedValue = articuloActual.Sucursal.Id;
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
            articuloActual.Cantidad = int.Parse(txtCantidad.Text);
            articuloActual.PrecioFabricacion = decimal.Parse(txtPrecioFabricacion.Text);
            articuloActual.PrecioComercial = decimal.Parse(txtPrecioComercial.Text);
            articuloActual.Preciomayorista = decimal.Parse(txtPrecioMayorista.Text);
            //articuloActual.Sucursal = sucursal;


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
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    limpiarControles();
                    
                }

            }
            else
            {
                try
                {
                    articuloNegocio.modificar(articuloActual);
                    MessageBox.Show("Articulo modificado");

                    auxListaRelacion= relacionNegocio.listar(articuloActual.Id);

                    bool iguales = true;
                    foreach (var item in auxListaRelacion)
                    {
                        foreach (var itemAct in listaRelacionActual)
                        {
                            if (item.Id!=itemAct.Id)
                            {
                                iguales = false;
                            }
                        }
                    } // Corroboramos si realizo alguna cambio en relacionArticuloinsumo

                    if (!iguales)
                    {
                        foreach (var item in auxListaRelacion)
                        {
                            relacionNegocio.eliminar(item.Id);
                        } // Borramos relaciones anteriores
                        foreach (var item in listaRelacionActual) // Agregamos nuevas relaaciones
                        {
                            relacionNegocio.agregar(item); ;
                        }
                    }

                    MessageBox.Show("Relacion modificada");

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

            RelacionArticuloInsumo aux = new RelacionArticuloInsumo(); //tomamos los datos del insumo y la cantidad 
            aux.IdInsumo = insumoSeleccionado.Id;
            aux.Insumo = insumoSeleccionado.Descripcion;
            aux.Cantidad = int.Parse(txtCantidadInsumo.Text);
            if (articuloActual != null) // cargamos aux a lista correspondiente
                listaRelacionActual.Add(aux);
            else
                auxListaRelacion.Add(aux); 

            calcularPrecios(insumoSeleccionado);
        }

        private void btnEliminarinsumo_Click(object sender, EventArgs e)
        {
            Insumo seleccionado = (Insumo)cmbInsumosAgregados.SelectedItem;

            Insumo eliminarArticulo = new Insumo();
            foreach (var item in listaInsumoAgregados) //buscamos el insumo a eliminar
            {
                if (item.Id == seleccionado.Id)
                {
                    eliminarArticulo = item;
                }
            }

            RelacionArticuloInsumo eliminarRelacion = new RelacionArticuloInsumo();
            if (articuloActual != null) 
            {
                foreach (var item in listaRelacionActual)
                {
                    if (item.IdInsumo == eliminarArticulo.Id)
                        eliminarRelacion = item;
                }
            }
            else
            {
                foreach (var item in auxListaRelacion)
                {
                    if (item.IdInsumo == eliminarArticulo.Id)
                        eliminarRelacion = item;
                }
            } // buscamos la relacion a eliminar

            listaInsumoAgregados.Remove(eliminarArticulo);
            cmbInsumosAgregados.Items.Remove(eliminarArticulo);

            if (articuloActual != null)
                listaRelacionActual.Remove(eliminarRelacion);
            else
                auxListaRelacion.Remove(eliminarRelacion);

            calcularPrecios(seleccionado);
        }

        private void cmbInsumosAgregados_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (articuloActual!=null)
            {
                Insumo seleccionado =(Insumo) cmbInsumosAgregados.SelectedItem;
                foreach (var item in listaRelacionActual)
                {
                    if (item.IdInsumo==seleccionado.Id)
                    {
                        txtCantidadInsumo.Text = item.Cantidad.ToString(); 
                    }
                }
            }
        }

        // Metodos
        private void calcularPrecios(Insumo seleccionado)
        {
            decimal precioFabricacion = 0;

            if (articuloActual==null)
            {
                foreach (var relacion in auxListaRelacion)
                {
                    foreach (var insumo in listaInsumo)
                    {
                        if (relacion.IdInsumo == insumo.Id)
                        {
                            precioFabricacion += (insumo.Precio * relacion.Cantidad);
                        }
                    }
                }
            }
            else
            {
                foreach (var relacion in listaRelacionActual)
                {
                    foreach (var insumo in listaInsumo)
                    {
                        if (relacion.IdInsumo==insumo.Id)
                        {
                            precioFabricacion += (insumo.Precio * relacion.Cantidad);
                        }
                    }
                }
            }


            decimal precioMayorista = ((precioFabricacion / 100) * porcentajeMayorista) + precioFabricacion;
            decimal precioComercial = ((precioFabricacion / 100) * porcentajeComercial) + precioFabricacion;


            txtPrecioFabricacion.Text = precioFabricacion.ToString("00");
            txtPrecioComercial.Text = precioComercial.ToString("00");
            txtPrecioMayorista.Text = precioMayorista.ToString("00");
        }
        private void limpiarControles()
        {
            articuloActual = null;
            listaRelacionActual = null;
            auxListaRelacion = new List<RelacionArticuloInsumo>();
            listaInsumoAgregados = new List<Insumo>();
            cmbInsumosAgregados.Items.Clear();
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtCantidadInsumo.Text = "";
            txtPrecioFabricacion.Text = "";
            txtPrecioMayorista.Text = "";
            txtPrecioComercial.Text = "";
        }

    }
}
