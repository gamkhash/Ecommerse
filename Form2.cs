using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Аптека
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Program.form3 = new Form3();
            Program.form4 = new Form4();    
        }




        private string connectionString = "Data Source=DESKTOP-JC5A2Q8\\SQLEXPRESS;Initial Catalog= The_IP_of_the_electronic_store. ;Integrated Security=True";

        private void Form2_Load(object sender, EventArgs e)//загружаются данные в различные таблицы из базы данных.
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_The_IP_of_the_electronic_store_DataSet.Orders_and_customers". При необходимости она может быть перемещена или удалена.
            this.orders_and_customersTableAdapter.Fill(this._The_IP_of_the_electronic_store_DataSet.Orders_and_customers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet7.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter2.Fill(this.аптекаDataSet7.Buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet6.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter1.Fill(this.аптекаDataSet6.Buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet5.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this.аптекаDataSet5.Buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптекаDataSet2.Madication". При необходимости она может быть перемещена или удалена.
            this.madicationTableAdapter2.Fill(this.аптекаDataSet2.Madication);

        }
        private void AddButton_Click(object sender, EventArgs e)//добавляет новую строку в таблицу Madication, после проверки заполнения всех текстовых полей.
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все три текстовых поля.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT MAX(id_M) FROM The_IP_of_the_electronic_store", connection);
                int lastId = Convert.ToInt32(command.ExecuteScalar());

                command = new SqlCommand("INSERT INTO The_IP_of_the_electronic_store. (id_Orders, Clients_full_name,Payment_method, The_prise_of_the_prodyct,Prodyc_name) VALUES (@id_Orders, @Clients_full_name, @Payment_method, @The_prise_of_the_prodyct, @Prodyc_name))", connection);

<<<<<<< HEAD

                command.Parameters.AddWithValue("@id_Orders", lastId + 1);
                command.Parameters.AddWithValue("@Clients_full_name", textBox1.Text);
                command.Parameters.AddWithValue("@Payment_method", textBox2.Text);
                command.Parameters.AddWithValue("@The_prise_of_the_prodyct", (textBox3.Text));
                command.Parameters.AddWithValue("@Prodyc_name", (textBox4.Text));
=======
//Изменены названия обектов textBox
                command.Parameters.AddWithValue("@id_Mtion", lastId + 1);
                command.Parameters.AddWithValue("@Name_of_the_drug", textBoxNameID.Text);
                command.Parameters.AddWithValue("@The_amount_of_the_drug", textBoxAmount.Text);
                command.Parameters.AddWithValue("@Country_of_the_drug", (textBoxCountry.Text));
                command.Parameters.AddWithValue("@The_prise_of_the_drug", (textBoxPrise.Text));
>>>>>>> 8a8b8ffb756b0d56d6383f1f99eb7fcb920be4c4
                command.ExecuteNonQuery();
                MessageBox.Show("Новая строка добавлена в базу данных.");
            }
            this.madicationTableAdapter2.Fill(this.аптекаDataSet2.Madication);

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все текстовые поля.");
                return;
            }
            int id_Mtion = Convert.ToInt32(textBox4.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE  The_IP_of_the_electronic_store SET Clients_full_name=@Clients, Payment_method=@Payment, The_prise_of_the_prodyct=@Price,Prodyc_name=Prodyct WHERE id_Orders = @id", connection);
                command.Parameters.AddWithValue("@id_Orders", int.Parse(textBox4.Text));
                command.Parameters.AddWithValue("@Clients_full_name", id_Mtion);
                command.Parameters.AddWithValue("@The_prise_of_the_prodyct", (textBox4.Text));
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Строка успешно обновлена в базе данных.");
                }
                else
                {
                    MessageBox.Show("Не удалось найти строку с указанным Id.");
                }
            }
            this.madicationTableAdapter2.Fill(this.аптекаDataSet2.Madication);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Пожалуйста, введите Id строки для удаления.");//Строка для вида
                return;
            }

            int id = Convert.ToInt32(textBox4.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Madication WHERE id_Mtion = @id_Mtion", connection);
                command.Parameters.AddWithValue("@id_Mtion", id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Строка успешно удалена из базы данных.");
                }
                else
                {
                    MessageBox.Show("Не удалось найти строку с указанным Id.");
                }
            }
            this.madicationTableAdapter2.Fill(this.аптекаDataSet2.Madication);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form3.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
