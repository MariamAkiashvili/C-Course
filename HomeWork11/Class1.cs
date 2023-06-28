using System;
using System.Text.RegularExpressions;

namespace Task11
{
	public class Numerics : IGenericInterface <double>


    {
		public double Add(double a, double b) 
		{
			return a + b;
		}

		public double Subtract(double a, double b) 
		{
			return a - b;
		}
		public double Multiply(double a, double b) 
		{
			return a * b;
		}
	}



	public class Text : IGenericInterface <string>
	{
		public string Add(string a, string b)
		{
			return a + b;
		}
		public string Subtract(string a, string b)
		{
			return Regex.Replace(a, b, "");
        }
		public string Multiply(string a, string b)
		{
			int n;
			string result ="";
			if(int.TryParse(b, out n))
			{
				for(int i = 0; i < n; i++)
				{
					result += (" " + a);
				}
			}else
			{
				//throw new Exception("enter integer");
				Console.WriteLine("Enter integer!");
			}
			return result;
			
		}

	}
}




