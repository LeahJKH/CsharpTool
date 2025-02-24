namespace CsharpTool
{
    class Program
    {
        static List<string> LoggUnshown = new List<string>();

        static void Main(string[] args)
        {
            bool choice;
            do
            {
                choice = Runner();
            } while (choice != false);

            Console.WriteLine("\nThanks for using");
        }

        static bool Runner()
        {
            Console.WriteLine("What do you need? \n  1. Check loggs \n  2. Write new entry \n  3. Delete entry \n  4. Exit");
            string? answerUser = Console.ReadLine();
             Console.WriteLine("\n");

            if (answerUser == "1" || answerUser == "one") 
            {
                Console.WriteLine("\n " + string.Join(", ", LoggUnshown));
                return true;
            }
            if (answerUser == "2" || answerUser == "two") 
            {
                Console.WriteLine("Please insert new value");
                string? newLog = Console.ReadLine();
                Console.WriteLine("\n");
                LoggUnshown.Add(newLog);
                return true;
            }
            if (answerUser == "3" || answerUser == "three")
            {
                return true;
            }
            if (answerUser == "4" || answerUser == "four")
            {
                return false;
            }

            return false; 
        }
    }
}
