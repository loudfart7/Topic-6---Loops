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
            double balance = 150, deposit, withdrawl;
            

            Console.WriteLine();
            Console.WriteLine("PLANET BLORB BANK");
            Console.WriteLine();

            string bankSelection ="";

            while (bankSelection != "q")
            {
                Console.Clear();
                Console.WriteLine("BANK OF BLORB MENU. PLEASE SELECT ONOF THE FOLLOWING ACTIONS:");
                Console.WriteLine();
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdrawl");
                Console.WriteLine("Bill Payment");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                bankSelection = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (balance > 0.75)
                {
                    if (bankSelection == "1")
                    {
                        balance = balance - 0.75;
                        Console.WriteLine($"YOUR BALANCE: {balance}");

                        Console.WriteLine("You chose 'DEPOSIT'.");
                        Console.WriteLine("Hit ENTER to continue.");
                        Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine($"BALANCE:{balance}");

                        Console.WriteLine("Please enter the amount of BLORPIAN DOLLARS you would like to deposit:");

                        while (!double.TryParse(Console.ReadLine(), out deposit))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please try again. Input must only contain numbers can must not contain letters or special characters.");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"You have deposited{deposit}.");
                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();

                        balance = balance + deposit;

                    }
                    else if (bankSelection == "2")
                    {
                        balance = balance - 0.75;
                        Console.WriteLine($"YOUR BALANCE: {balance}");

                        Console.WriteLine("You chose 'WITHDRAWL'.");
                        Console.WriteLine("Hit ENTER to continue.");
                        Console.ReadLine();

                        Console.WriteLine("Please enter the amount of BLORPIAN DOLLARS you would like to deposit:");

                        while (!double.TryParse(Console.ReadLine(), out withdrawl))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, please try again. Input must only contain numbers can must not contain letters or special characters.");
                            Console.WriteLine();
                        }

                        while (balance < withdrawl)
                        {
                            Console.WriteLine($"The amount you wish to withdrawl current exceeds your balance. Please try again.");

                            while (!double.TryParse(Console.ReadLine(), out withdrawl))
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid input, please try again. Input must only contain numbers can must not contain letters or special characters.");
                                Console.WriteLine();
                            }
                        }

                        balance = balance - withdrawl; 
                    }
                    else if (bankSelection == "3")
                    {
                        balance = balance - 0.75;
                        Console.WriteLine($"YOUR BALANCE: {balance}");

                        Console.WriteLine("You chose 'BILL PLAYMENT'.");
                        Console.WriteLine("Hit ENTER to continue.");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Invalid choice, please press ENTER to continue back to MENU.");
                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Your account balance does not contain the required amount of money to complete any further transactions.");
                    Console.WriteLine("Press ENTER to go back to menu.");
                    Console.Read();
                }
            }
        }

        static void doublesRoller()
        {
            bool done = false;

            Die die1, die2;
            Console.Clear();

            while (!done)
            {
                die1 = new Die();
                die2 = new Die();

                if (die1.Roll == die2.Roll)
                {
                    Console.WriteLine("DOUBLES");
                    Console.WriteLine("You will be sent back to the menu.");
                    done = true;
                }
                    
                else
                    Console.WriteLine("NOT DOUBLES");

                die1.DrawDie();
                die2.DrawDie();

                Console.WriteLine();
                Console.WriteLine("PRESS ENTER");
                Console.Read();
                Console.Clear();
            } 

            Console.WriteLine();
            Console.WriteLine("DOUBLES DICE ROLL");
            Console.WriteLine(); 
        }
    }
}
