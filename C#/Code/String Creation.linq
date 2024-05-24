<Query Kind="Program" />

void Main()
{
	string password = "Am1t$";
	PasswordSafety obj = new PasswordSafety();	
	Console.WriteLine($"Here is my passport details { obj.isPasswordComplex(password).ToString() }");		
}

public class PasswordSafety{
	public bool isPasswordComplex(string pass){
		return pass.Any(char.IsUpper) && pass.Any(char.IsLower) && pass.Any(char.IsDigit) && pass.Any(char.IsSymbol);
	}
}

// You can define other methods, fields, classes and namespaces here
