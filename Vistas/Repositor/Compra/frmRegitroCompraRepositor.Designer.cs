﻿namespace ProyectoTaller2Definitivo.Vistas.Repositor
{
    partial class frmRegitroCompraRepositor
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
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.dgvRegistroCompras = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.gbInfProducto = new System.Windows.Forms.GroupBox();
            this.iconBtnLupa = new FontAwesome.Sharp.IconButton();
            this.numUpDCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtprecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.gbInforProveedor = new System.Windows.Forms.GroupBox();
            this.iconButtonLupa = new FontAwesome.Sharp.IconButton();
            this.cbRazonSocial = new System.Windows.Forms.ComboBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblTutulo = new System.Windows.Forms.Label();
            this.gbInfCompra = new System.Windows.Forms.GroupBox();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.errIngresoDatos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).BeginInit();
            this.gbInfProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCantidad)).BeginInit();
            this.gbInforProveedor.SuspendLayout();
            this.gbInfCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Blue;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnRegistrar.IconColor = System.Drawing.Color.White;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 15;
            this.btnRegistrar.Location = new System.Drawing.Point(639, 497);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 29);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPagar.Location = new System.Drawing.Point(639, 462);
            this.txtTotalPagar.Multiline = true;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(132, 29);
            this.txtTotalPagar.TabIndex = 16;
            this.txtTotalPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noWrite_KeyPress);
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(636, 442);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(83, 17);
            this.lblTotalPagar.TabIndex = 19;
            this.lblTotalPagar.Text = "Total a pagar:";
            // 
            // dgvRegistroCompras
            // 
            this.dgvRegistroCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistroCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistroCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistroCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.PrecioCompra,
            this.cantidad,
            this.subTotal});
            this.dgvRegistroCompras.Location = new System.Drawing.Point(7, 254);
            this.dgvRegistroCompras.Name = "dgvRegistroCompras";
            this.dgvRegistroCompras.ReadOnly = true;
            this.dgvRegistroCompras.Size = new System.Drawing.Size(623, 272);
            this.dgvRegistroCompras.TabIndex = 18;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.Green;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(723, 150);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 80);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar Compra";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // gbInfProducto
            // 
            this.gbInfProducto.Controls.Add(this.iconBtnLupa);
            this.gbInfProducto.Controls.Add(this.numUpDCantidad);
            this.gbInfProducto.Controls.Add(this.lblCantidad);
            this.gbInfProducto.Controls.Add(this.txtprecioVenta);
            this.gbInfProducto.Controls.Add(this.lblPrecioVenta);
            this.gbInfProducto.Controls.Add(this.txtPrecioCompra);
            this.gbInfProducto.Controls.Add(this.lblPrecioCompra);
            this.gbInfProducto.Controls.Add(this.txtProductos);
            this.gbInfProducto.Controls.Add(this.txtCodProducto);
            this.gbInfProducto.Controls.Add(this.lblProductos);
            this.gbInfProducto.Controls.Add(this.lblCodProducto);
            this.gbInfProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfProducto.Location = new System.Drawing.Point(2, 143);
            this.gbInfProducto.Name = "gbInfProducto";
            this.gbInfProducto.Size = new System.Drawing.Size(710, 87);
            this.gbInfProducto.TabIndex = 14;
            this.gbInfProducto.TabStop = false;
            this.gbInfProducto.Text = "Información de Producto";
            // 
            // iconBtnLupa
            // 
            this.iconBtnLupa.BackColor = System.Drawing.Color.Silver;
            this.iconBtnLupa.FlatAppearance.BorderSize = 0;
            this.iconBtnLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnLupa.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBtnLupa.IconColor = System.Drawing.Color.Black;
            this.iconBtnLupa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnLupa.IconSize = 15;
            this.iconBtnLupa.Location = new System.Drawing.Point(125, 57);
            this.iconBtnLupa.Name = "iconBtnLupa";
            this.iconBtnLupa.Size = new System.Drawing.Size(42, 23);
            this.iconBtnLupa.TabIndex = 5;
            this.iconBtnLupa.UseVisualStyleBackColor = false;
            // 
            // numUpDCantidad
            // 
            this.numUpDCantidad.Location = new System.Drawing.Point(576, 58);
            this.numUpDCantidad.Name = "numUpDCantidad";
            this.numUpDCantidad.Size = new System.Drawing.Size(120, 22);
            this.numUpDCantidad.TabIndex = 9;
            this.numUpDCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(573, 42);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 17);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtprecioVenta
            // 
            this.txtprecioVenta.Location = new System.Drawing.Point(470, 58);
            this.txtprecioVenta.Name = "txtprecioVenta";
            this.txtprecioVenta.Size = new System.Drawing.Size(100, 22);
            this.txtprecioVenta.TabIndex = 7;
            this.txtprecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(467, 42);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(81, 17);
            this.lblPrecioVenta.TabIndex = 6;
            this.lblPrecioVenta.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(364, 58);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioCompra.TabIndex = 5;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(361, 42);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(93, 17);
            this.lblPrecioCompra.TabIndex = 4;
            this.lblPrecioCompra.Text = "Precio Compra:";
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(182, 57);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(173, 22);
            this.txtProductos.TabIndex = 3;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(19, 58);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(100, 22);
            this.txtCodProducto.TabIndex = 2;
            this.txtCodProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger_KeyPress);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(179, 37);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(64, 17);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Productos";
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(16, 42);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(86, 17);
            this.lblCodProducto.TabIndex = 0;
            this.lblCodProducto.Text = "Cod. Producto";
            // 
            // gbInforProveedor
            // 
            this.gbInforProveedor.Controls.Add(this.iconButtonLupa);
            this.gbInforProveedor.Controls.Add(this.cbRazonSocial);
            this.gbInforProveedor.Controls.Add(this.txtNumDoc);
            this.gbInforProveedor.Controls.Add(this.lblRazonSocial);
            this.gbInforProveedor.Controls.Add(this.lblNumDoc);
            this.gbInforProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInforProveedor.Location = new System.Drawing.Point(377, 50);
            this.gbInforProveedor.Name = "gbInforProveedor";
            this.gbInforProveedor.Size = new System.Drawing.Size(421, 87);
            this.gbInforProveedor.TabIndex = 15;
            this.gbInforProveedor.TabStop = false;
            this.gbInforProveedor.Text = "Información Proveedor";
            // 
            // iconButtonLupa
            // 
            this.iconButtonLupa.BackColor = System.Drawing.Color.Silver;
            this.iconButtonLupa.FlatAppearance.BorderSize = 0;
            this.iconButtonLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLupa.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButtonLupa.IconColor = System.Drawing.Color.Black;
            this.iconButtonLupa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLupa.IconSize = 15;
            this.iconButtonLupa.Location = new System.Drawing.Point(192, 53);
            this.iconButtonLupa.Name = "iconButtonLupa";
            this.iconButtonLupa.Size = new System.Drawing.Size(42, 27);
            this.iconButtonLupa.TabIndex = 4;
            this.iconButtonLupa.UseVisualStyleBackColor = false;
            // 
            // cbRazonSocial
            // 
            this.cbRazonSocial.FormattingEnabled = true;
            this.cbRazonSocial.Items.AddRange(new object[] {
            "opcion1",
            "opcion2"});
            this.cbRazonSocial.Location = new System.Drawing.Point(240, 55);
            this.cbRazonSocial.Name = "cbRazonSocial";
            this.cbRazonSocial.Size = new System.Drawing.Size(154, 25);
            this.cbRazonSocial.TabIndex = 3;
            this.cbRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noWrite_KeyPress);
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(19, 55);
            this.txtNumDoc.Multiline = true;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(151, 23);
            this.txtNumDoc.TabIndex = 2;
            this.txtNumDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger_KeyPress);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(237, 35);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(77, 17);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razón social";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDoc.Location = new System.Drawing.Point(16, 35);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(121, 17);
            this.lblNumDoc.TabIndex = 0;
            this.lblNumDoc.Text = "Número documento:";
            // 
            // lblTutulo
            // 
            this.lblTutulo.AutoSize = true;
            this.lblTutulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutulo.Location = new System.Drawing.Point(2, 11);
            this.lblTutulo.Name = "lblTutulo";
            this.lblTutulo.Size = new System.Drawing.Size(170, 26);
            this.lblTutulo.TabIndex = 13;
            this.lblTutulo.Text = "Registrar Compra";
            // 
            // gbInfCompra
            // 
            this.gbInfCompra.Controls.Add(this.cbTipoDoc);
            this.gbInfCompra.Controls.Add(this.txtFecha);
            this.gbInfCompra.Controls.Add(this.lblTipoDoc);
            this.gbInfCompra.Controls.Add(this.lblFecha);
            this.gbInfCompra.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfCompra.Location = new System.Drawing.Point(2, 50);
            this.gbInfCompra.Name = "gbInfCompra";
            this.gbInfCompra.Size = new System.Drawing.Size(355, 87);
            this.gbInfCompra.TabIndex = 12;
            this.gbInfCompra.TabStop = false;
            this.gbInfCompra.Text = "Información Compra";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(173, 53);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(172, 25);
            this.cbTipoDoc.TabIndex = 3;
            this.cbTipoDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noWrite_KeyPress);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(19, 53);
            this.txtFecha.Multiline = true;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(148, 23);
            this.txtFecha.TabIndex = 2;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(174, 35);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(102, 17);
            this.lblTipoDoc.TabIndex = 1;
            this.lblTipoDoc.Text = "Tipo Documento:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(16, 35);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 17);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // errIngresoDatos
            // 
            this.errIngresoDatos.ContainerControl = this;
            // 
            // frmRegitroCompraRepositor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.dgvRegistroCompras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbInfProducto);
            this.Controls.Add(this.gbInforProveedor);
            this.Controls.Add(this.lblTutulo);
            this.Controls.Add(this.gbInfCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegitroCompraRepositor";
            this.Text = "frmRegitroCompraRepositor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).EndInit();
            this.gbInfProducto.ResumeLayout(false);
            this.gbInfProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCantidad)).EndInit();
            this.gbInforProveedor.ResumeLayout(false);
            this.gbInforProveedor.PerformLayout();
            this.gbInfCompra.ResumeLayout(false);
            this.gbInfCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRegistrar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.DataGridView dgvRegistroCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.GroupBox gbInfProducto;
        private FontAwesome.Sharp.IconButton iconBtnLupa;
        private System.Windows.Forms.NumericUpDown numUpDCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtprecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.GroupBox gbInforProveedor;
        private FontAwesome.Sharp.IconButton iconButtonLupa;
        private System.Windows.Forms.ComboBox cbRazonSocial;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblTutulo;
        private System.Windows.Forms.GroupBox gbInfCompra;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ErrorProvider errIngresoDatos;
    }
}