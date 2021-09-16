
namespace wfaSysEdit
{
    partial class frmEditorasExcluir
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
            this.lblEdiID = new System.Windows.Forms.Label();
            this.txtEdiID = new System.Windows.Forms.TextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEdiID
            // 
            this.lblEdiID.AutoSize = true;
            this.lblEdiID.Location = new System.Drawing.Point(33, 14);
            this.lblEdiID.Name = "lblEdiID";
            this.lblEdiID.Size = new System.Drawing.Size(91, 13);
            this.lblEdiID.TabIndex = 43;
            this.lblEdiID.Text = "Código da Editora";
            // 
            // txtEdiID
            // 
            this.txtEdiID.Location = new System.Drawing.Point(24, 30);
            this.txtEdiID.Name = "txtEdiID";
            this.txtEdiID.Size = new System.Drawing.Size(111, 20);
            this.txtEdiID.TabIndex = 42;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(33, 67);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(91, 35);
            this.btnApagar.TabIndex = 44;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // frmEditorasExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 130);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblEdiID);
            this.Controls.Add(this.txtEdiID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditorasExcluir";
            this.Text = "Excluir Editora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEdiID;
        private System.Windows.Forms.TextBox txtEdiID;
        private System.Windows.Forms.Button btnApagar;
    }
}