namespace FilaImpressao
{
    partial class frmListImpressao
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnExcluirItens = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnExluirImpress = new System.Windows.Forms.Button();
            this.cadLetra = new System.Windows.Forms.Button();
            this.cadImpress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(531, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(549, 41);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(118, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnExcluirItens
            // 
            this.btnExcluirItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirItens.Location = new System.Drawing.Point(549, 70);
            this.btnExcluirItens.Name = "btnExcluirItens";
            this.btnExcluirItens.Size = new System.Drawing.Size(118, 23);
            this.btnExcluirItens.TabIndex = 2;
            this.btnExcluirItens.Text = "Excluir Itens";
            this.btnExcluirItens.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciar.Location = new System.Drawing.Point(549, 99);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(118, 23);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Refazer";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // btnExluirImpress
            // 
            this.btnExluirImpress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExluirImpress.BackColor = System.Drawing.SystemColors.Control;
            this.btnExluirImpress.Location = new System.Drawing.Point(549, 128);
            this.btnExluirImpress.Name = "btnExluirImpress";
            this.btnExluirImpress.Size = new System.Drawing.Size(118, 23);
            this.btnExluirImpress.TabIndex = 4;
            this.btnExluirImpress.Text = "Excluir Impressora";
            this.btnExluirImpress.UseVisualStyleBackColor = false;
            // 
            // cadLetra
            // 
            this.cadLetra.Location = new System.Drawing.Point(157, 12);
            this.cadLetra.Name = "cadLetra";
            this.cadLetra.Size = new System.Drawing.Size(127, 23);
            this.cadLetra.TabIndex = 5;
            this.cadLetra.Text = "Cadastro Letras";
            this.cadLetra.UseVisualStyleBackColor = true;
            this.cadLetra.Click += new System.EventHandler(this.cadLetra_Click);
            // 
            // cadImpress
            // 
            this.cadImpress.Location = new System.Drawing.Point(12, 12);
            this.cadImpress.Name = "cadImpress";
            this.cadImpress.Size = new System.Drawing.Size(139, 23);
            this.cadImpress.TabIndex = 6;
            this.cadImpress.Text = "Cadastro Impressora";
            this.cadImpress.UseVisualStyleBackColor = true;
            this.cadImpress.Click += new System.EventHandler(this.cadImpress_Click);
            // 
            // frmListImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 227);
            this.Controls.Add(this.cadImpress);
            this.Controls.Add(this.cadLetra);
            this.Controls.Add(this.btnExluirImpress);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnExcluirItens);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListImpressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Impressão";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnExcluirItens;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnExluirImpress;
        private System.Windows.Forms.Button cadLetra;
        private System.Windows.Forms.Button cadImpress;
    }
}