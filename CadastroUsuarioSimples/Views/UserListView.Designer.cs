namespace CadastroUsuarioSimples.Views
{
    partial class UserListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.lblQtdLinhas = new System.Windows.Forms.Label();
            this.txtNumLines = new System.Windows.Forms.TextBox();
            this.lblAPI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(43, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Procurar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(464, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(657, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Novo Usuário";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFilter.Location = new System.Drawing.Point(124, 13);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(309, 22);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.Text = "Digite alguma informação para a busca...";
            this.txtFilter.Enter += new System.EventHandler(this.btnClear_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(-8, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(814, 41);
            this.progressBar1.TabIndex = 5;
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Location = new System.Drawing.Point(43, 65);
            this.gridUsers.MultiSelect = false;
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.RowHeadersWidth = 51;
            this.gridUsers.RowTemplate.Height = 24;
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.Size = new System.Drawing.Size(714, 301);
            this.gridUsers.TabIndex = 6;
            this.gridUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsers_CellContentDoubleClick);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrev.Location = new System.Drawing.Point(258, 372);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Anterior";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Location = new System.Drawing.Point(437, 372);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Próxima";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(339, 375);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(92, 16);
            this.lblPageInfo.TabIndex = 9;
            this.lblPageInfo.Text = "Página X de Y";
            // 
            // lblQtdLinhas
            // 
            this.lblQtdLinhas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQtdLinhas.AutoSize = true;
            this.lblQtdLinhas.Location = new System.Drawing.Point(40, 375);
            this.lblQtdLinhas.Name = "lblQtdLinhas";
            this.lblQtdLinhas.Size = new System.Drawing.Size(132, 16);
            this.lblQtdLinhas.TabIndex = 10;
            this.lblQtdLinhas.Text = "Nº de linhas por pág.";
            // 
            // txtNumLines
            // 
            this.txtNumLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumLines.Location = new System.Drawing.Point(180, 372);
            this.txtNumLines.Name = "txtNumLines";
            this.txtNumLines.Size = new System.Drawing.Size(33, 22);
            this.txtNumLines.TabIndex = 11;
            this.txtNumLines.Text = "10\r\n\r\n";
            this.txtNumLines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumLines_KeyPress);
            this.txtNumLines.Leave += new System.EventHandler(this.txtNumLines_Leave);
            // 
            // lblAPI
            // 
            this.lblAPI.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAPI.AutoSize = true;
            this.lblAPI.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPI.Location = new System.Drawing.Point(268, 425);
            this.lblAPI.Name = "lblAPI";
            this.lblAPI.Size = new System.Drawing.Size(0, 16);
            this.lblAPI.TabIndex = 12;
            this.lblAPI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAPI);
            this.Controls.Add(this.txtNumLines);
            this.Controls.Add(this.lblQtdLinhas);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.gridUsers);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Name = "UserListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Label lblQtdLinhas;
        private System.Windows.Forms.TextBox txtNumLines;
        private System.Windows.Forms.Label lblAPI;
    }
}