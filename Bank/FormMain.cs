using Bank.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
                e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
    DialogResult.Yes;

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,БИС,Бакшеев Владислав, группа 731-2, 2023 год", "О программе",
MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStripMain_Opening(object sender, CancelEventArgs e)
        {

        }

        private void клиентToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormClients.fd.ShowForm();


        }

        private void заявкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormStatement fc = new FormStatement();
            fc.Show();
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormWorkersList fc = new FormWorkersList();
            fc.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
