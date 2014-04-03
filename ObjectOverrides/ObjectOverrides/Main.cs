using System;

namespace ObjectOverrides
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var person = new Person ();

			Console.WriteLine ("ToString: {0}", person.ToString ());
			Console.WriteLine ("Hash Code: {0}", person.GetHashCode ());
			Console.WriteLine ("Type: {0}", person.GetType ());

			Person person2 = person;
			object obj = person;

			//Are the references pointing to the same object in memory?
			if (obj.Equals (person) && person2.Equals (obj)) {
				Console.WriteLine("Same Instance");
			}
			Console.ReadLine();
		}
	}
}
