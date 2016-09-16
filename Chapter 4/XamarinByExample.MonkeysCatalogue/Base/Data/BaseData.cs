using System.Collections.Generic;
using SQLite;

namespace XamarinByExample.MonkeysCatalogue
{
	
	public class BaseData<TEntity, TKey> where TEntity : BaseEntity<TKey>, new()
	{
		public SQLiteConnection DatabaseConnection {
			get;
			set;
		}

		public BaseData () : this (new SQLiteConnection (Configuration.DatabasePath))
		{
	
		}

		public BaseData (SQLiteConnection databaseConnection)
		{
			DatabaseConnection = databaseConnection;
			DatabaseConnection.CreateTable<TEntity> (CreateFlags.AllImplicit);
		}

		public void Create (TEntity item)
		{
			DatabaseConnection.Insert (item, typeof(TEntity));
		}

		public List<TEntity> Read ()
		{
			List<TEntity> returnItem = new List<TEntity> ();
			TableQuery<TEntity> itemList = DatabaseConnection.Table<TEntity> ();

			for (int i = 0; i < itemList.Count (); i++) {
				returnItem.Add (itemList.ElementAt (i));
			}
			return returnItem;
		}

		public TEntity Read (TKey key)
		{
			return DatabaseConnection.Get<TEntity> (key);
		}

		public void Update (TEntity item)
		{
			DatabaseConnection.Update (item, typeof(TEntity));
		}

		public void Delete (TKey key)
		{
			DatabaseConnection.Delete (key);
		}
	}
}

