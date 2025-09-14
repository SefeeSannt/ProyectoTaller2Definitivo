namespace ProyectoTaller2Definitivo.Vistas.Repositor
{
    partial class frmConsultaProveedores
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
            this.lblConsultaProveedores = new System.Windows.Forms.Label();
            this.lblDocumentoProveedor = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.iconBtnBuscarProv = new FontAwesome.Sharp.IconButton();
            this.dgvConsultaProveedores = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProveedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConsultaProveedores
            // 
            this.lblConsultaProveedores.AutoSize = true;
            this.lblConsultaProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblConsultaProveedores.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaProveedores.Location = new System.Drawing.Point(21, 30);
            this.lblConsultaProveedores.Name = "lblConsultaProveedores";
            this.lblConsultaProveedores.Size = new System.Drawing.Size(205, 26);
            this.lblConsultaProveedores.TabIndex = 0;
            this.lblConsultaProveedores.Text = "Consulta proveedores";
            // 
            // lblDocumentoProveedor
            // 
            this.lblDocumentoProveedor.AutoSize = true;
            this.lblDocumentoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDocumentoProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoProveedor.Location = new System.Drawing.Point(11, 114);
            this.lblDocumentoProveedor.Name = "lblDocumentoProveedor";
            this.lblDocumentoProveedor.Size = new System.Drawing.Size(73, 17);
            this.lblDocumentoProveedor.TabIndex = 1;
            this.lblDocumentoProveedor.Text = "Documento";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRubro.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.Location = new System.Drawing.Point(180, 114);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(41, 17);
            this.lblRubro.TabIndex = 3;
            this.lblRubro.Text = "Rubro";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNombreProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.Location = new System.Drawing.Point(11, 71);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(65, 17);
            this.lblNombreProveedor.TabIndex = 2;
            this.lblNombreProveedor.Text = "Proveedor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 20);
            this.textBox2.TabIndex = 6;
            // 
            // iconBtnBuscarProv
            // 
            this.iconBtnBuscarProv.BackColor = System.Drawing.Color.Blue;
            this.iconBtnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnBuscarProv.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBtnBuscarProv.IconColor = System.Drawing.Color.Black;
            this.iconBtnBuscarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnBuscarProv.IconSize = 15;
            this.iconBtnBuscarProv.Location = new System.Drawing.Point(344, 82);
            this.iconBtnBuscarProv.Name = "iconBtnBuscarProv";
            this.iconBtnBuscarProv.Size = new System.Drawing.Size(106, 29);
            this.iconBtnBuscarProv.TabIndex = 7;
            this.iconBtnBuscarProv.Text = "Buscar";
            this.iconBtnBuscarProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnBuscarProv.UseVisualStyleBackColor = false;
            // 
            // dgvConsultaProveedores
            // 
            this.dgvConsultaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultaProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConsultaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Documento,
            this.rubro,
            this.telefonoEmail});
            this.dgvConsultaProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvConsultaProveedores.Location = new System.Drawing.Point(12, 194);
            this.dgvConsultaProveedores.Name = "dgvConsultaProveedores";
            this.dgvConsultaProveedores.RowHeadersVisible = false;
            this.dgvConsultaProveedores.Size = new System.Drawing.Size(469, 244);
            this.dgvConsultaProveedores.TabIndex = 8;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            // 
            // rubro
            // 
            this.rubro.HeaderText = "Rubro";
            this.rubro.Name = "rubro";
            // 
            // telefonoEmail
            // 
            this.telefonoEmail.HeaderText = "Télefono/Email";
            this.telefonoEmail.Name = "telefonoEmail";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.lblNombreProveedor);
            this.panel1.Controls.Add(this.iconBtnBuscarProv);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblRubro);
            this.panel1.Controls.Add(this.lblDocumentoProveedor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 176);
            this.panel1.TabIndex = 9;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 15;
            this.iconButton1.Location = new System.Drawing.Point(344, 117);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(106, 29);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Limpiar filtros";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // frmConsultaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.dgvConsultaProveedores);
            this.Controls.Add(this.lblConsultaProveedores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaProveedores";
            this.Text = "frmConsultaProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaProveedores;
        private System.Windows.Forms.Label lblDocumentoProveedor;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton iconBtnBuscarProv;
        private System.Windows.Forms.DataGridView dgvConsultaProveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoEmail;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}