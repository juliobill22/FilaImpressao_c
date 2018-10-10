using System;
using System.Collections.Generic;
using System.Text;


namespace FilaImpressao
{
	public class Impressora
	{

		public Impressora()
		{
			throw new NotImplementedException();
		}

		~Impressora()
		{
			throw new NotImplementedException();
		}

        public int Codigo { get => Codigo; set => Codigo = value; }
        public string Nome { get => Nome; set => Nome = value; }
        public int Tempo { get => Tempo; set => Tempo = value; }
        public DateTime DataCriacao { get => DataCriacao; set => DataCriacao = value; }
        public char Status { get => Status; set => Status = value; }
        public List<Impressora> DocsFila { get => DocsFila; set => DocsFila = value; }
        public List<Impressora> DocsImpresso { get => DocsImpresso; set => DocsImpresso = value; }
        public int ItemSelec { get => ItemSelec; set => ItemSelec = value; }

        public void addDocsFila()
		{
			throw new NotImplementedException();
		}

		public void NewMethod()
		{
			throw new NotImplementedException();
		}
	}
}
