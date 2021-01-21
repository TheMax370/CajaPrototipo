
namespace CajaPrototipo
{
    partial class Transacciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerodecuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTransaccionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new CajaPrototipo.DatabaseDataSet2();
            this.tblTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new CajaPrototipo.DatabaseDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.tbl_TransaccionTableAdapter = new CajaPrototipo.DatabaseDataSetTableAdapters.tbl_TransaccionTableAdapter();
            this.tbl_TransaccionTableAdapter1 = new CajaPrototipo.DatabaseDataSet2TableAdapters.tbl_TransaccionTableAdapter();
            this.disp_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaccionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.disp_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numerodecuentaDataGridViewTextBoxColumn,
            this.transaccionDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTransaccionBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 313);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerodecuentaDataGridViewTextBoxColumn
            // 
            this.numerodecuentaDataGridViewTextBoxColumn.DataPropertyName = "numero_de_cuenta";
            this.numerodecuentaDataGridViewTextBoxColumn.HeaderText = "numero_de_cuenta";
            this.numerodecuentaDataGridViewTextBoxColumn.Name = "numerodecuentaDataGridViewTextBoxColumn";
            this.numerodecuentaDataGridViewTextBoxColumn.Width = 120;
            // 
            // transaccionDataGridViewTextBoxColumn
            // 
            this.transaccionDataGridViewTextBoxColumn.DataPropertyName = "transaccion";
            this.transaccionDataGridViewTextBoxColumn.HeaderText = "transaccion";
            this.transaccionDataGridViewTextBoxColumn.Name = "transaccionDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // tblTransaccionBindingSource1
            // 
            this.tblTransaccionBindingSource1.DataMember = "tbl_Transaccion";
            this.tblTransaccionBindingSource1.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTransaccionBindingSource
            // 
            this.tblTransaccionBindingSource.DataMember = "tbl_Transaccion";
            this.tblTransaccionBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Transaccines";
            // 
            // tbl_TransaccionTableAdapter
            // 
            this.tbl_TransaccionTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_TransaccionTableAdapter1
            // 
            this.tbl_TransaccionTableAdapter1.ClearBeforeFill = true;
            // 
            // disp_panel
            // 
            this.disp_panel.BackColor = System.Drawing.Color.White;
            this.disp_panel.Controls.Add(this.dataGridView1);
            this.disp_panel.Controls.Add(this.label3);
            this.disp_panel.Location = new System.Drawing.Point(41, 12);
            this.disp_panel.Name = "disp_panel";
            this.disp_panel.Size = new System.Drawing.Size(606, 414);
            this.disp_panel.TabIndex = 11;
            // 
            // Transaccións
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.disp_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transaccións";
            this.Text = "Transaaccines";
            this.Load += new System.EventHandler(this.Transaccións_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaccionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.disp_panel.ResumeLayout(false);
            this.disp_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tblTransaccionBindingSource;
        private DatabaseDataSetTableAdapters.tbl_TransaccionTableAdapter tbl_TransaccionTableAdapter;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource tblTransaccionBindingSource1;
        private DatabaseDataSet2TableAdapters.tbl_TransaccionTableAdapter tbl_TransaccionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodecuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        public System.Windows.Forms.Panel disp_panel;
    }
}