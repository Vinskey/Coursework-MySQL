using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Программный_комплекс_конвертер_валют_MySQL
{
    public partial class RegForm : Form
    {


        public RegForm()
        {
            InitializeComponent();
         
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgForm ProgForm = new ProgForm();
            new ProgForm().Show();
        }

        private void ПомощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpForm HelpForm = new HelpForm();
            HelpForm.Show();
        }

        private void АвторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        private void КонвертерВалютToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KonvForm KonvForm = new KonvForm();
            KonvForm.Show();
        }

        private void Regbutton_Click(object sender, EventArgs e)
        {
            if (UserNameField.Text == "")
            {
                MessageBox.Show("Введите имя","Ошибка");
                return;
            }

            if (UserSurNameField.Text == "")
            {
                MessageBox.Show("Введите фамилию","Ошибка");
                return;
            }

            if (loginField.Text == "")
            {
                MessageBox.Show("Введите логин","Ошибка");
                return;
            }

            if (passField.Text == "")
            {
                MessageBox.Show("Введите пароль","Ошибка");
                return;
            }

            if (IsUserExists())
                return;


            DB db = new DB();
            MySqlCommand Command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surmane`) VALUES (@ul, @up, @un, @us)", db.GetConnection());

            Command.Parameters.AddWithValue("@ul", loginField.Text);
            Command.Parameters.AddWithValue("@up", passField.Text);
            Command.Parameters.AddWithValue("@un", UserNameField.Text);
            Command.Parameters.AddWithValue("@us", UserSurNameField.Text);

            db.OpenConnection();
            
                if (Command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.CloseConnection();
        }

        public Boolean IsUserExists() 
        {DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`WHERE`login`= @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже зарегистрирован введите другой", "Ошибка");
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
