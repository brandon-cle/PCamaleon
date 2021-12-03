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

namespace TCamaleonApp.Views
{
    public partial class FormMantenimiento : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarVehiculo fc = new frmBuscarVehiculo();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.txtIdVehiculo.Text = fc.dtVehiculo.Rows[fc.dtVehiculo.CurrentRow.Index].Cells[0].Value.ToString();
                string marca = fc.dtVehiculo.Rows[fc.dtVehiculo.CurrentRow.Index].Cells[3].Value.ToString();
                string modelo = fc.dtVehiculo.Rows[fc.dtVehiculo.CurrentRow.Index].Cells[4].Value.ToString();
                txtCliente.Text = fc.dtVehiculo.Rows[fc.dtVehiculo.CurrentRow.Index].Cells[2].Value.ToString();
                txtMarca.Text = marca +' '+ modelo;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            txtFechaIngreso.Text = String.Empty;
            txtFechaSalida.Text = String.Empty;
            txtIdVehiculo.Text = String.Empty;
            txtMarca.Text = String.Empty;

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
            this.txtIdMecanico.Text=DateTime.Now.ToString();
        }

        private void btnIdServicio_Click(object sender, EventArgs e)
        {
            frmBuscarServicio fc = new frmBuscarServicio();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.txtIdServicio.Text = fc.dtServicio.Rows[fc.dtServicio.CurrentRow.Index].Cells[2].Value.ToString();
                txtDescripcion.Text = fc.dtServicio.Rows[fc.dtServicio.CurrentRow.Index].Cells[1].Value.ToString();
                txtCosto.Text = fc.dtServicio.Rows[fc.dtServicio.CurrentRow.Index].Cells[3].Value.ToString();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
           
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
            this.dtMantenimiento.CurrentCell = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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

                    rpta = cMantenimiento.Insertar(Convert.ToInt32(txtIdVehiculo.Text), txtFechaIngreso.Text);
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
                //this.dtMantenimiento.DataSource = cVehiculo.MostrarVehiculo();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormMantenimiento_Load(object sender, EventArgs e)
        {
            this.txtIdMecanico.Text = DateTime.Now.ToString();
        }
    }
}
