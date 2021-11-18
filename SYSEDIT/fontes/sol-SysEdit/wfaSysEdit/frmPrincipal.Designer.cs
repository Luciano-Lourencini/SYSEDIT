
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
            this.components = new System.ComponentModel.Container();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBuscarEditarApagar = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEditarApagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEditarApagarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEditarApagarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssPrincipal = new System.Windows.Forms.StatusStrip();
            this.tsslblSysEdit = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmPrincipal = new System.Windows.Forms.Timer(this.components);
            this.msPrincipal.SuspendLayout();
            this.ssPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(615, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem,
            this.editorasToolStripMenuItem1,
            this.livrosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.editorasToolStripMenuItem.Text = "&Cadastrar";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCadastrar,
            this.tsBuscarEditarApagar});
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
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
            // editorasToolStripMenuItem1
            // 
            this.editorasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.buscarEditarApagarToolStripMenuItem});
            this.editorasToolStripMenuItem1.Name = "editorasToolStripMenuItem1";
            this.editorasToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
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
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.buscarEditarApagarToolStripMenuItem1});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
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
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem2,
            this.buscarEditarApagarToolStripMenuItem2});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
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
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // ssPrincipal
            // 
            this.ssPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblSysEdit,
            this.tsslblTimer});
            this.ssPrincipal.Location = new System.Drawing.Point(0, 251);
            this.ssPrincipal.Name = "ssPrincipal";
            this.ssPrincipal.Size = new System.Drawing.Size(615, 22);
            this.ssPrincipal.TabIndex = 1;
            this.ssPrincipal.Text = "statusStrip1";
            // 
            // tsslblSysEdit
            // 
            this.tsslblSysEdit.BackColor = System.Drawing.Color.White;
            this.tsslblSysEdit.Name = "tsslblSysEdit";
            this.tsslblSysEdit.Size = new System.Drawing.Size(62, 17);
            this.tsslblSysEdit.Text = ".: SysEdit :.";
            // 
            // tsslblTimer
            // 
            this.tsslblTimer.BackColor = System.Drawing.Color.White;
            this.tsslblTimer.Name = "tsslblTimer";
            this.tsslblTimer.Size = new System.Drawing.Size(16, 17);
            this.tsslblTimer.Text = "...";
            // 
            // tmPrincipal
            // 
            this.tmPrincipal.Enabled = true;
            this.tmPrincipal.Interval = 1000;
            this.tmPrincipal.Tick += new System.EventHandler(this.tmPrincipal_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(615, 273);
            this.Controls.Add(this.ssPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = ".: SYSEDIT :: Sistema de Editoras :.";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ssPrincipal.ResumeLayout(false);
            this.ssPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
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
        private System.Windows.Forms.StatusStrip ssPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel tsslblSysEdit;
        private System.Windows.Forms.Timer tmPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel tsslblTimer;
    }
}

