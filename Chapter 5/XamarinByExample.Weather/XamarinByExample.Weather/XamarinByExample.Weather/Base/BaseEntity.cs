using System;
using SQLite;

namespace XamarinByExample
{
	/// <summary>
	/// Base entity.
	/// </summary>
	public class BaseEntity<TKey>
	{
		/// <summary>
		/// Initializes a new instance of the BaseEntity class.
		/// </summary>
		public BaseEntity ()
		{
			
		}

		/// <summary>
		/// Gets or sets the key.
		/// </summary>
		/// <value>The key.</value>
		[PrimaryKey]
		public TKey Key {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the last update.
		/// </summary>
		/// <value>The last update.</value>
		public DateTime LastUpdate {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the error.
		/// </summary>
		/// <value>The error.</value>
		public string Error {
			get;
			set;
		}
	}
}

