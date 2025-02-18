public class Running : Activity{
    float _distance;
    public Running(int minutes, float distance):base(minutes){
        _distance=distance;
        _name="Running";
    }
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetPace()
    {
        return _minutes/_distance;
    }
    public override float GetSpeed()
    {
        return _distance/_minutes*60;
    }
}