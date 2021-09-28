
namespace wfaSysEdit
{
    partial class frmEditorasPesquisar
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
            this.dgEditoras = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEditoras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEditoras
            // 
            this.dgEditoras.AllowUserToAddRows = false;
            this.dgEditoras.AllowUserToDeleteRows = false;
            this.dgEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEditoras.Location = new System.Drawing.Point(12, 12);
            this.dgEditoras.Name = "dgEditoras";
            this.dgEditoras.ReadOnly = true;
            this.dgEditoras.Size = new System.Drawing.Size(438, 240);
            this.dgEditoras.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(195, 258);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 6;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 258);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(375, 258);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmEditorasPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 285);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgEditoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEditorasPesquisar";
            this.Text = "Pesquisar Editoras";
            this.Load += new System.EventHandler(this.frmEditorasPesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEditoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEditoras;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
    }
}