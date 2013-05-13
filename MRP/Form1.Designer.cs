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
            this.assyPartDS = new MRP.AssyPartDS();
            this.partAssyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.part_AssyTableAdapter = new MRP.AssyPartDSTableAdapters.Part_AssyTableAdapter();
            this.assyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assyTableAdapter = new MRP.AssyPartDSTableAdapters.AssyTableAdapter();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partTableAdapter = new MRP.AssyPartDSTableAdapters.PartTableAdapter();
            this.продуктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.компонентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AssyPartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partAssyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
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
            this.PartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartView.Location = new System.Drawing.Point(411, 12);
            this.PartView.Name = "PartView";
            this.PartView.Size = new System.Drawing.Size(240, 150);
            this.PartView.TabIndex = 1;
            this.PartView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartView_CellContentClick);
            this.PartView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartView_CellEndEdit);
            // 
            // assyPartDS
            // 
            this.assyPartDS.DataSetName = "AssyPartDS";
            this.assyPartDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // assyBindingSource
            // 
            this.assyBindingSource.DataMember = "Assy";
            this.assyBindingSource.DataSource = this.assyPartDS;
            // 
            // assyTableAdapter
            // 
            this.assyTableAdapter.ClearBeforeFill = true;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.assyPartDS;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
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
            this.Controls.Add(this.PartView);
            this.Controls.Add(this.AssyPartView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssyPartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partAssyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AssyPartView;
        private System.Windows.Forms.DataGridView PartView;
        private AssyPartDS assyPartDS;
        private System.Windows.Forms.BindingSource partAssyBindingSource;
        private AssyPartDSTableAdapters.Part_AssyTableAdapter part_AssyTableAdapter;
        private System.Windows.Forms.BindingSource assyBindingSource;
        private AssyPartDSTableAdapters.AssyTableAdapter assyTableAdapter;
        private System.Windows.Forms.BindingSource partBindingSource;
        private AssyPartDSTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn продуктDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn компонентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
    }
}

