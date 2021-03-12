using static System.Console;
using System;
using System.ComponentModel;
using System.Security.Policy;


namespace GameCsharp
{
    public class Item
    {
        private string Question;
        private string Answer;

        public Item( string itemQuestion,string itemAnswer)
        {
            Question = itemQuestion;
            Answer = itemAnswer;
        }

        public void AskQuestion()
        {
            
                WriteLine(Question);
                Write("What is your answer? ");
                string playerAnswer = ReadLine();
                WriteLine($"You answered  '{playerAnswer}'.");
                WriteLine($"The correct answer was: {Answer}.");
        }
        
    }
}