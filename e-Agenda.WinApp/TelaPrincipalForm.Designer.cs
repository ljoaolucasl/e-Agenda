namespace e_Agenda.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            lbStatus = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            tarefasMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnAdicionarItem = new ToolStripButton();
            btnAtualizarItens = new ToolStripButton();
            lblTipoCadastro = new ToolStripLabel();
            plPrincipal = new Panel();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbStatus });
            statusStrip1.Location = new Point(0, 547);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(924, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 17);
            lbStatus.Text = "Status";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(924, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem, tarefasMenuItem, despesasToolStripMenuItem });
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(71, 20);
            cadastrosMenuItem.Text = "Cadastros";
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(154, 22);
            contatosMenuItem.Text = "Contatos";
            contatosMenuItem.Click += contatosMenuItem_Click;
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(154, 22);
            compromissosMenuItem.Text = "Compromissos";
            compromissosMenuItem.Click += compromissosMenuItem_Click;
            // 
            // tarefasMenuItem
            // 
            tarefasMenuItem.Name = "tarefasMenuItem";
            tarefasMenuItem.Size = new Size(154, 22);
            tarefasMenuItem.Text = "Tarefas";
            tarefasMenuItem.Click += tarefasMenuItem_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despesasToolStripMenuItem1 });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(154, 22);
            despesasToolStripMenuItem.Text = "Despesas";
            // 
            // despesasToolStripMenuItem1
            // 
            despesasToolStripMenuItem1.Name = "despesasToolStripMenuItem1";
            despesasToolStripMenuItem1.Size = new Size(122, 22);
            despesasToolStripMenuItem1.Text = "Despesas";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, toolStripSeparator2, btnAdicionarItem, btnAtualizarItens, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(924, 45);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Enabled = false;
            btnAdd.Image = Properties.Resources.addIcon;
            btnAdd.ImageScaling = ToolStripItemImageScaling.None;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(7);
            btnAdd.Size = new Size(42, 42);
            btnAdd.Text = "Adicionar";
            btnAdd.ToolTipText = "Adicionar";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.editIcon;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "Editar";
            btnEditar.ToolTipText = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.deleteIcon;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(42, 42);
            btnExcluir.Text = "Excluir";
            btnExcluir.ToolTipText = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Enabled = false;
            btnFiltrar.Image = Properties.Resources.filterIcon;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(7);
            btnFiltrar.Size = new Size(42, 42);
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.ToolTipText = "Filtrar";
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarItem.Enabled = false;
            btnAdicionarItem.Image = Properties.Resources.addItemIcon;
            btnAdicionarItem.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionarItem.ImageTransparentColor = Color.Magenta;
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Padding = new Padding(7);
            btnAdicionarItem.Size = new Size(42, 42);
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.ToolTipText = "Adicionar Itens à Tarefa";
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // btnAtualizarItens
            // 
            btnAtualizarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAtualizarItens.Enabled = false;
            btnAtualizarItens.Image = Properties.Resources.itemCheckIcon;
            btnAtualizarItens.ImageScaling = ToolStripItemImageScaling.None;
            btnAtualizarItens.ImageTransparentColor = Color.Magenta;
            btnAtualizarItens.Name = "btnAtualizarItens";
            btnAtualizarItens.Padding = new Padding(7);
            btnAtualizarItens.Size = new Size(42, 42);
            btnAtualizarItens.Text = "Atualizar";
            btnAtualizarItens.ToolTipText = "Atualizar Itens da Tarefa";
            btnAtualizarItens.Click += btnAtualizarItens_Click;
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoCadastro.Margin = new Padding(2);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(0, 41);
            // 
            // plPrincipal
            // 
            plPrincipal.BackColor = SystemColors.ScrollBar;
            plPrincipal.Dock = DockStyle.Fill;
            plPrincipal.Location = new Point(0, 69);
            plPrincipal.Name = "plPrincipal";
            plPrincipal.Size = new Size(924, 478);
            plPrincipal.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 569);
            Controls.Add(plPrincipal);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            Text = "e-Agenda";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem1;
        private ToolStripStatusLabel lbStatus;
        private Panel plPrincipal;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripButton btnFiltrar;
        private ToolStripButton btnAdicionarItem;
        private ToolStripButton btnAtualizarItens;
        private ToolStripSeparator toolStripSeparator2;
    }
}