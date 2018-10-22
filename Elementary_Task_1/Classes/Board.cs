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
        /// Intializes a new instace of the Board class.
        /// </summary>
        /// <param name="height">height of</param>
        /// <param name="width">width of</param>
        private Board(int height, int width)
        {
            this.Board_Height = height;
            this.Board_Width = width;
            this.GetSetOfCells();
        }
        
        /// <summary>
        /// Property Height
        /// </summary>
        public int Board_Height
        {
            get; set;
        }

        /// <summary>
        /// Property Width
        /// </summary> 
        public int Board_Width
        {
            get; set;
        }

        /// <summary>
        /// Property Cells
        /// </summary>
        public Cell[,] Cells { get; set; }

        public static Board Initialize(int height, int width)
        {

            if (width > 0 && height > 0)
            {
                if ((width % 2 == 0) && (height % 2 == 0))
                {
                    return new Board(width, height);
                }
                else
                {
                    throw new ArgumentException("Incorrect width or height. Values should be divided by 2");
                }
            }
            else throw new ArgumentException("Incorrect width or height. Please use values more than 0");
        }

        private void GetSetOfCells()
        {
            this.Cells = new Cell[Board_Height, Board_Width];
            for (int height = 0; height < Board_Height; height++)
            {
                for(int width = 0; width < Board_Width; width++)
                {
                    if ((height % 2) == (width % 2))
                    {
                        Cells[height, width] = new Cell(Colors.White);
                    }
                    else
                    {
                        Cells[height, width] = new Cell(Colors.Black);
                    }
                }
            }
            
        }

    }
}
