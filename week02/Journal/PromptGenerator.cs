public class PromptGenerator
{
    public List<string> _prompt = new List<string>();
    public Random _random;
    public List<string> _prompts;

    public PromptGenerator()
    {
    _prompt = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"

    };
    _random = new Random();

}
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompt.Count); 
        return _prompt[index];
    }
}
