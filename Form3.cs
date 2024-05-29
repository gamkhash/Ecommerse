using System;
using System.Windows.Forms;

namespace Аптека
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_The_IP_of_the_electronic_store_DataSet2.List_of_the_betatesters". При необходимости она может быть перемещена или удалена.
            this.list_of_the_betatestersTableAdapter.Fill(this._The_IP_of_the_electronic_store_DataSet2.List_of_the_betatesters);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
