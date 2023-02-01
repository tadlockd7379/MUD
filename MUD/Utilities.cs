using System;

namespace MUD
{
    class Utilities
    {
        public static bool YesNoInput(String question)
        {
            Console.Write(question + "(Y/N): ");
            String result = Console.ReadLine().ToLower();
            if (result.Contains("y"))
            {
                return true;
            } 
            else if (result.Contains("n"))
            {
                return false;
            }
            else
            {
                return YesNoInput(question);
            }
        }

        public static String StringInput(String question)
        {
            Console.Write(question + ": ");
            return Console.ReadLine();
        }
    }
}
