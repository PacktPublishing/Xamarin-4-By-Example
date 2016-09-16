using System;
using System.Collections.Generic;

namespace XamarinByExample.MonkeysCatalogue
{
	public class BaseBusiness<TEntity,TKey> where TEntity : BaseEntity<TKey>, new()
	{
		public BaseData<TEntity,TKey> DataComponent {
			get;
			set;
		}

		public BaseBusiness (BaseData<TEntity,TKey> dataComponent)
		{
			DataComponent = dataComponent;
		}

		public virtual void Create (TEntity item)
		{
			DataComponent.Create (item);
		}

		public virtual List<TEntity> Read ()
		{
			return DataComponent.Read ();
		}

		public virtual TEntity Read (TKey key)
		{
			return DataComponent.Read (key);
		}

		public virtual void Update (TEntity item)
		{
			DataComponent.Update (item);
		}

		public virtual void Delete (TKey key)
		{
			DataComponent.Delete (key);
		}
	}
}

