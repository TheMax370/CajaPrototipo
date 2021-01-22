
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblTransaccionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new CajaPrototipo.DatabaseDataSet2();
            this.tblTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new CajaPrototipo.DatabaseDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.tbl_TransaccionTableAdapter = new CajaPrototipo.DatabaseDataSetTableAdapters.tbl_TransaccionTableAdapter();
            this.tbl_TransaccionTableAdapter1 = new CajaPrototipo.DatabaseDataSet2TableAdapters.tbl_TransaccionTableAdapter();
            this.disp_panel = new System.Windows.Forms.Panel();
            this.databaseDataSet5 = new CajaPrototipo.DatabaseDataSet5();
            this.tblTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionsTableAdapter = new CajaPrototipo.DatabaseDataSet5TableAdapters.tblTransactionsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactMount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaccionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.disp_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.TransactType,
            this.TransactDate,
            this.TransactMount,
            this.AccountNum});
            this.dataGridView1.DataSource = this.tblTransactionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 313);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.label3.Size = new System.Drawing.Size(218, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Transacciones";
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
            // databaseDataSet5
            // 
            this.databaseDataSet5.DataSetName = "DatabaseDataSet5";
            this.databaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTransactionsBindingSource
            // 
            this.tblTransactionsBindingSource.DataMember = "tblTransactions";
            this.tblTransactionsBindingSource.DataSource = this.databaseDataSet5;
            // 
            // tblTransactionsTableAdapter
            // 
            this.tblTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TransactType
            // 
            this.TransactType.DataPropertyName = "TransactType";
            this.TransactType.HeaderText = "TransactType";
            this.TransactType.Name = "TransactType";
            // 
            // TransactDate
            // 
            this.TransactDate.DataPropertyName = "TransactDate";
            this.TransactDate.HeaderText = "TransactDate";
            this.TransactDate.Name = "TransactDate";
            // 
            // TransactMount
            // 
            this.TransactMount.DataPropertyName = "TransactMount";
            this.TransactMount.HeaderText = "TransactMount";
            this.TransactMount.Name = "TransactMount";
            // 
            // AccountNum
            // 
            this.AccountNum.DataPropertyName = "AccountNum";
            this.AccountNum.HeaderText = "AccountNum";
            this.AccountNum.Name = "AccountNum";
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.disp_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transacciones";
            this.Text = "Transaaccines";
            this.Load += new System.EventHandler(this.Transaccións_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaccionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.disp_panel.ResumeLayout(false);
            this.disp_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).EndInit();
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
        public System.Windows.Forms.Panel disp_panel;
        private DatabaseDataSet5 databaseDataSet5;
        private System.Windows.Forms.BindingSource tblTransactionsBindingSource;
        private DatabaseDataSet5TableAdapters.tblTransactionsTableAdapter tblTransactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactMount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNum;
    }
}