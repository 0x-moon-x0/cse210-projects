public class PromptGenerator
{
    // prompts taken from dayoneapp.com/blog/journal-prompts/
    public List<string> _prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the worst thing that happened today?",
        "What am I grateful for today?",
        "What was the most surprising thing that happened today?",
        "What did I do today that I am proud of?",
        "What am I nervous or anxious about today?",
        "What was a small detail I noticed today?",
        "What was the weather like today?",
        "How can I make tomorrow even better?",
        "If I could have any dream I wanted tonight, what would it be about?",
        "What did I learn today?",
        "What did I do to help others today?",
        "What did I do to take care of myself today?",
        "What are some things I want to remember about today?"
    };

    public string GetRandomPrompt() // method that gets a random prompt from the list of prompts
    {
        // this method was taken from tutorialspoint.com
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
}