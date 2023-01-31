// Setting working directory so the program doesn't break if it's not on my PC
string dir = System.IO.Directory.GetCurrentDirectory();
// Establishing running loop
bool running = true;
while (running)
{
    // Introducing system and giving user choice
    Console.WriteLine("Ticketing System");
    Console.WriteLine("Please select an option: ");
    Console.WriteLine($"1. View current tickets \t 2. Edit tickets \t 3. Exit");
    // Taking user input before proceeding, using a switch statement to make input validation easier. If nothing is entered, it will read as a blank character and hit the default case
    string userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "1":
        // Print current content of tickets.csv
        if (File.Exists(dir + "\\tickets.csv"))
        {
            using (StreamReader reader = new StreamReader(dir + "\\tickets.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                Console.WriteLine(line);
                }
            }

        }   
        // Else statement if tickets.csv is not found to keep it from imploding
        else
        {
        Console.WriteLine("Error, tickets.csv not found");
        }
        break;

        case "2":
        // Appending to the tickets.csv file
        if (File.Exists(dir + "\\tickets.csv"))
        {
            using (StreamWriter writer = new StreamWriter(dir + "\\tickets.csv", append: true))
            {
                Console.WriteLine("Please enter what you would like to add to the ticket system");
                string userInput = Console.ReadLine();
                // Placing each new append on a new line for a more readable output
                writer.WriteLine($"\n" + userInput);
            }
        }
        // Else statement if tickets.csv is not found to keep it from imploding
        else
        {
            Console.WriteLine("Error, tickets.csv not found");
        }
        break;
    
        case "3":
        // Just an end program option
        running = false;
        break;

        default:
        // Catches bad inputs and brings the user back to the choice menu
        Console.WriteLine("Invalid input, please try again");
        break;
    }
}
