using System.Reflection.Metadata;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    
    private int _target;
    private int _bonus;

    public ChecklistGoal(string description, string name, int points, int target, int bonus) : base(description, name, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    //public override int RecordEvent()
    //{
    //    if (_amountCompleted >= _target)
    //    {
    //        return 0;
    //    }
    //    _amountCompleted++;
    //        
    //    if (_amountCompleted == _target)
    //    {
    //        Console.WriteLine("BONUS ACTIVATED");
    //        return GetPoints() + _bonus;
    //    }
    //    return GetPoints();
    //}
    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            if (_amountCompleted == _target)
            {
                Console.WriteLine("Goal completed! Bonus awarded!");
                return GetPoints() + _bonus;
            }

            return GetPoints();
        }

        return 0; 
    }


    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
          return $"{GetShortName()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_target},{_amountCompleted},{_bonus}";
    }

    public void SetAmountCompleted(int amount)
{
    _amountCompleted = amount;
}

}