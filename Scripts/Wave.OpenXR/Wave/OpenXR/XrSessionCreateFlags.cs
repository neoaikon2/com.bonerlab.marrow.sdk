using System;

namespace Wave.OpenXR
{
	public struct XrSessionCreateFlags : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrSessionCreateFlags(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrSessionCreateFlags equatable)
		{
			return 0uL;
		}

		public static implicit operator XrSessionCreateFlags(ulong u)
		{
			return default(XrSessionCreateFlags);
		}

		public bool Equals(XrSessionCreateFlags other)
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

		public static bool operator ==(XrSessionCreateFlags a, XrSessionCreateFlags b)
		{
			return false;
		}

		public static bool operator !=(XrSessionCreateFlags a, XrSessionCreateFlags b)
		{
			return false;
		}

		public static bool operator >=(XrSessionCreateFlags a, XrSessionCreateFlags b)
		{
			return false;
		}

		public static bool operator <=(XrSessionCreateFlags a, XrSessionCreateFlags b)
		{
			return false;
		}

		public static bool operator >(XrSessionCreateFlags a, XrSessionCreateFlags b)
		{
			return false;
		}

		public static bool operator <(XrSessionCreateFlags a, XrSessionCreateFlags b)
		{
			return false;
		}

		public static XrSessionCreateFlags operator +(XrSessionCreateFlags a, XrSessionCreateFlags b)
		{
			return default(XrSessionCreateFlags);
		}

		public static XrSessionCreateFlags operator -(XrSessionCreateFlags a, XrSessionCreateFlags b)
		{
			return default(XrSessionCreateFlags);
		}

		public static XrSessionCreateFlags operator *(XrSessionCreateFlags a, XrSessionCreateFlags b)
		{
			return default(XrSessionCreateFlags);
		}

		public static XrSessionCreateFlags operator /(XrSessionCreateFlags a, XrSessionCreateFlags b)
		{
			return default(XrSessionCreateFlags);
		}
	}
}
