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
   
    public partial class FormCliente : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormCliente()
        {
            InitializeComponent();
        }
        private void MostrarServicio()
        {

            this.dtCliente.DataSource = cCliente.MostrarCliente();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

            dtCliente.AllowUserToAddRows = false;
            MostrarServicio();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtCliente.DataSource = cCliente.BuscarCliente(txtBuscar.Text);
        }
        private void limpiar()
        {
            txtCedula.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtPrimerApellido.Text = String.Empty;
            txtPrimerNombre.Text = String.Empty;
            txtSegundoApellido.Text = String.Empty;
            txtSegundoNombre.Text = String.Empty;
            txtTelfono.Text = String.Empty;


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
            this.txtCedula.ReadOnly = !valor;
            txtCedula.ReadOnly = !valor;
            txtCorreo.ReadOnly = !valor;
            txtDireccion.ReadOnly = !valor;
            txtPrimerApellido.ReadOnly = !valor;
            txtPrimerNombre.ReadOnly = !valor;
            txtSegundoApellido.ReadOnly = !valor;
            txtSegundoNombre.ReadOnly = !valor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
            this.dtCliente.CurrentCell = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtCliente.SelectedRows.Count == 1)
            {
                this.txtCedula.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Cedula"].Value);
                this.txtCorreo.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Correo"].Value);
                this.txtDireccion.Text = Convert.ToString(dtCliente.CurrentRow.Cells["Direccion"].Value);
                this.txtPrimerApellido.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Primer Apellido"].Value);
                this.txtPrimerNombre.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Primer Nombre"].Value);
                this.txtSegundoApellido.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Segundo Apellido"].Value);
                this.txtSegundoNombre.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Segundo Nombre"].Value);
                this.txtTelfono.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Teléfono"].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtCedula.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
            this.txtCedula.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.IsNuevo)
                {

                    rpta = cCliente.Insertar(txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text
                       ,txtCedula.Text, txtTelfono.Text, txtCorreo.Text, txtDireccion.Text );
                }
                else
                {

                    rpta = cCliente.Editar(Convert.ToInt32(this.dtCliente.CurrentRow.Cells["Id Cliente"].Value), txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text
                       , txtCedula.Text, txtTelfono.Text, txtCorreo.Text, txtDireccion.Text);

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
                this.dtCliente.DataSource = cCliente.MostrarCliente();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }

}

