
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
            this.lblEdiID = new System.Windows.Forms.Label();
            this.txtEdiID = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(13, 62);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(70, 13);
            this.lblObs.TabIndex = 36;
            this.lblObs.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(16, 78);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(363, 20);
            this.txtObs.TabIndex = 35;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(276, 16);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 34;
            this.lblSigla.Text = "Sigla";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(279, 32);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 20);
            this.txtSigla.TabIndex = 33;
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
            this.txtNome.Size = new System.Drawing.Size(257, 20);
            this.txtNome.TabIndex = 31;
            // 
            // gpEditar
            // 
            this.gpEditar.Controls.Add(this.lblObs);
            this.gpEditar.Controls.Add(this.txtObs);
            this.gpEditar.Controls.Add(this.lblSigla);
            this.gpEditar.Controls.Add(this.txtSigla);
            this.gpEditar.Controls.Add(this.lblNome);
            this.gpEditar.Controls.Add(this.txtNome);
            this.gpEditar.Location = new System.Drawing.Point(12, 49);
            this.gpEditar.Name = "gpEditar";
            this.gpEditar.Size = new System.Drawing.Size(397, 117);
            this.gpEditar.TabIndex = 37;
            this.gpEditar.TabStop = false;
            // 
            // lblEdiID
            // 
            this.lblEdiID.AutoSize = true;
            this.lblEdiID.Location = new System.Drawing.Point(162, 7);
            this.lblEdiID.Name = "lblEdiID";
            this.lblEdiID.Size = new System.Drawing.Size(91, 13);
            this.lblEdiID.TabIndex = 38;
            this.lblEdiID.Text = "Código da Editora";
            // 
            // txtEdiID
            // 
            this.txtEdiID.Location = new System.Drawing.Point(153, 23);
            this.txtEdiID.Name = "txtEdiID";
            this.txtEdiID.Size = new System.Drawing.Size(111, 20);
            this.txtEdiID.TabIndex = 37;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(164, 172);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 37);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmEditorasEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 221);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblEdiID);
            this.Controls.Add(this.gpEditar);
            this.Controls.Add(this.txtEdiID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditorasEditar";
            this.Text = "Editar Editoras";
            this.gpEditar.ResumeLayout(false);
            this.gpEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}