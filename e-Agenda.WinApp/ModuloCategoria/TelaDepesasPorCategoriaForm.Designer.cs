namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TelaDepesasPorCategoriaForm
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
            lbCategoria = new Label();
            groupBox1 = new GroupBox();
            listDespesas = new ListBox();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria:";
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCategoria.Location = new Point(96, 26);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(70, 15);
            lbCategoria.TabIndex = 1;
            lbCategoria.Text = "*Categoria*";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listDespesas);
            groupBox1.Location = new Point(29, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 347);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Despesas";
            // 
            // listDespesas
            // 
            listDespesas.Dock = DockStyle.Fill;
            listDespesas.FormattingEnabled = true;
            listDespesas.ItemHeight = 15;
            listDespesas.Location = new Point(3, 19);
            listDespesas.Name = "listDespesas";
            listDespesas.Size = new Size(488, 325);
            listDespesas.TabIndex = 3;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Location = new Point(470, 419);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(70, 36);
            btnFechar.TabIndex = 42;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // TelaDepesasPorCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 467);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(lbCategoria);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDepesasPorCategoriaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualização de Depesas por Categoria";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnFechar;
        internal Label lbCategoria;
        internal ListBox listDespesas;
    }
}