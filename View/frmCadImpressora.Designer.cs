namespace FilaImpressao
{
    partial class frmCadImpressora
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpCodigo = new System.Windows.Forms.TextBox();
            this.cbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // btnFechar
            this.btnFechar.Location = new System.Drawing.Point(162, 119);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(85, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // btnGravar
            this.btnGravar.Location = new System.Drawing.Point(66, 119);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(85, 23);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // cpCodigo
            this.cpCodigo.Location = new System.Drawing.Point(122, 26);
            this.cpCodigo.Name = "cpCodigo";
            this.cpCodigo.Size = new System.Drawing.Size(125, 20);
            this.cpCodigo.TabIndex = 4;
            // cbNome
            this.cbNome.Location = new System.Drawing.Point(122, 54);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(125, 20);
            this.cbNome.TabIndex = 5;
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tempo";
            // cbTempo
            this.cbTempo.Location = new System.Drawing.Point(122, 80);
            this.cbTempo.Name = "cbTempo";
            this.cbTempo.Size = new System.Drawing.Size(125, 20);
            this.cbTempo.TabIndex = 7;
            // frmCadImpressora
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 154);
            this.Controls.Add(this.cbTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.cpCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnFechar);
            this.Name = "frmCadImpressora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Impressoras";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.ListaImpressao = this.lis;
        }

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cpCodigo;
        private System.Windows.Forms.TextBox cbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cbTempo;

    }
}