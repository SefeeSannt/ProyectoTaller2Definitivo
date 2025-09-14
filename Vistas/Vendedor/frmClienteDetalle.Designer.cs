﻿namespace ProyectoTaller2Definitivo.Vistas.Vendedor
{
    partial class frmClienteDetalle
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
            this.lblTotalClienteRegistrados = new System.Windows.Forms.Label();
            this.lblClienteRegistrados = new System.Windows.Forms.Label();
            this.cbFiltrarEstadoCliente = new System.Windows.Forms.ComboBox();
            this.txtClienteBuscarPor = new System.Windows.Forms.TextBox();
            this.lblFiltroEstadoCliente = new System.Windows.Forms.Label();
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.lblClientesReegistrados = new System.Windows.Forms.Label();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            this.dgvDetalleCliente = new System.Windows.Forms.DataGridView();
            this.numDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalClienteRegistrados
            // 
            this.lblTotalClienteRegistrados.AutoSize = true;
            this.lblTotalClienteRegistrados.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClienteRegistrados.Location = new System.Drawing.Point(199, 385);
            this.lblTotalClienteRegistrados.Name = "lblTotalClienteRegistrados";
            this.lblTotalClienteRegistrados.Size = new System.Drawing.Size(16, 17);
            this.lblTotalClienteRegistrados.TabIndex = 23;
            this.lblTotalClienteRegistrados.Text = "0";
            // 
            // lblClienteRegistrados
            // 
            this.lblClienteRegistrados.AutoSize = true;
            this.lblClienteRegistrados.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteRegistrados.Location = new System.Drawing.Point(23, 385);
            this.lblClienteRegistrados.Name = "lblClienteRegistrados";
            this.lblClienteRegistrados.Size = new System.Drawing.Size(170, 17);
            this.lblClienteRegistrados.TabIndex = 22;
            this.lblClienteRegistrados.Text = "Total de usuarios registrados:";
            // 
            // cbFiltrarEstadoCliente
            // 
            this.cbFiltrarEstadoCliente.FormattingEnabled = true;
            this.cbFiltrarEstadoCliente.Location = new System.Drawing.Point(300, 81);
            this.cbFiltrarEstadoCliente.Name = "cbFiltrarEstadoCliente";
            this.cbFiltrarEstadoCliente.Size = new System.Drawing.Size(239, 21);
            this.cbFiltrarEstadoCliente.TabIndex = 21;
            // 
            // txtClienteBuscarPor
            // 
            this.txtClienteBuscarPor.Location = new System.Drawing.Point(26, 83);
            this.txtClienteBuscarPor.Multiline = true;
            this.txtClienteBuscarPor.Name = "txtClienteBuscarPor";
            this.txtClienteBuscarPor.Size = new System.Drawing.Size(197, 19);
            this.txtClienteBuscarPor.TabIndex = 19;
            // 
            // lblFiltroEstadoCliente
            // 
            this.lblFiltroEstadoCliente.AutoSize = true;
            this.lblFiltroEstadoCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroEstadoCliente.Location = new System.Drawing.Point(297, 64);
            this.lblFiltroEstadoCliente.Name = "lblFiltroEstadoCliente";
            this.lblFiltroEstadoCliente.Size = new System.Drawing.Size(105, 17);
            this.lblFiltroEstadoCliente.TabIndex = 18;
            this.lblFiltroEstadoCliente.Text = "Filtrar por estado:";
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNombre.Location = new System.Drawing.Point(23, 67);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(116, 17);
            this.lblBuscarNombre.TabIndex = 16;
            this.lblBuscarNombre.Text = "Buscar por nombre:";
            // 
            // lblClientesReegistrados
            // 
            this.lblClientesReegistrados.AutoSize = true;
            this.lblClientesReegistrados.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesReegistrados.Location = new System.Drawing.Point(21, 8);
            this.lblClientesReegistrados.Name = "lblClientesReegistrados";
            this.lblClientesReegistrados.Size = new System.Drawing.Size(197, 26);
            this.lblClientesReegistrados.TabIndex = 15;
            this.lblClientesReegistrados.Text = "Clientes Registrados";
            // 
            // iconBtnLupaDetalleUser
            // 
            this.iconBtnLupaDetalleUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconBtnLupaDetalleUser.FlatAppearance.BorderSize = 0;
            this.iconBtnLupaDetalleUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnLupaDetalleUser.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBtnLupaDetalleUser.IconColor = System.Drawing.Color.White;
            this.iconBtnLupaDetalleUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnLupaDetalleUser.IconSize = 19;
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(229, 83);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(41, 21);
            this.iconBtnLupaDetalleUser.TabIndex = 14;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            // 
            // dgvDetalleCliente
            // 
            this.dgvDetalleCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDocumento,
            this.nombreCompleto,
            this.telefono,
            this.estado});
            this.dgvDetalleCliente.Location = new System.Drawing.Point(26, 118);
            this.dgvDetalleCliente.Name = "dgvDetalleCliente";
            this.dgvDetalleCliente.RowHeadersVisible = false;
            this.dgvDetalleCliente.Size = new System.Drawing.Size(737, 255);
            this.dgvDetalleCliente.TabIndex = 13;
            // 
            // numDocumento
            // 
            this.numDocumento.HeaderText = "Documento";
            this.numDocumento.Name = "numDocumento";
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.HeaderText = "Nombre completo";
            this.nombreCompleto.Name = "nombreCompleto";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // frmClienteDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lblTotalClienteRegistrados);
            this.Controls.Add(this.lblClienteRegistrados);
            this.Controls.Add(this.cbFiltrarEstadoCliente);
            this.Controls.Add(this.txtClienteBuscarPor);
            this.Controls.Add(this.lblFiltroEstadoCliente);
            this.Controls.Add(this.lblBuscarNombre);
            this.Controls.Add(this.lblClientesReegistrados);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.dgvDetalleCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClienteDetalle";
            this.Text = "frmClienteDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalClienteRegistrados;
        private System.Windows.Forms.Label lblClienteRegistrados;
        private System.Windows.Forms.ComboBox cbFiltrarEstadoCliente;
        private System.Windows.Forms.TextBox txtClienteBuscarPor;
        private System.Windows.Forms.Label lblFiltroEstadoCliente;
        private System.Windows.Forms.Label lblBuscarNombre;
        private System.Windows.Forms.Label lblClientesReegistrados;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private System.Windows.Forms.DataGridView dgvDetalleCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}