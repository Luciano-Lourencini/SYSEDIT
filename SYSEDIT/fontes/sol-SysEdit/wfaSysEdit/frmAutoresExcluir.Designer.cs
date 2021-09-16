
namespace wfaSysEdit
{
    partial class frmAutoresExcluir
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
            this.lblAutID = new System.Windows.Forms.Label();
            this.txtAutID = new System.Windows.Forms.TextBox();
            this.btnApagarAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAutID
            // 
            this.lblAutID.AutoSize = true;
            this.lblAutID.Location = new System.Drawing.Point(63, 11);
            this.lblAutID.Name = "lblAutID";
            this.lblAutID.Size = new System.Drawing.Size(83, 13);
            this.lblAutID.TabIndex = 44;
            this.lblAutID.Text = "Código do Autor";
            // 
            // txtAutID
            // 
            this.txtAutID.Location = new System.Drawing.Point(49, 27);
            this.txtAutID.Name = "txtAutID";
            this.txtAutID.Size = new System.Drawing.Size(111, 20);
            this.txtAutID.TabIndex = 43;
            // 
            // btnApagarAutor
            // 
            this.btnApagarAutor.Location = new System.Drawing.Point(49, 70);
            this.btnApagarAutor.Name = "btnApagarAutor";
            this.btnApagarAutor.Size = new System.Drawing.Size(111, 40);
            this.btnApagarAutor.TabIndex = 45;
            this.btnApagarAutor.Text = "Apagar";
            this.btnApagarAutor.UseVisualStyleBackColor = true;
            this.btnApagarAutor.Click += new System.EventHandler(this.btnApagarAutor_Click);
            // 
            // frmAutoresExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 122);
            this.Controls.Add(this.btnApagarAutor);
            this.Controls.Add(this.lblAutID);
            this.Controls.Add(this.txtAutID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAutoresExcluir";
            this.Text = "Excluir Autor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutID;
        private System.Windows.Forms.TextBox txtAutID;
        private System.Windows.Forms.Button btnApagarAutor;
    }
}