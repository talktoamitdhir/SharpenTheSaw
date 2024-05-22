<Query Kind="Program" />

void Main()
{
	int i = 91;
	
	object o = i;
	
	i = 92 ;
	
	int j = (int) o;
	
	Console.WriteLine($"I = {i}, O is {o} and J is {j}");
	
}

// You can define other methods, fields, classes and namespaces here
