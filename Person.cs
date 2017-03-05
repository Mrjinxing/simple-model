using System;

namespace Nvwa
{
	public abstract class Person
	{
		public void SameLook()
		{
			Console.WriteLine("我们外貌一样");
		}

		public abstract void Action();
	}
}