using System.Collections.Generic;

namespace MathPuzzles
{
    public interface IProgram
    {
        void Run(IEnumerable<string> arguments);
    }
}