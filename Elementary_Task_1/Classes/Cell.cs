namespace Elementary_Task_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum Colors
    {
        White,
        Black
    }

    public class Cell
    {
        public Cell(Colors color)
        {
            Color = color;
        }
        
        public Colors Color { get; set; }   
    }
}
