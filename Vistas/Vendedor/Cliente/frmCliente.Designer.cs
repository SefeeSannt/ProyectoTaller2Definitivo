namespace ProyectoTaller2Definitivo.Vistas.Vendedor
{
    partial class frmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnCanecelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errIngresoDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbFiltrarListProd = new System.Windows.Forms.ComboBox();
            this.txtProdList = new System.Windows.Forms.TextBox();
            this.lblFiltroListProd = new System.Windows.Forms.Label();
            this.lblBuscarListProd = new System.Windows.Forms.Label();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 30);
            this.label11.TabIndex = 52;
            this.label11.Text = "Registro cliente";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowDrop = true;
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(261, 112);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.Size = new System.Drawing.Size(685, 454);
            this.dgvClientes.TabIndex = 50;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 136);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 49;
           
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyLetters);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(13, 84);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(210, 20);
            this.txtDocumento.TabIndex = 48;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nro. Documento: ";
            // 
            // pnlClientes
            // 
            this.pnlClientes.BackColor = System.Drawing.Color.White;
            this.pnlClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientes.Controls.Add(this.textBox1);
            this.pnlClientes.Controls.Add(this.label4);
            this.pnlClientes.Controls.Add(this.txtApellido);
            this.pnlClientes.Controls.Add(this.label1);
            this.pnlClientes.Controls.Add(this.btnCancelar);
            this.pnlClientes.Controls.Add(this.label11);
            this.pnlClientes.Controls.Add(this.btnCanecelar);
            this.pnlClientes.Controls.Add(this.btnGuardar);
            this.pnlClientes.Controls.Add(this.txtNombre);
            this.pnlClientes.Controls.Add(this.txtTelefono);
            this.pnlClientes.Controls.Add(this.txtDocumento);
            this.pnlClientes.Controls.Add(this.label3);
            this.pnlClientes.Controls.Add(this.lblDomicilio);
            this.pnlClientes.Controls.Add(this.label2);
            this.pnlClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlClientes.Location = new System.Drawing.Point(0, 0);
            this.pnlClientes.Margin = new System.Windows.Forms.Padding(4);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(244, 538);
            this.pnlClientes.TabIndex = 53;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 312);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(13, 191);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(210, 20);
            this.txtApellido.TabIndex = 55;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Apellido:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Blue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 16;
            this.btnCancelar.Location = new System.Drawing.Point(12, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(211, 37);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCanecelar
            // 
            this.btnCanecelar.BackColor = System.Drawing.Color.Red;
            this.btnCanecelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanecelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCanecelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanecelar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnCanecelar.IconColor = System.Drawing.Color.Black;
            this.btnCanecelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCanecelar.IconSize = 16;
            this.btnCanecelar.Location = new System.Drawing.Point(12, 404);
            this.btnCanecelar.Name = "btnCanecelar";
            this.btnCanecelar.Size = new System.Drawing.Size(211, 37);
            this.btnCanecelar.TabIndex = 43;
            this.btnCanecelar.Text = "Limpiar";
            this.btnCanecelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCanecelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCanecelar.UseVisualStyleBackColor = false;
            this.btnCanecelar.Click += new System.EventHandler(this.btnCanecelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Location = new System.Drawing.Point(12, 361);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(211, 37);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(13, 248);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(210, 20);
            this.txtTelefono.TabIndex = 32;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.White;
            this.lblDomicilio.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.Black;
            this.lblDomicilio.Location = new System.Drawing.Point(13, 227);
            this.lblDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(63, 17);
            this.lblDomicilio.TabIndex = 28;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(241, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(718, 42);
            this.label10.TabIndex = 51;
            this.label10.Text = "Lista de Clientes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errIngresoDatos
            // 
            this.errIngresoDatos.ContainerControl = this;
            // 
            // cbFiltrarListProd
            // 
            this.cbFiltrarListProd.FormattingEnabled = true;
            this.cbFiltrarListProd.Location = new System.Drawing.Point(707, 73);
            this.cbFiltrarListProd.Name = "cbFiltrarListProd";
            this.cbFiltrarListProd.Size = new System.Drawing.Size(239, 21);
            this.cbFiltrarListProd.TabIndex = 58;
            // 
            // txtProdList
            // 
            this.txtProdList.Location = new System.Drawing.Point(404, 75);
            this.txtProdList.Multiline = true;
            this.txtProdList.Name = "txtProdList";
            this.txtProdList.Size = new System.Drawing.Size(197, 19);
            this.txtProdList.TabIndex = 57;
            // 
            // lblFiltroListProd
            // 
            this.lblFiltroListProd.AutoSize = true;
            this.lblFiltroListProd.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroListProd.Location = new System.Drawing.Point(704, 56);
            this.lblFiltroListProd.Name = "lblFiltroListProd";
            this.lblFiltroListProd.Size = new System.Drawing.Size(43, 17);
            this.lblFiltroListProd.TabIndex = 56;
            this.lblFiltroListProd.Text = "Filtrar:";
            // 
            // lblBuscarListProd
            // 
            this.lblBuscarListProd.AutoSize = true;
            this.lblBuscarListProd.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarListProd.Location = new System.Drawing.Point(401, 59);
            this.lblBuscarListProd.Name = "lblBuscarListProd";
            this.lblBuscarListProd.Size = new System.Drawing.Size(49, 17);
            this.lblBuscarListProd.TabIndex = 55;
            this.lblBuscarListProd.Text = "Buscar:";
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
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(607, 75);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(41, 21);
            this.iconBtnLupaDetalleUser.TabIndex = 54;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.cbFiltrarListProd);
            this.Controls.Add(this.txtProdList);
            this.Controls.Add(this.lblFiltroListProd);
            this.Controls.Add(this.lblBuscarListProd);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlClientes;
        private FontAwesome.Sharp.IconButton btnCanecelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errIngresoDatos;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFiltrarListProd;
        private System.Windows.Forms.TextBox txtProdList;
        private System.Windows.Forms.Label lblFiltroListProd;
        private System.Windows.Forms.Label lblBuscarListProd;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
    }
}