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
using TCamaleonApp.Model;

namespace TCamaleonApp.Views
{
    public partial class FormMantenimiento : Form
    {
        public static string globalID_toChange = null;
        public static string globalNombre_toChange = null;
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtFechaIngreso.Text = String.Empty;
            txtFechaSalida.Text = String.Empty;
            txtIdVehiculo.Text = String.Empty;
            txtMarca.Text = String.Empty;
            txtCliente.Text = String.Empty;

        }
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnModificar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }
        private void Habilitar(bool valor)
        {
            //txtMarca.ReadOnly = !valor;
            //txtIdVehiculo.ReadOnly = !valor;
        }

        private void btnMecanico_Click(object sender, EventArgs e)
        {
            Form_BuscarTécnico fc = new Form_BuscarTécnico();
            fc.ShowDialog();
            
            if (globalID_toChange != null)
            {
                txtIdMecanico.Text = globalID_toChange;
                txtMecanico.Text = globalNombre_toChange;
            }
            else
            {
                return;
            }

            MirarMantenimiento();
            //this.txtIdMecanico.Text=DateTime.Now.ToString();
        }

        private void btnIdServicio_Click(object sender, EventArgs e)
        {
            MirarMantenimiento();
            frmBuscarServicio fc = new frmBuscarServicio();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.txtIdServicio.Text = fc.dtServicio.Rows[fc.dtServicio.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcion.Text = fc.dtServicio.Rows[fc.dtServicio.CurrentRow.Index].Cells[1].Value.ToString();
                //txtCosto.Text = fc.dtServicio.Rows[fc.dtServicio.CurrentRow.Index].Cells[3].Value.ToString();

            }
        }

        private void MirarMantenimiento()
        {
            if (txtCliente.Text.Length == 0)
            {
                btnIdServicio.Enabled = false;
                btnMecanico.Enabled = false;
                //MessageBox.Show("Debe ingresar el mantenimiento para agregar servicios", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnIdServicio.Enabled = true;
                btnMecanico.Enabled = true;
            }
        }
    

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
            BotonesFalso();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if(btnCancelar.Text == "Listo")
            {
                lblMantenimiento.Text = String.Empty;
                btnCancelar.Text = "Cancelar";
                dtServicioMantenimiento.DataSource = cServicioMantenimiento.BuscarServicioMantenimiento(labelMantenimiento.Text);
                limpiarSevicio();
            }
            
                btnBuscarCliente.Enabled = true;
                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.limpiar();
                this.dtMantenimiento.CurrentCell = null;
            
            BotonesFalso();
        }

        private void BotonesFalso()
        {
            btnGuardarServicio.Enabled=false;
            btnCancelarServicio.Enabled = false;
            btnNuevoServicio.Enabled = false;
            btnMecanico.Enabled = false;
            btnIdServicio.Enabled = false;
        }

        private void BotonesVerdadero()
        {
            btnGuardarServicio.Enabled = true;
            btnCancelarServicio.Enabled = true;
            btnNuevoServicio.Enabled = true;
            btnMecanico.Enabled = true;
            btnIdServicio.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //this.txtFechaSalida.Text = this.dateTimePicker1.Value.ToString();
            try
            {
                if (this.txtIdVehiculo.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar el auto para realizar un mantenimiento", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string rpta = "";

                if (this.IsNuevo)
                {

                    rpta = cMantenimiento.Insertar(Convert.ToInt32(txtIdVehiculo.Text),  DateTime.Now);
                }
                else
                {

                   // rpta = cVehiculo.Editar(Convert.ToInt32(this.dtVehiculo.CurrentRow.Cells["Id Vehiculo"].Value), Convert.ToInt32(txtIdCliente.Text), txtMarca.Text, txtModelo.Text, Convert.ToInt32(txtAno.Text), txtPlaca.Text);
                }


                if (rpta.Equals("OK"))
                {
                    if (this.IsNuevo)
                    {

                        MessageBox.Show("Datos Ingresados", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datos Actualizados", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show(rpta, "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.limpiar();
               this.dtMantenimiento.DataSource = cMantenimiento.MostrarMantenimiento();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            BotonesFalso();
        }

        private void FormMantenimiento_Load(object sender, EventArgs e)
        {
            BotonesServicio();
            //this.dtMantenimiento.DataSource = CEmployeer.MostrarTécnicoA();
            this.dtMantenimiento.DataSource = cMantenimiento.MostrarMantenimiento();
           // this.txtFechaIngreso.Text = DateTime.Now.ToString();
            //string idManten = dtMantenimiento.Rows[dtMantenimiento.CurrentRow.Index].Cells[0].Value.ToString();


            //this.dtServicioMantenimiento.DataSource = cServicioMantenimiento.BuscarServicioMantenimiento(idManten);
        }

        private void btnBuscarVehiculo_Click_1(object sender, EventArgs e)
        {

            this.txtFechaIngreso.Text = DateTime.Now.ToString();
            frmBuscarVehiculo fc = new frmBuscarVehiculo();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.txtIdVehiculo.Text = fc.dtVehiculo.Rows[fc.dtVehiculo.CurrentRow.Index].Cells[0].Value.ToString();
                string marca = fc.dtVehiculo.Rows[fc.dtVehiculo.CurrentRow.Index].Cells[3].Value.ToString();
                string modelo = fc.dtVehiculo.Rows[fc.dtVehiculo.CurrentRow.Index].Cells[4].Value.ToString();
                txtCliente.Text = fc.dtVehiculo.Rows[fc.dtVehiculo.CurrentRow.Index].Cells[2].Value.ToString();
                txtMarca.Text = marca + ' ' + modelo;
            }
        }  
        private void BotonesServicio()
        {
            if (txtCliente.Text.Length == 0)
            {
                btnIdServicio.Enabled = false;
                btnMecanico.Enabled = false;
                //MessageBox.Show("Debe ingresar el mantenimiento para agregar servicios", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtMantenimiento.DataSource = cMantenimiento.BuscarMantenimiento(txtBuscar.Text);
        }

        private void dtServicioMantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnCancelar.Text = "Listo";
            if (this.dtMantenimiento.SelectedRows.Count == 1)
            {
                String Estado = Convert.ToString(this.dtMantenimiento.CurrentRow.Cells["Estado"].Value);
                if (Estado == "Finalizado")
                {
                    MessageBox.Show("El Mantenimiento ya finalizo", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BotonesVerdadero();
                    string idM = Convert.ToString(this.dtMantenimiento.CurrentRow.Cells["Id Mantenimiento"].Value);
                    this.txtMarca.Text = Convert.ToString(this.dtMantenimiento.CurrentRow.Cells["Marca de Vehiculo"].Value);
                    this.txtCliente.Text = Convert.ToString(this.dtMantenimiento.CurrentRow.Cells["Propetario"].Value);
                    this.txtFechaIngreso.Text = Convert.ToString(this.dtMantenimiento.CurrentRow.Cells["Ingreso"].Value);
                    this.txtFechaSalida.Text = Convert.ToString(this.dtMantenimiento.CurrentRow.Cells["Salida"].Value);
                    lblMantenimiento.Text = idM;
                    this.IsNuevo = false;
                    this.IsEditar = true;
                    this.Botones();
                    btnBuscarCliente.Enabled = false;
                    btnGuardar.Enabled = false;
                    this.dtServicioMantenimiento.DataSource = mServicioMantenimiento.BuscarServicioMantenimiento(idM);
                }
               

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCancelarServicio_Click(object sender, EventArgs e)
        {
            limpiarSevicio();
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            txtCosto.Enabled = true;
            limpiarSevicio();
        }
        private void limpiarSevicio()
        {
            txtDescripcion.Text = String.Empty;
            txtCosto.Text = String.Empty;
            txtIdMecanico.Text = String.Empty;
            txtIdServicio.Text = String.Empty;
            txtMecanico.Text = String.Empty;
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lblMantenimiento.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar el mantenimiento para agregar servicios", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                if (this.txtIdMecanico.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar el mecanico que brindara el servicio", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                if (this.txtIdServicio.Text.Length == 0)
                {
                    MessageBox.Show("Debe indicar el sevicio que se dara", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                if (float.Parse(this.txtCosto.Text) <= 0)
                {
                    MessageBox.Show("Precio no debe ser menor a 0 ", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

                string rpta = "";

                rpta = cServicioMantenimiento.Insertar(Convert.ToInt32(lblMantenimiento.Text),
                    Convert.ToInt32(txtIdServicio.Text), Convert.ToInt32(txtIdMecanico.Text), float.Parse(txtCosto.Text));

                if (rpta.Equals("OK"))
                {
                   

                        MessageBox.Show("Datos Ingresados", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show(rpta, "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //this.IsNuevo = false;
               // this.IsEditar = false;
                //this.Botones();
                //this.limpiar();
                this.dtServicioMantenimiento.DataSource = cServicioMantenimiento.BuscarServicioMantenimiento(lblMantenimiento.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            BotonesFalso();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (this.dtMantenimiento.SelectedRows.Count == 1)
            {
                try
                {

                    cMantenimiento.CambioEstado(Convert.ToInt32(this.dtMantenimiento.CurrentRow.Cells["Id Mantenimiento"].Value));
                   

                    IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    //this.Limpiar();
                    this.dtMantenimiento.DataSource= cMantenimiento.MostrarMantenimiento();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para cambiar el estado", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dtServicioMantenimiento.SelectedRows.Count == 1)
            {
                    int idSM = (int)dtServicioMantenimiento.CurrentRow.Cells["Id"].Value;
                cMantenimiento.BorrarServicioMantenimiento(idSM);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de eliminar", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
         
}
