using CadastroUsuarioSimples.Controllers;
using CadastroUsuarioSimples.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CadastroUsuarioSimples.Views
{
    public partial class ConnectionView : Form
    {
        private readonly ConnectionController _controller;

        public ConnectionView()
        {
            InitializeComponent();
            _controller = new ConnectionController();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var controller = new ConnectionController();

            bool ok = controller.UseMySql(
                txtServer.Text,
                txtPort.Text,
                txtUser.Text,
                txtPassword.Text,
                txtDatabase.Text
            );

            if (!ok)
            {
                MessageBox.Show("Não foi possível conectar.");
                return;
            }

            var next = new UserListView();
            next.Show();
            this.Hide();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            var controller = new ConnectionController();

            bool ok = controller.UseLocalDatabase();

            if (!ok)
            {
                MessageBox.Show("Não foi possível conectar.");
                return;
            }

            var next = new UserListView();
            next.Show();
            this.Hide();
        }

        private void OnClickTextBox(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt.ForeColor == System.Drawing.SystemColors.InactiveCaption)
            {
                txt.ForeColor = System.Drawing.SystemColors.WindowText;
                txt.Text = "";
            }

            if (txt != null)
            {
                txt.SelectAll();
            }
        }

        private void OnLeaveTextBox(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
                if (txt == txtServer)
                    txt.Text = "Endereço do servidor";
                else if (txt == txtPort)
                    txt.Text = "3306";
                else if (txt == txtUser)
                    txt.Text = "Usuário";
                else if (txt == txtPassword)
                    txt.Text = "";
                else if (txt == txtDatabase)
                    txt.Text = "Nome do banco";
            }
        }
    }
}
