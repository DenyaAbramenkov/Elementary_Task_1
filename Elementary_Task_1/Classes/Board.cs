namespace Elementary_Task_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Board class
    /// </summary>
    public class Board
    {
        /// <summary>
        /// Height of board
        /// </summary>
        private int boardHeight;

        /// <summary>
        /// Width of board
        /// </summary>
        private int boardWidth;
        //fs
        /// <summary>
        /// Intializes a new instace of the Board class.
        /// </summary>
        /// <param name="height">height of</param>
        /// <param name="width">width of</param>
        public Board(int height, int width)
        {
            this.Board_Height = height;
            this.Board_Width = width;
            this.Cells = new Cell[height, width];
            for (int i = 0; i < this.Board_Height; i++)
            {
                for (int j = 0; j < this.Board_Width; j++)
                {
                    this.Cells[i, j] = new Cell(i, j);
                }
            }
        }
        
        /// <summary>
        /// Property Height
        /// </summary>
        public int Board_Height
        {
            get
            {
                return this.boardHeight;
            }
  
            set
            {
                if (value % 2 == 0)
                {
                    this.boardHeight = value;
                }
                else
                {
                    Console.WriteLine("Board dimensions must be multiples of 2");
                }
            }
        }

        /// <summary>
        /// Property Width
        /// </summary> 
        public int Board_Width
        {
            get
            {
                return this.boardWidth;
            }
            
            set
            {
                if (value % 2 == 0)
                {
                    this.boardWidth = value;
                }
                else
                {
                    Console.WriteLine("Board dimensions must be multiples of 2");
                }
            }
        }

        /// <summary>
        /// Property Cells
        /// </summary>
        private Cell[,] Cells { get; set; }

        /// <summary>
        /// Method to drow the board
        /// </summary>
        public void DrawBoard()
        {
            for (int i = 0; i < this.Board_Height; i++)
            {
                for (int j = 0; j < this.Board_Width; j++)
                {
                    if (this.Cells[i, j].Color == (int)Cell.Colors.White)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();        
        }
    }
}
