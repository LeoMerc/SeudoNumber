
namespace ProyectoEquipo
{
    partial class Inventarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventarios));
            this.label3 = new System.Windows.Forms.Label();
            this.txtinv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtq = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Predeterminados = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.probas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.qDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoFaltanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoinventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet = new ProyectoEquipo.InventarioDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.btnComparar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaTableAdapter = new ProyectoEquipo.InventarioDataSetTableAdapters.TablaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invinicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numpseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invfinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invmensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.probas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(455, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ingrese su inventario inicial";
            // 
            // txtinv
            // 
            this.txtinv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinv.Location = new System.Drawing.Point(458, 62);
            this.txtinv.Name = "txtinv";
            this.txtinv.Size = new System.Drawing.Size(100, 23);
            this.txtinv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(183, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ingrese sus meses";
            // 
            // txtmes
            // 
            this.txtmes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmes.Location = new System.Drawing.Point(186, 62);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(100, 23);
            this.txtmes.TabIndex = 1;
            // 
            // txtq
            // 
            this.txtq.AutoSize = true;
            this.txtq.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtq.ForeColor = System.Drawing.Color.Black;
            this.txtq.Location = new System.Drawing.Point(322, 32);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(85, 17);
            this.txtq.TabIndex = 33;
            this.txtq.Text = "Ingrese su Q";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(325, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // txtr
            // 
            this.txtr.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtr.Location = new System.Drawing.Point(51, 62);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(100, 23);
            this.txtr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ingrese su R";
            // 
            // Predeterminados
            // 
            this.Predeterminados.AutoSize = true;
            this.Predeterminados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Predeterminados.ForeColor = System.Drawing.Color.Black;
            this.Predeterminados.Location = new System.Drawing.Point(690, 51);
            this.Predeterminados.Name = "Predeterminados";
            this.Predeterminados.Size = new System.Drawing.Size(119, 34);
            this.Predeterminados.TabIndex = 38;
            this.Predeterminados.Text = "Valores \r\npredeterminados";
            this.Predeterminados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Predeterminados.Click += new System.EventHandler(this.Predeterminados_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Location = new System.Drawing.Point(902, 39);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(75, 68);
            this.btngenerar.TabIndex = 4;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // probas
            // 
            this.probas.BackgroundColor = System.Drawing.Color.Coral;
            this.probas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.probas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.probas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.probas.GridColor = System.Drawing.Color.White;
            this.probas.Location = new System.Drawing.Point(112, 147);
            this.probas.Name = "probas";
            this.probas.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.probas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.probas.ShowEditingIcon = false;
            this.probas.Size = new System.Drawing.Size(806, 150);
            this.probas.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Probabilidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite inicial";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lim Final";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Meses (Entrega)";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Probabilidad Entrega";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Lim Inicial";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Lim Final";
            this.Column8.Name = "Column8";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qDataGridViewTextBoxColumn,
            this.rDataGridViewTextBoxColumn,
            this.costoFaltanteDataGridViewTextBoxColumn,
            this.costoinventarioDataGridViewTextBoxColumn,
            this.costoPedidoDataGridViewTextBoxColumn,
            this.costoTotalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tablaBindingSource;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(205, 630);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Size = new System.Drawing.Size(609, 150);
            this.dataGridView2.TabIndex = 42;
            // 
            // qDataGridViewTextBoxColumn
            // 
            this.qDataGridViewTextBoxColumn.DataPropertyName = "Q";
            this.qDataGridViewTextBoxColumn.HeaderText = "Q";
            this.qDataGridViewTextBoxColumn.Name = "qDataGridViewTextBoxColumn";
            // 
            // rDataGridViewTextBoxColumn
            // 
            this.rDataGridViewTextBoxColumn.DataPropertyName = "R";
            this.rDataGridViewTextBoxColumn.HeaderText = "R";
            this.rDataGridViewTextBoxColumn.Name = "rDataGridViewTextBoxColumn";
            // 
            // costoFaltanteDataGridViewTextBoxColumn
            // 
            this.costoFaltanteDataGridViewTextBoxColumn.DataPropertyName = "CostoFaltante";
            this.costoFaltanteDataGridViewTextBoxColumn.HeaderText = "CostoFaltante";
            this.costoFaltanteDataGridViewTextBoxColumn.Name = "costoFaltanteDataGridViewTextBoxColumn";
            // 
            // costoinventarioDataGridViewTextBoxColumn
            // 
            this.costoinventarioDataGridViewTextBoxColumn.DataPropertyName = "Costoinventario";
            this.costoinventarioDataGridViewTextBoxColumn.HeaderText = "Costoinventario";
            this.costoinventarioDataGridViewTextBoxColumn.Name = "costoinventarioDataGridViewTextBoxColumn";
            // 
            // costoPedidoDataGridViewTextBoxColumn
            // 
            this.costoPedidoDataGridViewTextBoxColumn.DataPropertyName = "CostoPedido";
            this.costoPedidoDataGridViewTextBoxColumn.HeaderText = "CostoPedido";
            this.costoPedidoDataGridViewTextBoxColumn.Name = "costoPedidoDataGridViewTextBoxColumn";
            // 
            // costoTotalDataGridViewTextBoxColumn
            // 
            this.costoTotalDataGridViewTextBoxColumn.DataPropertyName = "CostoTotal";
            this.costoTotalDataGridViewTextBoxColumn.HeaderText = "CostoTotal";
            this.costoTotalDataGridViewTextBoxColumn.Name = "costoTotalDataGridViewTextBoxColumn";
            // 
            // tablaBindingSource
            // 
            this.tablaBindingSource.DataMember = "Tabla";
            this.tablaBindingSource.DataSource = this.inventarioDataSet;
            // 
            // inventarioDataSet
            // 
            this.inventarioDataSet.DataSetName = "InventarioDataSet";
            this.inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(322, 839);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 44;
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnComparar.Location = new System.Drawing.Point(494, 786);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(92, 34);
            this.btnComparar.TabIndex = 5;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 727);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 47;
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 727);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 46;
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 736);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 45;
            this.label4.Visible = false;
            // 
            // tablaTableAdapter
            // 
            this.tablaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mes,
            this.R,
            this.Invinicial,
            this.Numpseudo,
            this.Demanda,
            this.Invfinal,
            this.Faltante,
            this.Orden,
            this.Invmensual,
            this.Demsim,
            this.Column9,
            this.R2,
            this.Mes2});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 306);
            this.dataGridView1.TabIndex = 48;
            // 
            // Mes
            // 
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            this.Mes.Width = 60;
            // 
            // R
            // 
            this.R.HeaderText = "R";
            this.R.Name = "R";
            this.R.Width = 80;
            // 
            // Invinicial
            // 
            this.Invinicial.HeaderText = "Inv.inicial";
            this.Invinicial.Name = "Invinicial";
            this.Invinicial.Width = 80;
            // 
            // Numpseudo
            // 
            this.Numpseudo.HeaderText = "Num.pseudo";
            this.Numpseudo.Name = "Numpseudo";
            this.Numpseudo.Width = 80;
            // 
            // Demanda
            // 
            this.Demanda.HeaderText = "Dem.ajustada";
            this.Demanda.Name = "Demanda";
            this.Demanda.Width = 80;
            // 
            // Invfinal
            // 
            this.Invfinal.HeaderText = "Inv.final";
            this.Invfinal.Name = "Invfinal";
            this.Invfinal.Width = 80;
            // 
            // Faltante
            // 
            this.Faltante.HeaderText = "Faltante";
            this.Faltante.Name = "Faltante";
            this.Faltante.Width = 80;
            // 
            // Orden
            // 
            this.Orden.HeaderText = "Orden";
            this.Orden.Name = "Orden";
            this.Orden.Width = 60;
            // 
            // Invmensual
            // 
            this.Invmensual.HeaderText = "Inv. Mensual";
            this.Invmensual.Name = "Invmensual";
            // 
            // Demsim
            // 
            this.Demsim.HeaderText = "Dem.sim";
            this.Demsim.Name = "Demsim";
            this.Demsim.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Factor2";
            this.Column9.Name = "Column9";
            // 
            // R2
            // 
            this.R2.HeaderText = "R";
            this.R2.Name = "R2";
            this.R2.Width = 80;
            // 
            // Mes2
            // 
            this.Mes2.HeaderText = "Mes";
            this.Mes2.Name = "Mes2";
            this.Mes2.Width = 60;
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1045, 898);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.probas);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.Predeterminados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtinv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventarios";
            this.Load += new System.EventHandler(this.Inventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.probas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Label txtq;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Predeterminados;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.DataGridView probas;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private InventarioDataSet inventarioDataSet;
        private System.Windows.Forms.BindingSource tablaBindingSource;
        private InventarioDataSetTableAdapters.TablaTableAdapter tablaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoFaltanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoinventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn R;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invinicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numpseudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invfinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faltante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invmensual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn R2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}