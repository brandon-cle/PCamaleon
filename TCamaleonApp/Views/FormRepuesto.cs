using System;
using System.Windows.Forms;
using TCamaleonApp.Controller;

namespace TCamaleonApp.Views
{
    public partial class FormRepuesto : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormRepuesto()
        {
            InitializeComponent();
        }

        private void FormRepuesto_Load(object sender, System.EventArgs e)
        {
            dtRepuesto.AllowUserToAddRows = false;
            MostrarRepuesto();


        }
        private void MostrarRepuesto()
        {

            this.dtRepuesto.DataSource = cRepuesto.MostrarRepuesto();
        }

        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            this.dtRepuesto.DataSource = cRepuesto.BuscarRepuesto(this.txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if(float.Parse(txtPrecio.Text) < 0 || Convert.ToInt32(txtCantidad.Text) < 0)
            {
                MessageBox.Show("Cantidad y precio no pueden ser negativos", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                float valor = float.Parse(txtPrecio.Text);
                float can = float.Parse(txtCantidad.Text);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Cantidad y precio solo deben ser Numeros", "Sistema de Taller Mecanico", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            try
            {
                string rpta = "";

                if (this.IsNuevo)
                {

                    rpta = cRepuesto.Insertar(txtTitulo.Text,txtDescripcion.Text, txtMarca.Text, txtModeloR.Text, 
                        float.Parse(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text));
                }
                else
                {

                    rpta = cRepuesto.Editar(Convert.ToInt32(this.dtRepuesto.CurrentRow.Cells["Id Repuesto"].Value), txtTitulo.Text, txtDescripcion.Text, txtMarca.Text, txtModeloR.Text,
                        float.Parse(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text));

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
                this.dtRepuesto.DataSource = cRepuesto.MostrarRepuesto();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
            this.dtRepuesto.CurrentCell = null;
        }
        private void limpiar()
        {
            txtPrecio.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtMarca.Text = String.Empty;
            txtModeloR.Text  = String.Empty;
            txtTitulo.Text = String.Empty;
            txtCantidad.Text = String.Empty;

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
            txtTitulo.ReadOnly = !valor;
            txtMarca.ReadOnly = !valor;
            txtPrecio.ReadOnly = !valor;
            txtModeloR.ReadOnly = !valor;
            txtCantidad.ReadOnly = !valor;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.limpiar();
            this.txtTitulo.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.dtRepuesto.SelectedRows.Count == 1)
            {
                this.txtTitulo.Text= Convert.ToString(this.dtRepuesto.CurrentRow.Cells["Titulo"].Value);
                this.txtModeloR.Text = Convert.ToString(this.dtRepuesto.CurrentRow.Cells["Modelo"].Value);
                this.txtCantidad.Text = Convert.ToString(dtRepuesto.CurrentRow.Cells["Cantidad"].Value);
                this.txtMarca.Text = Convert.ToString(this.dtRepuesto.CurrentRow.Cells["Marca"].Value);
                this.txtDescripcion.Text = Convert.ToString(this.dtRepuesto.CurrentRow.Cells["Descripcion"].Value);
                this.txtPrecio.Text = Convert.ToString(this.dtRepuesto.CurrentRow.Cells["Precio"].Value);

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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
