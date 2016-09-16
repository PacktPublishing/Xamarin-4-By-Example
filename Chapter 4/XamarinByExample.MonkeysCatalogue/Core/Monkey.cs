using System;

namespace XamarinByExample.MonkeysCatalogue
{
	public class Monkey : BaseEntity<int>
	{
		public Monkey () : base ()
		{
			
		}

		public int ScientificClassificationKey {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}

		public DateTime Birthdate {
			get;
			set;
		}

		public string Gender {
			get;
			set;
		}

		public override string ToString ()
		{
			return string.Format ("[Monkey:\n Key={4},\nScientificClassificationKey={0},\n Name={1},\n Birthdate={2},\n Gender={3}]", ScientificClassificationKey, Name, Birthdate, Gender, Key);
		}

	}
}

