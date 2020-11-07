using System;

namespace Sudoku
{
    public class Grid
    {
        public int Size => _cells.GetLength(0);
        
        private readonly int[,] _cells;

        public Grid(int size = 9)
        {
            _cells = new int[size, size];
            
            Clear();
        }

        public void Clear()
        {
            for (var x = 0; x < _cells.GetLength(0); x++) {
                for (var y = 0; y < _cells.GetLength(1); y++) {
                    Clear(x, y);
                }
            }
        }

        public void Clear(int x, int y)
        {
            Set(x, y, 0);
        }

        public void Set(int x, int y, int value)
        {
            AssertCellIsInRange(x, y);

            _cells[x, y] = value;
        }

        public int Get(int x, int y)
        {
            AssertCellIsInRange(x, y);

            return _cells[x, y];
        }

        private void AssertCellIsInRange(int x, int y)
        {
            if (x < 0 || x >= _cells.GetLength(0))
                throw new ArgumentOutOfRangeException(nameof(x));
            
            if (y < 0 || y >= _cells.GetLength(1))
                throw new ArgumentOutOfRangeException(nameof(y));
        }
    }
}