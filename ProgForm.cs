using System;
using System.Windows.Forms;

namespace Программный_комплекс_конвертер_валют_MySQL
{
    public partial class ProgForm : Form
    {
        public ProgForm()
        {
            InitializeComponent();
        }

        private void АвторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            new LoginForm().Show();
        }

        private void КонвертерВалютToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KonvForm LoginForm = new KonvForm();
            new KonvForm().Show();
        }

        private void ПомощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpForm HelpForm = new HelpForm();
            HelpForm.Show();
        }

        private void РегистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm RegForm = new RegForm();
            new RegForm().Show();
        }
    }
}
