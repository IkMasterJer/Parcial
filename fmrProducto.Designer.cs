namespace PARCIAL_CARRASCO_
{
    partial class fmrProducto
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
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripLabel();
            this.tsvEditar = new System.Windows.Forms.ToolStripLabel();
            this.tsbEliminar = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvproducto
            // 
            this.dgvproducto.AllowUserToAddRows = false;
            this.dgvproducto.AllowUserToDeleteRows = false;
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colMarca,
            this.colPrecio,
            this.colStock,
            this.colCategoria});
            this.dgvproducto.Location = new System.Drawing.Point(12, 40);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.ReadOnly = true;
            this.dgvproducto.RowHeadersVisible = false;
            this.dgvproducto.RowTemplate.Height = 25;
            this.dgvproducto.Size = new System.Drawing.Size(503, 167);
            this.dgvproducto.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsvEditar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(527, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsbNuevo.Text = "NUEVO";
            this.tsbNuevo.Click += new System.EventHandler(this.toolStripLabel1_Click_1);
            // 
            // tsvEditar
            // 
            this.tsvEditar.Name = "tsvEditar";
            this.tsvEditar.Size = new System.Drawing.Size(44, 22);
            this.tsvEditar.Text = "EDITAR";
            this.tsvEditar.Click += new System.EventHandler(this.tsvEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(60, 22);
            this.tsbEliminar.Text = "ELIMINAR";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // fmrProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 228);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvproducto);
            this.Name = "fmrProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.fmrProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvproducto;
        private ToolStrip toolStrip1;
        private ToolStripLabel tsbNuevo;
        private ToolStripLabel tsvEditar;
        private ToolStripLabel tsbEliminar;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colCategoria;
    }
}