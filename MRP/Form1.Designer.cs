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
            this.продуктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.assyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assyPartDS = new MRP.AssyPartDS();
            this.компонентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partAssyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PartView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PART_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderView = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aSSYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.part_AssyTableAdapter = new MRP.AssyPartDSTableAdapters.Part_AssyTableAdapter();
            this.partTableAdapter = new MRP.AssyPartDSTableAdapters.PartTableAdapter();
            this.assyTableAdapter = new MRP.AssyPartDSTableAdapters.AssyTableAdapter();
            this.assyPartDS1 = new MRP.AssyPartDS();
            this.clientTableAdapter = new MRP.AssyPartDSTableAdapters.ClientTableAdapter();
            this.orderTableAdapter = new MRP.AssyPartDSTableAdapters.OrderTableAdapter();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseTableAdapter = new MRP.AssyPartDSTableAdapters.PurchaseTableAdapter();
            this.purchaseView = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.calcButton = new System.Windows.Forms.Button();
            this.minStockBox = new System.Windows.Forms.TextBox();
            this.maxStockBox = new System.Windows.Forms.TextBox();
            this.daysBox = new System.Windows.Forms.TextBox();
            this.endDayBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AssyPartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partAssyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource1)).BeginInit();
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
            this.AssyPartView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.AssyPartView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.UserDeletedRow);
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
            // assyBindingSource
            // 
            this.assyBindingSource.DataMember = "Assy";
            this.assyBindingSource.DataSource = this.assyPartDS;
            // 
            // assyPartDS
            // 
            this.assyPartDS.DataSetName = "AssyPartDS";
            this.assyPartDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.assyPartDS;
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
            this.PartView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.PartView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.UserDeletedRow);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Компонент";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            this.ClientView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.ClientView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.UserDeletedRow);
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
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.assyPartDS;
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
            this.OrderView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.OrderView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.UserDeletedRow);
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
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.assyPartDS;
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
            // purchaseView
            // 
            this.purchaseView.AllowUserToAddRows = false;
            this.purchaseView.AllowUserToDeleteRows = false;
            this.purchaseView.AutoGenerateColumns = false;
            this.purchaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn1,
            this.pARTIDDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn1,
            this.pURCHASEIDDataGridViewTextBoxColumn});
            this.purchaseView.DataSource = this.purchaseBindingSource1;
            this.purchaseView.Location = new System.Drawing.Point(29, 350);
            this.purchaseView.Name = "purchaseView";
            this.purchaseView.ReadOnly = true;
            this.purchaseView.Size = new System.Drawing.Size(343, 150);
            this.purchaseView.TabIndex = 4;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "День";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pARTIDDataGridViewTextBoxColumn
            // 
            this.pARTIDDataGridViewTextBoxColumn.DataPropertyName = "PART_ID";
            this.pARTIDDataGridViewTextBoxColumn.DataSource = this.partBindingSource;
            this.pARTIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.pARTIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pARTIDDataGridViewTextBoxColumn.HeaderText = "Компонент";
            this.pARTIDDataGridViewTextBoxColumn.Name = "pARTIDDataGridViewTextBoxColumn";
            this.pARTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pARTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pARTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pARTIDDataGridViewTextBoxColumn.ValueMember = "PART_ID";
            // 
            // qtyDataGridViewTextBoxColumn1
            // 
            this.qtyDataGridViewTextBoxColumn1.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn1.HeaderText = "Кол-во";
            this.qtyDataGridViewTextBoxColumn1.Name = "qtyDataGridViewTextBoxColumn1";
            this.qtyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pURCHASEIDDataGridViewTextBoxColumn
            // 
            this.pURCHASEIDDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_ID";
            this.pURCHASEIDDataGridViewTextBoxColumn.HeaderText = "PURCHASE_ID";
            this.pURCHASEIDDataGridViewTextBoxColumn.Name = "pURCHASEIDDataGridViewTextBoxColumn";
            this.pURCHASEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pURCHASEIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // purchaseBindingSource1
            // 
            this.purchaseBindingSource1.DataMember = "Purchase";
            this.purchaseBindingSource1.DataSource = this.assyPartDS;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(404, 350);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calc!";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // minStockBox
            // 
            this.minStockBox.Location = new System.Drawing.Point(576, 350);
            this.minStockBox.Name = "minStockBox";
            this.minStockBox.Size = new System.Drawing.Size(100, 20);
            this.minStockBox.TabIndex = 6;
            this.minStockBox.Text = "10";
            // 
            // maxStockBox
            // 
            this.maxStockBox.Location = new System.Drawing.Point(576, 376);
            this.maxStockBox.Name = "maxStockBox";
            this.maxStockBox.Size = new System.Drawing.Size(100, 20);
            this.maxStockBox.TabIndex = 7;
            this.maxStockBox.Text = "1000";
            // 
            // daysBox
            // 
            this.daysBox.Location = new System.Drawing.Point(576, 403);
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(100, 20);
            this.daysBox.TabIndex = 8;
            this.daysBox.Text = "3";
            // 
            // endDayBox
            // 
            this.endDayBox.Location = new System.Drawing.Point(576, 430);
            this.endDayBox.Name = "endDayBox";
            this.endDayBox.Size = new System.Drawing.Size(100, 20);
            this.endDayBox.TabIndex = 9;
            this.endDayBox.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 515);
            this.Controls.Add(this.endDayBox);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.maxStockBox);
            this.Controls.Add(this.minStockBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.purchaseView);
            this.Controls.Add(this.OrderView);
            this.Controls.Add(this.ClientView);
            this.Controls.Add(this.PartView);
            this.Controls.Add(this.AssyPartView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssyPartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partAssyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView purchaseView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn pARTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURCHASEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaseBindingSource1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox minStockBox;
        private System.Windows.Forms.TextBox maxStockBox;
        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.TextBox endDayBox;
    }
}

