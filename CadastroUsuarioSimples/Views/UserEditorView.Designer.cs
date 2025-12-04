namespace CadastroUsuarioSimples.Views
{
    partial class UserEditorView
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Nome";
            this.txtName.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtName.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // txtSurname
            // 
            this.txtSurname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSurname.Location = new System.Drawing.Point(235, 12);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(271, 22);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Text = "Sobrenome";
            this.txtSurname.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtSurname.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // txtTelephone
            // 
            this.txtTelephone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTelephone.Location = new System.Drawing.Point(12, 55);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(200, 22);
            this.txtTelephone.TabIndex = 2;
            this.txtTelephone.Text = "Telefone";
            this.txtTelephone.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtTelephone.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(235, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(271, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "E-mail";
            this.txtEmail.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtEmail.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // txtOccupation
            // 
            this.txtOccupation.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOccupation.Location = new System.Drawing.Point(12, 139);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(200, 22);
            this.txtOccupation.TabIndex = 4;
            this.txtOccupation.Text = "Profissão";
            this.txtOccupation.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtOccupation.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // txtAddress
            // 
            this.txtAddress.AccessibleDescription = "";
            this.txtAddress.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAddress.Location = new System.Drawing.Point(12, 97);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(494, 22);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Text = "Endereço";
            this.txtAddress.Click += new System.EventHandler(this.OnClickTextBox);
            this.txtAddress.Leave += new System.EventHandler(this.OnLeaveTextBox);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(431, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // UserEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 248);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "UserEditorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar / Editar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}