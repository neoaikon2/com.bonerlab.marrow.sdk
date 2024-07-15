using System;

namespace Wave.OpenXR
{
	public struct XrTime : IEquatable<long>
	{
		private readonly long value;

		public XrTime(long u)
		{
			value = 0L;
		}

		public static implicit operator long(XrTime equatable)
		{
			return 0L;
		}

		public static implicit operator XrTime(long u)
		{
			return default(XrTime);
		}

		public bool Equals(XrTime other)
		{
			return false;
		}

		public bool Equals(long other)
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

		public static bool operator ==(XrTime a, XrTime b)
		{
			return false;
		}

		public static bool operator !=(XrTime a, XrTime b)
		{
			return false;
		}

		public static bool operator >=(XrTime a, XrTime b)
		{
			return false;
		}

		public static bool operator <=(XrTime a, XrTime b)
		{
			return false;
		}

		public static bool operator >(XrTime a, XrTime b)
		{
			return false;
		}

		public static bool operator <(XrTime a, XrTime b)
		{
			return false;
		}

		public static XrTime operator +(XrTime a, XrTime b)
		{
			return default(XrTime);
		}

		public static XrTime operator -(XrTime a, XrTime b)
		{
			return default(XrTime);
		}

		public static XrTime operator *(XrTime a, XrTime b)
		{
			return default(XrTime);
		}

		public static XrTime operator /(XrTime a, XrTime b)
		{
			return default(XrTime);
		}
	}
}
