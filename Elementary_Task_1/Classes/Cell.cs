namespace Elementary_Task_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Cell class 
    /// </summary>
    public class Cell
    {
        public Cell(int height_Location, int width_Location)
        {
            this.Height_Location = height_Location;
            this.Width_Location = width_Location;
            if ((height_Location % 2 == 1) && (width_Location % 2 == 1))
            {
                this.Color = (int)Colors.White;
            }
            else if ((height_Location % 2 == 0) && (width_Location % 2 == 0))
            {
                this.Color = (int)Colors.White;
            }
            else
            {
                this.Color = (int)Colors.Black;
            }
        }

        public enum Colors
        {
            White = 0,
            Black = 1
        }

        /// <summary>
        /// Height coordinate
        /// </summary>
        public int Height_Location { get; set; }

        /// <summary>
        /// Width coordinate
        /// </summary>
        public int Width_Location { get; set; }

        /// <summary>
        /// Color of cell
        /// </summary>
        public int Color { get; set; }   
    }
}
