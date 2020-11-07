using System;
using Sudoku;

namespace SudokuCli
{
    public class GridPrinter
    {
        public void Print(Grid grid)
        {
            for (var x = 0; x < grid.Size; x++)
            {
                for (var y = 0; y < grid.Size; y++)
                {
                    Console.Write($"{grid.Get(x, y).ToString()} ");
                }
                Console.WriteLine();
            }
        }
    }
}