
using static System.Console;
using System;
using System.ComponentModel;

namespace GameCsharp
{
    public class Player
    {
        public string Name;
        public int Score;

        public Player(string playerName)
        {
            Name = playerName;
            Score = 0;
        }
    }
}