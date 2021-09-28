
namespace wfaSysEdit
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEditarApagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBuscarEditarApagar = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEditarApagarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEditarApagarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(615, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorasToolStripMenuItem1,
            this.autoresToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.livrosToolStripMenuItem});
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.editorasToolStripMenuItem.Text = "&Cadastrar";
            // 
            // editorasToolStripMenuItem1
            // 
            this.editorasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.buscarEditarApagarToolStripMenuItem});
            this.editorasToolStripMenuItem1.Name = "editorasToolStripMenuItem1";
            this.editorasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editorasToolStripMenuItem1.Text = "&Editoras";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.novoToolStripMenuItem1.Text = "&Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // buscarEditarApagarToolStripMenuItem
            // 
            this.buscarEditarApagarToolStripMenuItem.Name = "buscarEditarApagarToolStripMenuItem";
            this.buscarEditarApagarToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.buscarEditarApagarToolStripMenuItem.Text = "&Buscar | Editar | Apagar";
            this.buscarEditarApagarToolStripMenuItem.Click += new System.EventHandler(this.buscarEditarApagarToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCadastrar,
            this.tsBuscarEditarApagar});
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoresToolStripMenuItem.Text = "&Autores";
            // 
            // tsCadastrar
            // 
            this.tsCadastrar.Name = "tsCadastrar";
            this.tsCadastrar.Size = new System.Drawing.Size(195, 22);
            this.tsCadastrar.Text = "&Cadastrar";
            this.tsCadastrar.Click += new System.EventHandler(this.tsCadastrar_Click);
            // 
            // tsBuscarEditarApagar
            // 
            this.tsBuscarEditarApagar.Name = "tsBuscarEditarApagar";
            this.tsBuscarEditarApagar.Size = new System.Drawing.Size(195, 22);
            this.tsBuscarEditarApagar.Text = "&Buscar | Editar | Apagar";
            this.tsBuscarEditarApagar.Click += new System.EventHandler(this.tsBuscarEditarApagar_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem2,
            this.buscarEditarApagarToolStripMenuItem2});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "&Usuários";
            // 
            // novoToolStripMenuItem2
            // 
            this.novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            this.novoToolStripMenuItem2.Size = new System.Drawing.Size(195, 22);
            this.novoToolStripMenuItem2.Text = "&Novo";
            this.novoToolStripMenuItem2.Click += new System.EventHandler(this.novoToolStripMenuItem2_Click);
            // 
            // buscarEditarApagarToolStripMenuItem2
            // 
            this.buscarEditarApagarToolStripMenuItem2.Name = "buscarEditarApagarToolStripMenuItem2";
            this.buscarEditarApagarToolStripMenuItem2.Size = new System.Drawing.Size(195, 22);
            this.buscarEditarApagarToolStripMenuItem2.Text = "&Buscar | Editar | Apagar";
            this.buscarEditarApagarToolStripMenuItem2.Click += new System.EventHandler(this.buscarEditarApagarToolStripMenuItem2_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.buscarEditarApagarToolStripMenuItem1});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livrosToolStripMenuItem.Text = "&Livros";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // buscarEditarApagarToolStripMenuItem1
            // 
            this.buscarEditarApagarToolStripMenuItem1.Name = "buscarEditarApagarToolStripMenuItem1";
            this.buscarEditarApagarToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.buscarEditarApagarToolStripMenuItem1.Text = "&Buscar | Editar | Apagar";
            this.buscarEditarApagarToolStripMenuItem1.Click += new System.EventHandler(this.buscarEditarApagarToolStripMenuItem1_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(615, 273);
            this.Controls.Add(this.msPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = ".: SYSEDIT :: Sistema de Editoras :.";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsBuscarEditarApagar;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarEditarApagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buscarEditarApagarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarEditarApagarToolStripMenuItem1;
    }
}

