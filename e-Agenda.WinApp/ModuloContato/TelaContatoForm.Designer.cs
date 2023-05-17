namespace e_Agenda.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            txtEmail = new TextBox();
            txtEmpresa = new TextBox();
            txtTelefone = new MaskedTextBox();
            lbId = new Label();
            lbEmpresa = new Label();
            lbCargo = new Label();
            lbEmail = new Label();
            lbTelefone = new Label();
            lbNome = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(80, 29);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 58);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(283, 119);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(147, 23);
            txtCargo.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(283, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(147, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(80, 116);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(125, 23);
            txtEmpresa.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(80, 87);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 23);
            txtTelefone.TabIndex = 6;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(20, 32);
            lbId.Name = "lbId";
            lbId.Size = new Size(54, 15);
            lbId.TabIndex = 7;
            lbId.Text = "Número:";
            // 
            // lbEmpresa
            // 
            lbEmpresa.AutoSize = true;
            lbEmpresa.Location = new Point(19, 119);
            lbEmpresa.Name = "lbEmpresa";
            lbEmpresa.Size = new Size(55, 15);
            lbEmpresa.TabIndex = 8;
            lbEmpresa.Text = "Empresa:";
            // 
            // lbCargo
            // 
            lbCargo.AutoSize = true;
            lbCargo.Location = new Point(235, 122);
            lbCargo.Name = "lbCargo";
            lbCargo.Size = new Size(42, 15);
            lbCargo.TabIndex = 9;
            lbCargo.Text = "Cargo:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(233, 93);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(44, 15);
            lbEmail.TabIndex = 10;
            lbEmail.Text = "E-Mail:";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(20, 90);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(54, 15);
            lbTelefone.TabIndex = 11;
            lbTelefone.Text = "Telefone:";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(31, 61);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(43, 15);
            lbNome.TabIndex = 12;
            lbNome.Text = "Nome:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(296, 210);
            button1.Name = "button1";
            button1.Size = new Size(70, 36);
            button1.TabIndex = 13;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(372, 210);
            button2.Name = "button2";
            button2.Size = new Size(70, 36);
            button2.TabIndex = 14;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 258);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbNome);
            Controls.Add(lbTelefone);
            Controls.Add(lbEmail);
            Controls.Add(lbCargo);
            Controls.Add(lbEmpresa);
            Controls.Add(lbId);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmpresa);
            Controls.Add(txtEmail);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            ShowIcon = false;
            Text = "Cadastro de Contatos";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtEmail;
        private TextBox txtEmpresa;
        private MaskedTextBox txtTelefone;
        private Label lbId;
        private Label lbEmpresa;
        private Label lbCargo;
        private Label lbEmail;
        private Label lbTelefone;
        private Label lbNome;
        private Button button1;
        private Button button2;
        public TextBox txtId;
    }
}