using System;
using System.Threading.Tasks;

namespace XamarinByExample.FastFood
{
	public class BaseService<TEntity, TKey> where TEntity : BaseEntity<TKey>
	{
		public event ResponseReceivedHandler ResponseReceived;

		public delegate void ResponseReceivedHandler (TEntity item);

		protected void OnResponseReceived (TEntity item)
		{
			if (ResponseReceived != null) {
				ResponseReceived (item);
			}
		}

		public BaseService ()
		{
		}

		public virtual async Task<TEntity> GetDelayedResponse (TEntity item, int seconds)
		{
			await Task.Delay (seconds * 1000);
			OnResponseReceived (item);
			return item;
		}


	}
}

