﻿
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gpEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(164, 241);
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
            this.lblAutID.Location = new System.Drawing.Point(19, 17);
            this.lblAutID.Name = "lblAutID";
            this.lblAutID.Size = new System.Drawing.Size(83, 13);
            this.lblAutID.TabIndex = 42;
            this.lblAutID.Text = "Código do Autor";
            // 
            // gpEditar
            // 
            this.gpEditar.Controls.Add(this.lblObs);
            this.gpEditar.Controls.Add(this.txtObs);
            this.gpEditar.Controls.Add(this.lblAutID);
            this.gpEditar.Controls.Add(this.lblPseud);
            this.gpEditar.Controls.Add(this.txtPseud);
            this.gpEditar.Controls.Add(this.txtAutID);
            this.gpEditar.Controls.Add(this.lblNome);
            this.gpEditar.Controls.Add(this.txtNome);
            this.gpEditar.Location = new System.Drawing.Point(12, 54);
            this.gpEditar.Name = "gpEditar";
            this.gpEditar.Size = new System.Drawing.Size(397, 164);
            this.gpEditar.TabIndex = 40;
            this.gpEditar.TabStop = false;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(16, 102);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(70, 13);
            this.lblObs.TabIndex = 36;
            this.lblObs.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(19, 118);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(363, 20);
            this.txtObs.TabIndex = 35;
            // 
            // lblPseud
            // 
            this.lblPseud.AutoSize = true;
            this.lblPseud.Location = new System.Drawing.Point(225, 56);
            this.lblPseud.Name = "lblPseud";
            this.lblPseud.Size = new System.Drawing.Size(65, 13);
            this.lblPseud.TabIndex = 34;
            this.lblPseud.Text = "Pseudônimo";
            // 
            // txtPseud
            // 
            this.txtPseud.Enabled = false;
            this.txtPseud.Location = new System.Drawing.Point(224, 72);
            this.txtPseud.Name = "txtPseud";
            this.txtPseud.Size = new System.Drawing.Size(158, 20);
            this.txtPseud.TabIndex = 33;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 32;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(19, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 20);
            this.txtNome.TabIndex = 31;
            // 
            // txtAutID
            // 
            this.txtAutID.Enabled = false;
            this.txtAutID.Location = new System.Drawing.Point(19, 33);
            this.txtAutID.Name = "txtAutID";
            this.txtAutID.Size = new System.Drawing.Size(111, 20);
            this.txtAutID.TabIndex = 41;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(173, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 36);
            this.btnPesquisar.TabIndex = 44;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmAutoresEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 310);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAutoresEditar";
            this.Text = "Editar Autor";
            this.gpEditar.ResumeLayout(false);
            this.gpEditar.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnPesquisar;
    }
}