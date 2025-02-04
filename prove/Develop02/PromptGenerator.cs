using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Which scripture inspired me today?",
        "Who was the most interesting person I interacted with today?",
        "What was the nest part of my day?",
        "what was the strongest emotion i felt today?",
        "How did I see teh hand of the Lord in my life today?",
        "if I had one thing I could do over today, what would it be?"
    };  // ; after curlybracket represents the body of the data structur/list that is being declared

    //call random generator, returns an empty string. no erro because it was supposed to return something
    Random randomGenerator = new Random();
    public string GetRandomPrompt()
    {
        int i = randomGenerator.Next(_prompts.Count);
        //int i - i is the index number. _prmopt.Count allows the random selection from the available i's, keeping it in the available range of i's. .Count can be applied to lists to count entries
        return _prompts[i]; //prompts[i] is the position in the index
    }
}