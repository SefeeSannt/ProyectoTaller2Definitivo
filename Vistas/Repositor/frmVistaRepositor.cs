﻿using CapaPresentacion.Vistas.Administrador.Reportes;

using ProyectoTaller2Definitivo.Vistas.Repositor;
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
using ProyectoTaller2Definitivo.Vistas.Repositor.Proveedor;

namespace ProyectoTaller2Definitivo.Vistas.Repositor
{
    public partial class frmVistaRepositor : Form
    {
        public frmVistaRepositor()
        {
            InitializeComponent();
        }

        private void tsmiRegistrarCompra_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmRegitroCompraRepositor();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiConsultarCompra_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmDetalleCompras();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiComprar_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmConsultaStock();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiConsultarProveedores_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmConsultaProveedores();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void frmVistaRepositor_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient mdi)
                {
                    // Fondo de color
                    mdi.BackColor = Color.White;
                }
            }
        }


        private void iconBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmAltaProveedor_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmAltaProveedor();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
