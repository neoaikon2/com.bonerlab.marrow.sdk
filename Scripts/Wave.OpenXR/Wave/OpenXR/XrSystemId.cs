using System;

namespace Wave.OpenXR
{
	public struct XrSystemId : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrSystemId(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrSystemId equatable)
		{
			return 0uL;
		}

		public static implicit operator XrSystemId(ulong u)
		{
			return default(XrSystemId);
		}

		public bool Equals(XrSystemId other)
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

		public static bool operator ==(XrSystemId a, XrSystemId b)
		{
			return false;
		}

		public static bool operator !=(XrSystemId a, XrSystemId b)
		{
			return false;
		}

		public static bool operator >=(XrSystemId a, XrSystemId b)
		{
			return false;
		}

		public static bool operator <=(XrSystemId a, XrSystemId b)
		{
			return false;
		}

		public static bool operator >(XrSystemId a, XrSystemId b)
		{
			return false;
		}

		public static bool operator <(XrSystemId a, XrSystemId b)
		{
			return false;
		}

		public static XrSystemId operator +(XrSystemId a, XrSystemId b)
		{
			return default(XrSystemId);
		}

		public static XrSystemId operator -(XrSystemId a, XrSystemId b)
		{
			return default(XrSystemId);
		}

		public static XrSystemId operator *(XrSystemId a, XrSystemId b)
		{
			return default(XrSystemId);
		}

		public static XrSystemId operator /(XrSystemId a, XrSystemId b)
		{
			return default(XrSystemId);
		}
	}
}
