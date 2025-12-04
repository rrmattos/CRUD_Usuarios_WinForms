using CadastroUsuarioSimples.Controllers;
using CadastroUsuarioSimples.Models;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CadastroUsuarioSimples.Views
{
    public partial class UserEditorView : Form
    {
        private readonly UserController _controller;
        private User _user;
        private User _originalUser;

        public UserEditorView(UserController controller, int userId = 0)
        {
            InitializeComponent();
            _controller = controller;

            if (userId > 0)
                LoadUser(userId);
            else
                _user = new User();
        }

        public UserEditorView(UserController controller)
        {
            InitializeComponent();
            _controller = controller;

            _user = new User();
            _originalUser = new User();
        }

        private async void LoadUser(int id)
        {
            _user = await _controller.GetById(id);

            if (_user == null)
            {
                MessageBox.Show("Usuário não encontrado!", "Erro");
                Close();
                return;
            }

            _originalUser = new User
            {
                Id = _user.Id,
                Nome = _user.Nome,
                Sobrenome = _user.Sobrenome,
                Telefone = _user.Telefone,
                Email = _user.Email,
                Profissao = _user.Profissao,
                Endereco = _user.Endereco,
                DataCadastro = _user.DataCadastro
            };

            txtName.Text = _user.Nome;
            txtSurname.Text = _user.Sobrenome;
            txtTelephone.Text = _user.Telefone;
            txtEmail.Text = _user.Email;
            txtOccupation.Text = _user.Profissao;
            txtAddress.Text = _user.Endereco;

            OnLoadUser();
        }


        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            _user.Nome = txtName.Text.Trim();
            _user.Sobrenome = txtSurname.Text.Trim();
            _user.Telefone = txtTelephone.Text.Trim();
            _user.Email = txtEmail.Text.Trim();
            _user.Profissao = txtOccupation.Text.Trim();
            _user.Endereco = txtAddress.Text.Trim();

            if (_user.Id == 0)
                _user.DataCadastro = await _controller.GetCurrentDateTime();

            bool sucesso = await _controller.Save(_user);

            if (sucesso)
            {
                MessageBox.Show("Usuário salvo com sucesso!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar usuário.");
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_user.Id == 0)
            {
                MessageBox.Show("Usuário ainda não foi salvo!");
                return;
            }

            var confirm = MessageBox.Show(
                "Deseja realmente excluir o cadastro?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                bool sucesso = await _controller.Delete(_user.Id);

                if (sucesso)
                {
                    MessageBox.Show("Usuário excluído.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir usuário.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_user.Id == 0 && !HouveAlteracao())
            {
                Close();
                return;
            }

            if (_user.Id > 0 && !HouveAlteracao())
            {
                Close();
                return;
            }

            var confirm = MessageBox.Show(
                "Deseja realmente cancelar as modificações?",
                "Confirmar Cancelamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
                Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text == "Nome")
            {
                MessageBox.Show("O campo Nome é obrigatório.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text) || txtSurname.Text == "Sobrenome")
            {
                MessageBox.Show("O campo Sobrenome é obrigatório.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelephone.Text) || txtTelephone.Text == "Telefone")
            {
                MessageBox.Show("O campo Telefone é obrigatório.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text == "E-mail")
            {
                MessageBox.Show("O campo Email é obrigatório.");
                return false;
            }

            if (txtOccupation.Text == "Profissão")
                txtOccupation.Text = "";

            if (txtAddress.Text == "Endereço")
                txtAddress.Text = "";

            return true;
        }

        private bool HouveAlteracao()
        {
            return
                _user.Nome != txtName.Text.Trim() ||
                _user.Sobrenome != txtSurname.Text.Trim() ||
                _user.Telefone != txtTelephone.Text.Trim() ||
                _user.Email != txtEmail.Text.Trim() ||
                _user.Profissao != txtOccupation.Text.Trim() ||
                _user.Endereco != txtAddress.Text.Trim();
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
                if (txt == txtName)
                    txt.Text = "Nome";
                else if (txt == txtSurname)
                    txt.Text = "Sobrenome";
                else if (txt == txtTelephone)
                    txt.Text = "Telefone";
                else if (txt == txtEmail)
                    txt.Text = "Email";
                else if (txt == txtOccupation)
                    txt.Text = "Profissão";
                else if (txt == txtAddress)
                    txt.Text = "Endereço";
            }
        }

        private void OnLoadUser()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "Nome";
                txtName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
            else
            {
                txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                txtSurname.Text = "Sobrenome";
                txtSurname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
            else
            {
                txtSurname.ForeColor = System.Drawing.SystemColors.WindowText;
            }

            if (string.IsNullOrWhiteSpace(txtTelephone.Text))
            {
                txtTelephone.Text = "Telefone";
                txtTelephone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
            else
            {
                txtTelephone.ForeColor = System.Drawing.SystemColors.WindowText;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
            else
            {
                txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            }

            if (string.IsNullOrWhiteSpace(txtOccupation.Text))
            {
                txtOccupation.Text = "Profissão";
                txtOccupation.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
            else
            {
                txtOccupation.ForeColor = System.Drawing.SystemColors.WindowText;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtAddress.Text = "Endereço";
                txtAddress.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
            else
            {
                txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }
    }
}
