using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilaImpressao.Model
{
    class Grid
    {
        private DataGridView Gd;
        private List<Impressora> Impressoras;

        public List<Impressora> Impressoras1 { get => Impressoras; set => Impressoras = value; }

        public Grid(DataGridView grid, List<Impressora> impressoras)
        {
            this.Gd = grid;
            this.Impressoras = impressoras;
        }

        public DataGridView GetGrid()
        {
            return Gd;
        }

        public void SetGrid(DataGridView value)
        {
            Gd = value;
        }

        public void gerarGrid()
        {
            if (Gd.Columns.Count == 0)
            {
                Gd.Columns.Add("clCodigo", "Código");
                Gd.Columns.Add("clNome", "Nome");
                Gd.Columns.Add("clDtCriacao", "Data Criação");
                Gd.Columns.Add("clStatus", "Status");
                Gd.Columns.Add("clTempo", "Tempo");
            }

            Gd.Rows.Clear();
            for (int i = 0; i < Impressoras.Count; i++)
            {
                string[] row0 = { Convert.ToString(Impressoras[i].Codigo)
                                 ,Convert.ToString(Impressoras[i].Nome)
                                 ,Convert.ToString(Impressoras[i].Status)
                                 ,Convert.ToString(Impressoras[i].Tempo)
                                 ,Convert.ToString(Impressoras[i].DataCriacao)};
                Gd.Rows.Add(row0);
            }
            Gd.Refresh();
        }
    }
}