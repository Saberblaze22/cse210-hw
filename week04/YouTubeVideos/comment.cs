public class Comment {
string _comment;
string _author;
public Comment(string author, string comment){
_comment = comment;
_author = author;
}

/** displays the comment to the user */
public void DisplayComment(){
    Console.WriteLine($"{_author}: {_comment}");
}
}
