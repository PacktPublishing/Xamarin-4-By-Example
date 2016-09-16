using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XamarinByExample
{
	public class BaseService<TEntity, TKey> where TEntity : BaseEntity<TKey>
	{
		readonly HttpHelper httpHelper;

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
			httpHelper = new HttpHelper ();
		}

public async Task<TEntity> GET (string url)
{
	string response = await httpHelper.GET (url);
	TEntity item = JsonConvert.DeserializeObject<TEntity> (response);
	OnResponseReceived (item);
	return item;
}

		public async Task<TEntity> POST (string url, string data)
		{
			string response = await httpHelper.POST (url, data);
			TEntity item = JsonConvert.DeserializeObject<TEntity> (response);
			OnResponseReceived (item);
			return item;
		}

		public async Task<TEntity> PUT (string url, string data)
		{
			string response = await httpHelper.PUT (url, data);
			TEntity item = JsonConvert.DeserializeObject<TEntity> (response);
			OnResponseReceived (item);
			return item;
		}

		public async Task<TEntity> DELETE (string url)
		{
			string response = await httpHelper.DELETE (url);
			TEntity item = JsonConvert.DeserializeObject<TEntity> (response);
			OnResponseReceived (item);
			return item;
		}
	}
}

