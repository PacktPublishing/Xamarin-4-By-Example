using System;
using XamarinByExample;

namespace XamarinByExample.FastFood
{
	public class MenuItem : BaseEntity<int>
	{
		public string Name {
			get;
			set;
		}

		public int RequiredSeconds {
			get;
			set;
		}

		public float Price {
			get;
			set;
		}
	}
}

