using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Helpers;
using CapaNegocio;

namespace ProyectoTaller2Definitivo.Vistas.Vendedor
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void onlyLetters(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyLetters(sender, e, errIngresoDatos);
        }

        private void onlyInteger(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyInteger(sender, e, errIngresoDatos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                errIngresoDatos.SetError(txtDocumento, "El campo Documento es obligatorio");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errIngresoDatos.SetError(txtNombre, "El campo Nombre es obligatorio");
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errIngresoDatos.SetError(txtApellido,"El campo Apellido es obligatorio");
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errIngresoDatos.SetError(txtTelefono, "El campo Telefono es obligatorio");
                return;
            }

            var nuevoCliente = new ClienteModel
            {
                Dni = int.Parse(txtDocumento.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = int.Parse(txtTelefono.Text)
            };

            try
            {
                var negocio = new CN_cliente();
                negocio.AgregarCliente(nuevoCliente);
                MessageBox.Show("Cliente registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientesEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCanecelar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Está seguro que desea cancelar el registro del cliente?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtDocumento.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Está seguro que desea cancelar el registro del cliente?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CargarClientesEnGrid()
        {
            var negocio = new CN_cliente();
            var lista = negocio.ObtenerClientes();
            dgvClientes.DataSource = lista;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }
    }
}
