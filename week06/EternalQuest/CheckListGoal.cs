public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonusPoints;
    private int _timesCompleted;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
    }
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int timesCompleted)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        if (_timesCompleted >= _targetCount)
        {
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override string GetDetailsString()
    {
        string status = _timesCompleted >= _targetCount ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Completed {_timesCompleted}/{_targetCount} times";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonusPoints}|{_targetCount}|{_timesCompleted}";
    }
}