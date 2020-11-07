using Sudoku;

namespace SudokuCli
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid();
            var printer = new GridPrinter();
            
            printer.Print(grid);
        }
    }
}