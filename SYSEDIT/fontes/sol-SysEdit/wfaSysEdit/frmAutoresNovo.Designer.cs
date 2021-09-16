
namespace wfaSysEdit
{
    partial class frmAutoresNovo
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
            this.lblPseud = new System.Windows.Forms.Label();
            this.txtPseud = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPseud
            // 
            this.lblPseud.AutoSize = true;
            this.lblPseud.Location = new System.Drawing.Point(28, 68);
            this.lblPseud.Name = "lblPseud";
            this.lblPseud.Size = new System.Drawing.Size(65, 13);
            this.lblPseud.TabIndex = 50;
            this.lblPseud.Text = "Pseudônimo";
            // 
            // txtPseud
            // 
            this.txtPseud.Location = new System.Drawing.Point(28, 84);
            this.txtPseud.Name = "txtPseud";
            this.txtPseud.Size = new System.Drawing.Size(340, 20);
            this.txtPseud.TabIndex = 49;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(127, 172);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 32);
            this.btnSalvar.TabIndex = 48;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(28, 119);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(70, 13);
            this.lblObs.TabIndex = 47;
            this.lblObs.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(28, 135);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(340, 20);
            this.txtObs.TabIndex = 46;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(78, 13);
            this.lblNome.TabIndex = 43;
            this.lblNome.Text = "Nome do Autor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(343, 20);
            this.txtNome.TabIndex = 42;
            // 
            // frmAutoresNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 225);
            this.Controls.Add(this.lblPseud);
            this.Controls.Add(this.txtPseud);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAutoresNovo";
            this.Text = "Adicionar Autor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPseud;
        private System.Windows.Forms.TextBox txtPseud;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}