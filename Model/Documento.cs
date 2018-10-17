using System;
using System.Collections.Generic;
using System.Text;

namespace FilaImpressao
{
	public class Documento
	{
		private int CodigoFila;
        private List<Char> Letras;

        public Documento()
        {
        }

        public Documento(int codigoFila, List<Char> letras)
        {
            CodigoFila = codigoFila;
            Letras = letras;
        }

        public int CodigoFila1 { get => CodigoFila; set => CodigoFila = value; }
        public List<Char> Letras1 { get => Letras; set => Letras = value; }

    }
}