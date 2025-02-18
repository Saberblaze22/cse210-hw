public abstract class Activity{
    protected int _minutes;
    protected DateTime _dateTime=DateTime.Now;
    protected string _name;

    public Activity(int minutes){
        _minutes=minutes;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public virtual string GetSummary(){
        return $"{_dateTime} {_name} ({_minutes}), distance {GetDistance()} km, speed {GetSpeed()} kph, pace {GetPace()} km per min";
    }
}