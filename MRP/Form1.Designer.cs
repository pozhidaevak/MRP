﻿namespace MRP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assyPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assyPartDS = new MRP.AssyPartDS();
            this.assyPartTableAdapter = new MRP.AssyPartDSTableAdapters.AssyPartTableAdapter();
            this.assyTableAdapter1 = new MRP.AssyPartDSTableAdapters.AssyTableAdapter();
            this.partTableAdapter1 = new MRP.AssyPartDSTableAdapters.PartTableAdapter();
            this.dataSet = new MRP.dataSet();
            this.assyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assyTableAdapter = new MRP.dataSetTableAdapters.AssyTableAdapter();
            this.продуктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.компонентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.продуктDataGridViewTextBoxColumn,
            this.компонентDataGridViewTextBoxColumn,
            this.колвоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assyPartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // assyPartBindingSource
            // 
            this.assyPartBindingSource.DataMember = "AssyPart";
            this.assyPartBindingSource.DataSource = this.assyPartDS;
            // 
            // assyPartDS
            // 
            this.assyPartDS.DataSetName = "AssyPartDS";
            this.assyPartDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assyPartTableAdapter
            // 
            this.assyPartTableAdapter.ClearBeforeFill = true;
            // 
            // assyTableAdapter1
            // 
            this.assyTableAdapter1.ClearBeforeFill = true;
            // 
            // partTableAdapter1
            // 
            this.partTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "dataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assyBindingSource
            // 
            this.assyBindingSource.DataMember = "Assy";
            this.assyBindingSource.DataSource = this.dataSet;
            // 
            // assyTableAdapter
            // 
            this.assyTableAdapter.ClearBeforeFill = true;
            // 
            // продуктDataGridViewTextBoxColumn
            // 
            this.продуктDataGridViewTextBoxColumn.DataPropertyName = "Продукт";
            this.продуктDataGridViewTextBoxColumn.DataSource = this.assyBindingSource;
            this.продуктDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.продуктDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.продуктDataGridViewTextBoxColumn.Name = "продуктDataGridViewTextBoxColumn";
            this.продуктDataGridViewTextBoxColumn.ReadOnly = true;
            this.продуктDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.продуктDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.продуктDataGridViewTextBoxColumn.ValueMember = "ASSY_ID";
            // 
            // компонентDataGridViewTextBoxColumn
            // 
            this.компонентDataGridViewTextBoxColumn.DataPropertyName = "Компонент";
            this.компонентDataGridViewTextBoxColumn.HeaderText = "Компонент";
            this.компонентDataGridViewTextBoxColumn.Name = "компонентDataGridViewTextBoxColumn";
            // 
            // колвоDataGridViewTextBoxColumn
            // 
            this.колвоDataGridViewTextBoxColumn.DataPropertyName = "Кол-во";
            this.колвоDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.колвоDataGridViewTextBoxColumn.Name = "колвоDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 401);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyPartDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AssyPartDS assyPartDS;
        private System.Windows.Forms.BindingSource assyPartBindingSource;
        private AssyPartDSTableAdapters.AssyPartTableAdapter assyPartTableAdapter;
        private AssyPartDSTableAdapters.AssyTableAdapter assyTableAdapter1;
        private AssyPartDSTableAdapters.PartTableAdapter partTableAdapter1;
        private dataSet dataSet;
        private System.Windows.Forms.BindingSource assyBindingSource;
        private dataSetTableAdapters.AssyTableAdapter assyTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn продуктDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компонентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоDataGridViewTextBoxColumn;
    }
}
