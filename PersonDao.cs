using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nvwa
{
	 public class PersonDao
	{
		private String M;
		private string W;

		public String FindPerson(String Type)
		{
			if ("M" == Type)
			{
				return M;
			}
			else if ("W" == Type)
			{
				return W;
			}
			else
			{
				return null;
			}
		}
	}
}
