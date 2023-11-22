using System.Collections;

namespace AssociationBetweenClasses
{
	// FIFO EXAMPLE
	public class Stack
	{
		private readonly ArrayList _stack = new();
		public void Push(object obj)
		{
			if (obj == null)
			{
				throw new InvalidOperationException("Null is not a valid value");
			}
			_stack.Add(obj);

		}
		public object Pop()
		{
			if (_stack.Count <= 0)
			{
				throw new InvalidOperationException("Can't pop value from an empty stack");
			}
            var temp = (int)_stack[_stack.Count - 1]!;
			_stack.RemoveAt(_stack.Count - 1);

			object obj = temp;
            return obj;
		}
		public void Clear()
		{
			_stack.Clear();
		}
	}
}