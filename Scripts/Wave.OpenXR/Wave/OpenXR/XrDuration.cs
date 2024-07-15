using System;

namespace Wave.OpenXR
{
	public struct XrDuration : IEquatable<long>
	{
		private readonly long value;

		public XrDuration(long u)
		{
			value = 0L;
		}

		public static implicit operator long(XrDuration equatable)
		{
			return 0L;
		}

		public static implicit operator XrDuration(long u)
		{
			return default(XrDuration);
		}

		public bool Equals(XrDuration other)
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

		public static bool operator ==(XrDuration a, XrDuration b)
		{
			return false;
		}

		public static bool operator !=(XrDuration a, XrDuration b)
		{
			return false;
		}

		public static bool operator >=(XrDuration a, XrDuration b)
		{
			return false;
		}

		public static bool operator <=(XrDuration a, XrDuration b)
		{
			return false;
		}

		public static bool operator >(XrDuration a, XrDuration b)
		{
			return false;
		}

		public static bool operator <(XrDuration a, XrDuration b)
		{
			return false;
		}

		public static XrDuration operator +(XrDuration a, XrDuration b)
		{
			return default(XrDuration);
		}

		public static XrDuration operator -(XrDuration a, XrDuration b)
		{
			return default(XrDuration);
		}

		public static XrDuration operator *(XrDuration a, XrDuration b)
		{
			return default(XrDuration);
		}

		public static XrDuration operator /(XrDuration a, XrDuration b)
		{
			return default(XrDuration);
		}
	}
}
