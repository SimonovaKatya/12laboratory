using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12laboratory
{
	public partial class Form1 : Form
	{
		private GamesInformation game;
		public Form1()
		{
			InitializeComponent();
		}

		

        private void PlayButton_Click_1(object sender, EventArgs e)
		{
			game = new GamesInformation();
			game.GoChampionship();

			foreach (var c in Controls)
			{
				if (c.GetType() == typeof(Label))
				{
					Label label = (Label)c;
					if (label.Name.Contains("team"))
					{
						var l = label.Name.Remove(0, 4);
						var inx = int.Parse(l);
						var match = game.Matches[inx / 2];
						int t = inx % 2;

						var penalty = (match.Penalty[0] != 0 && match.Penalty[1] != 0) ? " p" + match.Penalty[t].ToString() : "";

						label.Text = match.Teams[t] + "   " + match.Score[t] + penalty;
					}
					else if (label.Name.Contains("result"))
					{
						label.Text = "Победитель: " + game.Matches.Last().Winner;
					}
				}
			}
		}

        private void team28_Click(object sender, EventArgs e)
        {

        }
    }
}
