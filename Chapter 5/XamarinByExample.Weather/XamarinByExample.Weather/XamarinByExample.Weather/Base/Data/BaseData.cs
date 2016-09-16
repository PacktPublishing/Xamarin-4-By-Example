using System.Collections.Generic;
using SQLite;

namespace XamarinByExample
{
	/// <summary>
	/// Base data.
	/// </summary>
	public class BaseData<TEntity, TKey> where TEntity : BaseEntity<TKey>, new()
	{
		/// <summary>
		/// Gets or sets the database connection.
		/// </summary>
		/// <value>The database connection.</value>
		public SQLiteConnection DatabaseConnection {
			get;
			set;
		}

		/// <summary>
		/// Initializes a new instance of the BaseData class.
		/// </summary>
		public BaseData () : this (new SQLiteConnection (Configuration.DatabasePath))
		{
	
		}

		/// <summary>
		/// Initializes a new instance of the BaseData class.
		/// </summary>
		/// <param name="databaseConnection">Database connection.</param>
		public BaseData (SQLiteConnection databaseConnection)
		{
			DatabaseConnection = databaseConnection;
			DatabaseConnection.CreateTable<TEntity> (CreateFlags.AllImplicit);
		}

		/// <summary>
		/// Create the specified item.
		/// </summary>
		/// <param name="item">Item.</param>
		public void Create (TEntity item)
		{
			DatabaseConnection.Insert (item, typeof(TEntity));
		}

		/// <summary>
		/// Read the list of items.
		/// </summary>
		public List<TEntity> Read ()
		{
			var returnItem = new List<TEntity> ();
			TableQuery<TEntity> itemList = DatabaseConnection.Table<TEntity> ();

			for (int i = 0; i < itemList.Count (); i++) {
				returnItem.Add (itemList.ElementAt (i));
			}
			return returnItem;
		}

		/// <summary>
		/// Read the item with specified key.
		/// </summary>
		/// <param name="key">Key.</param>
		public TEntity Read (TKey key)
		{
			return DatabaseConnection.Get<TEntity> (key);
		}

		/// <summary>
		/// Updates the specified item.
		/// </summary>
		/// <param name="item">Item.</param>
		public void Update (TEntity item)
		{
			DatabaseConnection.Update (item, typeof(TEntity));
		}

		/// <summary>
		/// Delete the item with the specified key.
		/// </summary>
		/// <param name="key">Key.</param>
		public void Delete (TKey key)
		{
			DatabaseConnection.Delete (key);
		}
	}
}

