using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilaImpressao
{
    public partial class frmListImpressao : Form
    {

        private List<Impressora> ListaImpressao;
        
        public frmListImpressao()
        {
            InitializeComponent();
            if (ListaImpressao == null) {
                ListaImpressao = new List<Impressora>();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cadImpress_Click(object sender, EventArgs e)
        {
            var frm = new frmCadImpressora(dataGridView1, ListaImpressao);
            frm.ShowDialog();
        }

        private void cadLetra_Click(object sender, EventArgs e)
        {
            var frm = new frmCadLetras(ListaImpressao);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
