using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisadorLexico
{
    public class LexicalError : AnalysisError
    {
		private int linha;

        public LexicalError(String msg, int linha, int position): base(msg, position)
        {
			this.linha = linha;
        }

        public LexicalError(String msg): base(msg)
        {
		}

		public override String ToString()
		{
			return string.Format(base.Message, this.linha + "" , base.getPosition() + "");
		}
	}

}
