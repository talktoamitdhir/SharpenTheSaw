<Query Kind="Program" />

/*

Stack is a Linear Data Structure that Follows Last In First Out

push() 			to insert an element into the stack
pop() 			to remove an element from the stack
top() 			Returns the top element of the stack.
isEmpty() 		returns true if stack is empty else false.
isFull() 		returns true if the stack is full else false.
*/

void Main()
{
	MyCustomStack ins = new MyCustomStack(10);
	ins.Pull();
	ins.Traverse();
	ins.Push(10);
	ins.Push(20);
	ins.Traverse();
	ins.Pull();
	ins.Traverse();
	ins.Push(30);
	ins.Push(40);
	ins.Push(50);
	ins.Push(60);
	ins.Push(70);
	ins.Push(80);
	ins.Push(90);
	ins.Push(100);
	ins.Push(110);
	ins.Push(120);
	ins.Traverse();
}

// You can define other methods, fields, classes and namespaces here
public class MyCustomStack{
	private int?[] _stack;
	private readonly int _stackSize;
	private int _pointer = 0;
	
	public MyCustomStack(int StackSize){
		_stackSize = StackSize;
		_stack = new int?[_stackSize];
	}

	public void Push(int val){
		if(_pointer >= _stackSize){
			Console.WriteLine("Stack Overflow!");
			return;
		}
		
		_stack[_pointer] = val;
		_pointer++ ;
	}
	
	public void Pull(){
		if(_pointer == 0){
			Console.WriteLine("Stack is empty Unable to push");
			return;
		}
		_pointer--;		
		_stack[_pointer] = null;
	}
	
	public void Traverse(){
		for(int i = 0; i< _stackSize ; i++){
			Console.Write($"{_stack[i]} \n");
		}
	}
	
}