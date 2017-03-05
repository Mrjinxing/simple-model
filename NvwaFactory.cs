using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nvwa
{
	public class NvwaFactory
	{
		private static string M;
		private static string W;

		public static Person getPerson(String person)
		{
			if (person == M)
			{
				return new Man();
			}
			else if (person == W)
			{
				return new Woman();
			}
			else
			{
				return null;
			}
		}
	}
}
