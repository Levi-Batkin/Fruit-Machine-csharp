using System;
namespace Fruit_Machine
{
    class Program
    {
        static string[] fruits = { "Cherry", "Grape", "Pineapple", "Apple", "Melon", "BAR", "7" };
        static string[] reel = new string[9];
        static decimal balance = 10m;
        static bool threematches = false;
        static bool twomatches = false;
        static bool nomatches = false;
        static int autospin = 0;
        static string winnings = "";
        static decimal balancetostop = 10m;
        static Grid grid = new Grid();
        public static void Main(string[] args)
        {
            var random = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            grid.format();
            Console.WriteLine("===================================");
            Console.WriteLine("            ███████╗██████╗░██╗░░░██╗██╗████████╗  ███╗░░░███╗░█████╗░░█████╗░██╗░░██╗██╗███╗░░██╗███████╗\n            ██╔════╝██╔══██╗██║░░░██║██║╚══██╔══╝  ████╗░████║██╔══██╗██╔══██╗██║░░██║██║████╗░██║██╔════╝\n            █████╗░░██████╔╝██║░░░██║██║░░░██║░░░  ██╔████╔██║███████║██║░░╚═╝███████║██║██╔██╗██║█████╗░░\n            ██╔══╝░░██╔══██╗██║░░░██║██║░░░██║░░░  ██║╚██╔╝██║██╔══██║██║░░██╗██╔══██║██║██║╚████║██╔══╝░░\n            ██║░░░░░██║░░██║╚██████╔╝██║░░░██║░░░  ██║░╚═╝░██║██║░░██║╚█████╔╝██║░░██║██║██║░╚███║███████╗\n            ╚═╝░░░░░╚═╝░░╚═╝░╚═════╝░╚═╝░░░╚═╝░░░  ╚═╝░░░░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚══════╝\n\n                    ░██████╗██╗███╗░░░███╗██╗░░░██╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░\n                    ██╔════╝██║████╗░████║██║░░░██║██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗\n                    ╚█████╗░██║██╔████╔██║██║░░░██║██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝\n                    ░╚═══██╗██║██║╚██╔╝██║██║░░░██║██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗\n                    ██████╔╝██║██║░╚═╝░██║╚██████╔╝███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║");
            grid.format();
            Console.WriteLine("===================================\n");
            grid.format();
            Console.WriteLine("Autospin spins the slots automatically.");
            grid.format();
            Console.WriteLine("Choose an option from below:\n");
            grid.format();
            Console.WriteLine("Option:");
            grid.format();
            Console.WriteLine("1) Autospin");
            grid.format();
            Console.WriteLine("2) Normal Spin");
            grid.format();
            Console.WriteLine("3) Quit\n");
            grid.format();
            switch (Console.ReadLine())
            {
                case "1":
                    autospin = 1;
                    Console.Clear();
                    Console.WriteLine("");
                    grid.format();
                    Console.WriteLine("You decided to enable autospin!");
                    grid.format();
                    Console.WriteLine("");
                    grid.format();
                    Console.WriteLine("What balance would you like autospin to stop around?");
                    grid.format();
                    Console.WriteLine("e.g. 10 or 5.70");
                    grid.format();
                    Console.Write(" ");
                    try
                    {
                        balancetostop = Convert.ToDecimal(Console.ReadLine());
                    }
                    catch
                    {
                        grid.format();
                        Console.WriteLine("Invalid Input " + balancetostop);
                        grid.format();
                        Console.WriteLine("Defaulting to £5.00 balance");
                        balancetostop = 5m;
                    }
                    code();
                    break;
                case "2":
                    autospin = 0;
                    Console.Clear();
                    Console.WriteLine("");
                    grid.format();
                    Console.WriteLine("Autospin mode was not enabled.");
                    code();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("");
                    grid.format();
                    Console.WriteLine("Invalid option :c, Goodbye!\n");
                    break;

            }
        }
        public static void code()
        {
            grid.format();
            Console.WriteLine("");
            grid.format();
            Console.WriteLine("To begin, press ENTER");
            grid.format();
            Console.Read();
            while (true)
            {
                Console.Clear();
                SpinReel();

                if (reel[3].Equals(reel[4]) && reel[3].Equals(reel[5]))
                {
                    Check3();
                }
                if ((reel[3].Equals(reel[4]) && (reel[3].Equals(reel[5]) == false)) || (reel[3].Equals(reel[4]) && (reel[3].Equals(reel[4]) == false)) || (reel[5].Equals(reel[4]) && (reel[5].Equals(reel[3]) == false)))
                {
                    Check2();
                }
                if ((reel[3].Equals(reel[4]) == false) && (reel[3].Equals(reel[5]) == false) && (reel[4].Equals(reel[5]) == false) && (reel[4].Equals(reel[3]) == false) && (reel[5].Equals(reel[3]) == false) && (reel[5].Equals(reel[4]) == false))
                {
                    Check1();
                }
                Console.WriteLine("");
                if (balance >= 0.10m || balance >= 0.05m)
                {
                    if (autospin == 1)
                    {
                        grid.format();
                        Console.WriteLine("Winnings: £ " + winnings + "!");
                        grid.format();
                        Console.WriteLine("Current Balance: £" + balance + "!");
                        grid.format();
                        Console.WriteLine("\n");
                        grid.format();
                        System.Threading.Thread.Sleep(300);
                        if (balance <= balancetostop)
                        {
                            grid.format();
                            Console.WriteLine("You finished with a balance of £" + balance);
                            grid.format();
                            Console.WriteLine("Press ENTER to Quit.");
                            grid.format();
                            Console.Read();
                            Environment.Exit(0);
                        }

                    }
                    if (autospin == 0)
                    {
                        grid.format();
                        Console.WriteLine("Winnings: £ " + winnings + "!");
                        grid.format();
                        Console.WriteLine("Current Balance: £" + balance + "!");
                        grid.format();
                        Console.WriteLine("\n");
                        grid.format();
                        Console.WriteLine("To play again, press ENTER");
                        grid.format();
                        Console.Read();
                    }
                }
                else
                {
                    grid.format();
                    Console.WriteLine("Hate to say it, but you are broke.");
                    grid.format();
                    Console.WriteLine("Remaining: £" + balance + "!");
                    grid.format();
                    Console.WriteLine("Press ENTER to Quit.");
                    grid.format();
                    Console.Read();
                    Environment.Exit(0);
                }
            }
        }
        public static void SpinReel()
        {
            for (int i = 0; i < 9; i++)
            {
                Random rnd = new Random();
                reel[i] = fruits[rnd.Next(0, 7)];
            }
            grid.printGrid(reel[0], reel[1], reel[2], reel[3], reel[4], reel[5], reel[6], reel[7], reel[8]);
        }
        public static void Check3()
        {
            threematches = true;
            grid.format();
            Console.WriteLine("You got 3 " + reel[3] + "'s in a row!");
            if (reel[3] == "Cherry" && threematches == true)
            {
                balance += 0.05m;
                winnings = "0.05";
            }
            if (reel[3] == "Grape" && threematches == true)
            {
                balance += 0.10m;
                winnings = "0.10";
            }
            if (reel[3] == "Pineapple" && threematches == true)
            {
                balance += 0.25m;
                winnings = "0.25";
            }
            if (reel[3] == "Apple" && threematches == true)
            {
                balance += 0.5m;
                winnings = "0.50";
            }
            if (reel[3] == "Melon" && threematches == true)
            {
                balance += 1m;
                winnings = "1.00";
            }
            if (reel[3] == "BAR" && threematches == true)
            {
                balance += 5m;
                winnings = "5.00";
            }
            if (reel[3] == "7" && threematches == true)
            {
                balance += 10m;
                winnings = "10.00";
            }
        }
        public static void Check2()
        {
            twomatches = true;
            grid.format();
            Console.WriteLine("Two in a row, You lost nothing.");
            if (reel[3] == "Cherry" && twomatches == true)
            {
                winnings = "0";
            }
            if (reel[3] == "Grape" && twomatches == true)
            {
                winnings = "0";
            }
            if (reel[3] == "Pineapple" && twomatches == true)
            {
                winnings = "0";
            }
            if (reel[3] == "Apple" && twomatches == true)
            {
                winnings = "0";
            }
            if (reel[3] == "Melon" && twomatches == true)
            {
                winnings = "0";
            }
            if (reel[3] == "BAR" && twomatches == true)
            {
                winnings = "0";
            }
            if (reel[3] == "7" && twomatches == true)
            {
                winnings = "0";
            }
        }
        public static void Check1()
        {
            nomatches = true;
            grid.format();
            Console.WriteLine("No matches, you lost £0.10");
            if (reel[3] == "Cherry" && nomatches == true)
            {
                winnings = "-0.10";
                balance = balance - 0.10m;
            }
            if (reel[3] == "Grape" && nomatches == true)
            {
                winnings = "-0.10";
                balance = balance - 0.10m;
            }
            if (reel[3] == "Pineapple" && nomatches == true)
            {
                winnings = "-0.10";
                balance = balance - 0.10m;
            }
            if (reel[3] == "Apple" && nomatches == true)
            {
                winnings = "-0.10";
                balance = balance - 0.10m;
            }
            if (reel[3] == "Melon" && nomatches == true)
            {
                winnings = "-0.10";
                balance = balance - 0.10m;
            }
            if (reel[3] == "BAR" && nomatches == true)
            {
                winnings = "-0.10";
                balance = balance - 0.10m;
            }
            if (reel[3] == "7" && nomatches == true)
            {
                winnings = "-0.10";
                balance = balance - 0.10m;
            }
        }
    }
}
