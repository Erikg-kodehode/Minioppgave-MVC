using System;

class Program
{
    static void Main()
    {
        Model model = new Model();
        View view = new View();
        Controller controller = new Controller(model, view);

        string continueInput;

        do
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine() ?? ""; // Ensure no null values
            controller.SetName(userName); // Store name

            Console.Write("Enter your age: ");
            int userAge;
            while (!int.TryParse(Console.ReadLine(), out userAge)) // Prevents invalid input
            {
                Console.Write("Invalid input. Enter a valid age (number): ");
            }
            controller.SetAge(userAge); // Store age

            Console.WriteLine("\nDisplaying Information:");
            controller.ShowName(); // Show stored name
            controller.ShowAge(); // Show stored age

            Console.Write("\nWould you like to enter another? (yes/no): ");
            continueInput = Console.ReadLine()?.Trim().ToLower() ?? "no"; // Default to "no" if null

        } while (continueInput == "yes");

        Console.WriteLine("\nProgram exited. Have a great day!");
    }
}
