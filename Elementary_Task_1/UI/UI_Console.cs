namespace Elementary_Task_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    
    public class UI_Console
    { 
        public static void BuildUI()
        {
            const int RIGHT_COUNT_ARGS = 3;
            string[] args = Environment.GetCommandLineArgs();
            switch (args.Length)
            {
                case RIGHT_COUNT_ARGS:
                    {
                        try
                        {
                            Board board = Board.Initialize(int.Parse(args[1]), int.Parse(args[2]));
                            UI_Console.DrawBoard(board);
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Incorect enter of args");
                            Console.ReadKey();
                        }

                        break;
                    }

                default:
                    {
                        Instruction();
                        break;
                    }
            }
        }
        public static void DrawBoard(Board board)
        {
            for (int i = 0; i < board.Board_Height; i++)
            {
                for (int j = 0; j < board.Board_Width; j++)
                {
                    if (board.Cells[i, j].Color == Colors.White)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static void Instruction()
        {
            Console.WriteLine("Instructions for working with the program:" + Environment.NewLine +
               "To draw chess boars n*m input 2 natural numbers:");
        }
    }           
}