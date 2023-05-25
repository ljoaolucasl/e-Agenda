namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TelaCategoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCategoriaForm));
            btnCancelar = new Button();
            btnAdd = new Button();
            lbTitulo = new Label();
            lbId = new Label();
            txtTitulo = new TextBox();
            txtId = new TextBox();
            avisoErro = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)avisoErro).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(207, 124);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(131, 124);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Gravar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new Point(54, 67);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(40, 15);
            lbTitulo.TabIndex = 39;
            lbTitulo.Text = "Título:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(40, 38);
            lbId.Name = "lbId";
            lbId.Size = new Size(54, 15);
            lbId.TabIndex = 36;
            lbId.Text = "Número:";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.Window;
            txtTitulo.Location = new Point(100, 64);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(153, 23);
            txtTitulo.TabIndex = 34;
            txtTitulo.Validating += Validacoes_Validating;
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 35);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 33;
            // 
            // avisoErro
            // 
            avisoErro.BlinkRate = 0;
            avisoErro.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            avisoErro.ContainerControl = this;
            avisoErro.Icon = (Icon)resources.GetObject("avisoErro.Icon");
            // 
            // TelaCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 172);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(lbTitulo);
            Controls.Add(lbId);
            Controls.Add(txtTitulo);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCategoriaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Categorias";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)avisoErro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAdd;
        private Label lbTitulo;
        private Label lbId;
        private TextBox txtTitulo;
        public TextBox txtId;
        private ErrorProvider avisoErro;
    }
}