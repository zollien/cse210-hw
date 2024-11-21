//PromptGenerator - complete
public class PromptGenerator
{
    //class 1 to write
    public List<string> _prompts = new List<string>()
    {
        "Which scripture inspired you today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };   //;after the bracket because it represents the body of a data structure/list that we are declaring

    // call random number generator
    Random randomGenerator = new Random();
    public string GetRandomPrompt()
    {
        int i = randomGenerator.Next(_prompts.Count);
        // int i - i is the index number   - _prompt.Count allows the random selections from with the available i's - .Count can be applied to lists to count the entries and keeps the random index with the range of i available.
        return _prompts[i]; //_prompts[i] means at position i in the index

        /* this returns an empty string and builds without error because we asked it to return something, even though it was an empty string. */
    }
}