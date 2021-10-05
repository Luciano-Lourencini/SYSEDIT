
namespace wfaSysEdit
{
    partial class frmEditorasEditar
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
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpEditar = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblEdiID = new System.Windows.Forms.Label();
            this.txtEdiID = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.gpEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(12, 107);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(70, 13);
            this.lblObs.TabIndex = 36;
            this.lblObs.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(15, 123);
            this.txtObs.MaxLength = 500;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(363, 20);
            this.txtObs.TabIndex = 5;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(275, 61);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 34;
            this.lblSigla.Text = "Sigla";
            // 
            // txtSigla
            // 
            this.txtSigla.Enabled = false;
            this.txtSigla.Location = new System.Drawing.Point(278, 77);
            this.txtSigla.MaxLength = 25;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 20);
            this.txtSigla.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 32;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(15, 77);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(257, 20);
            this.txtNome.TabIndex = 3;
            // 
            // gpEditar
            // 
            this.gpEditar.Controls.Add(this.btnLimpar);
            this.gpEditar.Controls.Add(this.lblObs);
            this.gpEditar.Controls.Add(this.lblEdiID);
            this.gpEditar.Controls.Add(this.txtObs);
            this.gpEditar.Controls.Add(this.lblSigla);
            this.gpEditar.Controls.Add(this.txtEdiID);
            this.gpEditar.Controls.Add(this.txtSigla);
            this.gpEditar.Controls.Add(this.lblNome);
            this.gpEditar.Controls.Add(this.txtNome);
            this.gpEditar.Location = new System.Drawing.Point(12, 54);
            this.gpEditar.Name = "gpEditar";
            this.gpEditar.Size = new System.Drawing.Size(397, 164);
            this.gpEditar.TabIndex = 37;
            this.gpEditar.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(309, 17);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(69, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblEdiID
            // 
            this.lblEdiID.AutoSize = true;
            this.lblEdiID.Location = new System.Drawing.Point(15, 22);
            this.lblEdiID.Name = "lblEdiID";
            this.lblEdiID.Size = new System.Drawing.Size(91, 13);
            this.lblEdiID.TabIndex = 38;
            this.lblEdiID.Text = "Código da Editora";
            // 
            // txtEdiID
            // 
            this.txtEdiID.Enabled = false;
            this.txtEdiID.Location = new System.Drawing.Point(15, 38);
            this.txtEdiID.Name = "txtEdiID";
            this.txtEdiID.Size = new System.Drawing.Size(111, 20);
            this.txtEdiID.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(91, 232);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 39);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(165, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(92, 35);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Enabled = false;
            this.btnApagar.Location = new System.Drawing.Point(223, 231);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(111, 40);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // frmEditorasEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 288);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditorasEditar";
            this.Text = "Editar Editoras";
            this.gpEditar.ResumeLayout(false);
            this.gpEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpEditar;
        private System.Windows.Forms.Label lblEdiID;
        private System.Windows.Forms.TextBox txtEdiID;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
    }
}