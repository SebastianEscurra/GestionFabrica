using Dominio;
using Helper;
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

            if (articuloActual==null) // Agregamos o modificamos?
                HelpGrid.mostrarGrid(dgvInsumosNecesarios,listaInsumo);
            else
            {
                foreach (var insumo in listaInsumo) // actualizar las cantidades de insumos para armado desde db.
                {
                    foreach (var relacion in listaRelacionActual)
                    {
                        if (relacion.IdInsumo==insumo.Id)
                            insumo.CantidadInsumosParaArmado = relacion.Cantidad;
                    }
                }
                HelpGrid.mostrarGrid(dgvInsumosNecesarios, listaInsumo);

            }

            if (articuloActual!= null)
            {
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
                

                cmbTipoCalzado.DisplayMember= "Descripcion";
                cmbTipoCalzado.ValueMember = "Id";
                cmbTipoCalzado.SelectedValue = articuloActual.Modelo.Id;
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
            articuloActual.PrecioFabricacion = decimal.Parse(txtPrecioFabricacion.Text);
            articuloActual.PrecioComercial = decimal.Parse(txtPrecioComercial.Text);
            articuloActual.Preciomayorista = decimal.Parse(txtPrecioMayorista.Text);

            if (articuloActual.Id == 0) //estamos agregando
            {
                try
                {
                    articuloNegocio.agregar(articuloActual); //agregado pero solo con nombre y modelo
                    MessageBox.Show("articulo agregado"); 

                    articuloActual.Id = articuloNegocio.obtenerId(articuloActual.Nombre); //obtenemos id del articulo
                    
                    foreach (var item in auxListaRelacion) // uno a uno cargamos las relaciones a la DB
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
                    } // Corroboramos si realizo algun cambio en relacionArticuloinsumo

                    if (!iguales)
                    {
                        foreach (var item in auxListaRelacion)
                        {
                            relacionNegocio.eliminar(item.Id);
                        } // Borramos relaciones anteriores
                        foreach (var item in listaRelacionActual) // Agregamos nuevas relaciones
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

        private void btnCalcularPrecios_Click(object sender, EventArgs e)
        {
            List<Insumo> auxInsumos = new List<Insumo>();
            auxInsumos=(List<Insumo>)dgvInsumosNecesarios.DataSource;

            foreach (DataGridViewRow row in dgvInsumosNecesarios.Rows)
            {
                if (row.Cells[3].Value.ToString()!="0") // Agrega relacion solo si hay una cantidad != de cero
                {
                    RelacionArticuloInsumo aux = new RelacionArticuloInsumo();
                    aux.IdInsumo = int.Parse(row.Cells[0].Value.ToString());
                    aux.Insumo = row.Cells[1].Value.ToString();
                    aux.Cantidad = int.Parse(row.Cells[3].Value.ToString());
                    auxListaRelacion.Add(aux);
                }
            }

            calcularPrecios(auxInsumos);
        }

        private void dgvInsumosNecesarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dgvInsumosNecesarios.ReadOnly = false;
            }
            else
            {
                dgvInsumosNecesarios.ReadOnly = true;
            }
        }

        private void dgvInsumosNecesarios_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex ==3 && e.FormattedValue.ToString() == "")
            {
                dgvInsumosNecesarios.CancelEdit();
            }
        }

        // Metodos
        private void calcularPrecios(List<Insumo> listaInsumos)
        {
            decimal precioFabricacion = 0;

            foreach (var item in listaInsumo)
            {
                precioFabricacion += item.Precio * item.CantidadInsumosParaArmado;
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
            txtDescripcion.Text = "";
            txtPrecioFabricacion.Text = "";
            txtPrecioMayorista.Text = "";
            txtPrecioComercial.Text = "";
        }

    }
}
