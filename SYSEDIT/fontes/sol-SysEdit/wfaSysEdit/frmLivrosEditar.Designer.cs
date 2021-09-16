
namespace wfaSysEdit
{
    partial class frmLivrosEditar
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblLivID = new System.Windows.Forms.Label();
            this.gpEditar = new System.Windows.Forms.GroupBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLivID = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblAnoPubli = new System.Windows.Forms.Label();
            this.txtAnoPubli = new System.Windows.Forms.TextBox();
            this.lblEdiID = new System.Windows.Forms.Label();
            this.txtEdiID = new System.Windows.Forms.TextBox();
            this.gpEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(165, 228);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 37);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblLivID
            // 
            this.lblLivID.AutoSize = true;
            this.lblLivID.Location = new System.Drawing.Point(162, 13);
            this.lblLivID.Name = "lblLivID";
            this.lblLivID.Size = new System.Drawing.Size(81, 13);
            this.lblLivID.TabIndex = 42;
            this.lblLivID.Text = "Código do Livro";
            // 
            // gpEditar
            // 
            this.gpEditar.Controls.Add(this.lblEdiID);
            this.gpEditar.Controls.Add(this.txtEdiID);
            this.gpEditar.Controls.Add(this.lblISBN);
            this.gpEditar.Controls.Add(this.txtISBN);
            this.gpEditar.Controls.Add(this.lblAnoPubli);
            this.gpEditar.Controls.Add(this.txtAnoPubli);
            this.gpEditar.Controls.Add(this.lblObs);
            this.gpEditar.Controls.Add(this.txtObs);
            this.gpEditar.Controls.Add(this.lblNome);
            this.gpEditar.Controls.Add(this.txtNome);
            this.gpEditar.Location = new System.Drawing.Point(12, 55);
            this.gpEditar.Name = "gpEditar";
            this.gpEditar.Size = new System.Drawing.Size(400, 155);
            this.gpEditar.TabIndex = 40;
            this.gpEditar.TabStop = false;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(13, 98);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(70, 13);
            this.lblObs.TabIndex = 36;
            this.lblObs.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(16, 114);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(363, 20);
            this.txtObs.TabIndex = 35;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 32;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(363, 20);
            this.txtNome.TabIndex = 31;
            // 
            // txtLivID
            // 
            this.txtLivID.Location = new System.Drawing.Point(153, 29);
            this.txtLivID.Name = "txtLivID";
            this.txtLivID.Size = new System.Drawing.Size(111, 20);
            this.txtLivID.TabIndex = 41;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(13, 59);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 45;
            this.lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(16, 75);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 44;
            // 
            // lblAnoPubli
            // 
            this.lblAnoPubli.AutoSize = true;
            this.lblAnoPubli.Location = new System.Drawing.Point(250, 59);
            this.lblAnoPubli.Name = "lblAnoPubli";
            this.lblAnoPubli.Size = new System.Drawing.Size(97, 13);
            this.lblAnoPubli.TabIndex = 43;
            this.lblAnoPubli.Text = "Ano de Publicação";
            // 
            // txtAnoPubli
            // 
            this.txtAnoPubli.Location = new System.Drawing.Point(253, 75);
            this.txtAnoPubli.Name = "txtAnoPubli";
            this.txtAnoPubli.Size = new System.Drawing.Size(126, 20);
            this.txtAnoPubli.TabIndex = 42;
            // 
            // lblEdiID
            // 
            this.lblEdiID.AutoSize = true;
            this.lblEdiID.Location = new System.Drawing.Point(125, 59);
            this.lblEdiID.Name = "lblEdiID";
            this.lblEdiID.Size = new System.Drawing.Size(91, 13);
            this.lblEdiID.TabIndex = 47;
            this.lblEdiID.Text = "Código da Editora";
            // 
            // txtEdiID
            // 
            this.txtEdiID.Location = new System.Drawing.Point(128, 75);
            this.txtEdiID.Name = "txtEdiID";
            this.txtEdiID.Size = new System.Drawing.Size(119, 20);
            this.txtEdiID.TabIndex = 46;
            // 
            // frmLivrosEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 277);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblLivID);
            this.Controls.Add(this.gpEditar);
            this.Controls.Add(this.txtLivID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLivrosEditar";
            this.Text = "Editar Livros";
            this.gpEditar.ResumeLayout(false);
            this.gpEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblLivID;
        private System.Windows.Forms.GroupBox gpEditar;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLivID;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblAnoPubli;
        private System.Windows.Forms.TextBox txtAnoPubli;
        private System.Windows.Forms.Label lblEdiID;
        private System.Windows.Forms.TextBox txtEdiID;
    }
}