using CadastroUsuarioSimples.Controllers;
using CadastroUsuarioSimples.Models;
using CadastroUsuarioSimples.Utils;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuarioSimples.Views
{
    public partial class UserListView : Form
    {
        private readonly UserController _controller;

        private int _currentPage = 1;
        private int _totalPages = 1;
        private int _pageSize = 10;
        private string _currentFilter = "";

        public UserListView()
        {
            InitializeComponent();
            _controller = new UserController();

            LoadUsers();
            gridUsers.CellDoubleClick += GridUsers_CellDoubleClick;
            this.KeyPreview = true;
            this.KeyDown += UserListView_KeyDown;

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 10 * 60 * 1000; // 10 minutos em ms
            timer.Tick += async (s, e) => await UpdateClimateInfo();
            timer.Start();

            UpdateClimateInfo();
        }


        private void LoadUsers()
        {
            var result = _controller.SearchUsers(_currentFilter, _currentPage, _pageSize);
            gridUsers.DataSource = result.Data;

            _totalPages = (int)Math.Ceiling(result.TotalItems / (double)_pageSize);
            lblPageInfo.Text = $"Página {_currentPage} de {_totalPages}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text.Contains("Digite"))
                return;

            _currentFilter = txtFilter.Text.Trim();
            _currentPage = 1;
            LoadUsers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
            _currentFilter = "";
            _currentPage = 1;
            LoadUsers();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                LoadUsers();
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadUsers();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editor = new UserEditorView(_controller);
            if (editor.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void GridUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenSelectedUser();
        }

        private void UserListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OpenSelectedUser();
        }

        private void OpenSelectedUser()
        {
            if (gridUsers.SelectedRows.Count == 0)
                return;

            var user = gridUsers.SelectedRows[0].DataBoundItem as User;
            LoadUsers();
        }

        private void gridUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = (int)gridUsers.Rows[e.RowIndex].Cells["Id"].Value;

            var editor = new UserEditorView(_controller, id);
            if (editor.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void txtNumLines_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                ValidateNumOfLines();
        }

        private void txtNumLines_Leave(object sender, EventArgs e)
        {
            ValidateNumOfLines();
        }

        private void ValidateNumOfLines()
        {
            bool isInt = Int32.TryParse(txtNumLines.Text, out int newPageSize);

            if (!isInt)
            {
                _pageSize = 10;
                txtNumLines.Text = "10";
                this.ActiveControl = null;
                LoadUsers();
                return;
            }

            if (newPageSize > 0 && newPageSize <= 20)
            {
                _pageSize = newPageSize;
            }
            else
            {
                _pageSize = 10;
                txtNumLines.Text = "10";
            }

            LoadUsers();
        }

        private async Task UpdateClimateInfo()
        {
            try
            {
                var locService = new LocationService();
                var (lat, lon) = await locService.GetLocationAsync();

                var weatherService = new WeatherService();
                var info = await weatherService.GetCurrent(lat, lon);

                lblAPI.Text = $"{info.Temperature} °C - {info.WindSpeed} km/h - {info.Time}";
            }
            catch
            {
                lblAPI.Text = "";
            }
        }

        //private void OnClickLabelAPI(object sender, EventArgs e)
        //{
        //    UpdateClimateInfo();
        //}
    }

}
