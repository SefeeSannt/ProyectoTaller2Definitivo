using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CapaPresentacion.Vistas.Administrador.Reportes
{
    partial class frmDetalleVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Agregra = new ContextMenuStrip(components);
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            labelBuscarPor = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            fechaRegistro = new DataGridViewTextBoxColumn();
            NroDocumento = new DataGridViewTextBoxColumn();
            montoTotal = new DataGridViewTextBoxColumn();
            usuarioRegistro = new DataGridViewTextBoxColumn();
            docProveedor = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewButtonColumn();
            comboBox1 = new ComboBox();
            lblProveedor = new Label();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            Agregra.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Agregra
            // 
            Agregra.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem });
            Agregra.Name = "Agregra";
            Agregra.Size = new Size(110, 26);
            Agregra.Text = "Agregar";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(109, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(labelBuscarPor);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lblProveedor);
            panel1.Controls.Add(lblFechaFin);
            panel1.Controls.Add(lblFechaInicio);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 538);
            panel1.TabIndex = 4;
            // 
            // iconButton2
            // 
            iconButton2.AccessibleRole = AccessibleRole.None;
            iconButton2.BackColor = Color.White;
            iconButton2.FlatAppearance.BorderColor = Color.White;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.White;
            iconButton2.FlatAppearance.MouseOverBackColor = Color.White;
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.ForeColor = SystemColors.ActiveCaptionText;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 18;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(662, 138);
            iconButton2.Margin = new Padding(4, 3, 4, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(37, 28);
            iconButton2.TabIndex = 17;
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(478, 142);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(301, 142);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 23);
            comboBox2.TabIndex = 15;
            // 
            // labelBuscarPor
            // 
            labelBuscarPor.AutoSize = true;
            labelBuscarPor.BackColor = Color.White;
            labelBuscarPor.Font = new Font("Franklin Gothic Medium", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBuscarPor.ForeColor = SystemColors.ActiveCaptionText;
            labelBuscarPor.Location = new Point(222, 145);
            labelBuscarPor.Margin = new Padding(4, 0, 4, 0);
            labelBuscarPor.Name = "labelBuscarPor";
            labelBuscarPor.Size = new Size(62, 15);
            labelBuscarPor.TabIndex = 14;
            labelBuscarPor.Text = "Búscar por:";
            // 
            // iconButton1
            // 
            iconButton1.AccessibleRole = AccessibleRole.None;
            iconButton1.BackColor = Color.White;
            iconButton1.FlatAppearance.BorderColor = Color.White;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.White;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.White;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.ForeColor = SystemColors.ActiveCaptionText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 18;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(789, 65);
            iconButton1.Margin = new Padding(4, 3, 4, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(92, 25);
            iconButton1.TabIndex = 13;
            iconButton1.Text = "Buscar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fechaRegistro, NroDocumento, montoTotal, usuarioRegistro, docProveedor, precioCompra });
            dataGridView1.Location = new Point(0, 195);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(960, 310);
            dataGridView1.TabIndex = 12;
            // 
            // fechaRegistro
            // 
            fechaRegistro.HeaderText = "Fecha Registro";
            fechaRegistro.Name = "fechaRegistro";
            // 
            // NroDocumento
            // 
            NroDocumento.HeaderText = "Nro. Documento";
            NroDocumento.Name = "NroDocumento";
            // 
            // montoTotal
            // 
            montoTotal.HeaderText = "Monto Total";
            montoTotal.Name = "montoTotal";
            // 
            // usuarioRegistro
            // 
            usuarioRegistro.HeaderText = "Vendedor";
            usuarioRegistro.Name = "usuarioRegistro";
            // 
            // docProveedor
            // 
            docProveedor.HeaderText = "Proveedor";
            docProveedor.Name = "docProveedor";
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Accion";
            precioCompra.Name = "precioCompra";
            precioCompra.Resizable = DataGridViewTriState.True;
            precioCompra.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(531, 65);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 23);
            comboBox1.TabIndex = 10;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.BackColor = Color.White;
            lblProveedor.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProveedor.ForeColor = SystemColors.ActiveCaptionText;
            lblProveedor.Location = new Point(441, 67);
            lblProveedor.Margin = new Padding(4, 0, 4, 0);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(71, 18);
            lblProveedor.TabIndex = 6;
            lblProveedor.Text = "Proveedor:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.BackColor = Color.White;
            lblFechaFin.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaFin.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaFin.Location = new Point(222, 69);
            lblFechaFin.Margin = new Padding(4, 0, 4, 0);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(62, 17);
            lblFechaFin.TabIndex = 5;
            lblFechaFin.Text = "Fecha fin:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = Color.White;
            lblFechaInicio.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaInicio.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaInicio.Location = new Point(4, 69);
            lblFechaInicio.Margin = new Padding(4, 0, 4, 0);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(77, 17);
            lblFechaInicio.TabIndex = 4;
            lblFechaInicio.Text = "Fecha inicio:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(100, 66);
            dateTimePicker2.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(114, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(14, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 24);
            label2.TabIndex = 2;
            label2.Text = "Reporte de ventas";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(298, 65);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(960, 93);
            label1.TabIndex = 1;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(960, 538);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmVentas";
            Text = "Ventas";
            Agregra.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Agregra;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelBuscarPor;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox textBox1;
        private DataGridViewTextBoxColumn fechaRegistro;
        private DataGridViewTextBoxColumn NroDocumento;
        private DataGridViewTextBoxColumn montoTotal;
        private DataGridViewTextBoxColumn usuarioRegistro;
        private DataGridViewTextBoxColumn docProveedor;
        private DataGridViewButtonColumn precioCompra;
    }
}

