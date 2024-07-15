using System;

namespace Wave.OpenXR.FacialTracking
{
	public struct XrFacialTrackerHTC : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrFacialTrackerHTC(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrFacialTrackerHTC equatable)
		{
			return 0uL;
		}

		public static implicit operator XrFacialTrackerHTC(ulong u)
		{
			return default(XrFacialTrackerHTC);
		}

		public bool Equals(XrFacialTrackerHTC other)
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

		public static bool operator ==(XrFacialTrackerHTC a, XrFacialTrackerHTC b)
		{
			return false;
		}

		public static bool operator !=(XrFacialTrackerHTC a, XrFacialTrackerHTC b)
		{
			return false;
		}

		public static bool operator >=(XrFacialTrackerHTC a, XrFacialTrackerHTC b)
		{
			return false;
		}

		public static bool operator <=(XrFacialTrackerHTC a, XrFacialTrackerHTC b)
		{
			return false;
		}

		public static bool operator >(XrFacialTrackerHTC a, XrFacialTrackerHTC b)
		{
			return false;
		}

		public static bool operator <(XrFacialTrackerHTC a, XrFacialTrackerHTC b)
		{
			return false;
		}

		public static XrFacialTrackerHTC operator +(XrFacialTrackerHTC a, XrFacialTrackerHTC b)
		{
			return default(XrFacialTrackerHTC);
		}

		public static XrFacialTrackerHTC operator -(XrFacialTrackerHTC a, XrFacialTrackerHTC b)
		{
			return default(XrFacialTrackerHTC);
		}

		public static XrFacialTrackerHTC operator *(XrFacialTrackerHTC a, XrFacialTrackerHTC b)
		{
			return default(XrFacialTrackerHTC);
		}

		public static XrFacialTrackerHTC operator /(XrFacialTrackerHTC a, XrFacialTrackerHTC b)
		{
			return default(XrFacialTrackerHTC);
		}
	}
}
