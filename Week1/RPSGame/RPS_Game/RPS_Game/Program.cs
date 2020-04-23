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


            //List<string> resultsList = new List<string>(); // results stored in a list
            //string[] rps = { "Rock", "Paper", "Scissor" }; // Declare an string array to store Rock, Paper,and Scissors strings
            //Random rand = new Random(); // instansiates the Random Class

            //while (true)
            //{
            //    round++; //increase the round by 1

            //    //randomly chooses rock paper or scissors for each player
            //    int p1rand = rand.Next(3);
            //    int p2rand = rand.Next(3);


            //    int win = p1rand - p2rand + 2;
            //    // string of current round result to be stored in list
            //    string results = "Round " + round + " - " + player1 + " chose " + rps[p1rand];
            //    results += ", " + player2 + " chose " + rps[p2rand] + ". - ";

            //    switch (win)
            //    { //win is mostly unique varying with what each player picks
            //        case 0: //p1 rock p2 scissor p1 wins
            //            p1++;
            //            break;
            //        case 1: // p1 lost since result is negative rock(0) - paper(1) or 1 - 2
            //            p2++;
            //            break;
            //        case 2: // tie
            //            ties++;
            //            break;
            //        case 3:// p1 wins as 1 - 0 or 2 - 1;
            //            p1++;
            //            break;
            //        case 4://p1 scissor p2 rock p2 wins
            //            p2++;
            //            break;
            //        default:
            //            break;
            //    }

            //    //adds the rest of the results to string stored in list
            //    if (win == 2) // tie
            //    {
            //        results += player1 + " and " + player2 + " ties.";
            //    }
            //    else if (win == 0 || win == 3) // player1 wins
            //    {
            //        results += player1 + " wins.";
            //    }
            //    else
            //    { //player2 wins
            //        results += player2 + " wins.";
            //    }

            //    resultsList.Add(results); // store results in a list

            //    // conditions check to see if a player has won,checks if p1 or p2 has more than 2 wins.
            //    if (p1 > 1 || p2 > 1)
            //    {
            //        // if either player has more than 2 wins print each result saved in the list
            //        foreach (string element in resultsList)
            //        { // prints all rounds played
            //            Console.WriteLine(element);
            //        }

            //        if (p1 > 1)
            //        {    // print results and message stating player 1 wins
            //            Console.WriteLine($"{player1} Wins {p1} - {p2} with {ties} ties.");
            //        }
            //        else
            //        { // print results and message staring player 2 wins
            //            Console.WriteLine($"{player2} Wins {p2} - {p1} with {ties} ties.");
            //        }

            //        return; //ends program
            //    }
            //}
        }
    }
}