
namespace wfaSysEdit
{
    partial class frmAutoresEditar
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
            this.lblAutID = new System.Windows.Forms.Label();
            this.gpEditar = new System.Windows.Forms.GroupBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblPseud = new System.Windows.Forms.Label();
            this.txtPseud = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAutID = new System.Windows.Forms.TextBox();
            this.gpEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(164, 177);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 37);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblAutID
            // 
            this.lblAutID.AutoSize = true;
            this.lblAutID.Location = new System.Drawing.Point(162, 12);
            this.lblAutID.Name = "lblAutID";
            this.lblAutID.Size = new System.Drawing.Size(83, 13);
            this.lblAutID.TabIndex = 42;
            this.lblAutID.Text = "Código do Autor";
            // 
            // gpEditar
            // 
            this.gpEditar.Controls.Add(this.lblObs);
            this.gpEditar.Controls.Add(this.txtObs);
            this.gpEditar.Controls.Add(this.lblPseud);
            this.gpEditar.Controls.Add(this.txtPseud);
            this.gpEditar.Controls.Add(this.lblNome);
            this.gpEditar.Controls.Add(this.txtNome);
            this.gpEditar.Location = new System.Drawing.Point(12, 54);
            this.gpEditar.Name = "gpEditar";
            this.gpEditar.Size = new System.Drawing.Size(397, 117);
            this.gpEditar.TabIndex = 40;
            this.gpEditar.TabStop = false;
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
            // lblPseud
            // 
            this.lblPseud.AutoSize = true;
            this.lblPseud.Location = new System.Drawing.Point(222, 16);
            this.lblPseud.Name = "lblPseud";
            this.lblPseud.Size = new System.Drawing.Size(65, 13);
            this.lblPseud.TabIndex = 34;
            this.lblPseud.Text = "Pseudônimo";
            // 
            // txtPseud
            // 
            this.txtPseud.Location = new System.Drawing.Point(221, 32);
            this.txtPseud.Name = "txtPseud";
            this.txtPseud.Size = new System.Drawing.Size(158, 20);
            this.txtPseud.TabIndex = 33;
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
            this.txtNome.Size = new System.Drawing.Size(199, 20);
            this.txtNome.TabIndex = 31;
            // 
            // txtAutID
            // 
            this.txtAutID.Location = new System.Drawing.Point(153, 28);
            this.txtAutID.Name = "txtAutID";
            this.txtAutID.Size = new System.Drawing.Size(111, 20);
            this.txtAutID.TabIndex = 41;
            // 
            // frmAutoresEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 233);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblAutID);
            this.Controls.Add(this.gpEditar);
            this.Controls.Add(this.txtAutID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAutoresEditar";
            this.Text = "Editar Autor";
            this.gpEditar.ResumeLayout(false);
            this.gpEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblAutID;
        private System.Windows.Forms.GroupBox gpEditar;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblPseud;
        private System.Windows.Forms.TextBox txtPseud;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAutID;
    }
}