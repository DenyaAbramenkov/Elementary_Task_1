using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Task_1
{
    class Board
    {
        public int Board_Height { get; set; }
        public int Board_Width { get; set; }
        public Cell[,] Cells;
        public  Board Build_Board()
        {
            Board board = new Board();
            for (int i =0; i < Board_Height; i++)
            {
                for (int j = 0; j < Board_Height; j++)
                {
                    Cells[i, j] = new Cell();
                }
            }
            return board;
        }
    }
}
