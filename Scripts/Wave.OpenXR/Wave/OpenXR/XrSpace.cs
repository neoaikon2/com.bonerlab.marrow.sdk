using System;

namespace Wave.OpenXR
{
	public struct XrSpace : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrSpace(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrSpace equatable)
		{
			return 0uL;
		}

		public static implicit operator XrSpace(ulong u)
		{
			return default(XrSpace);
		}

		public bool Equals(XrSpace other)
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

		public static bool operator ==(XrSpace a, XrSpace b)
		{
			return false;
		}

		public static bool operator !=(XrSpace a, XrSpace b)
		{
			return false;
		}

		public static bool operator >=(XrSpace a, XrSpace b)
		{
			return false;
		}

		public static bool operator <=(XrSpace a, XrSpace b)
		{
			return false;
		}

		public static bool operator >(XrSpace a, XrSpace b)
		{
			return false;
		}

		public static bool operator <(XrSpace a, XrSpace b)
		{
			return false;
		}

		public static XrSpace operator +(XrSpace a, XrSpace b)
		{
			return default(XrSpace);
		}

		public static XrSpace operator -(XrSpace a, XrSpace b)
		{
			return default(XrSpace);
		}

		public static XrSpace operator *(XrSpace a, XrSpace b)
		{
			return default(XrSpace);
		}

		public static XrSpace operator /(XrSpace a, XrSpace b)
		{
			return default(XrSpace);
		}
	}
}
