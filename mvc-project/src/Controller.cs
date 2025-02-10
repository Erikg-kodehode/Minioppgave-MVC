// The Controller class connects the Model and View, handling updates and user choices.
public class Controller
{
    // Private fields to store references to Model and View objects
    private Model _model;
    private View _view;

    // Constructor: Initializes the Controller with a Model and a View
    public Controller(Model model, View view)
    {
        _model = model; // Assigns the provided Model instance
        _view = view;   // Assigns the provided View instance
    }

    // Method to update the Model with new data, then refresh the View
    public void UpdateModel(string data)
    {
        _model.SetData(data); // Updates the model with the provided data
        UpdateView();         // Calls UpdateView() to reflect changes in the View
    }

    // Method to update the View based on the Model's data
    public void UpdateView()
    {
        _view.DisplayData(_model.GetData()); // Gets data from the Model and displays it
    }
}
