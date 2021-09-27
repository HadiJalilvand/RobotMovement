using System;
using System.IO;

namespace RobotMovement
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            Console.WriteLine("Type path file: ");
            path = Console.ReadLine();


            try
            {
                if (File.Exists(path) && (Path.GetExtension(path) == ".txt"))
                {
                    string[] commands = File.ReadAllLines(path);
                    Console.WriteLine(Commander(commands));
                }
                else
                {
                    Console.WriteLine("Not a .txt file. Please try again.");
                    Console.Write(@"The correct command formats are as follows:
PLACE X,Y,DIRECTION
MOVE
RIGHT
LEFT
REPORT
---------------------
Please review your input file and try again.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public static string Commander(string[] commands)
        {
            string message = "";
            Command cmd = new Command();
            if (cmd != null)
            {
                message = cmd.Start(commands);
            }
            return message;
        }
    }
}
