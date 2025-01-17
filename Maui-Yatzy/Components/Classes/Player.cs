using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_Yatzy.Components.Classes
{
	internal class Player
	{
		public string Name { get; private set; }
		public Dictionary<ScoreCategory, int> ScoreList { get; private set; }

		public Player(string name)
		{
			Name = name;
			ScoreList = InitializeScoreList();
		}

		private Dictionary<ScoreCategory, int> InitializeScoreList()
		{
			var scores = new Dictionary<ScoreCategory, int>();
			foreach (ScoreCategory category in Enum.GetValues(typeof(ScoreCategory)))
			{
				scores[category] = 0;
			}
			return scores;
		}

		public void UpdateScore(ScoreCategory category, int score)
		{
			if (ScoreList.ContainsKey(category))
			{
				ScoreList[category] = score;
			}
		}
		public int TotalScore => CalculateTotalScore();

		private int CalculateTotalScore()
		{
			int total = 0;
			foreach (var score in ScoreList.Values)
			{
				total += score;
			}
			return total;
		}
		public static List<Player> PlayerList { get; private set; } = new List<Player>();
		public override string ToString() => $"{Name}";
	}
	public enum ScoreCategory
	{
		Ones,
		Twos,
		Threes,
		Fours,
		Fives,
		Sixes,
		ThreeOfAKind,
		FourOfAKind,
		FullHouse,
		SmallStraight,
		LargeStraight,
		Yatzy,
		Chance
	}
}
