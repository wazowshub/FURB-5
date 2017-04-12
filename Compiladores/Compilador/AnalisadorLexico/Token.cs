using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisadorLexico
{
    public class Token
    {
        private int id;
        private String lexeme;
        private int position;
		private int linha;

        public Token(int id, String lexeme, int position, int linha)
        {
            this.id = id;
            this.lexeme = lexeme;
            this.position = position;
			this.linha = linha;
        }

        public int getId()
        {
            return id;
        }

        public String getLexeme()
        {
            return lexeme;
        }

        public int getPosition()
        {
            return position;
        }

        public override String ToString()
        {
            return "Linha " + linha + ": { " + lexeme + " } - " + Constants.ToClassType(id);
        }
    }

}
