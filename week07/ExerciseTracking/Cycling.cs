public class Cycling : Activity{
    float _speed;
    public Cycling(int minutes, float speed):base(minutes){
        _speed=speed;
        _name="Cycling";
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetDistance()
    {
        return _speed/60*_minutes;
    }
    public override float GetPace()
    {
        return 60/_speed;
    }
}