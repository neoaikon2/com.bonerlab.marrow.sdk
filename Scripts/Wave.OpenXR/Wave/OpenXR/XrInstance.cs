using System;

namespace Wave.OpenXR
{
	public struct XrInstance : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrInstance(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrInstance equatable)
		{
			return 0uL;
		}

		public static implicit operator XrInstance(ulong u)
		{
			return default(XrInstance);
		}

		public bool Equals(XrInstance other)
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

		public static bool operator ==(XrInstance a, XrInstance b)
		{
			return false;
		}

		public static bool operator !=(XrInstance a, XrInstance b)
		{
			return false;
		}

		public static bool operator >=(XrInstance a, XrInstance b)
		{
			return false;
		}

		public static bool operator <=(XrInstance a, XrInstance b)
		{
			return false;
		}

		public static bool operator >(XrInstance a, XrInstance b)
		{
			return false;
		}

		public static bool operator <(XrInstance a, XrInstance b)
		{
			return false;
		}

		public static XrInstance operator +(XrInstance a, XrInstance b)
		{
			return default(XrInstance);
		}

		public static XrInstance operator -(XrInstance a, XrInstance b)
		{
			return default(XrInstance);
		}

		public static XrInstance operator *(XrInstance a, XrInstance b)
		{
			return default(XrInstance);
		}

		public static XrInstance operator /(XrInstance a, XrInstance b)
		{
			return default(XrInstance);
		}
	}
}
