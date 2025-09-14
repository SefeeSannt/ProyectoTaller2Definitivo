using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas.Administrador.Productos
{
    partial class frmAltaProducto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTituloListaProd = new System.Windows.Forms.Label();
            this.dgvRegistrarProducto = new System.Windows.Forms.DataGridView();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistroProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStockProd = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaProd = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.cboCategoriaProd = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.lblRegistrarProducto = new System.Windows.Forms.Label();
            this.errIngresoDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-157, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Detalle usuario";
            // 
            // lblTituloListaProd
            // 
            this.lblTituloListaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTituloListaProd.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaProd.ForeColor = System.Drawing.Color.White;
            this.lblTituloListaProd.Location = new System.Drawing.Point(213, 0);
            this.lblTituloListaProd.Name = "lblTituloListaProd";
            this.lblTituloListaProd.Size = new System.Drawing.Size(609, 42);
            this.lblTituloListaProd.TabIndex = 26;
            this.lblTituloListaProd.Text = "Lista de Productos";
            this.lblTituloListaProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvRegistrarProducto
            // 
            this.dgvRegistrarProducto.AllowUserToAddRows = false;
            this.dgvRegistrarProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrarProducto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistrarProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistrarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProducto,
            this.categoria,
            this.colCosto,
            this.precioVenta});
            this.dgvRegistrarProducto.Location = new System.Drawing.Point(213, 45);
            this.dgvRegistrarProducto.MultiSelect = false;
            this.dgvRegistrarProducto.Name = "dgvRegistrarProducto";
            this.dgvRegistrarProducto.ReadOnly = true;
            this.dgvRegistrarProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRegistrarProducto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistrarProducto.RowTemplate.Height = 28;
            this.dgvRegistrarProducto.Size = new System.Drawing.Size(609, 440);
            this.dgvRegistrarProducto.TabIndex = 25;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // colCosto
            // 
            this.colCosto.HeaderText = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.ReadOnly = true;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            // 
            // lblRegistroProducto
            // 
            this.lblRegistroProducto.BackColor = System.Drawing.Color.White;
            this.lblRegistroProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistroProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRegistroProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRegistroProducto.Location = new System.Drawing.Point(0, 0);
            this.lblRegistroProducto.Name = "lblRegistroProducto";
            this.lblRegistroProducto.Size = new System.Drawing.Size(214, 485);
            this.lblRegistroProducto.TabIndex = 24;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.BackColor = System.Drawing.Color.White;
            this.lblNombreProducto.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNombreProducto.Location = new System.Drawing.Point(10, 56);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(139, 17);
            this.lblNombreProducto.TabIndex = 28;
            this.lblNombreProducto.Text = "Nombre del producto";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.White;
            this.lblCategoria.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCategoria.Location = new System.Drawing.Point(10, 94);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 17);
            this.lblCategoria.TabIndex = 29;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.White;
            this.lblDescripcion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(10, 133);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 17);
            this.lblDescripcion.TabIndex = 30;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.BackColor = System.Drawing.Color.White;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPrecioVenta.Location = new System.Drawing.Point(10, 173);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(84, 17);
            this.lblPrecioVenta.TabIndex = 31;
            this.lblPrecioVenta.Text = "Precio venta";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.White;
            this.lblCosto.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCosto.Location = new System.Drawing.Point(10, 211);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(44, 17);
            this.lblCosto.TabIndex = 32;
            this.lblCosto.Text = "Costo";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.White;
            this.lblStock.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblStock.Location = new System.Drawing.Point(10, 250);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 33;
            this.lblStock.Text = "Stock";
            // 
            // txtStockProd
            // 
            this.txtStockProd.Location = new System.Drawing.Point(10, 265);
            this.txtStockProd.Name = "txtStockProd";
            this.txtStockProd.Size = new System.Drawing.Size(190, 20);
            this.txtStockProd.TabIndex = 34;
            // 
            // txtPrecioVentaProd
            // 
            this.txtPrecioVentaProd.Location = new System.Drawing.Point(10, 189);
            this.txtPrecioVentaProd.Name = "txtPrecioVentaProd";
            this.txtPrecioVentaProd.Size = new System.Drawing.Size(190, 20);
            this.txtPrecioVentaProd.TabIndex = 35;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(11, 72);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(189, 20);
            this.txtNombreProd.TabIndex = 38;
            // 
            // cboCategoriaProd
            // 
            this.cboCategoriaProd.FormattingEnabled = true;
            this.cboCategoriaProd.Location = new System.Drawing.Point(10, 110);
            this.cboCategoriaProd.Name = "cboCategoriaProd";
            this.cboCategoriaProd.Size = new System.Drawing.Size(190, 21);
            this.cboCategoriaProd.TabIndex = 39;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 16;
            this.btnCancelar.Location = new System.Drawing.Point(11, 401);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(189, 37);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Location = new System.Drawing.Point(10, 358);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(189, 37);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblRegistrarProducto
            // 
            this.lblRegistrarProducto.AutoSize = true;
            this.lblRegistrarProducto.BackColor = System.Drawing.Color.White;
            this.lblRegistrarProducto.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblRegistrarProducto.Location = new System.Drawing.Point(11, 11);
            this.lblRegistrarProducto.Name = "lblRegistrarProducto";
            this.lblRegistrarProducto.Size = new System.Drawing.Size(165, 23);
            this.lblRegistrarProducto.TabIndex = 43;
            this.lblRegistrarProducto.Text = "Registrar Producto";
            // 
            // errIngresoDatos
            // 
            this.errIngresoDatos.ContainerControl = this;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(748, 436);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 20);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(10, 150);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(189, 20);
            this.txtDescripcion.TabIndex = 44;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(10, 227);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(189, 20);
            this.txtCosto.TabIndex = 45;
            // 
            // frmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 485);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegistrarProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboCategoriaProd);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.txtPrecioVentaProd);
            this.Controls.Add(this.txtStockProd);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTituloListaProd);
            this.Controls.Add(this.dgvRegistrarProducto);
            this.Controls.Add(this.lblRegistroProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label11;
        private Label lblTituloListaProd;
        private DataGridView dgvRegistrarProducto;
        private Label lblRegistroProducto;
        private Label lblNombreProducto;
        private Label lblCategoria;
        private Label lblDescripcion;
        private Label lblPrecioVenta;
        private Label lblCosto;
        private Label lblStock;
        private TextBox txtStockProd;
        private TextBox txtPrecioVentaProd;
        private TextBox txtCostoProd;
        private TextBox txtDescripcionProd;
        private TextBox txtNombreProd;
        private ComboBox cboCategoriaProd;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblRegistrarProducto;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn colCosto;
        private DataGridViewTextBoxColumn precioVenta;
        private ErrorProvider errIngresoDatos;
        private Button btnSalir;
        private TextBox txtCosto;
        private TextBox txtDescripcion;
    }
}