public class PromptGenerator{
    public List<string> _prompts=new List<string>();

    public string GetRandomPrompt(){
        Random random=new Random();
        int PromptNumber = random.Next(0,_prompts.Count-1);
        string prompt =_prompts[PromptNumber];
        return prompt;
    }
}