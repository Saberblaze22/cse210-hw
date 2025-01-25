
public class Word
{
    string _word;
    bool _isHidden;
    public Word(string word){
        _word=word;
    }
    public void Hide(){
        _isHidden=true;
    }
    public void Show(){
        _isHidden=false;
    }
    public string GetPublicDisplay(){
        if(_isHidden){
            int len=_word.Length;
            string blank="";
            for(int i=0;i<len;i++){
                blank=blank+"_";
            }
            return blank;
        }
        else{
            return _word;
        }
    }
    public bool IsHidden(){
        return _isHidden;
    }
}