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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label11 = new Label();
            lblTituloListaProd = new Label();
            dgvRegistrarProducto = new DataGridView();
            nombreProducto = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            lblRegistroProducto = new Label();
            lblNombreProducto = new Label();
            lblCategoria = new Label();
            lblDescripcion = new Label();
            lblPrecioVenta = new Label();
            lblCosto = new Label();
            lblStock = new Label();
            txtStockProd = new TextBox();
            txtPrecioVentaProd = new TextBox();
            txtNombreProd = new TextBox();
            cboCategoriaProd = new ComboBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            lblRegistrarProducto = new Label();
            errIngresoDatos = new ErrorProvider(components);
            btnSalir = new Button();
            txtDescripcion = new TextBox();
            txtCosto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errIngresoDatos).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(64, 64, 64);
            label11.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(-183, 25);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(141, 25);
            label11.TabIndex = 27;
            label11.Text = "Detalle usuario";
            // 
            // lblTituloListaProd
            // 
            lblTituloListaProd.BackColor = Color.FromArgb(255, 128, 0);
            lblTituloListaProd.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloListaProd.ForeColor = Color.White;
            lblTituloListaProd.Location = new Point(249, 0);
            lblTituloListaProd.Margin = new Padding(4, 0, 4, 0);
            lblTituloListaProd.Name = "lblTituloListaProd";
            lblTituloListaProd.Size = new Size(711, 49);
            lblTituloListaProd.TabIndex = 26;
            lblTituloListaProd.Text = "Lista de Productos";
            lblTituloListaProd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvRegistrarProducto
            // 
            dgvRegistrarProducto.AllowUserToAddRows = false;
            dgvRegistrarProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistrarProducto.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistrarProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistrarProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistrarProducto.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, categoria, colCosto, precioVenta });
            dgvRegistrarProducto.Location = new Point(249, 52);
            dgvRegistrarProducto.Margin = new Padding(4, 3, 4, 3);
            dgvRegistrarProducto.MultiSelect = false;
            dgvRegistrarProducto.Name = "dgvRegistrarProducto";
            dgvRegistrarProducto.ReadOnly = true;
            dgvRegistrarProducto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvRegistrarProducto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistrarProducto.RowTemplate.Height = 28;
            dgvRegistrarProducto.Size = new Size(711, 508);
            dgvRegistrarProducto.TabIndex = 25;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre";
            nombreProducto.Name = "nombreProducto";
            nombreProducto.ReadOnly = true;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            // 
            // colCosto
            // 
            colCosto.HeaderText = "Costo";
            colCosto.Name = "colCosto";
            colCosto.ReadOnly = true;
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio Venta";
            precioVenta.Name = "precioVenta";
            precioVenta.ReadOnly = true;
            // 
            // lblRegistroProducto
            // 
            lblRegistroProducto.BackColor = Color.White;
            lblRegistroProducto.BorderStyle = BorderStyle.FixedSingle;
            lblRegistroProducto.Dock = DockStyle.Left;
            lblRegistroProducto.ForeColor = Color.FromArgb(224, 224, 224);
            lblRegistroProducto.Location = new Point(0, 0);
            lblRegistroProducto.Margin = new Padding(4, 0, 4, 0);
            lblRegistroProducto.Name = "lblRegistroProducto";
            lblRegistroProducto.Size = new Size(249, 560);
            lblRegistroProducto.TabIndex = 24;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.BackColor = Color.White;
            lblNombreProducto.Font = new Font("Tahoma", 10F);
            lblNombreProducto.Location = new Point(12, 65);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(139, 17);
            lblNombreProducto.TabIndex = 28;
            lblNombreProducto.Text = "Nombre del producto";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.White;
            lblCategoria.Font = new Font("Tahoma", 10F);
            lblCategoria.Location = new Point(12, 109);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(66, 17);
            lblCategoria.TabIndex = 29;
            lblCategoria.Text = "Categoria";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.White;
            lblDescripcion.Font = new Font("Tahoma", 10F);
            lblDescripcion.Location = new Point(12, 153);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(78, 17);
            lblDescripcion.TabIndex = 30;
            lblDescripcion.Text = "Descripción";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.BackColor = Color.White;
            lblPrecioVenta.Font = new Font("Tahoma", 10F);
            lblPrecioVenta.Location = new Point(12, 200);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(84, 17);
            lblPrecioVenta.TabIndex = 31;
            lblPrecioVenta.Text = "Precio venta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.BackColor = Color.White;
            lblCosto.Font = new Font("Tahoma", 10F);
            lblCosto.Location = new Point(12, 244);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(44, 17);
            lblCosto.TabIndex = 32;
            lblCosto.Text = "Costo";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.White;
            lblStock.Font = new Font("Tahoma", 10F);
            lblStock.Location = new Point(12, 288);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(43, 17);
            lblStock.TabIndex = 33;
            lblStock.Text = "Stock";
            // 
            // txtStockProd
            // 
            txtStockProd.Location = new Point(12, 306);
            txtStockProd.Name = "txtStockProd";
            txtStockProd.Size = new Size(221, 23);
            txtStockProd.TabIndex = 34;
            txtStockProd.KeyPress += onlyInteger_KeyPress;
            // 
            // txtPrecioVentaProd
            // 
            txtPrecioVentaProd.Location = new Point(12, 218);
            txtPrecioVentaProd.Name = "txtPrecioVentaProd";
            txtPrecioVentaProd.Size = new Size(221, 23);
            txtPrecioVentaProd.TabIndex = 35;
            txtPrecioVentaProd.KeyPress += onlyNumbers_KeyPress;
            // 
            // txtNombreProd
            // 
            txtNombreProd.Location = new Point(13, 83);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(220, 23);
            txtNombreProd.TabIndex = 38;
            txtNombreProd.KeyPress += onlyLetters_KeyPress;
            // 
            // cboCategoriaProd
            // 
            cboCategoriaProd.FormattingEnabled = true;
            cboCategoriaProd.Location = new Point(12, 127);
            cboCategoriaProd.Name = "cboCategoriaProd";
            cboCategoriaProd.Size = new Size(221, 23);
            cboCategoriaProd.TabIndex = 39;
            cboCategoriaProd.KeyPress += noWrite_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 16;
            btnCancelar.Location = new Point(13, 428);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 27);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Limpiar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 16;
            btnGuardar.Location = new Point(13, 461);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(220, 27);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblRegistrarProducto
            // 
            lblRegistrarProducto.AutoSize = true;
            lblRegistrarProducto.BackColor = Color.White;
            lblRegistrarProducto.Font = new Font("Tahoma", 14F);
            lblRegistrarProducto.Location = new Point(13, 13);
            lblRegistrarProducto.Name = "lblRegistrarProducto";
            lblRegistrarProducto.Size = new Size(165, 23);
            lblRegistrarProducto.TabIndex = 43;
            lblRegistrarProducto.Text = "Registrar Producto";
            // 
            // errIngresoDatos
            // 
            errIngresoDatos.ContainerControl = this;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(873, 503);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 173);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(220, 23);
            txtDescripcion.TabIndex = 44;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(12, 262);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(220, 23);
            txtCosto.TabIndex = 45;
            // 
            // frmAltaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 560);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(btnSalir);
            Controls.Add(lblRegistrarProducto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cboCategoriaProd);
            Controls.Add(txtNombreProd);
            Controls.Add(txtPrecioVentaProd);
            Controls.Add(txtStockProd);
            Controls.Add(lblStock);
            Controls.Add(lblCosto);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombreProducto);
            Controls.Add(label11);
            Controls.Add(lblTituloListaProd);
            Controls.Add(dgvRegistrarProducto);
            Controls.Add(lblRegistroProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAltaProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alta producto";
            ((System.ComponentModel.ISupportInitialize)dgvRegistrarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errIngresoDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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