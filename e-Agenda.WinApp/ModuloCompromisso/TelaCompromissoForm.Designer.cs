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
            txtId = new TextBox();
            txtAssunto = new TextBox();
            txtRemoto = new TextBox();
            txtPresencial = new TextBox();
            cbContato = new ComboBox();
            radioRemoto = new RadioButton();
            radioPresencial = new RadioButton();
            dtData = new DateTimePicker();
            checkContatoBool = new CheckBox();
            dtInicio = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtTermino = new DateTimePicker();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
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
            // 
            // txtRemoto
            // 
            txtRemoto.Location = new Point(107, 36);
            txtRemoto.Name = "txtRemoto";
            txtRemoto.Size = new Size(284, 23);
            txtRemoto.TabIndex = 2;
            // 
            // txtPresencial
            // 
            txtPresencial.Location = new Point(107, 72);
            txtPresencial.Name = "txtPresencial";
            txtPresencial.Size = new Size(284, 23);
            txtPresencial.TabIndex = 3;
            // 
            // cbContato
            // 
            cbContato.FormattingEnabled = true;
            cbContato.Location = new Point(93, 192);
            cbContato.Name = "cbContato";
            cbContato.Size = new Size(127, 23);
            cbContato.TabIndex = 4;
            // 
            // radioRemoto
            // 
            radioRemoto.AutoSize = true;
            radioRemoto.Location = new Point(12, 37);
            radioRemoto.Name = "radioRemoto";
            radioRemoto.Size = new Size(70, 19);
            radioRemoto.TabIndex = 5;
            radioRemoto.TabStop = true;
            radioRemoto.Text = "Remoto:";
            radioRemoto.UseVisualStyleBackColor = true;
            // 
            // radioPresencial
            // 
            radioPresencial.AutoSize = true;
            radioPresencial.Location = new Point(12, 73);
            radioPresencial.Name = "radioPresencial";
            radioPresencial.Size = new Size(81, 19);
            radioPresencial.TabIndex = 6;
            radioPresencial.TabStop = true;
            radioPresencial.Text = "Presencial:";
            radioPresencial.UseVisualStyleBackColor = true;
            // 
            // dtData
            // 
            dtData.CustomFormat = "";
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(93, 91);
            dtData.Name = "dtData";
            dtData.Size = new Size(127, 23);
            dtData.TabIndex = 7;
            // 
            // checkContatoBool
            // 
            checkContatoBool.AutoSize = true;
            checkContatoBool.Checked = true;
            checkContatoBool.CheckState = CheckState.Checked;
            checkContatoBool.Location = new Point(93, 167);
            checkContatoBool.Name = "checkContatoBool";
            checkContatoBool.Size = new Size(277, 19);
            checkContatoBool.TabIndex = 8;
            checkContatoBool.Text = "Deseja marcar um contato neste compromisso?";
            checkContatoBool.UseVisualStyleBackColor = true;
            checkContatoBool.CheckedChanged += checkContatoBool_CheckedChanged;
            // 
            // dtInicio
            // 
            dtInicio.CustomFormat = "HH:mm";
            dtInicio.Format = DateTimePickerFormat.Custom;
            dtInicio.Location = new Point(93, 120);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(127, 23);
            dtInicio.TabIndex = 9;
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
            // dtTermino
            // 
            dtTermino.CustomFormat = "HH:mm";
            dtTermino.Format = DateTimePickerFormat.Custom;
            dtTermino.Location = new Point(302, 120);
            dtTermino.Name = "dtTermino";
            dtTermino.Size = new Size(127, 23);
            dtTermino.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPresencial);
            groupBox1.Controls.Add(txtRemoto);
            groupBox1.Controls.Add(radioRemoto);
            groupBox1.Controls.Add(radioPresencial);
            groupBox1.Location = new Point(53, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 123);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Localização";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(420, 394);
            button2.Name = "button2";
            button2.Size = new Size(70, 36);
            button2.TabIndex = 20;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(344, 394);
            button1.Name = "button1";
            button1.Size = new Size(70, 36);
            button1.TabIndex = 19;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 454);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dtTermino);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtInicio);
            Controls.Add(checkContatoBool);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private CheckBox checkContatoBool;
        private DateTimePicker dtInicio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtTermino;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        public ComboBox cbContato;
        public TextBox txtId;
    }
}