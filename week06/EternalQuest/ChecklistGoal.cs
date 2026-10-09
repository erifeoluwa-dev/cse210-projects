public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int amountCompleted, int bonus)
    : base(name, description, points)
    {
        _target = target;
        _amountCompleted = amountCompleted;
          _bonus = bonus;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            CompleteGoal();
            return GetPoints() + _bonus; 
        }
        return GetPoints();
    }
        public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
        public int GetTarget()
    {
        return _target;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    
}
