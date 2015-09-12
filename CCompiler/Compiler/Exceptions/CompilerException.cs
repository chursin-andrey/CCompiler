using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCompiler.Compiler.Exceptions
{
    /// <summary>
    /// This exception about compiler issue
    /// </summary>
    public class CompilerException : Exception
    {
        private int lineIndex;
        private int positionIndex;
        private String message;

        /// <summary>
        /// Exception about compiler issue
        /// </summary>
        /// <param name="lineIndex">index of line with issue</param>
        /// <param name="positionIndex">index of position in line with issue</param>
        /// <param name="message">reason of issue</param>
        public CompilerException(int lineIndex, int positionIndex, string message)
        {
            if (lineIndex < 0 || positionIndex < 0)
            {
                throw new ArgumentException("lineIndex and PositionIndex must be positive");
            }
            this.message = message;
            this.lineIndex = lineIndex;
            this.positionIndex = positionIndex;
        }

        public CompilerException(string message)
        {
            this.message = message;
            this.lineIndex = -1;
            this.positionIndex = -1;
        }

        /// <summary>
        /// index of position in line with issue
        /// </summary>
        public int PositionIndex
        {
            get { return positionIndex; }
        }

        /// <summary>
        /// index of line with issue
        /// </summary>
        public int LineIndex
        {
            get { return lineIndex; }
        }

        /// <summary>
        /// reason of issue
        /// </summary>
        public String Message
        {
            get { return message; }
        }

        public override String ToString()
        {
            if (lineIndex == -1 || positionIndex == -1)
            {
                return String.Format("Compiler error: {0}", message);
            }
            return String.Format("Compiler error: Line {0} Position {1} = {2}", lineIndex, positionIndex, message);
        }
    }
}
