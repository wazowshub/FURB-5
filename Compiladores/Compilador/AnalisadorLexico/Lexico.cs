using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AnalisadorLexico
{
    public class Lexico : Constants
    {
        private int position;
        private String input;
        public List<Token> Tokens;
        public string MensagemErro;
		private int linha;
		private int poslinha;

		public Lexico()
            : this("")
        {
        }

        public Lexico(string _text)
        {
            setInput(_text);
            Tokens = new List<Token>();
        }

        public bool Start()
        {
			linha = 1;
			poslinha = 0;
			MensagemErro = "";
            Tokens.Clear();
            try
            {
                var token = nextToken();

                while (token != null)
                {
                    Tokens.Add(token);
                    token = nextToken();
                }
            }
            catch (LexicalError e)
            {
                MensagemErro = e.ToString();
                return false;
            }

            return true;
        }

        public void setInput(string _text)
        {
            var _input = new StringReader(_text);
            StringBuilder bfr = new StringBuilder();
            try
            {
                int c = _input.Read();
                while (c != -1)
                {
                    bfr.Append((char)c);
                    c = _input.Read();
                }
                this.input = bfr.ToString();
            }
            catch (IOException e)
            {
                e.ToString();
            }

            setPosition(0);
        }

        public void setPosition(int pos)
        {
            position = pos;
        }

        public Token nextToken()
        {
            if (!hasInput())
                return null;

            int start = position;

			int state = 0;
            int lastState = 0;
            int endState = -1;
            int end = -1;
			var quebralinha = false;
			int poslinhaaux = 0;
			char nextchar = '?';

            while (hasInput())
            {
                lastState = state;
				nextchar = nextChar();
                state = nextState(nextchar, state, out quebralinha);
				poslinhaaux++;


				if (state < 0)
				{
					poslinhaaux--;
					break;
				}
				else
				{
					if (tokenForState(state) >= 0)
					{
						endState = state;
						end = position;
						if (quebralinha)
						{
							linha++;
							poslinha = 0;
							poslinhaaux = 0;
						}
					}
				}
            }
            if (endState < 0 || (endState != state && tokenForState(lastState) == -2))
                throw new LexicalError(SCANNER_ERROR[lastState], linha, poslinha);

            position = end;
			poslinha = poslinha + poslinhaaux;

			int token = tokenForState(endState);

            if ((token == 0) || (token == 6) || (token == 7))
                return nextToken();
            else
            {
                String lexeme = input.Substring(start, end - start);
                token = lookupToken(token, lexeme);
                return new Token(token, lexeme, poslinha, linha);
            }
        }

        private int nextState(char c, int state, out bool quebralinha)
		{
			quebralinha = c == '\n';

			int start = SCANNER_TABLE_INDEXES[state];
            int end = SCANNER_TABLE_INDEXES[state + 1] - 1;

            while (start <= end)
            {
                int half = (start + end) / 2;

                if (SCANNER_TABLE[half][0] == c)
                    return SCANNER_TABLE[half][1];
                else if (SCANNER_TABLE[half][0] < c)
                    start = half + 1;
                else  //(SCANNER_TABLE[half][0] > c)
                    end = half - 1;
            }

            return -1;
        }

        private int tokenForState(int state)
        {
            if (state < 0 || state >= TOKEN_STATE.Length)
                return -1;

            return TOKEN_STATE[state];
        }

        public int lookupToken(int _base, String key)
        {
            int start = SPECIAL_CASES_INDEXES[_base];
            int end = SPECIAL_CASES_INDEXES[_base + 1] - 1;

            while (start <= end)
            {
                int half = (start + end) / 2;
                int comp = SPECIAL_CASES_KEYS[half].CompareTo(key);

                if (comp == 0)
                    return SPECIAL_CASES_VALUES[half];
                else if (comp < 0)
                    start = half + 1;
                else  //(comp > 0)
                    end = half - 1;
            }

            return _base;
        }

        private bool hasInput()
        {
            return position < input.Length;
        }

        private char nextChar()
        {
            if (hasInput())
                return input[position++];
            else
                return unchecked((char)-1);
        }
    }

}
