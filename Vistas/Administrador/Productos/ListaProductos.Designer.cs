using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CapaPresentacion.Vistas.Administrador.Productos
{
    partial class frmListaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuariosAlta = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTituloListUsuarioAlta = new System.Windows.Forms.Label();
            this.btnBuscarListUsuarioAlta = new FontAwesome.Sharp.IconButton();
            this.txtBuscarUsuarioAlta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuariosAlta
            // 
            this.dgvUsuariosAlta.AllowUserToAddRows = false;
            this.dgvUsuariosAlta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuariosAlta.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuariosAlta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvUsuariosAlta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosAlta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuariosAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosAlta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.precioCosto,
            this.precioVenta,
            this.marca,
            this.proveedor,
            this.stock,
            this.colImg,
            this.colAccion});
            this.dgvUsuariosAlta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsuariosAlta.Location = new System.Drawing.Point(0, 87);
            this.dgvUsuariosAlta.Name = "dgvUsuariosAlta";
            this.dgvUsuariosAlta.Size = new System.Drawing.Size(823, 363);
            this.dgvUsuariosAlta.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // precioCosto
            // 
            this.precioCosto.HeaderText = "Precio Costo";
            this.precioCosto.Name = "precioCosto";
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            // 
            // colImg
            // 
            this.colImg.HeaderText = "Imagen";
            this.colImg.Name = "colImg";
            // 
            // colAccion
            // 
            this.colAccion.HeaderText = "Accion";
            this.colAccion.Name = "colAccion";
            this.colAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lblTituloListUsuarioAlta
            // 
            this.lblTituloListUsuarioAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTituloListUsuarioAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloListUsuarioAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListUsuarioAlta.ForeColor = System.Drawing.Color.White;
            this.lblTituloListUsuarioAlta.Location = new System.Drawing.Point(0, 0);
            this.lblTituloListUsuarioAlta.Name = "lblTituloListUsuarioAlta";
            this.lblTituloListUsuarioAlta.Size = new System.Drawing.Size(823, 42);
            this.lblTituloListUsuarioAlta.TabIndex = 22;
            this.lblTituloListUsuarioAlta.Text = "Lista de Productos";
            this.lblTituloListUsuarioAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscarListUsuarioAlta
            // 
            this.btnBuscarListUsuarioAlta.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBuscarListUsuarioAlta.BackColor = System.Drawing.Color.White;
            this.btnBuscarListUsuarioAlta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarListUsuarioAlta.FlatAppearance.BorderSize = 0;
            this.btnBuscarListUsuarioAlta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscarListUsuarioAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBuscarListUsuarioAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarListUsuarioAlta.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarListUsuarioAlta.IconColor = System.Drawing.Color.Black;
            this.btnBuscarListUsuarioAlta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarListUsuarioAlta.IconSize = 15;
            this.btnBuscarListUsuarioAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarListUsuarioAlta.Location = new System.Drawing.Point(742, 51);
            this.btnBuscarListUsuarioAlta.Name = "btnBuscarListUsuarioAlta";
            this.btnBuscarListUsuarioAlta.Size = new System.Drawing.Size(57, 30);
            this.btnBuscarListUsuarioAlta.TabIndex = 33;
            this.btnBuscarListUsuarioAlta.Text = "Búscar";
            this.btnBuscarListUsuarioAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarListUsuarioAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarListUsuarioAlta.UseVisualStyleBackColor = false;
            // 
            // txtBuscarUsuarioAlta
            // 
            this.txtBuscarUsuarioAlta.Location = new System.Drawing.Point(530, 51);
            this.txtBuscarUsuarioAlta.Multiline = true;
            this.txtBuscarUsuarioAlta.Name = "txtBuscarUsuarioAlta";
            this.txtBuscarUsuarioAlta.Size = new System.Drawing.Size(206, 31);
            this.txtBuscarUsuarioAlta.TabIndex = 32;
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.btnBuscarListUsuarioAlta);
            this.Controls.Add(this.txtBuscarUsuarioAlta);
            this.Controls.Add(this.lblTituloListUsuarioAlta);
            this.Controls.Add(this.dgvUsuariosAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvUsuariosAlta;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precioCosto;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn proveedor;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewImageColumn colImg;
        private DataGridViewButtonColumn colAccion;
        private Label lblTituloListUsuarioAlta;
        private FontAwesome.Sharp.IconButton btnBuscarListUsuarioAlta;
        private TextBox txtBuscarUsuarioAlta;
    }
}