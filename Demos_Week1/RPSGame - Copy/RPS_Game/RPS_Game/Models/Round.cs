using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace RPS_Game.Models
{
    public class Round
    {
        private Player _winner;//store who won this round
        public int RoundId { get; set; }
        public string p1Choice { get; set; }
        public string p2Choice { get; set; }
        public Boolean pWinner = false;//false means player 1 won the round. True means player 2 won the round.
        public Player Winner { get => _winner; set => _winner = value; }
    }
}
