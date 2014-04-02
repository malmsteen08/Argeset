using System;

namespace DeclaringEnumVariables
{

	class MainClass
	{

		enum EmpType
		{
			Manager,
			Grunt,
			Contractor,
			VicePresident,
		}

		public static void Main (string[] args)
		{
			Console.WriteLine("Enums...");
			//contractor type

			EmpType emp = EmpType.Contractor;//emp --> Contractor
			AskForBonus(emp);

			Console.WriteLine("EmpType uses a {0} for storage\n", Enum.GetUnderlyingType(emp.GetType()));

			Console.WriteLine("emp is AccessViolationException {0} for storage\n", Enum.GetUnderlyingType(typeof(EmpType)));

			Console.WriteLine("emp is a {0}\n", emp.ToString());

			Console.WriteLine("{0} = {1}\n", emp.ToString(), (byte)emp);

			EmpType e2 = EmpType.Contractor;

			DayOfWeek day = DayOfWeek.Monday;
			ConsoleColor color = ConsoleColor.DarkGray;

			EvaluateEnum(e2);
			EvaluateEnum(day);
			EvaluateEnum(color);
			Console.ReadLine();

		}

		static void AskForBonus (EmpType e)
		{
			switch (e) {
			case EmpType.Manager:
				Console.WriteLine ("How about stock option instead?");
				break;
			case EmpType.Grunt:
				Console.WriteLine ("You've got to be kidding..");
				break;
			case EmpType.Contractor:
				Console.WriteLine ("You already get enough cash..");
				break;
			case EmpType.VicePresident:
				Console.WriteLine ("Sir");
				break;
			}
		}

		static void EvaluateEnum (System.Enum e)
		{
			Console.WriteLine ("Information about {0}", e.GetType ().Name);
			Console.WriteLine ("Underlying storage type: {0}", Enum.GetUnderlyingType (e.GetType ()));

			Array enumData = Enum.GetValues (e.GetType ());
			Console.WriteLine ("This enum has {0} members", enumData.Length);

			for (int i = 0; i < enumData.Length; i++) {
				Console.WriteLine ("Name : {0}, Value : {0:D}", enumData.GetValue (i));
			}

			Console.WriteLine();

		}

}
}