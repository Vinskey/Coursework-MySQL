using System;
using System.Windows.Forms;

namespace Программный_комплекс_конвертер_валют_MySQL
{
    public partial class KonvForm : Form
    {
        public KonvForm()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void Button1_Click(object sender, EventArgs e)
        {
            string from, to;

            from = listBox1.SelectedItem.ToString(); // выбранная валюта в 1 списке
            to = listBox2.SelectedItem.ToString(); // выбранная валюта во 2 списке

            if (from == to)
            {
                MessageBox.Show("Это одна и та же валюта!", "Внимание!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Введите количество валюты!", "Внимание!");
            }
            else
            {
                webBrowser1.Navigate("https://www.google.ru/search?q=" + textBox1.Text + " " + from + " %D0%B2 " + to);
            }
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgForm ProgForm = new ProgForm();
            new ProgForm().Show();
        }

        private void РегистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm RegForm = new RegForm();
            new RegForm().Show();
        }
    }
}
