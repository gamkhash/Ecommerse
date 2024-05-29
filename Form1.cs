using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Аптека
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}
public class UserManager
{
private string connectionString = "Data Source=DESKTOP-JC5A2Q8\SQLEXPRESS;Initial Catalog= Аптека;Integrated Security=True";
public bool AuthenticateUser(string userName, string userPassword)
{
using (SqlConnection connection = new SqlConnection(connectionString))
{
connection.Open();
string query = "SELECT COUNT(*) FROM P_and_L WHERE Login  = @Login AND Passworsd = @Passworsd"; // Комментарий: Выборка количества записей в таблице P_and_L, где значение Login равно переданному userName и значение Passworsd равно переданному userPassword
SqlCommand command = new SqlCommand(query, connection);
command.Parameters.AddWithValue("@Login", userName);
command.Parameters.AddWithValue("@Passworsd", userPassword);
int count = (int)command.ExecuteScalar();
return count > 0;
}
}
}

    private void button1_Click(object sender, EventArgs e)
    {
<<<<<<< HEAD
        public Form1()
        {
            InitializeComponent();
        }
        public class UserManager
        {
            private string connectionString = "Data Source=DESKTOP-JC5A2Q8\\SQLEXPRESS;Initial Catalog= The_IP_of_the_electronic_store. ;Integrated Security=True";
                public bool AuthenticateUser(string username, string password)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Log_and_pass_ WHERE Login  = @Login AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
=======
        string userName = TextBoxUsername.Text;
        string userPassword = PasswordTextBox.Text;
>>>>>>> 8a8b8ffb756b0d56d6383f1f99eb7fcb920be4c4

        UserManager userManager = new UserManager();
        if (userManager.AuthenticateUser(userName, userPassword))
        {
<<<<<<< HEAD
            string username = TextBoxUsername.Text;
            string password = PasswordTextBox.Text;

            UserManager userManager = new UserManager();
            if (userManager.AuthenticateUser(username, password))
            {
                MessageBox.Show("Вы успешно вошли в систему");

                Program.form2 = new Form2();
                Program.form2.Show();
                this.Hide();

                //Form2 form = new Form2();
                //form.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль!");
            }
=======
            MessageBox.Show("Вы успешно вошли в систему");
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Неправильное имя пользователя или пароль!");
>>>>>>> 8a8b8ffb756b0d56d6383f1f99eb7fcb920be4c4
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
}




