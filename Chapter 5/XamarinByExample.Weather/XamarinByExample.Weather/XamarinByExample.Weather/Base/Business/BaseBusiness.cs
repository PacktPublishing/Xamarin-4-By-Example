using System;
using System.Collections.Generic;

namespace XamarinByExample
{
	/// <summary>
	/// Base business.
	/// </summary>
	public class BaseBusiness<TEntity,TKey> where TEntity : BaseEntity<TKey>, new()
	{
		/// <summary>
		/// Gets or sets the data component.
		/// </summary>
		/// <value>The data component.</value>
		public BaseData<TEntity,TKey> DataComponent {
			get;
			set;
		}

		/// <summary>
		/// Initializes a new instance of the BaseBusiness class.
		/// </summary>
		/// <param name="dataComponent">Data component.</param>
		public BaseBusiness (BaseData<TEntity,TKey> dataComponent)
		{
			DataComponent = dataComponent;
		}

		/// <summary>
		/// Create the specified item.
		/// </summary>
		/// <param name="item">Item.</param>
		public virtual void Create (TEntity item)
		{
			DataComponent.Create (item);
		}

		/// <summary>
		/// Read this instance.
		/// </summary>
		public virtual List<TEntity> Read ()
		{
			return DataComponent.Read ();
		}

		/// <summary>
		/// Read the specified key.
		/// </summary>
		/// <param name="key">Key.</param>
		public virtual TEntity Read (TKey key)
		{
			return DataComponent.Read (key);
		}

		/// <summary>
		/// Update the specified item.
		/// </summary>
		/// <param name="item">Item.</param>
		public virtual void Update (TEntity item)
		{
			DataComponent.Update (item);
		}

		/// <summary>
		/// Delete the specified key.
		/// </summary>
		/// <param name="key">Key.</param>
		public virtual void Delete (TKey key)
		{
			DataComponent.Delete (key);
		}
	}
}

