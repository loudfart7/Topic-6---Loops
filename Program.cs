namespace Topic_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Menu Option 1");
                Console.WriteLine("2 - Menu Option 2");
                Console.WriteLine("...");
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                    prompter();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                    banking();
                }
                else if (choice == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ReadLine();

                    doublesRoller();
                }

                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }

            }
        }

        static void prompter()
        {
            Console.WriteLine();
            Console.WriteLine("PROMPTER");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void banking()
        {
            Console.WriteLine();
        }

        static void doublesRoller()
        {
            Console.WriteLine();
        }
    }
}
