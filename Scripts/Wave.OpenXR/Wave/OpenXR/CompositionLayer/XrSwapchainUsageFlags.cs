using System;

namespace Wave.OpenXR.CompositionLayer
{
	public struct XrSwapchainUsageFlags : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrSwapchainUsageFlags(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrSwapchainUsageFlags xrBool)
		{
			return 0uL;
		}

		public static implicit operator XrSwapchainUsageFlags(ulong u)
		{
			return default(XrSwapchainUsageFlags);
		}

		public bool Equals(XrSwapchainUsageFlags other)
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

		public static bool operator ==(XrSwapchainUsageFlags a, XrSwapchainUsageFlags b)
		{
			return false;
		}

		public static bool operator !=(XrSwapchainUsageFlags a, XrSwapchainUsageFlags b)
		{
			return false;
		}

		public static bool operator >=(XrSwapchainUsageFlags a, XrSwapchainUsageFlags b)
		{
			return false;
		}

		public static bool operator <=(XrSwapchainUsageFlags a, XrSwapchainUsageFlags b)
		{
			return false;
		}

		public static bool operator >(XrSwapchainUsageFlags a, XrSwapchainUsageFlags b)
		{
			return false;
		}

		public static bool operator <(XrSwapchainUsageFlags a, XrSwapchainUsageFlags b)
		{
			return false;
		}

		public static XrSwapchainUsageFlags operator +(XrSwapchainUsageFlags a, XrSwapchainUsageFlags b)
		{
			return default(XrSwapchainUsageFlags);
		}

		public static XrSwapchainUsageFlags operator -(XrSwapchainUsageFlags a, XrSwapchainUsageFlags b)
		{
			return default(XrSwapchainUsageFlags);
		}

		public static XrSwapchainUsageFlags operator *(XrSwapchainUsageFlags a, XrSwapchainUsageFlags b)
		{
			return default(XrSwapchainUsageFlags);
		}

		public static XrSwapchainUsageFlags operator /(XrSwapchainUsageFlags a, XrSwapchainUsageFlags b)
		{
			return default(XrSwapchainUsageFlags);
		}
	}
}
