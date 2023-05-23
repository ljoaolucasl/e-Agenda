namespace e_Agenda.WinApp.ModuloTarefa.Item
{
    partial class TelaItemCheckForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            lbTarefa = new Label();
            btnCancelar = new Button();
            btnAdd = new Button();
            checkListItens = new CheckedListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 102);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 27;
            label1.Text = "Check em Itens Concluídos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTarefa);
            groupBox1.Location = new Point(100, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 59);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tarefa Selecionada";
            // 
            // lbTarefa
            // 
            lbTarefa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbTarefa.Location = new Point(0, 17);
            lbTarefa.Name = "lbTarefa";
            lbTarefa.Size = new Size(200, 39);
            lbTarefa.TabIndex = 1;
            lbTarefa.Text = "*Tarefa*";
            lbTarefa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(320, 459);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Location = new Point(244, 459);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Gravar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // checkListItens
            // 
            checkListItens.FormattingEnabled = true;
            checkListItens.Location = new Point(55, 143);
            checkListItens.Name = "checkListItens";
            checkListItens.Size = new Size(288, 292);
            checkListItens.TabIndex = 28;
            // 
            // TelaItemCheckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 507);
            Controls.Add(checkListItens);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemCheckForm";
            ShowIcon = false;
            Text = "Itens Check";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnAdd;
        internal Label lbTarefa;
        public CheckedListBox checkListItens;
    }
}