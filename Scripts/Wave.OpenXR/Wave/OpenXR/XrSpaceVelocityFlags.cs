using System;

namespace Wave.OpenXR
{
	public struct XrSpaceVelocityFlags : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrSpaceVelocityFlags(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrSpaceVelocityFlags equatable)
		{
			return 0uL;
		}

		public static implicit operator XrSpaceVelocityFlags(ulong u)
		{
			return default(XrSpaceVelocityFlags);
		}

		public bool Equals(XrSpaceVelocityFlags other)
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

		public static bool operator ==(XrSpaceVelocityFlags a, XrSpaceVelocityFlags b)
		{
			return false;
		}

		public static bool operator !=(XrSpaceVelocityFlags a, XrSpaceVelocityFlags b)
		{
			return false;
		}

		public static bool operator >=(XrSpaceVelocityFlags a, XrSpaceVelocityFlags b)
		{
			return false;
		}

		public static bool operator <=(XrSpaceVelocityFlags a, XrSpaceVelocityFlags b)
		{
			return false;
		}

		public static bool operator >(XrSpaceVelocityFlags a, XrSpaceVelocityFlags b)
		{
			return false;
		}

		public static bool operator <(XrSpaceVelocityFlags a, XrSpaceVelocityFlags b)
		{
			return false;
		}

		public static XrSpaceVelocityFlags operator +(XrSpaceVelocityFlags a, XrSpaceVelocityFlags b)
		{
			return default(XrSpaceVelocityFlags);
		}

		public static XrSpaceVelocityFlags operator -(XrSpaceVelocityFlags a, XrSpaceVelocityFlags b)
		{
			return default(XrSpaceVelocityFlags);
		}

		public static XrSpaceVelocityFlags operator *(XrSpaceVelocityFlags a, XrSpaceVelocityFlags b)
		{
			return default(XrSpaceVelocityFlags);
		}

		public static XrSpaceVelocityFlags operator /(XrSpaceVelocityFlags a, XrSpaceVelocityFlags b)
		{
			return default(XrSpaceVelocityFlags);
		}
	}
}
