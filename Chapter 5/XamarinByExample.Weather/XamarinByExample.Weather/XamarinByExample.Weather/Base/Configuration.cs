using System;

namespace XamarinByExample
{
	/// <summary>
	/// Configuration.
	/// </summary>
	public static partial class Configuration
	{
		/// <summary>
		/// The database path.
		/// </summary>
		private static string _databasePath;

		/// <summary>
		/// Gets or sets the database path.
		/// </summary>
		/// <value>The database path.</value>
		public static string DatabasePath {
			get {
				if (string.IsNullOrEmpty (_databasePath)) {
					_databasePath = "weather.db";
				}
				return _databasePath;
			}
			set { _databasePath = value; }
		}
	}
}

