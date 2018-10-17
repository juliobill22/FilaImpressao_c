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
        List<Impressora> lstLocal;

        public frmCadLetras(List<Impressora> lst)
        {
            InitializeComponent();
            lstLocal = lst;

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

        private void btnGravar_Click(object sender, EventArgs e)
        {

            Documento doc = new Documento();
            List<Char> letras = new List<char>();

            if (ckA.Checked == true) { letras.Add('A'); }
            if (ckB.Checked == true) { letras.Add('B'); }
            if (ckC.Checked == true) { letras.Add('C'); }
            if (ckD.Checked == true) { letras.Add('D'); }
            if (ckE.Checked == true) { letras.Add('E'); }
            if (ckF.Checked == true) { letras.Add('F'); }
            if (ckG.Checked == true) { letras.Add('G'); }
            if (ckH.Checked == true) { letras.Add('H'); }
            if (ckI.Checked == true) { letras.Add('I'); }
            if (ckJ.Checked == true) { letras.Add('J'); }
            if (ckL.Checked == true) { letras.Add('L'); }
            if (ckM.Checked == true) { letras.Add('M'); }
            if (ckN.Checked == true) { letras.Add('N'); }
            if (ckO.Checked == true) { letras.Add('O'); }
            if (ckP.Checked == true) { letras.Add('P'); }
            if (ckQ.Checked == true) { letras.Add('Q'); }
            if (ckR.Checked == true) { letras.Add('R'); }
            if (ckS.Checked == true) { letras.Add('S'); }
            if (ckT.Checked == true) { letras.Add('T'); }
            if (ckU.Checked == true) { letras.Add('U'); }
            if (ckV.Checked == true) { letras.Add('V'); }
            if (ckX.Checked == true) { letras.Add('X'); }
            if (ckZ.Checked == true) { letras.Add('Z'); }
            if (ckW.Checked == true) { letras.Add('W'); }
            if (ckY.Checked == true) { letras.Add('Y'); }

            doc.Letras1 = letras;

            ckA.Checked = false;
            ckB.Checked = false;
            ckC.Checked = false;
            ckD.Checked = false;
            ckE.Checked = false;
            ckF.Checked = false;
            ckG.Checked = false;
            ckH.Checked = false;
            ckI.Checked = false;
            ckJ.Checked = false;
            ckL.Checked = false;
            ckM.Checked = false;
            ckN.Checked = false;
            ckO.Checked = false;
            ckP.Checked = false;
            ckQ.Checked = false;
            ckR.Checked = false;
            ckS.Checked = false;
            ckT.Checked = false;
            ckU.Checked = false;
            ckV.Checked = false;
            ckX.Checked = false;
            ckZ.Checked = false;
            ckW.Checked = false;
            ckY.Checked = false;

            if (lstLocal.Count == 0)
            {
                MessageBox.Show("Primeiramente, cadastre uma impressora na outra tela.");

            } else if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecione a impressora!");
                comboBox1.Focus();

            }
            else
            {
                if (letras.Count > 0)
                {
                    MessageBox.Show("Letra gravada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Informe a(s) letra(s) que serão gravadas!");
                }
            }
        }
    }
}
