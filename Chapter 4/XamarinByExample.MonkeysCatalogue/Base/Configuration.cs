using System;

namespace XamarinByExample.MonkeysCatalogue
{
	public static partial class Configuration
	{
		private static string _databasePath;

		public static string DatabasePath {
			get {
				if (string.IsNullOrEmpty (_databasePath)) {
					_databasePath = "monkey.db";
				}
				return _databasePath;
			}
			set { _databasePath = value; }
		}
	}
}

