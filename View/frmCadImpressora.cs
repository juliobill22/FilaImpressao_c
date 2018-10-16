using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FilaImpressao
{
    public partial class frmCadImpressora : Form
    {
        private List<Impressora> ListaImpressao;

        public frmCadImpressora(List<Impressora> lst)
        {
            InitializeComponent();
            this.ListaImpressao = lst;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if ((cpCodigo.Text == null) && (cbNome.Text == null) && (cbTempo.Text == null)) {

                Impressora _impressora = new Impressora();

                string strValue;
                int intValue;

                strValue = cpCodigo.Text;
                intValue = Convert.ToInt32(strValue);
                _impressora.Codigo = intValue;

                _impressora.Nome = cbNome.Text;

                strValue = cbTempo.Text;
                intValue = Convert.ToInt32(strValue);
                _impressora.Tempo = intValue;

                ListaImpressao.Add(_impressora);

                MessageBox.Show("Impressora cadastrada com sucesso!");

                cpCodigo.Text = "";
                cbNome.Text = "";
                cbTempo.Text = "";

                cpCodigo.Focus();

            } else
            {
                MessageBox.Show("Para gravar, preencha todos os dados.");
            }
        }
    }
}
