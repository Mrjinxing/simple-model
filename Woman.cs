using System;

namespace Nvwa
{
	public class Woman : Person
	{
		public Woman()
		{
			Console.WriteLine("创建女人对象");
		}
		public override void Action()
		{
			Console.WriteLine("我们特征不一样，我是女的");
		}
	}
}