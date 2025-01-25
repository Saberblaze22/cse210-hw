

public class Scripture
{
    List<Word> _words =new List<Word>();
    Reference _reference=new Reference();
    public Scripture(string scripture, Reference reference){
        _reference=reference;
        string[] words=scripture.Split(" ");
        foreach (string word in words){
            Word _word=new Word(word);
            _words.Add(_word);
        }
    }
    public Scripture(){}
    public bool IsAllHidden(){
        bool isAllHidden=true;
        foreach (Word word in _words){
            if (!word.IsHidden()){
                isAllHidden=false;
            }
        }
        return isAllHidden;
    }
    public void HideRandom(int numberToHide){
        int count=0;
        foreach (Word word in _words){
            if (!word.IsHidden()){
                count++;
            }
        }
        if (count<numberToHide){
            numberToHide=count;
        }
        for(int i=0;i<numberToHide;i++){
            Random random=new Random();
            int randNum=random.Next(0,_words.Count());
            if (_words[randNum].IsHidden()){
                i=i-1;
            }
            else{
                _words[randNum].Hide();
            }
        }
    }
    public string GetPublicDisplay(){
        string scripture=_reference.GetReference();
        foreach (Word word in _words){
            scripture=$"{scripture} {word.GetPublicDisplay()}";
        }
        return scripture;
    }
}
