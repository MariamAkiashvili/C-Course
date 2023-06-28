using System;

namespace Task11
{
	public interface IGenericInterface <T> //where T : struct, IComparable<T>, IEquatable<T>
    {
		T Add(T a, T b);
		T Subtract(T a, T b);
		T Multiply(T a, T b);
	}

}
