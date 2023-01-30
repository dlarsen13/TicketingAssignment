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
    // Taking and validating user input before proceeding

    // Rip this from an old project, for now just don't fuck up in the meantime
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
            using (StreamWriter writer = new StreamWriter(dir + "\\tickets.csv"))
            {

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
        // This might validate input and restart the loop, test it first
        Console.WriteLine("Invalid input, please try again");
        break;
    }
}


