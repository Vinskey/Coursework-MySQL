using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Программный_комплекс_конвертер_валют_MySQL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void ПомощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpForm HelpForm = new HelpForm();
            HelpForm.Show();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                MessageBox.Show("Введите логин","Ошибка");
                return;
            }

            if (passField.Text == "")
            {
                MessageBox.Show("Введите пароль", "Ошибка");
                return;
            }  

            string loginUser = loginField.Text;
            string passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`WHERE`login`= @uL AND `pass`= @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Добро пожаловать");
            else
                MessageBox.Show("Неверный логин или пароль", "Ошибка");

        }

        private void КонвертерВалютToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KonvForm KonvForm = new KonvForm();
            new KonvForm().Show();
        }

        private void РегистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm RegForm = new RegForm();
            new RegForm().Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm RegForm = new RegForm();
            new RegForm().Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgForm ProgForm = new ProgForm();
            new ProgForm().Show();
        }
    }
}
