using System;

// Namespace
namespace tebakangka
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Ask for users name and greet

            while (true)
            {

                // Init correct number
                //int correctNumber = 7;

                // membuat random object baru
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Tebak angka antara 1 sampai 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Mohon masukan angka yang sesuai");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Angka salah, silahkan coba lagi");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "HORE!! tebakanmu benar");

                // Ask to play again
                Console.WriteLine("bermain lagi? [Y or T]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "T")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Tebak Angka";
            string appVersion = "1.0.0";
            string appAuthor = "Furqon Maulana";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("Siapa namamu?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hallo {0}, mari bermain game tebakan...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}