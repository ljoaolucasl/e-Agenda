namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromissoForm
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
            radioVisualizarTodos = new RadioButton();
            radioVisualizarPassados = new RadioButton();
            radioVisualizarFuturos = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            gbDatas = new GroupBox();
            dtDataFinal = new DateTimePicker();
            dtDataInicial = new DateTimePicker();
            btnCancelar = new Button();
            btnAdd = new Button();
            gbDatas.SuspendLayout();
            SuspendLayout();
            // 
            // radioVisualizarTodos
            // 
            radioVisualizarTodos.AutoSize = true;
            radioVisualizarTodos.Checked = true;
            radioVisualizarTodos.Location = new Point(25, 38);
            radioVisualizarTodos.Name = "radioVisualizarTodos";
            radioVisualizarTodos.Size = new Size(205, 19);
            radioVisualizarTodos.TabIndex = 0;
            radioVisualizarTodos.TabStop = true;
            radioVisualizarTodos.Text = "Visualizar todos os Compromissos";
            radioVisualizarTodos.UseVisualStyleBackColor = true;
            // 
            // radioVisualizarPassados
            // 
            radioVisualizarPassados.AutoSize = true;
            radioVisualizarPassados.Location = new Point(25, 82);
            radioVisualizarPassados.Name = "radioVisualizarPassados";
            radioVisualizarPassados.Size = new Size(208, 19);
            radioVisualizarPassados.TabIndex = 1;
            radioVisualizarPassados.Text = "Visualizar Compromissos Passados";
            radioVisualizarPassados.UseVisualStyleBackColor = true;
            // 
            // radioVisualizarFuturos
            // 
            radioVisualizarFuturos.AutoSize = true;
            radioVisualizarFuturos.Location = new Point(25, 126);
            radioVisualizarFuturos.Name = "radioVisualizarFuturos";
            radioVisualizarFuturos.Size = new Size(200, 19);
            radioVisualizarFuturos.TabIndex = 2;
            radioVisualizarFuturos.Text = "Visualizar Compromissos Futuros";
            radioVisualizarFuturos.UseVisualStyleBackColor = true;
            radioVisualizarFuturos.CheckedChanged += radioVisualizarFuturos_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 37);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 6;
            label4.Text = "Data Final:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 37);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 7;
            label5.Text = "Data Inicial:";
            // 
            // gbDatas
            // 
            gbDatas.Controls.Add(dtDataFinal);
            gbDatas.Controls.Add(label5);
            gbDatas.Controls.Add(label4);
            gbDatas.Controls.Add(dtDataInicial);
            gbDatas.Enabled = false;
            gbDatas.Location = new Point(25, 178);
            gbDatas.Name = "gbDatas";
            gbDatas.Size = new Size(447, 83);
            gbDatas.TabIndex = 8;
            gbDatas.TabStop = false;
            gbDatas.Text = "Filtro para Compromissos Futuros";
            // 
            // dtDataFinal
            // 
            dtDataFinal.CustomFormat = "";
            dtDataFinal.Format = DateTimePickerFormat.Short;
            dtDataFinal.Location = new Point(318, 33);
            dtDataFinal.Name = "dtDataFinal";
            dtDataFinal.Size = new Size(105, 23);
            dtDataFinal.TabIndex = 24;
            // 
            // dtDataInicial
            // 
            dtDataInicial.CustomFormat = "";
            dtDataInicial.Format = DateTimePickerFormat.Short;
            dtDataInicial.Location = new Point(95, 33);
            dtDataInicial.Name = "dtDataInicial";
            dtDataInicial.Size = new Size(105, 23);
            dtDataInicial.TabIndex = 21;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(414, 278);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Location = new Point(338, 278);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Aplicar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 334);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(gbDatas);
            Controls.Add(radioVisualizarFuturos);
            Controls.Add(radioVisualizarPassados);
            Controls.Add(radioVisualizarTodos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromissoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtrar Compromissos";
            gbDatas.ResumeLayout(false);
            gbDatas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioVisualizarTodos;
        private RadioButton radioVisualizarPassados;
        private RadioButton radioVisualizarFuturos;
        private Label label4;
        private Label label5;
        private GroupBox gbDatas;
        private DateTimePicker dtDataFinal;
        private DateTimePicker dtDataInicial;
        private Button btnCancelar;
        private Button btnAdd;
    }
}