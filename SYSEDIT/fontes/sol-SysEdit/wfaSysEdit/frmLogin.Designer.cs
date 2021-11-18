
namespace wfaSysEdit
{
    partial class frmLogin
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
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chMostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLogo.Location = new System.Drawing.Point(35, 22);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(299, 65);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "SYSEDIT";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblEmail.Location = new System.Drawing.Point(78, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(146, 155);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(146, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSenha.Location = new System.Drawing.Point(70, 150);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 24);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chMostrarSenha
            // 
            this.chMostrarSenha.AutoSize = true;
            this.chMostrarSenha.Location = new System.Drawing.Point(146, 181);
            this.chMostrarSenha.Name = "chMostrarSenha";
            this.chMostrarSenha.Size = new System.Drawing.Size(95, 17);
            this.chMostrarSenha.TabIndex = 6;
            this.chMostrarSenha.Text = "Mostrar Senha";
            this.chMostrarSenha.UseVisualStyleBackColor = true;
            this.chMostrarSenha.CheckedChanged += new System.EventHandler(this.chMostrarSenha_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(380, 266);
            this.Controls.Add(this.chMostrarSenha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Login :.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chMostrarSenha;
    }
}