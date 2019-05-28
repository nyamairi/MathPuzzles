using System.Linq;

namespace MathPuzzles
{
    public static class Program
    {
        private static readonly IProgram[] Programs =
        {
            new Program1()
        };

        public static void Main(string[] args)
        {
            var index = int.Parse(args.First()) - 1;
            Programs[index].Run(args.Skip(1));
        }
    }
}