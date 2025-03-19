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
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - BOB Banking");
                Console.WriteLine("3 - Doubles Roller") ;
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
                    Console.WriteLine("Invalid choice, please press ENTER to continue.");
                    Console.ReadLine();
                }

            }
        }

        static void prompter()
        {
            Console.Clear();
            int min, max, input;
            bool done = false;

            Console.WriteLine();
            Console.WriteLine("PROMPTER");
            Console.WriteLine();

            Console.Write("Enter a min value and amax for your randome number generator: ");
            Console.WriteLine();

            Console.Write("MIN: ");
            while (!int.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input, please try again. Input must only contain numbers can must not contain letters or special characters.");
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("MAX: ");
            while (!int.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input, please try again. Input must only contain numbers can must not contain letters or special characters.");
                Console.WriteLine();
            }

            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            Console.WriteLine();

            //loop
            while (!done)
            {
                Console.WriteLine("Enter in a value between " + min + " and " + max + ":");

                while (!int.TryParse(Console.ReadLine(), out input))
                    Console.WriteLine("Invalid input. Please try again.");

                if (input >= min && input <= max)
                    done = true;
                else
                    Console.WriteLine("Please enter valid input between " + min + " and " + max + ".");
            }

        }

        static void banking()
        {
            Console.Clear();
            double balance = 150;

            Console.WriteLine();
            Console.WriteLine("PLANET BLORB BANK");
            Console.WriteLine();

            string bankSelection = "";

            while (bankSelection != "q")
            {
                Console.Clear();
                Console.WriteLine("BANK OF BLORB MENU. PLEASE SELECT ONOF THE FOLLOWING ACTIONS:");
                Console.WriteLine();
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdrawl");
                Console.WriteLine("Bill Payment");
                Console.WriteLine();
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                bankSelection = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (bankSelection == "deposit")
                {
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                    prompter();
                }
                else if (bankSelection == "withdrawl")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                    banking();
                }
                else if (bankSelection == "Bill Payment")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ReadLine();

                    doublesRoller();
                }

                else
                {
                    Console.WriteLine("Invalid choice, please press ENTER to continue.");
                    Console.ReadLine();
                }


            }

            static void doublesRoller()
            {
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("PLANET BLORB BANK");
                Console.WriteLine();

            }
        }
    }

}
