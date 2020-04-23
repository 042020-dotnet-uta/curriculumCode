using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Game
{
    public class Player
    {
		private string _Name;
		public string Name
		{
			get {return _Name;}
			set { _Name = value; }
		}

		private int wins { get; set; }
		private int losses { get; set; }


		public Player() { }

		public Player(string name)
		{
			_Name = name;
		}




	}
}