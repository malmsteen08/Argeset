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
			
				var pers1 = new Person("Homer", "Simpson", 50);
				var pers2 = new Person("Homer", "Simpson", 50);

				Console.WriteLine("pers1.ToString() = {0}",pers1.ToString());
				Console.WriteLine("pers2.ToString() = {0}",pers2.ToString());
				Console.WriteLine("pers1 = pers2: {0}", pers1.Equals(pers2));
				Console.WriteLine("Same hash codes? : {0}", pers1.GetHashCode() == pers2.GetHashCode());
				Console.ReadLine();
			}
			Console.ReadLine();
		}
	}
}
