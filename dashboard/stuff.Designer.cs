namespace dashboard
{
    partial class stuff
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.back_staff = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffShiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.anoy2DataSet1 = new dashboard.Anoy2DataSet1();
            this.btn_Updatequantity = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Stuff_ID = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Item_Name = new System.Windows.Forms.Label();
            this.anoyDataSet1 = new dashboard.AnoyDataSet1();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new dashboard.AnoyDataSet1TableAdapters.ItemsTableAdapter();
            this.anoy1DataSet1 = new dashboard.Anoy1DataSet1();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter1 = new dashboard.Anoy1DataSet1TableAdapters.ItemsTableAdapter();
            this.itemsTableAdapter2 = new dashboard.Anoy2DataSet1TableAdapters.ItemsTableAdapter();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoy2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoy1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_staff
            // 
            this.back_staff.Location = new System.Drawing.Point(28, 29);
            this.back_staff.Name = "back_staff";
            this.back_staff.Size = new System.Drawing.Size(86, 38);
            this.back_staff.TabIndex = 1;
            this.back_staff.Text = "back";
            this.back_staff.UseVisualStyleBackColor = true;
            this.back_staff.Click += new System.EventHandler(this.back_staff_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.staffIDDataGridViewTextBoxColumn,
                this.staffShiftDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(278, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 278);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffShiftDataGridViewTextBoxColumn
            // 
            this.staffShiftDataGridViewTextBoxColumn.DataPropertyName = "StaffShift";
            this.staffShiftDataGridViewTextBoxColumn.HeaderText = "StaffShift";
            this.staffShiftDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffShiftDataGridViewTextBoxColumn.Name = "staffShiftDataGridViewTextBoxColumn";
            this.staffShiftDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemsBindingSource2
            // 
            this.itemsBindingSource2.DataMember = "Items";
            this.itemsBindingSource2.DataSource = this.anoy2DataSet1;
            // 
            // anoy2DataSet1
            // 
            this.anoy2DataSet1.DataSetName = "Anoy2DataSet1";
            this.anoy2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Updatequantity
            // 
            this.btn_Updatequantity.Location = new System.Drawing.Point(157, 370);
            this.btn_Updatequantity.Name = "btn_Updatequantity";
            this.btn_Updatequantity.Size = new System.Drawing.Size(86, 38);
            this.btn_Updatequantity.TabIndex = 7;
            this.btn_Updatequantity.Text = "Update";
            this.btn_Updatequantity.UseVisualStyleBackColor = true;
            this.btn_Updatequantity.Click += new System.EventHandler(this.btn_Updatequantity_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Stuff_ID
            // 
            this.Stuff_ID.AutoSize = true;
            this.Stuff_ID.Location = new System.Drawing.Point(12, 126);
            this.Stuff_ID.Name = "Stuff_ID";
            this.Stuff_ID.Size = new System.Drawing.Size(62, 17);
            this.Stuff_ID.TabIndex = 8;
            this.Stuff_ID.Text = "Staff ID: ";
            this.Stuff_ID.Click += new System.EventHandler(this.Item_Number_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSize = true;
            this.Item_Name.Location = new System.Drawing.Point(12, 179);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(73, 17);
            this.Item_Name.TabIndex = 10;
            this.Item_Name.Text = "Staff Shift:";
            this.Item_Name.Click += new System.EventHandler(this.Staff_Shift_Click);
            // 
            // anoyDataSet1
            // 
            this.anoyDataSet1.DataSetName = "AnoyDataSet1";
            this.anoyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.anoyDataSet1;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // anoy1DataSet1
            // 
            this.anoy1DataSet1.DataSetName = "Anoy1DataSet1";
            this.anoy1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.anoy1DataSet1;
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // itemsTableAdapter2
            // 
            this.itemsTableAdapter2.ClearBeforeFill = true;
            // 
            // stuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Stuff_ID);
            this.Controls.Add(this.btn_Updatequantity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_staff);
            this.Name = "stuff";
            this.Text = "stuff";
            this.Load += new System.EventHandler(this.stuff_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoy2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoy1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_staff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Updatequantity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Stuff_ID;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Item_Name;
        private AnoyDataSet1 anoyDataSet1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private AnoyDataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffShiftDataGridViewTextBoxColumn;
        private Anoy1DataSet1 anoy1DataSet1;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private Anoy1DataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter1;
        private Anoy2DataSet1 anoy2DataSet1;
        private System.Windows.Forms.BindingSource itemsBindingSource2;
        private Anoy2DataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter2;
    }
}
