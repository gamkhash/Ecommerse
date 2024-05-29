using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Аптека
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_The_IP_of_the_electronic_store_DataSet3.Marceting_material". При необходимости она может быть перемещена или удалена.
            this.marceting_materialTableAdapter.Fill(this._The_IP_of_the_electronic_store_DataSet3.Marceting_material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_The_IP_of_the_electronic_store_DataSet1.Orders_and_customers". При необходимости она может быть перемещена или удалена.
            this.orders_and_customersTableAdapter.Fill(this._The_IP_of_the_electronic_store_DataSet1.Orders_and_customers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet8.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this.аптекаDataSet8.Buyers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
