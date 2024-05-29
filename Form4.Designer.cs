namespace Аптека
{
    partial class Form4
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
            this.buyersTableAdapter1 = new Аптека.АптекаDataSet5TableAdapters.BuyersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersandcustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._The_IP_of_the_electronic_store_DataSet1 = new Аптека._The_IP_of_the_electronic_store_DataSet1();
            this.buyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аптекаDataSet8 = new Аптека.АптекаDataSet8();
            this.buyersTableAdapter = new Аптека.АптекаDataSet8TableAdapters.BuyersTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Delete_ID = new System.Windows.Forms.Button();
            this.orders_and_customersTableAdapter = new Аптека._The_IP_of_the_electronic_store_DataSet1TableAdapters.Orders_and_customersTableAdapter();
            this._The_IP_of_the_electronic_store_DataSet3 = new Аптека._The_IP_of_the_electronic_store_DataSet3();
            this.marcetingmaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marceting_materialTableAdapter = new Аптека._The_IP_of_the_electronic_store_DataSet3TableAdapters.Marceting_materialTableAdapter();
            this.idMMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofmarcetingmaterialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theplatformusedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profittheplatformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idoacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersandcustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcetingmaterialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buyersTableAdapter1
            // 
            this.buyersTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMMDataGridViewTextBoxColumn,
            this.typeofmarcetingmaterialsDataGridViewTextBoxColumn,
            this.theplatformusedDataGridViewTextBoxColumn,
            this.profittheplatformDataGridViewTextBoxColumn,
            this.idoacDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.marcetingmaterialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ordersandcustomersBindingSource
            // 
            this.ordersandcustomersBindingSource.DataMember = "Orders_and_customers";
            this.ordersandcustomersBindingSource.DataSource = this._The_IP_of_the_electronic_store_DataSet1;
            // 
            // _The_IP_of_the_electronic_store_DataSet1
            // 
            this._The_IP_of_the_electronic_store_DataSet1.DataSetName = "_The_IP_of_the_electronic_store_DataSet1";
            this._The_IP_of_the_electronic_store_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyersBindingSource
            // 
            this.buyersBindingSource.DataMember = "Buyers";
            this.buyersBindingSource.DataSource = this.аптекаDataSet8;
            // 
            // аптекаDataSet8
            // 
            this.аптекаDataSet8.DataSetName = "АптекаDataSet8";
            this.аптекаDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyersTableAdapter
            // 
            this.buyersTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(439, 347);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(225, 373);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(225, 293);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 370);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Прибыль от платформы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Тип маркетингово материала";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Используемая платформа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "id_M_M";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Delete_ID
            // 
            this.button_Delete_ID.Location = new System.Drawing.Point(439, 383);
            this.button_Delete_ID.Name = "button_Delete_ID";
            this.button_Delete_ID.Size = new System.Drawing.Size(92, 23);
            this.button_Delete_ID.TabIndex = 21;
            this.button_Delete_ID.Text = "Удалить по ID";
            this.button_Delete_ID.UseVisualStyleBackColor = true;
            // 
            // orders_and_customersTableAdapter
            // 
            this.orders_and_customersTableAdapter.ClearBeforeFill = true;
            // 
            // _The_IP_of_the_electronic_store_DataSet3
            // 
            this._The_IP_of_the_electronic_store_DataSet3.DataSetName = "_The_IP_of_the_electronic_store_DataSet3";
            this._The_IP_of_the_electronic_store_DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcetingmaterialBindingSource
            // 
            this.marcetingmaterialBindingSource.DataMember = "Marceting_material";
            this.marcetingmaterialBindingSource.DataSource = this._The_IP_of_the_electronic_store_DataSet3;
            // 
            // marceting_materialTableAdapter
            // 
            this.marceting_materialTableAdapter.ClearBeforeFill = true;
            // 
            // idMMDataGridViewTextBoxColumn
            // 
            this.idMMDataGridViewTextBoxColumn.DataPropertyName = "id_M_M";
            this.idMMDataGridViewTextBoxColumn.HeaderText = "id_M_M";
            this.idMMDataGridViewTextBoxColumn.Name = "idMMDataGridViewTextBoxColumn";
            this.idMMDataGridViewTextBoxColumn.Width = 160;
            // 
            // typeofmarcetingmaterialsDataGridViewTextBoxColumn
            // 
            this.typeofmarcetingmaterialsDataGridViewTextBoxColumn.DataPropertyName = "Type_of_marceting_materials";
            this.typeofmarcetingmaterialsDataGridViewTextBoxColumn.HeaderText = "Type_of_marceting_materials";
            this.typeofmarcetingmaterialsDataGridViewTextBoxColumn.Name = "typeofmarcetingmaterialsDataGridViewTextBoxColumn";
            this.typeofmarcetingmaterialsDataGridViewTextBoxColumn.Width = 180;
            // 
            // theplatformusedDataGridViewTextBoxColumn
            // 
            this.theplatformusedDataGridViewTextBoxColumn.DataPropertyName = "The_platform_used";
            this.theplatformusedDataGridViewTextBoxColumn.HeaderText = "The_platform_used";
            this.theplatformusedDataGridViewTextBoxColumn.Name = "theplatformusedDataGridViewTextBoxColumn";
            this.theplatformusedDataGridViewTextBoxColumn.Width = 160;
            // 
            // profittheplatformDataGridViewTextBoxColumn
            // 
            this.profittheplatformDataGridViewTextBoxColumn.DataPropertyName = "Profit_the_platform";
            this.profittheplatformDataGridViewTextBoxColumn.HeaderText = "Profit_the_platform";
            this.profittheplatformDataGridViewTextBoxColumn.Name = "profittheplatformDataGridViewTextBoxColumn";
            this.profittheplatformDataGridViewTextBoxColumn.Width = 160;
            // 
            // idoacDataGridViewTextBoxColumn
            // 
            this.idoacDataGridViewTextBoxColumn.DataPropertyName = "id_o_a_c";
            this.idoacDataGridViewTextBoxColumn.HeaderText = "id_o_a_c";
            this.idoacDataGridViewTextBoxColumn.Name = "idoacDataGridViewTextBoxColumn";
            this.idoacDataGridViewTextBoxColumn.Width = 180;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 444);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Delete_ID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Маркетинговые материалы";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersandcustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcetingmaterialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private АптекаDataSet5TableAdapters.BuyersTableAdapter buyersTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private АптекаDataSet8 аптекаDataSet8;
        private System.Windows.Forms.BindingSource buyersBindingSource;
        private АптекаDataSet8TableAdapters.BuyersTableAdapter buyersTableAdapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Delete_ID;
        private _The_IP_of_the_electronic_store_DataSet1 _The_IP_of_the_electronic_store_DataSet1;
        private System.Windows.Forms.BindingSource ordersandcustomersBindingSource;
        private _The_IP_of_the_electronic_store_DataSet1TableAdapters.Orders_and_customersTableAdapter orders_and_customersTableAdapter;
        private _The_IP_of_the_electronic_store_DataSet3 _The_IP_of_the_electronic_store_DataSet3;
        private System.Windows.Forms.BindingSource marcetingmaterialBindingSource;
        private _The_IP_of_the_electronic_store_DataSet3TableAdapters.Marceting_materialTableAdapter marceting_materialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofmarcetingmaterialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theplatformusedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profittheplatformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoacDataGridViewTextBoxColumn;
    }
}