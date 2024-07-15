using System;

namespace Wave.OpenXR
{
	public struct XrSpaceLocationFlags : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrSpaceLocationFlags(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrSpaceLocationFlags equatable)
		{
			return 0uL;
		}

		public static implicit operator XrSpaceLocationFlags(ulong u)
		{
			return default(XrSpaceLocationFlags);
		}

		public bool Equals(XrSpaceLocationFlags other)
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

		public static bool operator ==(XrSpaceLocationFlags a, XrSpaceLocationFlags b)
		{
			return false;
		}

		public static bool operator !=(XrSpaceLocationFlags a, XrSpaceLocationFlags b)
		{
			return false;
		}

		public static bool operator >=(XrSpaceLocationFlags a, XrSpaceLocationFlags b)
		{
			return false;
		}

		public static bool operator <=(XrSpaceLocationFlags a, XrSpaceLocationFlags b)
		{
			return false;
		}

		public static bool operator >(XrSpaceLocationFlags a, XrSpaceLocationFlags b)
		{
			return false;
		}

		public static bool operator <(XrSpaceLocationFlags a, XrSpaceLocationFlags b)
		{
			return false;
		}

		public static XrSpaceLocationFlags operator +(XrSpaceLocationFlags a, XrSpaceLocationFlags b)
		{
			return default(XrSpaceLocationFlags);
		}

		public static XrSpaceLocationFlags operator -(XrSpaceLocationFlags a, XrSpaceLocationFlags b)
		{
			return default(XrSpaceLocationFlags);
		}

		public static XrSpaceLocationFlags operator *(XrSpaceLocationFlags a, XrSpaceLocationFlags b)
		{
			return default(XrSpaceLocationFlags);
		}

		public static XrSpaceLocationFlags operator /(XrSpaceLocationFlags a, XrSpaceLocationFlags b)
		{
			return default(XrSpaceLocationFlags);
		}
	}
}
