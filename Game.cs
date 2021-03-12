using static System.Console;
using System;
using System.ComponentModel;

namespace GameCsharp
{
    public class Game
    {
        private string GameTitleArt = @"
 ██████╗  █████╗ ███╗   ███╗███████╗
██╔════╝ ██╔══██╗████╗ ████║██╔════╝
██║  ███╗███████║██╔████╔██║█████╗  
██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  
╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗
 ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝
                                    
";
        private string GameTitle = "My First Game";
        private string Description = "Chalange yourself";
        private Player CurrentPlayer;
        private Item UnicornQuestion;
        private Item OctoQuestion;
        private Item BleachQuestion;
        public Game()
        {
            string unicornQuestion = "The national animal of Scotland is Unicorn -true or false?";
            UnicornQuestion = new Item(unicornQuestion, "true");

            string octoQ = " An octopus can fit through any hole larger than its beak -true or false?";
            OctoQuestion = new Item(octoQ, "true");

            string bleachQ = "Bleach never expires -true or false?";
            BleachQuestion = new Item(bleachQ, "false");
        }

        public void Play()
        {
          
            Title = GameTitle;
            WriteLine(GameTitleArt);
            WriteLine($"Welcome to {GameTitle}");
            WriteLine($"{Description}");
            
            Write(" \n What is yor name?");
            string playerName = ReadLine();
            CurrentPlayer = new Player(playerName);
            WriteLine($"Welcome to {GameTitle}, {CurrentPlayer.Name}");
            WriteLine($"Your starting score is {CurrentPlayer.Score} ");
            
            WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            UnicornQuestion.AskQuestion();
            WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            
            WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            OctoQuestion.AskQuestion();
            WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            
            WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            BleachQuestion.AskQuestion();
            WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            
            ;
            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }


}