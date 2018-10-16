using System;
using System.Collections.Generic;
using System.Text;


namespace FilaImpressao
{
	public class Impressora
	{
        public Impressora(int codigo, string nome, int tempo, DateTime dataCriacao, char status, List<Impressora> docsFila, List<Impressora> docsImpresso, int itemSelec)
        {
            Codigo = codigo;
            Nome = nome;
            Tempo = tempo;
            DataCriacao = dataCriacao;
            Status = status;
            DocsFila = docsFila;
            DocsImpresso = docsImpresso;
            ItemSelec = itemSelec;
        }

        public Impressora()
        {
        }

        private int codigo;
        private string nome;
        private int tempo;
        private DateTime dataCriacao;
        private char status;
        private List<Impressora> docsFila;
        private List<Impressora> docsImpresso;
        private int itemSelec;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Tempo { get => tempo; set => tempo = value; }
        public DateTime DataCriacao { get => dataCriacao; set => dataCriacao = value; }
        public char Status { get => status; set => status = value; }
        public List<Impressora> DocsFila { get => docsFila; set => docsFila = value; }
        public List<Impressora> DocsImpresso { get => docsImpresso; set => docsImpresso = value; }
        public int ItemSelec { get => itemSelec; set => itemSelec = value; }

        public void addDocsFila()
		{
		}

		public void NewMethod()
		{
		}
	}
}
