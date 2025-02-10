// The Model class is responsible for storing and managing data.
public class Model
{
    // A private variable to store data (string)
    private string _data;

    // Method to update the data inside the model
    public void SetData(string data)
    {
        _data = data; // Assigns the provided data to the _data variable
    }

    // Method to retrieve the stored data
    public string GetData()
    {
        return _data; // Returns the stored data
    }
}
