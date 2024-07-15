using System;

namespace Wave.OpenXR
{
	public struct XrBool32 : IEquatable<uint>
	{
		private readonly uint value;

		public XrBool32(uint u)
		{
			value = 0u;
		}

		public static implicit operator uint(XrBool32 equatable)
		{
			return 0u;
		}

		public static implicit operator XrBool32(uint u)
		{
			return default(XrBool32);
		}

		public static implicit operator bool(XrBool32 equatable)
		{
			return false;
		}

		public static implicit operator XrBool32(bool b)
		{
			return default(XrBool32);
		}

		public bool Equals(XrBool32 other)
		{
			return false;
		}

		public bool Equals(uint other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(XrBool32 a, XrBool32 b)
		{
			return false;
		}

		public static bool operator !=(XrBool32 a, XrBool32 b)
		{
			return false;
		}

		public static bool operator >=(XrBool32 a, XrBool32 b)
		{
			return false;
		}

		public static bool operator <=(XrBool32 a, XrBool32 b)
		{
			return false;
		}

		public static bool operator >(XrBool32 a, XrBool32 b)
		{
			return false;
		}

		public static bool operator <(XrBool32 a, XrBool32 b)
		{
			return false;
		}

		public static XrBool32 operator +(XrBool32 a, XrBool32 b)
		{
			return default(XrBool32);
		}

		public static XrBool32 operator -(XrBool32 a, XrBool32 b)
		{
			return default(XrBool32);
		}

		public static XrBool32 operator *(XrBool32 a, XrBool32 b)
		{
			return default(XrBool32);
		}

		public static XrBool32 operator /(XrBool32 a, XrBool32 b)
		{
			return default(XrBool32);
		}
	}
}
