<Query Kind="Program" />

/*

Queue is also a Linear data structure that follows First In First Out

// https://www.geeksforgeeks.org/queue-data-structure/
// https://www.geeksforgeeks.org/introduction-to-queue-data-structure-and-algorithm-tutorials/
// Elements of the Queue are operated in First in First out order.
// https://media.geeksforgeeks.org/wp-content/uploads/20240411130637/Types-of-Queue-(1).webp

Basic 				Operations of Queue Data Structure
Enqueue (Insert): 	Adds an element to the rear of the queue.
Dequeue (Delete): 	Removes and returns the element from the front of the queue.
Peek: 				Returns the element at the front of the queue without removing it.
isEmpty: 			Checks if the queue is empty.
isFull: 			Checks if the queue is full.

*/

void Main()
{
	var mQ = new MyQueue(5);
	Console.WriteLine($"The Length of the Queue is here !");
	mQ.Traverse();
	
	mQ.Enqueue(1);
	mQ.Enqueue(2);
	mQ.Enqueue(3);
	mQ.Enqueue(4);
	mQ.Enqueue(5);
	
	Console.WriteLine($"After 1,2,3,4,5 Enqeue !");
	mQ.Traverse();
	
	mQ.DeQueue();
	Console.WriteLine($"After 1 DeQueue!");
	mQ.Traverse();
	
	mQ.DeQueue();
	Console.WriteLine($"After 2 DeQueue !");
	mQ.Traverse();
	
	mQ.DeQueue();
	Console.WriteLine($"After 3 DeQueue !");
	mQ.Traverse();
	
	mQ.DeQueue();
	Console.WriteLine($"After 4 DeQueue !");
	mQ.Traverse();
	
	mQ.Enqueue(1);
	mQ.Enqueue(2);
	Console.WriteLine($"After 1,2 enQueue !");
	mQ.Traverse();
	
	mQ.DeQueue();
	Console.WriteLine($"After 5 DeQueue !");
	mQ.Traverse();
	
	
}

public class MyQueue {
	private readonly int _size;
	private  int _rear; //  Insertion happens here
	private int _front = 0; // Dequeue happens here
	private readonly int[] _myQueue;
	
	public MyQueue(int lengthOfQueue){
		_size = lengthOfQueue;
		_rear = 0;
		_myQueue = new int[lengthOfQueue];
	}
	
	public void Enqueue(int item){
		if(_rear == _size+1){
			Console.WriteLine("Queue is Full");
			return;
		}
		
		_myQueue[_rear] = item;
		_rear++;
	}
	
	public void DeQueue(){
		if(_rear == 0){
			Console.WriteLine("Queue is Empty");
		}
		
		for( int i=0; i<_rear-1; i++){
				_myQueue[i] = _myQueue[i+1];
		}

		_rear--;
	}
	
	public void Traverse(){
		StringBuilder sb = new StringBuilder();
	
		for( int i=0; i<_rear ; i++){
			if(i == 0) sb.Append($"[ ");
			sb.Append($"{_myQueue[i]}, ");
			if(i == (_size-1)) sb.Append($" ]");
		}
		
		Console.WriteLine($"{sb.ToString()} ");
	}
	
	public int Peak(){
		return _myQueue[_front];
	}
	
	public bool IsEmpty(){
		if(_rear == 0 ){
			return true;
		}else{
			return false;
		}
	}
	
	public bool IsFull(){
		if(_rear == _size){
			return true;
		}
		else{
			return false;
		}
	}
}



