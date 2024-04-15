void Main()
{
	// All these keywords are used to pass the value to function by ref only. 

	int i = 1; // for IN keyword, no need  
	int o; // For OUT Keyword, no need of any variable assignment.
	int r = 1; // For 

	Console.WriteLine($"I is {i.ToString()} , R is {r} \n");

	PassTheParameters(in i, out o , ref r);
	
	Console.WriteLine($"I is {i.ToString()} , O is {o.ToString()} and R is {r} \n");
}

public static void PassTheParameters(in int i, out int o, ref int r){
	
	//i = 2; Value can not be updated as this only for IN only.
	
	o = 2; 
	
	r = 2;
}

// You can define other methods, fields, classes and namespaces here
