namespace Аптека
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listofthebetatestersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._The_IP_of_the_electronic_store_DataSet2 = new Аптека._The_IP_of_the_electronic_store_DataSet2();
            this.list_of_the_betatestersTableAdapter = new Аптека._The_IP_of_the_electronic_store_DataSet2TableAdapters.List_of_the_betatestersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.idlBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnamebetatestersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarybetatestersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thetesterspartofthesystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listofthebetatestersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlBDataGridViewTextBoxColumn,
            this.fullnamebetatestersDataGridViewTextBoxColumn,
            this.salarybetatestersDataGridViewTextBoxColumn,
            this.thetesterspartofthesystemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listofthebetatestersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // listofthebetatestersBindingSource
            // 
            this.listofthebetatestersBindingSource.DataMember = "List_of_the_betatesters";
            this.listofthebetatestersBindingSource.DataSource = this._The_IP_of_the_electronic_store_DataSet2;
            // 
            // _The_IP_of_the_electronic_store_DataSet2
            // 
            this._The_IP_of_the_electronic_store_DataSet2.DataSetName = "_The_IP_of_the_electronic_store_DataSet2";
            this._The_IP_of_the_electronic_store_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // list_of_the_betatestersTableAdapter
            // 
            this.list_of_the_betatestersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idlBDataGridViewTextBoxColumn
            // 
            this.idlBDataGridViewTextBoxColumn.DataPropertyName = "id_l_B";
            this.idlBDataGridViewTextBoxColumn.HeaderText = "id_l_B";
            this.idlBDataGridViewTextBoxColumn.Name = "idlBDataGridViewTextBoxColumn";
            this.idlBDataGridViewTextBoxColumn.Width = 160;
            // 
            // fullnamebetatestersDataGridViewTextBoxColumn
            // 
            this.fullnamebetatestersDataGridViewTextBoxColumn.DataPropertyName = "full_name_betatesters";
            this.fullnamebetatestersDataGridViewTextBoxColumn.HeaderText = "full_name_betatesters";
            this.fullnamebetatestersDataGridViewTextBoxColumn.Name = "fullnamebetatestersDataGridViewTextBoxColumn";
            this.fullnamebetatestersDataGridViewTextBoxColumn.Width = 200;
            // 
            // salarybetatestersDataGridViewTextBoxColumn
            // 
            this.salarybetatestersDataGridViewTextBoxColumn.DataPropertyName = "Salary_betatesters";
            this.salarybetatestersDataGridViewTextBoxColumn.HeaderText = "Salary_betatesters";
            this.salarybetatestersDataGridViewTextBoxColumn.Name = "salarybetatestersDataGridViewTextBoxColumn";
            this.salarybetatestersDataGridViewTextBoxColumn.Width = 200;
            // 
            // thetesterspartofthesystemDataGridViewTextBoxColumn
            // 
            this.thetesterspartofthesystemDataGridViewTextBoxColumn.DataPropertyName = "The_testers_part_of_the_system";
            this.thetesterspartofthesystemDataGridViewTextBoxColumn.HeaderText = "The_testers_part_of_the_system";
            this.thetesterspartofthesystemDataGridViewTextBoxColumn.Name = "thetesterspartofthesystemDataGridViewTextBoxColumn";
            this.thetesterspartofthesystemDataGridViewTextBoxColumn.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "id_I_B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя ползователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Зарплата пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Тестируемая часть системы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 362);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(190, 362);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Список пользовательей-тестировщиков";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listofthebetatestersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _The_IP_of_the_electronic_store_DataSet2 _The_IP_of_the_electronic_store_DataSet2;
        private System.Windows.Forms.BindingSource listofthebetatestersBindingSource;
        private _The_IP_of_the_electronic_store_DataSet2TableAdapters.List_of_the_betatestersTableAdapter list_of_the_betatestersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnamebetatestersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarybetatestersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thetesterspartofthesystemDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
    }
}