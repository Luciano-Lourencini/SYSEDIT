
namespace wfaSysEdit
{
    partial class frmLivrosNovo
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblAnoPubli = new System.Windows.Forms.Label();
            this.txtAnoPubli = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblEdiID = new System.Windows.Forms.Label();
            this.txtEdiID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(116, 172);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 32);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(30, 121);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(70, 13);
            this.lblObs.TabIndex = 36;
            this.lblObs.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(33, 137);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(337, 20);
            this.txtObs.TabIndex = 35;
            // 
            // lblAnoPubli
            // 
            this.lblAnoPubli.AutoSize = true;
            this.lblAnoPubli.Location = new System.Drawing.Point(267, 70);
            this.lblAnoPubli.Name = "lblAnoPubli";
            this.lblAnoPubli.Size = new System.Drawing.Size(97, 13);
            this.lblAnoPubli.TabIndex = 34;
            this.lblAnoPubli.Text = "Ano de Publicação";
            // 
            // txtAnoPubli
            // 
            this.txtAnoPubli.Location = new System.Drawing.Point(270, 86);
            this.txtAnoPubli.Name = "txtAnoPubli";
            this.txtAnoPubli.Size = new System.Drawing.Size(100, 20);
            this.txtAnoPubli.TabIndex = 33;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 13);
            this.lblNome.TabIndex = 32;
            this.lblNome.Text = "Nome do Livro";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(33, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 20);
            this.txtNome.TabIndex = 31;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(30, 70);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 39;
            this.lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(33, 86);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 38;
            // 
            // lblEdiID
            // 
            this.lblEdiID.AutoSize = true;
            this.lblEdiID.Location = new System.Drawing.Point(142, 70);
            this.lblEdiID.Name = "lblEdiID";
            this.lblEdiID.Size = new System.Drawing.Size(91, 13);
            this.lblEdiID.TabIndex = 41;
            this.lblEdiID.Text = "Código da Editora";
            // 
            // txtEdiID
            // 
            this.txtEdiID.Location = new System.Drawing.Point(145, 86);
            this.txtEdiID.Name = "txtEdiID";
            this.txtEdiID.Size = new System.Drawing.Size(119, 20);
            this.txtEdiID.TabIndex = 40;
            // 
            // frmLivrosNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 223);
            this.Controls.Add(this.lblEdiID);
            this.Controls.Add(this.txtEdiID);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblAnoPubli);
            this.Controls.Add(this.txtAnoPubli);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLivrosNovo";
            this.Text = "Adicionar Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblAnoPubli;
        private System.Windows.Forms.TextBox txtAnoPubli;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblEdiID;
        private System.Windows.Forms.TextBox txtEdiID;
    }
}