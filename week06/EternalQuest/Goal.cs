public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
         _isComplete = false;
    }
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }
    public virtual int RecordEvent()
    {
        return 0;
    }
    public virtual bool IsComplete()
    {
        return _isComplete;
    }
    protected void CompleteGoal()
    {
        _isComplete = true;
    }

}
