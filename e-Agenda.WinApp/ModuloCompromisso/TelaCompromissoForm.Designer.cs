namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCompromissoForm));
            txtId = new TextBox();
            txtAssunto = new TextBox();
            txtRemoto = new TextBox();
            txtPresencial = new TextBox();
            cbContato = new ComboBox();
            radioRemoto = new RadioButton();
            radioPresencial = new RadioButton();
            dtData = new DateTimePicker();
            checkContato = new CheckBox();
            dtInicio = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtFinal = new DateTimePicker();
            gbLocalizacao = new GroupBox();
            btnCancelar = new Button();
            btnAdd = new Button();
            avisoErro = new ErrorProvider(components);
            gbLocalizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avisoErro).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(93, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 0;
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(93, 62);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(336, 23);
            txtAssunto.TabIndex = 1;
            txtAssunto.Validating += Validacoes_Validating;
            // 
            // txtRemoto
            // 
            txtRemoto.Location = new Point(107, 36);
            txtRemoto.Name = "txtRemoto";
            txtRemoto.Size = new Size(284, 23);
            txtRemoto.TabIndex = 2;
            txtRemoto.Validating += Validacoes_Validating;
            // 
            // txtPresencial
            // 
            txtPresencial.Location = new Point(107, 72);
            txtPresencial.Name = "txtPresencial";
            txtPresencial.Size = new Size(284, 23);
            txtPresencial.TabIndex = 3;
            txtPresencial.Validating += Validacoes_Validating;
            // 
            // cbContato
            // 
            cbContato.FormattingEnabled = true;
            cbContato.Location = new Point(93, 192);
            cbContato.Name = "cbContato";
            cbContato.Size = new Size(127, 23);
            cbContato.TabIndex = 4;
            cbContato.Validating += Validacoes_Validating;
            // 
            // radioRemoto
            // 
            radioRemoto.AutoSize = true;
            radioRemoto.Checked = true;
            radioRemoto.Location = new Point(12, 37);
            radioRemoto.Name = "radioRemoto";
            radioRemoto.Size = new Size(70, 19);
            radioRemoto.TabIndex = 5;
            radioRemoto.TabStop = true;
            radioRemoto.Text = "Remoto:";
            radioRemoto.UseVisualStyleBackColor = true;
            radioRemoto.Validating += Validacoes_Validating;
            // 
            // radioPresencial
            // 
            radioPresencial.AutoSize = true;
            radioPresencial.Location = new Point(12, 73);
            radioPresencial.Name = "radioPresencial";
            radioPresencial.Size = new Size(81, 19);
            radioPresencial.TabIndex = 6;
            radioPresencial.Text = "Presencial:";
            radioPresencial.UseVisualStyleBackColor = true;
            radioPresencial.Validating += Validacoes_Validating;
            // 
            // dtData
            // 
            dtData.CustomFormat = "";
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(93, 91);
            dtData.Name = "dtData";
            dtData.Size = new Size(127, 23);
            dtData.TabIndex = 7;
            dtData.Validating += Validacoes_Validating;
            // 
            // checkContato
            // 
            checkContato.AutoSize = true;
            checkContato.Checked = true;
            checkContato.CheckState = CheckState.Checked;
            checkContato.Location = new Point(93, 167);
            checkContato.Name = "checkContato";
            checkContato.Size = new Size(277, 19);
            checkContato.TabIndex = 8;
            checkContato.Text = "Deseja marcar um contato neste compromisso?";
            checkContato.UseVisualStyleBackColor = true;
            checkContato.CheckedChanged += checkContatoBool_CheckedChanged;
            checkContato.Validating += Validacoes_Validating;
            // 
            // dtInicio
            // 
            dtInicio.CustomFormat = "HH:mm";
            dtInicio.Format = DateTimePickerFormat.Custom;
            dtInicio.Location = new Point(93, 120);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(127, 23);
            dtInicio.TabIndex = 9;
            dtInicio.Validating += Validacoes_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 11;
            label1.Text = "Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 65);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 12;
            label2.Text = "Assunto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 97);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 13;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 126);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 124);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 15;
            label5.Text = "Término:";
            // 
            // dtFinal
            // 
            dtFinal.CustomFormat = "HH:mm";
            dtFinal.Format = DateTimePickerFormat.Custom;
            dtFinal.Location = new Point(302, 120);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(127, 23);
            dtFinal.TabIndex = 17;
            dtFinal.Validating += Validacoes_Validating;
            // 
            // gbLocalizacao
            // 
            gbLocalizacao.Controls.Add(txtPresencial);
            gbLocalizacao.Controls.Add(txtRemoto);
            gbLocalizacao.Controls.Add(radioRemoto);
            gbLocalizacao.Controls.Add(radioPresencial);
            gbLocalizacao.Location = new Point(34, 247);
            gbLocalizacao.Name = "gbLocalizacao";
            gbLocalizacao.Size = new Size(430, 123);
            gbLocalizacao.TabIndex = 18;
            gbLocalizacao.TabStop = false;
            gbLocalizacao.Text = "Localização";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(420, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(344, 394);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // avisoErro
            // 
            avisoErro.BlinkRate = 0;
            avisoErro.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            avisoErro.ContainerControl = this;
            avisoErro.Icon = (Icon)resources.GetObject("avisoErro.Icon");
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 454);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(gbLocalizacao);
            Controls.Add(dtFinal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtInicio);
            Controls.Add(checkContato);
            Controls.Add(dtData);
            Controls.Add(cbContato);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            Text = "Cadastro de Compromissos";
            TopMost = true;
            gbLocalizacao.ResumeLayout(false);
            gbLocalizacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avisoErro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAssunto;
        private TextBox txtRemoto;
        private TextBox txtPresencial;
        private RadioButton radioRemoto;
        private RadioButton radioPresencial;
        private DateTimePicker dtData;
        private CheckBox checkContato;
        private DateTimePicker dtInicio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtFinal;
        private GroupBox gbLocalizacao;
        private Button btnCancelar;
        private Button btnAdd;
        public ComboBox cbContato;
        public TextBox txtId;
        private ErrorProvider avisoErro;
    }
}