using System;

namespace Nvwa
{
	public class Man : Person
	{
		public Man()
		{
			Console.WriteLine("创建男人对象");
		}
		public override void Action()
		{
			Console.WriteLine("我们特征不一样，我是男的");
		}
	}
}