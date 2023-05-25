namespace e_Agenda.WinApp.ModuloDespesas
{
    partial class TelaDespesaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDespesaForm));
            btnCancelar = new Button();
            btnAdd = new Button();
            lbDescricao = new Label();
            lbValor = new Label();
            lbData = new Label();
            lbId = new Label();
            txtValor = new TextBox();
            txtDescricao = new TextBox();
            txtId = new TextBox();
            dtData = new DateTimePicker();
            cbPagamento = new ComboBox();
            lbPagamento = new Label();
            gpCategorias = new GroupBox();
            checkListCategorias = new CheckedListBox();
            avisoErro = new ErrorProvider(components);
            gpCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avisoErro).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(451, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(375, 312);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Gravar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Location = new Point(41, 72);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(61, 15);
            lbDescricao.TabIndex = 26;
            lbDescricao.Text = "Descrição:";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(42, 101);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(60, 15);
            lbValor.TabIndex = 25;
            lbValor.Text = "Valor (R$):";
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(68, 130);
            lbData.Name = "lbData";
            lbData.Size = new Size(34, 15);
            lbData.TabIndex = 22;
            lbData.Text = "Data:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(48, 43);
            lbId.Name = "lbId";
            lbId.Size = new Size(54, 15);
            lbId.TabIndex = 21;
            lbId.Text = "Número:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(108, 98);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(153, 23);
            txtValor.TabIndex = 18;
            txtValor.KeyPress += txtValor_ApenasNumeros_KeyPress;
            txtValor.Validating += Validacoes_Validating;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = SystemColors.Window;
            txtDescricao.Location = new Point(108, 69);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(153, 23);
            txtDescricao.TabIndex = 16;
            txtDescricao.Validating += Validacoes_Validating;
            // 
            // txtId
            // 
            txtId.Location = new Point(108, 40);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 15;
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(108, 127);
            dtData.Name = "dtData";
            dtData.Size = new Size(108, 23);
            dtData.TabIndex = 29;
            // 
            // cbPagamento
            // 
            cbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPagamento.FormattingEnabled = true;
            cbPagamento.Items.AddRange(new object[] { "Dinheiro", "Debito", "Credito", "Pix" });
            cbPagamento.Location = new Point(108, 156);
            cbPagamento.Name = "cbPagamento";
            cbPagamento.Size = new Size(121, 23);
            cbPagamento.TabIndex = 30;
            cbPagamento.Validating += Validacoes_Validating;
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Location = new Point(20, 159);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(82, 15);
            lbPagamento.TabIndex = 31;
            lbPagamento.Text = "Form de Pgto:";
            lbPagamento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gpCategorias
            // 
            gpCategorias.Controls.Add(checkListCategorias);
            gpCategorias.Location = new Point(296, 21);
            gpCategorias.Name = "gpCategorias";
            gpCategorias.Size = new Size(225, 276);
            gpCategorias.TabIndex = 32;
            gpCategorias.TabStop = false;
            gpCategorias.Text = "Categorias";
            // 
            // checkListCategorias
            // 
            checkListCategorias.Dock = DockStyle.Fill;
            checkListCategorias.FormattingEnabled = true;
            checkListCategorias.Location = new Point(3, 19);
            checkListCategorias.Name = "checkListCategorias";
            checkListCategorias.Size = new Size(219, 254);
            checkListCategorias.TabIndex = 0;
            checkListCategorias.Validating += Validacoes_Validating;
            // 
            // avisoErro
            // 
            avisoErro.BlinkRate = 0;
            avisoErro.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            avisoErro.ContainerControl = this;
            avisoErro.Icon = (Icon)resources.GetObject("avisoErro.Icon");
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 367);
            Controls.Add(gpCategorias);
            Controls.Add(lbPagamento);
            Controls.Add(cbPagamento);
            Controls.Add(dtData);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(lbDescricao);
            Controls.Add(lbValor);
            Controls.Add(lbData);
            Controls.Add(lbId);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDespesaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Despesas";
            TopMost = true;
            gpCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)avisoErro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAdd;
        private Label lbDescricao;
        private Label lbValor;
        private Label lbData;
        private Label lbId;
        private TextBox txtValor;
        private TextBox txtDescricao;
        public TextBox txtId;
        private DateTimePicker dtData;
        private ComboBox cbPagamento;
        private Label lbPagamento;
        private GroupBox gpCategorias;
        private ErrorProvider avisoErro;
        internal CheckedListBox checkListCategorias;
    }
}