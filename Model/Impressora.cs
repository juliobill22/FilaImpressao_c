using System;
using System.Collections.Generic;
using System.Text;

namespace FilaImpressao
{
    public class Impressora
    {
        public Impressora(
            int codigo,
            string nome,
            int tempo,
            DateTime dataCriacao,
            char status,
            List<Documento> docsFila,
            List<Documento> docsImpresso,
            int itemSelec)
        {
            Codigo = codigo;
            Nome = nome;
            Tempo = tempo;
            DataCriacao = dataCriacao;
            Status = status;
            DocsFila = new List<Documento>(docsFila);
            DocsImpresso = new List<Documento>(docsImpresso);
            ItemSelec = itemSelec;
        }

        public Impressora()
        {
            DocsFila = new List<Documento>();
            DocsImpresso = new List<Documento>();
        }

        private int codigo;
        private string nome;
        private int tempo;
        private DateTime dataCriacao;
        private char status;
        private List<Documento> docsFila;
        private List<Documento> docsImpresso;
        private int itemSelec;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Tempo { get => tempo; set => tempo = value; }
        public DateTime DataCriacao { get => dataCriacao; set => dataCriacao = value; }
        public char Status { get => status; set => status = value; }

        public List<Documento> DocsFila {
            get => docsFila;
            set => docsFila = value;
        }
        public List<Documento> DocsImpresso {
            get => docsImpresso;
            set => docsImpresso = value;
        }

        public int ItemSelec { get => itemSelec; set => itemSelec = value; }

        public string getLetras(int index)
        {
            string strLetras = null;

            for (int i = 0; i < DocsFila.Count; i++)
            {
                strLetras += " Doc: " + Convert.ToString(DocsFila[i].CodigoFila1) + " Letra(s): ";

                for (int y = 0; y < DocsFila[i].Letras1.Count; y++)
                {
                    if (y < DocsFila[i].Letras1.Count-1)
                    {
                        strLetras += Convert.ToString(DocsFila[i].Letras1[y]) + ",";
                    }
                    else
                    {
                        strLetras += Convert.ToString(DocsFila[i].Letras1[y]);
                    }
                }
                strLetras += ";";
            }
            return strLetras;
        } 

	}
}