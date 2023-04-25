
namespace LibreriaMSQL
{
    partial class Form1
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
            this.Guardar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroPaginas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.libreriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libreriaDataSet = new LibreriaMSQL.LibreriaDataSet();
            this.libreriaDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPaginasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new LibreriaMSQL.LibreriaDataSetTableAdapters.LibrosTableAdapter();
            this.CajaFecha = new System.Windows.Forms.DateTimePicker();
            this.Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(693, 12);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(131, 42);
            this.Guardar.TabIndex = 1;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(693, 68);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(131, 49);
            this.Modificar.TabIndex = 2;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(693, 131);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(132, 46);
            this.Eliminar.TabIndex = 3;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(12, 12);
            this.Titulo.Multiline = true;
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(316, 37);
            this.Titulo.TabIndex = 4;
            this.Titulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Título del Libro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumeroPaginas
            // 
            this.NumeroPaginas.Location = new System.Drawing.Point(12, 120);
            this.NumeroPaginas.Multiline = true;
            this.NumeroPaginas.Name = "NumeroPaginas";
            this.NumeroPaginas.Size = new System.Drawing.Size(316, 41);
            this.NumeroPaginas.TabIndex = 6;
            this.NumeroPaginas.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número de Páginas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de Publicación";
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(12, 175);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(316, 41);
            this.Descripcion.TabIndex = 10;
            this.Descripcion.TextChanged += new System.EventHandler(this.Descripcion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripción";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "LIsta de Libros ";
            // 
            // libreriaDataSetBindingSource
            // 
            this.libreriaDataSetBindingSource.DataSource = this.libreriaDataSet;
            this.libreriaDataSetBindingSource.Position = 0;
            // 
            // libreriaDataSet
            // 
            this.libreriaDataSet.DataSetName = "LibreriaDataSet";
            this.libreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libreriaDataSetBindingSource1
            // 
            this.libreriaDataSetBindingSource1.DataSource = this.libreriaDataSet;
            this.libreriaDataSetBindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.fechaPublicacionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.numeroPaginasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.librosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(820, 262);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Filas);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaPublicacionDataGridViewTextBoxColumn
            // 
            this.fechaPublicacionDataGridViewTextBoxColumn.DataPropertyName = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.HeaderText = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaPublicacionDataGridViewTextBoxColumn.Name = "fechaPublicacionDataGridViewTextBoxColumn";
            this.fechaPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaPublicacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeroPaginasDataGridViewTextBoxColumn
            // 
            this.numeroPaginasDataGridViewTextBoxColumn.DataPropertyName = "NumeroPaginas";
            this.numeroPaginasDataGridViewTextBoxColumn.HeaderText = "NumeroPaginas";
            this.numeroPaginasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numeroPaginasDataGridViewTextBoxColumn.Name = "numeroPaginasDataGridViewTextBoxColumn";
            this.numeroPaginasDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroPaginasDataGridViewTextBoxColumn.Width = 150;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.libreriaDataSetBindingSource;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // CajaFecha
            // 
            this.CajaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CajaFecha.Location = new System.Drawing.Point(16, 68);
            this.CajaFecha.Name = "CajaFecha";
            this.CajaFecha.Size = new System.Drawing.Size(312, 26);
            this.CajaFecha.TabIndex = 14;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(693, 187);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(132, 46);
            this.Limpiar.TabIndex = 15;
            this.Limpiar.Text = "Borrar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 532);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.CajaFecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroPaginas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Guardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libreriaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroPaginas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource libreriaDataSetBindingSource;
        private LibreriaDataSet libreriaDataSet;
        private LibreriaDataSetTableAdapters.LibrosTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource libreriaDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private LibreriaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPaginasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker CajaFecha;
        private System.Windows.Forms.Button Limpiar;
    }
}

