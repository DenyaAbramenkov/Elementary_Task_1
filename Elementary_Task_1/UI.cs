namespace Elementary_Task_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// UI class
    /// </summary>
    public class UI
    {
        /// <summary>
        /// Method to build UI
        /// </summary>
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
                            Board b = new Board(int.Parse(args[1]), int.Parse(args[2]));
                            b.DrawBoard();
                        }
                        catch (Exception)
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

        /// <summary>
        /// Method to show instruction to user
        /// </summary>
        private static void Instruction()
        {
            Console.WriteLine("Instructions for working with the program:" + Environment.NewLine +
               "To draw chess boars n*m input 2 natural numbers:");
        }
    }           
}