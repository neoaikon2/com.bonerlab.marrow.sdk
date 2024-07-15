using System;

namespace Wave.OpenXR
{
	public struct XrFlags64 : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrFlags64(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrFlags64 equatable)
		{
			return 0uL;
		}

		public static implicit operator XrFlags64(ulong u)
		{
			return default(XrFlags64);
		}

		public bool Equals(XrFlags64 other)
		{
			return false;
		}

		public bool Equals(ulong other)
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

		public static bool operator ==(XrFlags64 a, XrFlags64 b)
		{
			return false;
		}

		public static bool operator !=(XrFlags64 a, XrFlags64 b)
		{
			return false;
		}

		public static bool operator >=(XrFlags64 a, XrFlags64 b)
		{
			return false;
		}

		public static bool operator <=(XrFlags64 a, XrFlags64 b)
		{
			return false;
		}

		public static bool operator >(XrFlags64 a, XrFlags64 b)
		{
			return false;
		}

		public static bool operator <(XrFlags64 a, XrFlags64 b)
		{
			return false;
		}

		public static XrFlags64 operator +(XrFlags64 a, XrFlags64 b)
		{
			return default(XrFlags64);
		}

		public static XrFlags64 operator -(XrFlags64 a, XrFlags64 b)
		{
			return default(XrFlags64);
		}

		public static XrFlags64 operator *(XrFlags64 a, XrFlags64 b)
		{
			return default(XrFlags64);
		}

		public static XrFlags64 operator /(XrFlags64 a, XrFlags64 b)
		{
			return default(XrFlags64);
		}
	}
}
