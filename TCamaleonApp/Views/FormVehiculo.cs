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
    public partial class FormVehiculo : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormVehiculo()
        {
            InitializeComponent();
        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            this.dtVehiculo.DataSource = cVehiculo.MostrarVehiculo();
            Botones();

            txtIdCliente.Enabled = false;
            txtCliente.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtVehiculo.DataSource = cVehiculo.BuscarVehiculo(txtBuscar.Text);
        }
        private void limpiar()
        {
            txtAno.Text = String.Empty;
            txtMarca.Text = String.Empty;
            txtModelo.Text = String.Empty;
            txtPlaca.Text = String.Empty;
            txtCliente.Text = String.Empty;
            txtPlaca.Text = String.Empty;
            txtIdCliente.Text = String.Empty;
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
            txtAno.ReadOnly = !valor;
            txtCliente.ReadOnly = !valor;
            txtIdCliente.ReadOnly = !valor;
            txtMarca.ReadOnly = !valor;
            txtMarca.ReadOnly = !valor;
            txtModelo.ReadOnly = !valor;
            txtPlaca.ReadOnly = !valor;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
            this.txtPlaca.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.dtVehiculo.SelectedRows.Count == 1)
            {
                this.txtAno.Text = Convert.ToString(this.dtVehiculo.CurrentRow.Cells["Año"].Value);
                this.txtCliente.Text = Convert.ToString(this.dtVehiculo.CurrentRow.Cells["Propetario"].Value);
                this.txtIdCliente.Text = Convert.ToString(this.dtVehiculo.CurrentRow.Cells["Id Propetario"].Value);
                this.txtMarca.Text = Convert.ToString(this.dtVehiculo.CurrentRow.Cells["Marca"].Value);
                this.txtModelo.Text = Convert.ToString(this.dtVehiculo.CurrentRow.Cells["Modelo"].Value);
                this.txtPlaca.Text = Convert.ToString(this.dtVehiculo.CurrentRow.Cells["Matricula"].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtPlaca.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
            this.dtVehiculo.CurrentCell = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(txtIdCliente.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar el propetario del auto", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                string rpta = "";

                if (this.IsNuevo)
                {

                    rpta = cVehiculo.Insertar (Convert.ToInt32(txtIdCliente.Text), txtMarca.Text, txtModelo.Text, Convert.ToInt32(txtAno.Text), txtPlaca.Text);
                }
                else
                {

                    rpta = cVehiculo.Editar(Convert.ToInt32(this.dtVehiculo.CurrentRow.Cells["Id Vehiculo"].Value), Convert.ToInt32(txtIdCliente.Text), txtMarca.Text, txtModelo.Text, Convert.ToInt32(txtAno.Text), txtPlaca.Text);
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
                this.dtVehiculo.DataSource = cVehiculo.MostrarVehiculo();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente fc = new frmBuscarCliente();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.txtIdCliente.Text = fc.dtCliente.Rows[fc.dtCliente.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtCliente.Text = fc.dtCliente.Rows[fc.dtCliente.CurrentRow.Index].Cells[1].Value.ToString();
            }
        }
    }
}
