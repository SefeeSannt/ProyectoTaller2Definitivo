﻿namespace ProyectoTaller2Definitivo.Vistas.Vendedor
{
    partial class frmVistaVendedor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imiSalir = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiListarProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaProd = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiAltaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiDetalleVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetalleCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.pntCabecera = new System.Windows.Forms.Panel();
            this.lblNombreRegistro = new System.Windows.Forms.Label();
            this.lblTituloAdm = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.menuStrip1.SuspendLayout();
            this.pntCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(166)))), ((int)(((byte)(54)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imiSalir,
            this.iconMenuItem1,
            this.iconMenuItem2,
            this.iconMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(944, 52);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imiSalir
            // 
            this.imiSalir.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imiSalir.ForeColor = System.Drawing.Color.White;
            this.imiSalir.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.imiSalir.IconColor = System.Drawing.Color.White;
            this.imiSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiSalir.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.imiSalir.Name = "imiSalir";
            this.imiSalir.Size = new System.Drawing.Size(61, 38);
            this.imiSalir.Text = "Salir";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListarProd,
            this.tsmiAltaProd});
            this.iconMenuItem1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconMenuItem1.IconColor = System.Drawing.Color.White;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.iconMenuItem1.Size = new System.Drawing.Size(94, 38);
            this.iconMenuItem1.Text = "Productos";
            // 
            // tsmiListarProd
            // 
            this.tsmiListarProd.Name = "tsmiListarProd";
            this.tsmiListarProd.Size = new System.Drawing.Size(142, 22);
            this.tsmiListarProd.Text = "Listar";
            // 
            // tsmiAltaProd
            // 
            this.tsmiAltaProd.Name = "tsmiAltaProd";
            this.tsmiAltaProd.Size = new System.Drawing.Size(142, 22);
            this.tsmiAltaProd.Text = "Dar de alta";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaUsuario,
            this.tsmiListarUsuarios});
            this.iconMenuItem2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem2.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconMenuItem2.IconColor = System.Drawing.Color.White;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.iconMenuItem2.Size = new System.Drawing.Size(84, 38);
            this.iconMenuItem2.Text = "Usuarios";
            // 
            // tsmiAltaUsuario
            // 
            this.tsmiAltaUsuario.Name = "tsmiAltaUsuario";
            this.tsmiAltaUsuario.Size = new System.Drawing.Size(142, 22);
            this.tsmiAltaUsuario.Text = "Dar de alta";
            // 
            // tsmiListarUsuarios
            // 
            this.tsmiListarUsuarios.Name = "tsmiListarUsuarios";
            this.tsmiListarUsuarios.Size = new System.Drawing.Size(142, 22);
            this.tsmiListarUsuarios.Text = "Listar";
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDetalleVentas,
            this.tsmiDetalleCompras});
            this.iconMenuItem3.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem3.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.RectangleList;
            this.iconMenuItem3.IconColor = System.Drawing.Color.White;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(90, 38);
            this.iconMenuItem3.Text = "Reportes";
            // 
            // tsmiDetalleVentas
            // 
            this.tsmiDetalleVentas.Name = "tsmiDetalleVentas";
            this.tsmiDetalleVentas.Size = new System.Drawing.Size(194, 22);
            this.tsmiDetalleVentas.Text = "Detalle de Ventas";
            // 
            // tsmiDetalleCompras
            // 
            this.tsmiDetalleCompras.Name = "tsmiDetalleCompras";
            this.tsmiDetalleCompras.Size = new System.Drawing.Size(194, 22);
            this.tsmiDetalleCompras.Text = "Detalle de Compras";
            // 
            // pntCabecera
            // 
            this.pntCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(37)))));
            this.pntCabecera.Controls.Add(this.lblNombreRegistro);
            this.pntCabecera.Controls.Add(this.lblTituloAdm);
            this.pntCabecera.Controls.Add(this.lblTitulo);
            this.pntCabecera.Controls.Add(this.iconButton1);
            this.pntCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntCabecera.Location = new System.Drawing.Point(0, 0);
            this.pntCabecera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pntCabecera.Name = "pntCabecera";
            this.pntCabecera.Size = new System.Drawing.Size(944, 70);
            this.pntCabecera.TabIndex = 11;
            // 
            // lblNombreRegistro
            // 
            this.lblNombreRegistro.AutoSize = true;
            this.lblNombreRegistro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRegistro.ForeColor = System.Drawing.Color.White;
            this.lblNombreRegistro.Location = new System.Drawing.Point(811, 24);
            this.lblNombreRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreRegistro.Name = "lblNombreRegistro";
            this.lblNombreRegistro.Size = new System.Drawing.Size(129, 19);
            this.lblNombreRegistro.TabIndex = 12;
            this.lblNombreRegistro.Text = "nombreCompleto";
            // 
            // lblTituloAdm
            // 
            this.lblTituloAdm.AutoSize = true;
            this.lblTituloAdm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAdm.ForeColor = System.Drawing.Color.White;
            this.lblTituloAdm.Location = new System.Drawing.Point(711, 24);
            this.lblTituloAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloAdm.Name = "lblTituloAdm";
            this.lblTituloAdm.Size = new System.Drawing.Size(75, 19);
            this.lblTituloAdm.TabIndex = 11;
            this.lblTituloAdm.Text = "Vendedor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Ink Free", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(183, 29);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Tienda zonafitt";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(37)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 22;
            this.iconButton1.Location = new System.Drawing.Point(680, 18);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 33);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // frmVistaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 621);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pntCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmVistaVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVistaVendedor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pntCabecera.ResumeLayout(false);
            this.pntCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem imiSalir;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarProd;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaProd;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarUsuarios;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetalleVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetalleCompras;
        private System.Windows.Forms.Panel pntCabecera;
        private System.Windows.Forms.Label lblNombreRegistro;
        private System.Windows.Forms.Label lblTituloAdm;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}