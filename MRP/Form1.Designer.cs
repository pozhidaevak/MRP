namespace MRP
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AssyPartView = new System.Windows.Forms.DataGridView();
            this.PartView = new System.Windows.Forms.DataGridView();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PART_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientView = new System.Windows.Forms.DataGridView();
            this.OrderView = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assyPartDS = new MRP.AssyPartDS();
            this.aSSYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.assyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.компонентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partAssyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.part_AssyTableAdapter = new MRP.AssyPartDSTableAdapters.Part_AssyTableAdapter();
            this.partTableAdapter = new MRP.AssyPartDSTableAdapters.PartTableAdapter();
            this.assyTableAdapter = new MRP.AssyPartDSTableAdapters.AssyTableAdapter();
            this.assyPartDS1 = new MRP.AssyPartDS();
            this.clientTableAdapter = new MRP.AssyPartDSTableAdapters.ClientTableAdapter();
            this.orderTableAdapter = new MRP.AssyPartDSTableAdapters.OrderTableAdapter();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseTableAdapter = new MRP.AssyPartDSTableAdapters.PurchaseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AssyPartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partAssyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AssyPartView
            // 
            this.AssyPartView.AutoGenerateColumns = false;
            this.AssyPartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssyPartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.продуктDataGridViewTextBoxColumn,
            this.компонентDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.AssyPartView.DataSource = this.partAssyBindingSource;
            this.AssyPartView.Location = new System.Drawing.Point(12, 12);
            this.AssyPartView.Name = "AssyPartView";
            this.AssyPartView.Size = new System.Drawing.Size(393, 150);
            this.AssyPartView.TabIndex = 0;
            this.AssyPartView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.AssyPartView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssyPartView_CellEndEdit);
            this.AssyPartView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.AssyPartView_UserAddedRow);
            this.AssyPartView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.AssyPartView_UserDeletingRow);
            // 
            // PartView
            // 
            this.PartView.AutoGenerateColumns = false;
            this.PartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Qty,
            this.PART_ID});
            this.PartView.DataSource = this.partBindingSource;
            this.PartView.Location = new System.Drawing.Point(430, 12);
            this.PartView.Name = "PartView";
            this.PartView.Size = new System.Drawing.Size(243, 150);
            this.PartView.TabIndex = 1;
            this.PartView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartView_CellEndEdit);
            this.PartView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.PartView_UserDeletedRow);
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Количество";
            this.Qty.Name = "Qty";
            // 
            // PART_ID
            // 
            this.PART_ID.DataPropertyName = "PART_ID";
            this.PART_ID.HeaderText = "PART_ID";
            this.PART_ID.Name = "PART_ID";
            this.PART_ID.ReadOnly = true;
            this.PART_ID.Visible = false;
            // 
            // ClientView
            // 
            this.ClientView.AutoGenerateColumns = false;
            this.ClientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.cLIENTIDDataGridViewTextBoxColumn});
            this.ClientView.DataSource = this.clientBindingSource;
            this.ClientView.Location = new System.Drawing.Point(13, 169);
            this.ClientView.Name = "ClientView";
            this.ClientView.Size = new System.Drawing.Size(123, 150);
            this.ClientView.TabIndex = 2;
            this.ClientView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientView_CellEndEdit);
            this.ClientView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ClientView_UserDeletedRow);
            // 
            // OrderView
            // 
            this.OrderView.AutoGenerateColumns = false;
            this.OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.cLIENTIDDataGridViewTextBoxColumn1,
            this.aSSYIDDataGridViewTextBoxColumn});
            this.OrderView.DataSource = this.orderBindingSource;
            this.OrderView.Location = new System.Drawing.Point(202, 169);
            this.OrderView.Name = "OrderView";
            this.OrderView.Size = new System.Drawing.Size(495, 150);
            this.OrderView.TabIndex = 3;
            this.OrderView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderView_CellEndEdit);
            this.OrderView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.OrderView_UserDeletedRow);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // cLIENTIDDataGridViewTextBoxColumn1
            // 
            this.cLIENTIDDataGridViewTextBoxColumn1.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn1.DataSource = this.clientBindingSource;
            this.cLIENTIDDataGridViewTextBoxColumn1.DisplayMember = "Name";
            this.cLIENTIDDataGridViewTextBoxColumn1.HeaderText = "Клиент";
            this.cLIENTIDDataGridViewTextBoxColumn1.Name = "cLIENTIDDataGridViewTextBoxColumn1";
            this.cLIENTIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cLIENTIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cLIENTIDDataGridViewTextBoxColumn1.ValueMember = "CLIENT_ID";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.assyPartDS;
            // 
            // assyPartDS
            // 
            this.assyPartDS.DataSetName = "AssyPartDS";
            this.assyPartDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aSSYIDDataGridViewTextBoxColumn
            // 
            this.aSSYIDDataGridViewTextBoxColumn.DataPropertyName = "ASSY_ID";
            this.aSSYIDDataGridViewTextBoxColumn.DataSource = this.assyBindingSource;
            this.aSSYIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.aSSYIDDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.aSSYIDDataGridViewTextBoxColumn.Name = "aSSYIDDataGridViewTextBoxColumn";
            this.aSSYIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aSSYIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aSSYIDDataGridViewTextBoxColumn.ValueMember = "ASSY_ID";
            this.aSSYIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // assyBindingSource
            // 
            this.assyBindingSource.DataMember = "Assy";
            this.assyBindingSource.DataSource = this.assyPartDS;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.assyPartDS;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 80;
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            this.cLIENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Компонент";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.assyPartDS;
            // 
            // продуктDataGridViewTextBoxColumn
            // 
            this.продуктDataGridViewTextBoxColumn.DataPropertyName = "Продукт";
            this.продуктDataGridViewTextBoxColumn.DataSource = this.assyBindingSource;
            this.продуктDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.продуктDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.продуктDataGridViewTextBoxColumn.Name = "продуктDataGridViewTextBoxColumn";
            this.продуктDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.продуктDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.продуктDataGridViewTextBoxColumn.ValueMember = "ASSY_ID";
            this.продуктDataGridViewTextBoxColumn.Width = 150;
            // 
            // компонентDataGridViewTextBoxColumn
            // 
            this.компонентDataGridViewTextBoxColumn.DataPropertyName = "Компонент";
            this.компонентDataGridViewTextBoxColumn.DataSource = this.partBindingSource;
            this.компонентDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.компонентDataGridViewTextBoxColumn.HeaderText = "Компонент";
            this.компонентDataGridViewTextBoxColumn.Name = "компонентDataGridViewTextBoxColumn";
            this.компонентDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.компонентDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.компонентDataGridViewTextBoxColumn.ValueMember = "PART_ID";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // partAssyBindingSource
            // 
            this.partAssyBindingSource.DataMember = "Part_Assy";
            this.partAssyBindingSource.DataSource = this.assyPartDS;
            // 
            // part_AssyTableAdapter
            // 
            this.part_AssyTableAdapter.ClearBeforeFill = true;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // assyTableAdapter
            // 
            this.assyTableAdapter.ClearBeforeFill = true;
            // 
            // assyPartDS1
            // 
            this.assyPartDS1.DataSetName = "AssyPartDS";
            this.assyPartDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "Purchase";
            this.purchaseBindingSource.DataSource = this.assyPartDS;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 515);
            this.Controls.Add(this.OrderView);
            this.Controls.Add(this.ClientView);
            this.Controls.Add(this.PartView);
            this.Controls.Add(this.AssyPartView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssyPartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partAssyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AssyPartView;
        private System.Windows.Forms.DataGridView PartView;
        private AssyPartDS assyPartDS;
        private System.Windows.Forms.BindingSource partAssyBindingSource;
        private AssyPartDSTableAdapters.Part_AssyTableAdapter part_AssyTableAdapter;
        private System.Windows.Forms.BindingSource partBindingSource;
        private AssyPartDSTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.BindingSource assyBindingSource;
        private AssyPartDSTableAdapters.AssyTableAdapter assyTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn продуктDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn компонентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PART_ID;
        private System.Windows.Forms.DataGridView ClientView;
        private AssyPartDS assyPartDS1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private AssyPartDSTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridView OrderView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private AssyPartDSTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cLIENTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn aSSYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private AssyPartDSTableAdapters.PurchaseTableAdapter purchaseTableAdapter;
    }
}

