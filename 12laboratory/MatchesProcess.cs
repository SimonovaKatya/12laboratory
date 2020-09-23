using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12laboratory
{
	class MatchesProcess
	{
		private static CounterGeneration generator = new CounterGeneration();
		public MatchesProcess(string name1, string name2)
		{
			Teams = new string[2];
			Score = new int[2];
			Penalty = new int[2];

			Teams[0] = name1;
			Teams[1] = name2;

			Result();
		}
		public string[] Teams { get; private set; }

		public string Winner { get; private set; }

		public int[] Score { get; private set; }
		public int[] Penalty { get; private set; }

		private void Result()
		{
			Score[0] = generator.GetResult(2);
			Score[1] = generator.GetResult(2);

			if (Score[0] == Score[1])
			{
				while (Penalty[0] == Penalty[1])
				{
					Penalty[0] = generator.GetResult(4);
					Penalty[1] = generator.GetResult(4);
				}

				Winner = Penalty[0] > Penalty[1] ? Teams[0] : Teams[1];
			}
			else
			{
				Winner = Score[0] > Score[1] ? Teams[0] : Teams[1];
			}
		}
	}
}
