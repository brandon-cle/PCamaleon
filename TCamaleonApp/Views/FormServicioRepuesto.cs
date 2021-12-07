using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCamaleonApp.Controller;
using System.Windows.Forms;
using System.Data;

namespace TCamaleonApp.Views
{
    public partial class FormServicioRepuesto : Form
    {
        public static int cont_fila = 0;
        public static double total;
        public FormServicioRepuesto()
        {
            InitializeComponent();
        }

        private void btnMecanico_Click(object sender, EventArgs e)
        {
            /*frmBuscarRepuesto fc = new frmBuscarRepuesto();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.txtIdServicio.Text = fc.dtRepuesto.Rows[fc.dtRepuesto.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcion.Text = fc.dtRepuesto.Rows[fc.dtRepuesto.CurrentRow.Index].Cells[1].Value.ToString();
                txtCosto.Text = fc.dtRepuesto.Rows[fc.dtRepuesto.CurrentRow.Index].Cells[3].Value.ToString();

            }*/
        }

        private void FormServicioRepuesto_Load(object sender, EventArgs e)
        {
            nudCantidad.Value = 1;
            dtServicioMantenimiento.DataSource = cServicioMantenimiento.BuscarServicioMantenimiento(txtIdMantenimiento.Text);
        }

        private void btnBuscarMantenimiento_Click(object sender, EventArgs e)
        {
            frmBuscarMantenimiento fc = new frmBuscarMantenimiento();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.txtIdMantenimiento.Text = fc.dtMantenimiento.Rows[fc.dtMantenimiento.CurrentRow.Index].Cells[0].Value.ToString();

            }
        }

        private void txtIdMantenimiento_TextChanged(object sender, EventArgs e)
        {
            dtServicioMantenimiento.DataSource = cServicioMantenimiento.BuscarServicioMantenimiento(txtIdMantenimiento.Text);
        }

