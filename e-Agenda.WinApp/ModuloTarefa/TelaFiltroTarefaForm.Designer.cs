namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaFiltroTarefaForm
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
            btnCancelar = new Button();
            btnAdd = new Button();
            radioVisualizarConcluidas = new RadioButton();
            radioVisualizarPendentes = new RadioButton();
            radioVisualizarTodos = new RadioButton();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(274, 195);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Location = new Point(198, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Aplicar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // radioVisualizarConcluidas
            // 
            radioVisualizarConcluidas.AutoSize = true;
            radioVisualizarConcluidas.Location = new Point(35, 124);
            radioVisualizarConcluidas.Name = "radioVisualizarConcluidas";
            radioVisualizarConcluidas.Size = new Size(175, 19);
            radioVisualizarConcluidas.TabIndex = 26;
            radioVisualizarConcluidas.Text = "Visualizar Tarefas Concluídas";
            radioVisualizarConcluidas.UseVisualStyleBackColor = true;
            // 
            // radioVisualizarPendentes
            // 
            radioVisualizarPendentes.AutoSize = true;
            radioVisualizarPendentes.Location = new Point(35, 80);
            radioVisualizarPendentes.Name = "radioVisualizarPendentes";
            radioVisualizarPendentes.Size = new Size(171, 19);
            radioVisualizarPendentes.TabIndex = 25;
            radioVisualizarPendentes.Text = "Visualizar Tarefas Pendentes";
            radioVisualizarPendentes.UseVisualStyleBackColor = true;
            // 
            // radioVisualizarTodos
            // 
            radioVisualizarTodos.AutoSize = true;
            radioVisualizarTodos.Checked = true;
            radioVisualizarTodos.Location = new Point(35, 36);
            radioVisualizarTodos.Name = "radioVisualizarTodos";
            radioVisualizarTodos.Size = new Size(160, 19);
            radioVisualizarTodos.TabIndex = 24;
            radioVisualizarTodos.TabStop = true;
            radioVisualizarTodos.Text = "Visualizar todos as Tarefas";
            radioVisualizarTodos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 243);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(radioVisualizarConcluidas);
            Controls.Add(radioVisualizarPendentes);
            Controls.Add(radioVisualizarTodos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtrar Tarefas";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAdd;
        private RadioButton radioVisualizarConcluidas;
        private RadioButton radioVisualizarPendentes;
        private RadioButton radioVisualizarTodos;
    }
}