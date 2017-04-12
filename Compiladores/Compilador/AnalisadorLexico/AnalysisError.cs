using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisadorLexico
{
    public class AnalysisError : Exception
    {
        private int position;

        public AnalysisError(String msg, int position): base(msg)
        {
            this.position = position;
        }

        public AnalysisError(String msg): base(msg)
        {
            this.position = -1;
        }

        public int getPosition()
        {
            return position;
        }

        public override String ToString()
        {
            return base.Message + ", @ " + position;
        }
    }

}
