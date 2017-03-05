using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nvwa
{
	class Program
	{
		static void Main(string[] args)
		{
			Person _person;
			PersonDao persongDao = new PersonDao();
			String person = persongDao.FindPerson("M");
			_person = NvwaFactory.getPerson(person);
			_person.SameLook();
			_person.Action();
		}
	}
}
