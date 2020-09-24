using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12laboratory
{
	class GamesInformation
	{
		public GamesInformation()
		{
			Teams = new string[16]
			{
				"Манчестер Юнтайдед",
				"Эспаньол",
				"Локомотив",
				"Спартак",
				"Зенит",
				"Динамо",
				"Интер Милан",
				"Бавария Мюнхен",
				"Монтеррей",
				"Челси",
				"Пайлмейрас",
				"Манчестер",
				"Барселона",
				"Ливерпуль",
				"Ювентус",
				"ЦСКА",
				
			};

			Matches = new List<MatchesProcess>();
		}

		public IList<MatchesProcess> Matches { get; private set; }
		public string[] Teams { get; private set; }

		public void GoChampionship()
		{
			for (int i = 0; i < 16; i += 2)
			{
				Matches.Add(new MatchesProcess(Teams[i], Teams[i + 1]));
			}

			for (int i = 0; i < 8; i += 2)
			{
				Matches.Add(new MatchesProcess(Matches[i].Winner, Matches[i + 1].Winner));
			}

			for (int i = 8; i < 12; i += 2)
			{
				Matches.Add(new MatchesProcess(Matches[i].Winner, Matches[i + 1].Winner));
			}

			for (int i = 12; i < 14; i += 2)
			{
				Matches.Add(new MatchesProcess(Matches[i].Winner, Matches[i + 1].Winner));
			}
		}


	}
}
