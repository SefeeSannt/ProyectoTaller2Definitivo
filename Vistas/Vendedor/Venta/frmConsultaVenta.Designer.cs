namespace ProyectoTaller2Definitivo.Vistas.Vendedor
{
    partial class frmConsultaVenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbVendedor_Ventas = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaConsVentas = new System.Windows.Forms.Label();
            this.txtProduc_Ventas = new System.Windows.Forms.TextBox();
            this.lblVendedorConstVentas = new System.Windows.Forms.Label();
            this.txtCliente_Ventas = new System.Windows.Forms.TextBox();
            this.lblProdOCategoria = new System.Windows.Forms.Label();
            this.lblClienteConsVentas = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloCantidad = new System.Windows.Forms.Label();
            this.lblTotalVentaFilt = new System.Windows.Forms.Label();
            this.lblTituloTotalVentas = new System.Windows.Forms.Label();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.dgvConsultaVentas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cbVendedor_Ventas);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblFechaConsVentas);
            this.panel1.Controls.Add(this.txtProduc_Ventas);
            this.panel1.Controls.Add(this.lblVendedorConstVentas);
            this.panel1.Controls.Add(this.txtCliente_Ventas);
            this.panel1.Controls.Add(this.lblProdOCategoria);
            this.panel1.Controls.Add(this.lblClienteConsVentas);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 183);
            this.panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Blue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(6, 139);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 30);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cbVendedor_Ventas
            // 
            this.cbVendedor_Ventas.FormattingEnabled = true;
            this.cbVendedor_Ventas.Location = new System.Drawing.Point(194, 30);
            this.cbVendedor_Ventas.Name = "cbVendedor_Ventas";
            this.cbVendedor_Ventas.Size = new System.Drawing.Size(184, 21);
            this.cbVendedor_Ventas.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.TabStop = false;
            // 
            // lblFechaConsVentas
            // 
            this.lblFechaConsVentas.AutoSize = true;
            this.lblFechaConsVentas.BackColor = System.Drawing.Color.White;
            this.lblFechaConsVentas.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaConsVentas.Location = new System.Drawing.Point(10, 11);
            this.lblFechaConsVentas.Name = "lblFechaConsVentas";
            this.lblFechaConsVentas.Size = new System.Drawing.Size(42, 17);
            this.lblFechaConsVentas.TabIndex = 9;
            this.lblFechaConsVentas.Text = "Fecha";
            // 
            // txtProduc_Ventas
            // 
            this.txtProduc_Ventas.Location = new System.Drawing.Point(194, 95);
            this.txtProduc_Ventas.Name = "txtProduc_Ventas";
            this.txtProduc_Ventas.Size = new System.Drawing.Size(184, 20);
            this.txtProduc_Ventas.TabIndex = 12;
            // 
            // lblVendedorConstVentas
            // 
            this.lblVendedorConstVentas.AutoSize = true;
            this.lblVendedorConstVentas.BackColor = System.Drawing.Color.White;
            this.lblVendedorConstVentas.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorConstVentas.Location = new System.Drawing.Point(191, 15);
            this.lblVendedorConstVentas.Name = "lblVendedorConstVentas";
            this.lblVendedorConstVentas.Size = new System.Drawing.Size(61, 17);
            this.lblVendedorConstVentas.TabIndex = 7;
            this.lblVendedorConstVentas.Text = "Vendedor";
            // 
            // txtCliente_Ventas
            // 
            this.txtCliente_Ventas.Location = new System.Drawing.Point(11, 95);
            this.txtCliente_Ventas.Name = "txtCliente_Ventas";
            this.txtCliente_Ventas.Size = new System.Drawing.Size(159, 20);
            this.txtCliente_Ventas.TabIndex = 11;
            // 
            // lblProdOCategoria
            // 
            this.lblProdOCategoria.AutoSize = true;
            this.lblProdOCategoria.BackColor = System.Drawing.Color.White;
            this.lblProdOCategoria.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdOCategoria.Location = new System.Drawing.Point(191, 79);
            this.lblProdOCategoria.Name = "lblProdOCategoria";
            this.lblProdOCategoria.Size = new System.Drawing.Size(125, 17);
            this.lblProdOCategoria.TabIndex = 6;
            this.lblProdOCategoria.Text = "Producto o Categoria";
            // 
            // lblClienteConsVentas
            // 
            this.lblClienteConsVentas.AutoSize = true;
            this.lblClienteConsVentas.BackColor = System.Drawing.Color.White;
            this.lblClienteConsVentas.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteConsVentas.Location = new System.Drawing.Point(10, 79);
            this.lblClienteConsVentas.Name = "lblClienteConsVentas";
            this.lblClienteConsVentas.Size = new System.Drawing.Size(47, 17);
            this.lblClienteConsVentas.TabIndex = 8;
            this.lblClienteConsVentas.Text = "Cliente";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 462);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(404, 64);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta Ventas";
            // 
            // lblTituloCantidad
            // 
            this.lblTituloCantidad.AutoSize = true;
            this.lblTituloCantidad.BackColor = System.Drawing.Color.White;
            this.lblTituloCantidad.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCantidad.Location = new System.Drawing.Point(16, 497);
            this.lblTituloCantidad.Name = "lblTituloCantidad";
            this.lblTituloCantidad.Size = new System.Drawing.Size(118, 17);
            this.lblTituloCantidad.TabIndex = 3;
            this.lblTituloCantidad.Text = "Cantidad de ventas:";
            // 
            // lblTotalVentaFilt
            // 
            this.lblTotalVentaFilt.AutoSize = true;
            this.lblTotalVentaFilt.BackColor = System.Drawing.Color.White;
            this.lblTotalVentaFilt.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentaFilt.Location = new System.Drawing.Point(159, 468);
            this.lblTotalVentaFilt.Name = "lblTotalVentaFilt";
            this.lblTotalVentaFilt.Size = new System.Drawing.Size(58, 23);
            this.lblTotalVentaFilt.TabIndex = 4;
            this.lblTotalVentaFilt.Text = "$0.00";
            // 
            // lblTituloTotalVentas
            // 
            this.lblTituloTotalVentas.AutoSize = true;
            this.lblTituloTotalVentas.BackColor = System.Drawing.Color.White;
            this.lblTituloTotalVentas.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalVentas.Location = new System.Drawing.Point(16, 474);
            this.lblTituloTotalVentas.Name = "lblTituloTotalVentas";
            this.lblTituloTotalVentas.Size = new System.Drawing.Size(126, 17);
            this.lblTituloTotalVentas.TabIndex = 5;
            this.lblTituloTotalVentas.Text = "Total ventas filtradas:";
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.BackColor = System.Drawing.Color.White;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.Location = new System.Drawing.Point(159, 497);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(58, 23);
            this.lblCantidadVentas.TabIndex = 14;
            this.lblCantidadVentas.Text = "$0.00";
            // 
            // dgvConsultaVentas
            // 
            this.dgvConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVentas.Location = new System.Drawing.Point(12, 230);
            this.dgvConsultaVentas.Name = "dgvConsultaVentas";
            this.dgvConsultaVentas.Size = new System.Drawing.Size(404, 226);
            this.dgvConsultaVentas.TabIndex = 15;
            // 
            // frmConsultaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 538);
            this.Controls.Add(this.lblCantidadVentas);
            this.Controls.Add(this.lblTotalVentaFilt);
            this.Controls.Add(this.lblTituloTotalVentas);
            this.Controls.Add(this.lblTituloCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvConsultaVentas);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaVenta";
            this.Text = "frmConsultaVenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloCantidad;
        private System.Windows.Forms.Label lblTotalVentaFilt;
        private System.Windows.Forms.Label lblTituloTotalVentas;
        private System.Windows.Forms.Label lblProdOCategoria;
        private System.Windows.Forms.Label lblVendedorConstVentas;
        private System.Windows.Forms.Label lblClienteConsVentas;
        private System.Windows.Forms.Label lblFechaConsVentas;
        private System.Windows.Forms.ComboBox cbVendedor_Ventas;
        private System.Windows.Forms.TextBox txtCliente_Ventas;
        private System.Windows.Forms.TextBox txtProduc_Ventas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.DataGridView dgvConsultaVentas;
    }
}