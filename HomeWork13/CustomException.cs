using System;

namespace HomeWork13
{
	public class BookNotFoundException : ApplicationException
	{
		string _message;
		public BookNotFoundException(string message)
		{
			_message = message;
		}

		public string GetMessage()
		{
			return _message;
		}
	}
}
