public class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void SetName(string name)
    {
        _model.SetName(name);
    }

    public void ShowName()
    {
        _view.ShowName(_model.GetName()); // ✅ Now this works because View.cs has ShowName()
    }

    public void SetAge(int age)
    {
        _model.SetAge(age);
    }

    public void ShowAge()
    {
        _view.ShowAge(_model.GetAge()); // ✅ Now this works because View.cs has ShowAge()
    }
}
