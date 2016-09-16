using System;

namespace XamarinByExample.MonkeysCatalogue
{
	public class MonkeyBusiness : BaseBusiness<Monkey,int>
	{
		public MonkeyBusiness () : base (new MonkeyData ())
		{
		}

public override void Create (Monkey item)
{
	base.Create (item);
}
	}
}

