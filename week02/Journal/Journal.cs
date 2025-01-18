public class Journal{
   List<Entry> _entries = new List<Entry>();

   public void DisplayAll(){
    foreach (Entry e in _entries){
        e.Display();
    }
   }
   public void AddEntry(){
    Entry _entry=new Entry();
    _entry.FillEntry();
    _entries.Add(_entry);
   }
   public void SaveToFile(){
    Console.Write("what do you want the file name to be? ");
    string _filename=Console.ReadLine();
    using(StreamWriter outputfile=new StreamWriter(_filename)){
        foreach(Entry e in _entries){
            outputfile.WriteLine(e._entryText);
        }
        Console.WriteLine("saving to file... ");
    }
   }
   public void LoadFromFile(){
    Console.Write("which file do you want to load? ");
    string _filename=Console.ReadLine();
    string[] lines=File.ReadAllLines(_filename);
    List<Entry> oldentries=new List<Entry>();
    foreach (string line in lines){
        Entry e=new Entry();
        e._entryText=line;
        oldentries.Add(e);
    }
    _entries=oldentries;
   }
}