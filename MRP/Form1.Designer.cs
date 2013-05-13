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
            this.assyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MRP.dataSet();
            this.assyTableAdapter = new MRP.dataSetTableAdapters.AssyTableAdapter();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assyPartDS1 = new MRP.AssyPartDS();
            this.partAssyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assyPartDS = new MRP.AssyPartDS();
            this.assyTableAdapter1 = new MRP.AssyPartDSTableAdapters.AssyTableAdapter();
            this.partTableAdapter1 = new MRP.AssyPartDSTableAdapters.PartTableAdapter();
            this.part_AssyTableAdapter = new MRP.AssyPartDSTableAdapters.Part_AssyTableAdapter();
            this.продуктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.компонентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AssyPartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partAssyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS)).BeginInit();
            this.SuspendLayout();
            // 
            // AssyPartView
            // 
            this.AssyPartView.AutoGenerateColumns = false;
            this.AssyPartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssyPartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.продуктDataGridViewTextBoxColumn,
            this.компонентDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.AssyPartView.DataSource = this.partAssyBindingSource;
            this.AssyPartView.Location = new System.Drawing.Point(78, 89);
            this.AssyPartView.Name = "AssyPartView";
            this.AssyPartView.Size = new System.Drawing.Size(485, 150);
            this.AssyPartView.TabIndex = 0;
            this.AssyPartView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.AssyPartView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssyPartView_CellEndEdit);
            this.AssyPartView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.AssyPartView_UserAddedRow);
            this.AssyPartView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.AssyPartView_UserDeletingRow);
            // 
            // assyBindingSource
            // 
            this.assyBindingSource.DataMember = "Assy";
            this.assyBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "dataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assyTableAdapter
            // 
            this.assyTableAdapter.ClearBeforeFill = true;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.assyPartDS1;
            // 
            // assyPartDS1
            // 
            this.assyPartDS1.DataSetName = "AssyPartDS";
            this.assyPartDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partAssyBindingSource
            // 
            this.partAssyBindingSource.DataMember = "Part_Assy";
            this.partAssyBindingSource.DataSource = this.assyPartDS;
            // 
            // assyPartDS
            // 
            this.assyPartDS.DataSetName = "AssyPartDS";
            this.assyPartDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assyTableAdapter1
            // 
            this.assyTableAdapter1.ClearBeforeFill = true;
            // 
            // partTableAdapter1
            // 
            this.partTableAdapter1.ClearBeforeFill = true;
            // 
            // part_AssyTableAdapter
            // 
            this.part_AssyTableAdapter.ClearBeforeFill = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 401);
            this.Controls.Add(this.AssyPartView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssyPartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partAssyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AssyPartView;
        private AssyPartDS assyPartDS;
        private AssyPartDSTableAdapters.AssyTableAdapter assyTableAdapter1;
        private AssyPartDSTableAdapters.PartTableAdapter partTableAdapter1;
        private dataSet dataSet;
        private System.Windows.Forms.BindingSource assyBindingSource;
        private dataSetTableAdapters.AssyTableAdapter assyTableAdapter;
        private System.Windows.Forms.BindingSource partAssyBindingSource;
        private AssyPartDSTableAdapters.Part_AssyTableAdapter part_AssyTableAdapter;
        private AssyPartDS assyPartDS1;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn продуктDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn компонентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
    }
}

