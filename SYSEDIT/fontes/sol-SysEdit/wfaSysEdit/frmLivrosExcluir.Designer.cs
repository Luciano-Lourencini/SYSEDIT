
namespace wfaSysEdit
{
    partial class frmLivrosExcluir
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
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblLivID = new System.Windows.Forms.Label();
            this.txtLivID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(48, 72);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(91, 35);
            this.btnApagar.TabIndex = 47;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblLivID
            // 
            this.lblLivID.AutoSize = true;
            this.lblLivID.Location = new System.Drawing.Point(48, 19);
            this.lblLivID.Name = "lblLivID";
            this.lblLivID.Size = new System.Drawing.Size(81, 13);
            this.lblLivID.TabIndex = 46;
            this.lblLivID.Text = "Código do Livro";
            // 
            // txtLivID
            // 
            this.txtLivID.Location = new System.Drawing.Point(39, 35);
            this.txtLivID.Name = "txtLivID";
            this.txtLivID.Size = new System.Drawing.Size(111, 20);
            this.txtLivID.TabIndex = 45;
            // 
            // frmLivrosExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 132);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblLivID);
            this.Controls.Add(this.txtLivID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLivrosExcluir";
            this.Text = "Excluir livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblLivID;
        private System.Windows.Forms.TextBox txtLivID;
    }
}