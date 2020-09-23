using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12laboratory
{
	public class CounterGeneration
	{
		readonly Random random = new Random();

		public int GetResult(int lambda)
		{
			int m = 0;
			double S = 0;
			while (true)
			{
				var alpha = random.NextDouble();
				S += Math.Log(alpha);

				if (S < -lambda) break;
				else m += 1;
			}

			return m;
		}
	}
}
