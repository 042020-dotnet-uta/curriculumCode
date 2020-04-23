using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RPS_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //get users info by calling the static class
            GamePlay.GetPlayersName();
            GamePlay.RunGame();
            GamePlay.PrintResults();
        }
    }
}