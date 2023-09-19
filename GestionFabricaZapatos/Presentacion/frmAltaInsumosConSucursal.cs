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
    public partial class frmAltaInsumosConSucursal : Form
    {
        private int tipoSucursal = 2;
        private Sucursal sucursalActual;
        private double cantidad;

        private RelacionSucursal_Insumo relacionSucInsumoActual = null;

        private InsumoNegocio insumoNegocio=new InsumoNegocio();
        private SucursalNegocio sucursalNegocio = new SucursalNegocio();
        private RelacionSucursal_InsumoNegocio relacionSucInsumoNegocio = new RelacionSucursal_InsumoNegocio();

        public frmAltaInsumosConSucursal(Sucursal sucursalActual)
        {
            InitializeComponent();
            this.sucursalActual = sucursalActual;
        }
        public frmAltaInsumosConSucursal(RelacionSucursal_Insumo relacionSucursalActual)
        {
            InitializeComponent();
            this.relacionSucInsumoActual = relacionSucursalActual;
            sucursalActual = relacionSucursalActual.Sucursal;
        }

        private void frmAltaInsumosConSucursal_Load(object sender, EventArgs e)
        {
            cmbInsumo.DataSource = insumoNegocio.listar();
            cmbSucursal.DataSource = sucursalNegocio.listar(tipoSucursal);

            if (relacionSucInsumoActual!=null)
            {
                cmbSucursal.Visible = true;
                lblSucursal.Visible = true;

                cmbInsumo.ValueMember = "Id";
                cmbInsumo.DisplayMember = "Descripcion";
                cmbInsumo.SelectedValue = relacionSucInsumoActual.Insumo.Id;

                cmbSucursal.ValueMember = "Id";
                cmbSucursal.DisplayMember = "Descripcion";
                cmbSucursal.SelectedValue = relacionSucInsumoActual.Sucursal.Id;

                txtCantidad.Text = relacionSucInsumoActual.Cantidad.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTnAceptar_Click(object sender, EventArgs e)
        {
            if (relacionSucInsumoActual == null)
            {
                relacionSucInsumoActual = new RelacionSucursal_Insumo();
                relacionSucInsumoActual.Sucursal = sucursalActual;
            }
            else
            {
                relacionSucInsumoActual.Sucursal = (Sucursal)cmbSucursal.SelectedItem;
            }

            relacionSucInsumoActual.Insumo = (Insumo)cmbInsumo.SelectedItem;

            Insumo auxModificarStock= new Insumo();// obtenemos la cantidad a modificar del insumo principal
            auxModificarStock.Id = relacionSucInsumoActual.Insumo.Id;

            int cantidadActual = relacionSucInsumoActual.Cantidad - int.Parse(txtCantidad.Text);

            try
            {
                if (relacionSucInsumoActual.Id==0)
                {
                    auxModificarStock.Stock = relacionSucInsumoActual.Insumo.Stock - int.Parse(txtCantidad.Text);
                    if (verificarInsumoRepetido(relacionSucInsumoActual.Insumo))
                    {
                        relacionSucInsumoNegocio.actualizarRepetido(relacionSucInsumoActual); // busca por insumo y sucursal
                        insumoNegocio.modificarStock(auxModificarStock);
                        MessageBox.Show("Insumo Agregado a sucursal " + sucursalActual.Descripcion);
                    }
                    else
                    {
                        relacionSucInsumoActual.Cantidad = int.Parse(txtCantidad.Text);
                        relacionSucInsumoNegocio.agregar(relacionSucInsumoActual);
                        insumoNegocio.modificarStock(auxModificarStock);
                        MessageBox.Show("Insumo Agregado a sucursal " + sucursalActual.Descripcion);
                    }

                    }
                else
                {
                    if (verificarSucursal())// verdadero si estoy en la misma sucursal
                    {
                        calcularStockModificado(auxModificarStock);
                        relacionSucInsumoActual.Cantidad = int.Parse(txtCantidad.Text);
                        relacionSucInsumoNegocio.modificar(relacionSucInsumoActual);
                        insumoNegocio.modificarStock(auxModificarStock);
                        MessageBox.Show("Insumo Modificado");
                    }
                    else
                    {
                        if (verificarInsumoRepetido(relacionSucInsumoActual.Insumo, false))
                        {
                            if (cantidadActual == 0)
                            {
                                relacionSucInsumoNegocio.actualizarRepetidoModificandoSucursal(relacionSucInsumoActual); // cambia sucursal y cantidad
                                MessageBox.Show("Insumo cambiado a sucursal a sucursal " + relacionSucInsumoActual.Sucursal.Descripcion);
                            }
                            else
                            {
                                relacionSucInsumoNegocio.actualizarRepetido(relacionSucInsumoActual); // cambia sucursal y cantidad
                                MessageBox.Show(txtCantidad.Text + " " + relacionSucInsumoActual.Insumo.Descripcion + " cambiadx a sucursal " + relacionSucInsumoActual.Sucursal.Descripcion + " repetido");
                            }
                        }
                        else
                        {
                            
                            if (cantidadActual==0)
                            {
                                relacionSucInsumoActual.Cantidad = int.Parse(txtCantidad.Text);
                                relacionSucInsumoNegocio.actualizarRepetidoModificandoSucursal(relacionSucInsumoActual);
                                MessageBox.Show("Insumo cambiado a sucursal a sucursal " + relacionSucInsumoActual.Sucursal.Descripcion);
                            }
                            else
                            {
                                RelacionSucursal_Insumo aux = new RelacionSucursal_Insumo();
                                aux.Insumo = relacionSucInsumoActual.Insumo;
                                aux.Sucursal = relacionSucInsumoActual.Sucursal;
                                aux.Cantidad = int.Parse(txtCantidad.Text);
                                relacionSucInsumoNegocio.agregar(aux);

                                relacionSucInsumoActual.Sucursal = sucursalActual;
                                relacionSucInsumoActual.Cantidad = cantidadActual;

                                relacionSucInsumoNegocio.actualizarRepetido(relacionSucInsumoActual); // cambia suc y cantidad
                                MessageBox.Show(aux.Cantidad + " " + relacionSucInsumoActual.Insumo.Descripcion + " cambiadx a sucursal " + relacionSucInsumoActual.Sucursal.Descripcion);



                            }
                        }
                        
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool verificarSucursal()
        {
            if (sucursalActual.Id==relacionSucInsumoActual.Sucursal.Id)
                return true;
            else
                return false;
        }

        private void calcularStockModificado(Insumo auxModificarCantidad)
        {
            int cantidadNueva = int.Parse(txtCantidad.Text);

            if ((relacionSucInsumoActual.Cantidad - cantidadNueva) < 0)
            {
                cantidadNueva = relacionSucInsumoActual.Cantidad - cantidadNueva;
                auxModificarCantidad.Stock = relacionSucInsumoActual.Insumo.Stock - (-(cantidadNueva));
            }
            else if ((relacionSucInsumoActual.Cantidad - cantidadNueva) > 0)
            {
                cantidadNueva = relacionSucInsumoActual.Cantidad - cantidadNueva;
                auxModificarCantidad.Stock = relacionSucInsumoActual.Insumo.Stock + cantidadNueva;
            }
            else
            {
                auxModificarCantidad.Stock = relacionSucInsumoActual.Insumo.Stock;
            }
        }
        

        private bool verificarInsumoRepetido(Insumo insumoActual,bool agregando=true)
        {
            if (agregando)
            {
                foreach (var relacionInsumo in relacionSucInsumoNegocio.listar(sucursalActual))
                {
                    if (relacionInsumo.Insumo.Id==insumoActual.Id)
                    {
                        relacionSucInsumoActual.Cantidad = int.Parse(txtCantidad.Text) + relacionInsumo.Cantidad;
                        return true;
                    }
                }
            }
            else
            {
                int cantidadActual = relacionSucInsumoActual.Cantidad - int.Parse(txtCantidad.Text);

                foreach (var relacionInsumo in relacionSucInsumoNegocio.listar(relacionSucInsumoActual.Sucursal))
                {
                    if (relacionInsumo.Insumo.Id == insumoActual.Id && cantidadActual==0) //esta el mismo insumo y ademas se envio el total del este
                    {
                        relacionSucInsumoActual.Cantidad = int.Parse(txtCantidad.Text) + relacionInsumo.Cantidad;
                        relacionSucInsumoNegocio.eliminar(relacionInsumo.Id);
                        return true;
                    }
                    else if (relacionInsumo.Insumo.Id == insumoActual.Id && cantidadActual != 0) //  no se envio el total del este
                    {
                        relacionSucInsumoActual.Cantidad = cantidadActual;
                        relacionSucInsumoActual.Sucursal = sucursalActual;

                        relacionInsumo.Cantidad += int.Parse(txtCantidad.Text);
                        relacionSucInsumoNegocio.modificar(relacionInsumo);
                        return true;
                    }
                }
            }
            

            return false;
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            Insumo seleccionado = (Insumo)cmbInsumo.SelectedItem;
            lblMensajeCantidadDisponible.Text = "Unidades disponibles: " + seleccionado.Stock.ToString();
            lblMensajeCantidadDisponible.Visible = true;
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            lblMensajeCantidadDisponible.Visible = false;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Insumo seleccionado = (Insumo)cmbInsumo.SelectedItem;

            if (relacionSucInsumoActual != null)
            {
                if (txtCantidad.Text != "")
                {
                    cantidad = (seleccionado.Stock + relacionSucInsumoActual.Cantidad) - int.Parse(txtCantidad.Text);
                    lblMensajeCantidadDisponible.Text = "Unidades disponibles: " + cantidad;
                }
                else
                {
                    lblMensajeCantidadDisponible.Text = "Unidades disponibles: " + (seleccionado.Stock + relacionSucInsumoActual.Cantidad).ToString();
                }
            }
            else
            {
                if (txtCantidad.Text != "")
                {
                    cantidad = seleccionado.Stock  - int.Parse(txtCantidad.Text);
                    lblMensajeCantidadDisponible.Text = "Unidades disponibles: " + cantidad;
                }
                else
                {
                    lblMensajeCantidadDisponible.Text = "Unidades disponibles: " + seleccionado.Stock.ToString();
                }
            }
        }

        private void lblMensajeCantidadDisponible_TextChanged(object sender, EventArgs e)
        {
            Insumo seleccionado = (Insumo)cmbInsumo.SelectedItem;

            if (txtCantidad.Text!="" && relacionSucInsumoActual != null) //modificando
            {
                cantidad = (seleccionado.Stock + relacionSucInsumoActual.Cantidad) - int.Parse(txtCantidad.Text);

                if (cantidad < 0)
                {
                    lblMensajeCantidadDisponible.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblMensajeCantidadDisponible.ForeColor = Color.DimGray;
                }
            }
            else if (txtCantidad.Text != "") // agregando nuevo
            {
                cantidad = seleccionado.Stock - int.Parse(txtCantidad.Text);

                if (cantidad < 0)
                {
                    lblMensajeCantidadDisponible.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblMensajeCantidadDisponible.ForeColor = Color.DimGray;
                }
            }
        }
    }
}
