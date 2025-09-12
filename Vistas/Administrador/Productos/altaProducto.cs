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

namespace CapaPresentacion.Vistas.Administrador.Productos {

    public partial class frmAltaProducto : Form
    {
        private object messageBox;

        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void onlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyLetters(sender, e, errIngresoDatos);
        }

        private void onlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyNumbers(sender, e, errIngresoDatos);
        }

        private void onlyInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyInteger(sender, e, errIngresoDatos);
        }

        private void noWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Está seguro que desea limpiar el registro del producto?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtNombreProd.Clear();
                txtDescripcionProd.Clear();
                cboCategoriaProd.SelectedIndex = -1;
                txtPrecioVentaProd.Clear();
                txtCostoProd.Clear();
                txtStockProd.Clear();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            if (string.IsNullOrEmpty(txtNombreProd.Text) ||
                string.IsNullOrEmpty(txtDescripcionProd.Text) ||
                cboCategoriaProd.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtPrecioVentaProd.Text) ||
                string.IsNullOrEmpty(txtCostoProd.Text) ||
                string.IsNullOrEmpty(txtStockProd.Text))
            {
                MessageBox.Show(txtNombreProd, "Debe completar todos los campos.");

                return;
            }

            // guardar el producto en la base de datos
            messageBox = MessageBox.Show("Producto registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
