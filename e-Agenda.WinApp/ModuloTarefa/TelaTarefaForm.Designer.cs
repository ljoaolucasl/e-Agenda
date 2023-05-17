namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            lbId = new Label();
            lbTitulo = new Label();
            lbPrioridade = new Label();
            txtTitulo = new TextBox();
            cbPrioridade = new ComboBox();
            txtId = new TextBox();
            btnCancelar = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(22, 28);
            lbId.Name = "lbId";
            lbId.Size = new Size(54, 15);
            lbId.TabIndex = 0;
            lbId.Text = "Número:";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new Point(36, 57);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(40, 15);
            lbTitulo.TabIndex = 1;
            lbTitulo.Text = "Título:";
            // 
            // lbPrioridade
            // 
            lbPrioridade.AutoSize = true;
            lbPrioridade.Location = new Point(12, 86);
            lbPrioridade.Name = "lbPrioridade";
            lbPrioridade.Size = new Size(64, 15);
            lbPrioridade.TabIndex = 2;
            lbPrioridade.Text = "Prioridade:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(82, 54);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(329, 23);
            txtTitulo.TabIndex = 3;
            // 
            // cbPrioridade
            // 
            cbPrioridade.FormattingEnabled = true;
            cbPrioridade.Items.AddRange(new object[] { "Baixa", "Média", "Alta", "Urgente" });
            cbPrioridade.Location = new Point(82, 83);
            cbPrioridade.Name = "cbPrioridade";
            cbPrioridade.Size = new Size(100, 23);
            cbPrioridade.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(82, 25);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(338, 161);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Location = new Point(262, 161);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 209);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(txtId);
            Controls.Add(cbPrioridade);
            Controls.Add(txtTitulo);
            Controls.Add(lbPrioridade);
            Controls.Add(lbTitulo);
            Controls.Add(lbId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Tarefas";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label lbTitulo;
        private Label lbPrioridade;
        private TextBox txtTitulo;
        private ComboBox cbPrioridade;
        private Button btnCancelar;
        private Button btnAdd;
        public TextBox txtId;
    }
}