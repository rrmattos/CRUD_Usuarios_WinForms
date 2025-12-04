namespace CadastroUsuarioSimples.Views
{
    partial class ConnectionView
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtServer.Location = new System.Drawing.Point(160, 32);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(245, 22);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "Endereço do servidor";
            this.txtServer.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtServer.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // txtUser
            // 
            this.txtUser.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUser.Location = new System.Drawing.Point(160, 77);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(245, 22);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Usuário";
            this.txtUser.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtUser.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(160, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(245, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Senha";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtPassword.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(160, 223);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(245, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Conectar ao banco (MySQL)";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(160, 264);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(245, 23);
            this.btnLocal.TabIndex = 4;
            this.btnLocal.Text = "Usar banco local (SQLite)";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDatabase.Location = new System.Drawing.Point(160, 174);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(245, 22);
            this.txtDatabase.TabIndex = 5;
            this.txtDatabase.Text = "Nome do banco";
            this.txtDatabase.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtDatabase.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // txtPort
            // 
            this.txtPort.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPort.Location = new System.Drawing.Point(411, 32);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(46, 22);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "3306";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPort.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtPort.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // ConnectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 308);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtServer);
            this.Name = "ConnectionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial - Conexão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtPort;
    }
}