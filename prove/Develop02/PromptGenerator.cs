public class PromptGenerator
{
    public List<string> _prompt = new List<string>
    {
        "Who did you talk to today?",
        "What was the bast part of your day?",
        "What is one thing that you wish you could change from today?",
        "What is something new you learned today?",
        "How did you feel today?",
        "What did you eat today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);

        return _prompt[index];
    }
}