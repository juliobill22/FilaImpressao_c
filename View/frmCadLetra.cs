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
    public partial class frmCadLetras : Form
    {
        public frmCadLetras(List<Impressora> lst)
        {
            InitializeComponent();
            if (lst != null) { 
                if (lst.Count > 0) { 
                    for (int i = 0; i < lst.Count; i++)
                        comboBox1.Items.Add(lst[i].Codigo.ToString() + " - " + lst[i].Nome);
                }
            }
        }

        private void ckI_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
