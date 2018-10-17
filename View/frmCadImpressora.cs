using FilaImpressao.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FilaImpressao
{
    public partial class frmCadImpressora : Form
    {
        private List<Impressora> ListaImpressao;
        private DataGridView Grid;

        public frmCadImpressora(DataGridView grid, List<Impressora> lst)
        {
            InitializeComponent();

            this.Grid = grid;
            this.ListaImpressao = lst;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if ((cpCodigo.Text != null) && (cbNome.Text != null) && (cbTempo.Text != null)) {

                Impressora _impressora = new Impressora();

                string strCodigo, strTempo;

                strCodigo = cpCodigo.Text;
                _impressora.Codigo = Convert.ToInt32(strCodigo);
                _impressora.Nome = cbNome.Text;
                _impressora.DataCriacao = DateTime.Now;
                _impressora.Status = 'S';
                strTempo = cbTempo.Text;
                _impressora.Tempo = Convert.ToInt32(strTempo);
                ListaImpressao.Add(_impressora);

                MessageBox.Show("Impressora cadastrada com sucesso!");

                cpCodigo.Text = "";
                cbNome.Text = "";
                cbTempo.Text = "";

                cpCodigo.Focus();

            } else {

                MessageBox.Show("Para gravar, preencha todos os dados.");

            }

            Grid gd = new Grid(this.Grid, ListaImpressao);
            gd.gerarGrid();


        }
    }
}