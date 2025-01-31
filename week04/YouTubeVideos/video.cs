public class Video {
string _title;
string _author;
int _seconds;
List<Comment> _comments = new List<Comment>();
public Video(string title, string author, int seconds){
_title = title;
_author = author;
_seconds = seconds;
}

/**
*  adds a new comment to the video 
* @param name – the name of the user
* @param comment – the comment of the user
*/
public void AddComment(string name, string comment) {
_comments.Add(new Comment(name, comment));
}

/** displays the video information with all the comments */
public string GetVideoInfo(){
    return $"{_title}, by {_author}, {_seconds} seconds, {_comments.Count} comments";
}
public void DisplayAllComments(){
    foreach(Comment c in _comments){
        c.DisplayComment();
    }
}
}
