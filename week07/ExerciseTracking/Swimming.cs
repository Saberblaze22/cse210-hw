public class Swimming : Activity{
    int _laps;
    public Swimming(int minutes, int laps):base(minutes){
        _laps=laps;
        _name="Swimming";
    }
    public override float GetDistance()
    {
        float lapDistance=_laps*50;
        return lapDistance/1000;
    }
    public override float GetPace()
    {
        return _minutes/GetDistance();
    }
    public override float GetSpeed()
    {
        return GetDistance()/_minutes*60;
    }
    public override string GetSummary()
    {
        return $"{_dateTime} {_name} ({_minutes}), laps {_laps}, distance {GetDistance()} km, speed {GetSpeed()} kph, pace {GetPace()} km per min";
    }
}