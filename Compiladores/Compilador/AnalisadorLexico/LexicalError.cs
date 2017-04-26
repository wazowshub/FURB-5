using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisadorLexico
{
    public class LexicalError : AnalysisError
    {
		private int linha;
		private string token;

		public LexicalError(String msg, int linha, int position, string token): base(msg, position)
        {
			this.linha = linha;
			this.token = token;
        }

        public LexicalError(String msg): base(msg)
        {
		}

		public override String ToString()
		{
			return string.Format(base.Message, this.linha + "" , base.getPosition() + "", token);
		}
	}

}
