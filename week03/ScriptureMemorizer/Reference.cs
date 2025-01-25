

public class Reference
{
    string _reference;
    public Reference(string book, int chapter, int verse){
        _reference=$"{book} {chapter}:{verse}";
    }
    public Reference(string book, int chapter, int startverse, int endverse){
        _reference=$"{book} {chapter}:{startverse}-{endverse}";
    }
    public Reference(){}
    public void SetReference(){
        Console.Write("scripture reference input: ");
        _reference=Console.ReadLine();
    }
    public string GetReference(){
        return _reference;
    }
}
