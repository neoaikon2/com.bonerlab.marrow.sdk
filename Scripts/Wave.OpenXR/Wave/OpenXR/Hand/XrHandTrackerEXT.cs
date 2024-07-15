using System;

namespace Wave.OpenXR.Hand
{
	public struct XrHandTrackerEXT : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrHandTrackerEXT(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrHandTrackerEXT xrInst)
		{
			return 0uL;
		}

		public static implicit operator XrHandTrackerEXT(ulong u)
		{
			return default(XrHandTrackerEXT);
		}

		public bool Equals(XrHandTrackerEXT other)
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

		public static bool operator ==(XrHandTrackerEXT a, XrHandTrackerEXT b)
		{
			return false;
		}

		public static bool operator !=(XrHandTrackerEXT a, XrHandTrackerEXT b)
		{
			return false;
		}

		public static bool operator >=(XrHandTrackerEXT a, XrHandTrackerEXT b)
		{
			return false;
		}

		public static bool operator <=(XrHandTrackerEXT a, XrHandTrackerEXT b)
		{
			return false;
		}

		public static bool operator >(XrHandTrackerEXT a, XrHandTrackerEXT b)
		{
			return false;
		}

		public static bool operator <(XrHandTrackerEXT a, XrHandTrackerEXT b)
		{
			return false;
		}

		public static XrHandTrackerEXT operator +(XrHandTrackerEXT a, XrHandTrackerEXT b)
		{
			return default(XrHandTrackerEXT);
		}

		public static XrHandTrackerEXT operator -(XrHandTrackerEXT a, XrHandTrackerEXT b)
		{
			return default(XrHandTrackerEXT);
		}

		public static XrHandTrackerEXT operator *(XrHandTrackerEXT a, XrHandTrackerEXT b)
		{
			return default(XrHandTrackerEXT);
		}

		public static XrHandTrackerEXT operator /(XrHandTrackerEXT a, XrHandTrackerEXT b)
		{
			return default(XrHandTrackerEXT);
		}
	}
}
