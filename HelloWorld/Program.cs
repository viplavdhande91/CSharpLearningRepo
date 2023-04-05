// C# program to illustrate encapsulation
using System;

public class DemoEncap {

	// private variables declared these can only be accessed by public methods of class
	private String studentName = string.Empty;

	// using accessors to get and set the value of studentName
	public String Name
	{

		get { return studentName; }

		set { studentName = value; }
	}


}

// Driver Class
class GFG {

	// Main Method
	static public void Main()
	{

		// creating object
		DemoEncap obj = new DemoEncap();

		// calls set accessor of the property Name, and pass "Ankita" as value of the standard field 'value'
		obj.Name = "Ankita";

	

		// Displaying values of the variables
		Console.WriteLine(" Name : " + obj.Name);
	}
}
