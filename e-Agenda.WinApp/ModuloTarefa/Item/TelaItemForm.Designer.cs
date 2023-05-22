namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaItemForm
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
            lbTarefa = new Label();
            btnAdicionarItem = new Button();
            listItens = new ListBox();
            txtItem = new TextBox();
            btnCancelar = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // btnAdicionarItem
            // 
            btnAdicionarItem.Location = new Point(248, 89);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(94, 23);
            btnAdicionarItem.TabIndex = 2;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 15;
            listItens.Location = new Point(54, 128);
            listItens.Name = "listItens";
            listItens.Size = new Size(288, 304);
            listItens.TabIndex = 3;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(89, 89);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(153, 23);
            txtItem.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(316, 449);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Location = new Point(240, 449);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Gravar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTarefa);
            groupBox1.Location = new Point(99, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 59);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tarefa Selecionada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 93);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 20;
            label1.Text = "Item:";
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 497);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(txtItem);
            Controls.Add(listItens);
            Controls.Add(btnAdicionarItem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Itens";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        internal Label lbTarefa;
        internal Button btnAdicionarItem;
        internal ListBox listItens;
        internal TextBox txtItem;
        internal Button btnCancelar;
        internal Button btnAdd;
    }
}