using System;
using SQLite;

namespace XamarinByExample.MonkeysCatalogue
{
	public class BaseEntity<TKey>
	{
		public BaseEntity ()
		{
			
		}

		[PrimaryKey]
		public TKey Key {
			get;
			set;
		}

		public DateTime LastUpdate {
			get;
			set;
		}

		public string Error {
			get;
			set;
		}
	}
}

