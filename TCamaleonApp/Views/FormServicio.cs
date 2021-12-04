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
    public partial class FormServicio : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormServicio()
        {
            InitializeComponent();
            cmbTipoMantenimiento.SelectedIndex = 0;
        }
        private void MostrarServicio()
        {

            this.dtServicio.DataSource = cServicio.MostrarServicio();

        }

        private void FormServicio_Load(object sender, EventArgs e)
        {
            dtServicio.AllowUserToAddRows = false;
            MostrarServicio();
            Botones();
        }
        //Buscar servicio
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.dtServicio.DataSource = cServicio.BuscarServicio(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(!char.IsNumber(e.KeyChar) && (e.KeyChar !=(char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                float valor = float.Parse(txtPrecio.Text);
            }
            catch (FormatException ex)
            {

                textBox3.Text = "Error";

            }
            string Tipo = cmbTipoMantenimiento.Text;
            //float valor = float.Parse(txtPrecio.Text);
            try
            {
                string rpta = "";

                if (this.IsNuevo)
                {
                   
                    rpta = cServicio.Insertar( txtDescripcion.Text, cmbTipoMantenimiento.Text, float.Parse(txtPrecio.Text));
                }
                else { 
                
                    rpta = cServicio.Editar(Convert.ToInt32(this.dtServicio.CurrentRow.Cells["Id Servicio"].Value),txtDescripcion.Text, cmbTipoMantenimiento.Text, float.Parse(txtPrecio.Text));

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
                this.dtServicio.DataSource = cServicio.MostrarServicio();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
            this.dtServicio.CurrentCell = null;
        }
        private void limpiar()
        {
            txtPrecio.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
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
            this.txtDescripcion.ReadOnly = !valor;
            txtPrecio.ReadOnly = !valor;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
            this.txtDescripcion.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.dtServicio.SelectedRows.Count == 1)
            {
                this.cmbTipoMantenimiento.Text = Convert.ToString(this.dtServicio.CurrentRow.Cells["Tipo de Mantenimiento"].Value);
                this.txtDescripcion.Text = Convert.ToString(this.dtServicio.CurrentRow.Cells["Descripcion"].Value);
                this.txtPrecio.Text = Convert.ToString(this.dtServicio.CurrentRow.Cells["Precio"].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtDescripcion.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}