using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisadorLexico
{
    public class SyntaticError : AnalysisError
    {
        public SyntaticError(String msg, int position): base(msg,position)
        {
        }

        public SyntaticError(String msg): base(msg)
        {
        }
    }

}
