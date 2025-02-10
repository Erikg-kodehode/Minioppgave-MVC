using System; // Required for console input and output

// Main program that runs the MVC application
class Program
{
    static void Main()
    {
        // Create instances of Model and View
        Model model = new Model();
        View view = new View();

        // Create a Controller and pass in the Model and View
        Controller controller = new Controller(model, view);

        // Ask the user for input
        Console.Write("Enter data: ");
        string userInput = Console.ReadLine(); // Reads input from the console

        // Use the Controller to update the Model with user input
        controller.UpdateModel(userInput);
    }
}
