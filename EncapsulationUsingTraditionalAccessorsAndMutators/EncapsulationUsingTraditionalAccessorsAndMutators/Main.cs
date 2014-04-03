using System;

namespace EncapsulationUsingTraditionalAccessorsAndMutators
{
	class Employee
	{
		//Field Data
		private string empName;
		private int empID;
		private float currPay;
		//new fields
		private int empAge;
		private string empSSN;


		//new property
		public int Age {
			get { return empAge; }
			set { empAge = value; }
		}
		public string SocialSecurityNumber {
			get { return empSSN; }
		}

		//properties
		public string Name {

			get { return empName; }
			set {
				if (value.Length > 15) {
					Console.WriteLine ("Error! Name must be less than 16 characters!");
				} else {
					empName = value;
				}
			}
		}

		public int ID {
			get { return empID; }
			set { empID = value; }
		}

		public float Pay {
			get { return currPay; }
			set { currPay = value; }
		}

		//Accessor(with get method)
		public string GetName ()
		{
			return empName;
		}

		//Mutator (with set method)
		public void SetName (string name)
		{
			//Girilen Değeri atamadan önce check ediyoruz.
			if (name.Length > 15) {
				Console.WriteLine ("Error! Name must be less than 16 characters");
			} else {
				empName = name;
			}
		}

		//constructors.
		public Employee ()
		{
		}
		public Employee (string name, int id, float pay)
		:this (name, 0, id, pay){}

		public Employee (string name,int age, int id, float pay)
		{
			empName = name;
			empID = id;
			currPay = pay;
			empAge = age;

		}

		//Methods
		public void GiveBonus (float amount)
		{
			currPay += amount;
		}

		public void DisplayStats ()
		{
			Console.WriteLine ("Name : {0}", empName);
			Console.WriteLine ("ID: {0}", empID);
			Console.WriteLine ("Pay: {0}", currPay);
			Console.WriteLine("Age : {0}", empAge);
			//Console.WriteLine("SSN : {0}", empSSN);
		}

		public static void Main (string[] args)
		{
			var employee = new Employee ("Marvin", 456, 30000);
			employee.GiveBonus (1000);
			employee.DisplayStats ();

			//use get/set methods to interact with object's name.
			employee.SetName ("Marv");
			Console.WriteLine ("employee is named : {0}", employee.GetName ());
			Console.ReadLine ();
		}
	}
}