        private void btnBuscarRepuesto_Click(object sender, EventArgs e)
        {
            frmBuscarRepuesto fc = new frmBuscarRepuesto();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.idRepuesto.Text = fc.dtRepuesto.Rows[fc.dtRepuesto.CurrentRow.Index].Cells[0].Value.ToString();
               // this.txtCosto.Text = fc.dtRepuesto.Rows[fc.dtRepuesto.CurrentRow.Index].Cells[5].Value.ToString();
                txtDescripcion.Text = fc.dtRepuesto.Rows[fc.dtRepuesto.CurrentRow.Index].Cells[2].Value.ToString();
                txtNombreRepuesto.Text = fc.dtRepuesto.Rows[fc.dtRepuesto.CurrentRow.Index].Cells[1].Value.ToString();
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarServicio();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (this.dtServicioMantenimiento.SelectedRows.Count == 1)
            {
               
                this.textBox3.Text = Convert.ToString(this.dtServicioMantenimiento.CurrentRow.Cells["Costo"].Value);
                this.txtServicioDescripcion.Text = Convert.ToString(this.dtServicioMantenimiento.CurrentRow.Cells["Descripcion"].Value);
                this.txtServicio.Text = Convert.ToString(this.dtServicioMantenimiento.CurrentRow.Cells["Id"].Value);

                BotonesVerdadero();
                btnNuevo.Enabled = false;
                btnBuscarMantenimiento.Enabled = false;
                btnCancelar.Enabled = false;
            }   }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            if (cont_fila != 0)
            {
                try
                {
                    //DataTable Datos = CFactura.InsertarFactura(Convert.ToInt32(codigoUsuario),
                    //                                                Convert.ToInt32(this.txtCodigoCliente.Text.Trim()));
                    //string idFactura;

                    //idFactura = Datos.Rows[0][0].ToString();
                    DataGridView dataGridView = new DataGridView();
                    foreach (DataGridViewRow Fila in dtFactura.Rows)
                    {

                        cServicioRepuesto.Insertar(Convert.ToInt32(Fila.Cells[0].Value.ToString()), Convert.ToInt32(Fila.Cells[1].Value.ToString()), Convert.ToInt32(Fila.Cells[2].Value.ToString()), float.Parse(Fila.Cells[3].Value.ToString()));

                    }

                    MessageBox.Show("Datos Ingresados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception error) { }
                //Limpiar();

            }
            else
            {
                MessageBox.Show("La Factura está vacía", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            BotonesFalso();
            btnNuevo.Enabled = true;
            btnBuscarMantenimiento.Enabled = true;
            btnCancelar.Enabled = true;

            /*txtServicio.Text = Convert.ToString(cont_fila);
            if (cont_fila > 0)
            {
                do
                {
                    
                    dtFactura.Rows.RemoveAt(cont_fila);
                    cont_fila--;
                } while (cont_fila == 1);

            }*/

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.nudCantidad.Value > 0 && float.Parse(this.txtCosto.Text) > 0)
            {
                bool existe = false;
                int num_fila = 0;
                if (cont_fila == 0)
                {
                  
                    this.dtFactura.Rows.Add(this.txtServicio.Text, this.idRepuesto.Text,
                                            this.nudCantidad.Value, this.txtCosto.Text, this.txtDescripcion.Text);

                       double importe = Convert.ToDouble(this.dtFactura.Rows[cont_fila].Cells[2].Value) *
                                                      Convert.ToDouble(this.dtFactura.Rows[cont_fila].Cells[3].Value);
                    dtFactura.Rows[cont_fila].Cells[4].Value = importe;
                    cont_fila++;
                    //LimpiarProducto();
                }
                else
                {
                     //DataGridViewRow Fila = new DataGridViewRow();
                    foreach (DataGridViewRow Fila in dtFactura.Rows)
                    {
                        if (Fila.Cells[1].Value.ToString() == this.idRepuesto.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        this.dtFactura.Rows[num_fila].Cells[3].Value =
                        (Convert.ToDouble(nudCantidad.Value) + Convert.ToDouble(this.dtFactura.Rows[num_fila].Cells[2].Value)).ToString();
                        double importe = Convert.ToDouble(this.dtFactura.Rows[num_fila].Cells[2].Value) *
                                                Convert.ToDouble(this.dtFactura.Rows[num_fila].Cells[3].Value);
                        dtFactura.Rows[num_fila].Cells[4].Value = importe;
                        //LimpiarProducto();
                    }
                    else
                    {
                        this.dtFactura.Rows.Add(this.txtServicio.Text, this.idRepuesto.Text,
                                            this.nudCantidad.Value, this.txtCosto.Text);
                        double importe = Convert.ToDouble(this.dtFactura.Rows[cont_fila].Cells[2].Value) *
                                                      Convert.ToDouble(this.dtFactura.Rows[cont_fila].Cells[3].Value);
                        dtFactura.Rows[cont_fila].Cells[4].Value = importe;
                        cont_fila++;
                        //LimpiarProducto();

                    }

                }
                float total = 0;
                foreach (DataGridViewRow Fila in dtFactura.Rows)
                {
                    total = (float)(total + Convert.ToDouble(Fila.Cells[4].Value));
                }
              // this.lblSubTotal.Text = "C$ " + total.ToString();
              //this.lblIVA.Text = "C$ " + (total * 1.15).ToString();

            }
            else
            {
                MessageBox.Show("Debe Ingresar la Cantidad y/o Precio", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                //total = total - (Convert.ToDouble(this.dtFactura.Rows[dtFactura.CurrentRow.Index].Cells[4].Value));
                //this.lblSubTotal.Text = "C$ " + total.ToString();
                //this.lblIVA.Text = "C$ " + (total * 1.15).ToString();
                dtFactura.Rows.RemoveAt(dtFactura.CurrentRow.Index);
                cont_fila--;
                
            }
        }

        private void btnCancelarServicio_Click(object sender, EventArgs e)
        {
            limpiarRepuesto();
        }
        private void limpiarServicio()
        {
            txtServicioDescripcion.Text = string.Empty;
            txtServicio.Text = string.Empty;
            textBox3.Text = string.Empty;
            txtIdMantenimiento.Text = string.Empty;
        }

        private void limpiarRepuesto()
        {
            idRepuesto.Text = string.Empty;
            txtNombreRepuesto.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            nudCantidad.Value = 1;
        }
        private void BotonesFalso()
        {
            btnGuardarServicio.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelarServicio.Enabled = false;
            btnNuevoServicio.Enabled = false;
         
            btnBuscarRepuesto.Enabled = false;
        }

        private void BotonesVerdadero()
        {
            btnGuardarServicio.Enabled = true;
            btnCancelarServicio.Enabled = true;
            btnNuevoServicio.Enabled = true;
            btnAgregar.Enabled = true;
            btnBuscarRepuesto.Enabled = true;
        }
        /*private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnModificar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }*/

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            txtCosto.Enabled = true;
            limpiarRepuesto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarServicio();
        }
    }
}
