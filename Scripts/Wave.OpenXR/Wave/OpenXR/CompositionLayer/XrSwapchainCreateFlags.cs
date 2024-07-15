using System;

namespace Wave.OpenXR.CompositionLayer
{
	public struct XrSwapchainCreateFlags : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrSwapchainCreateFlags(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrSwapchainCreateFlags xrBool)
		{
			return 0uL;
		}

		public static implicit operator XrSwapchainCreateFlags(ulong u)
		{
			return default(XrSwapchainCreateFlags);
		}

		public bool Equals(XrSwapchainCreateFlags other)
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

		public static bool operator ==(XrSwapchainCreateFlags a, XrSwapchainCreateFlags b)
		{
			return false;
		}

		public static bool operator !=(XrSwapchainCreateFlags a, XrSwapchainCreateFlags b)
		{
			return false;
		}

		public static bool operator >=(XrSwapchainCreateFlags a, XrSwapchainCreateFlags b)
		{
			return false;
		}

		public static bool operator <=(XrSwapchainCreateFlags a, XrSwapchainCreateFlags b)
		{
			return false;
		}

		public static bool operator >(XrSwapchainCreateFlags a, XrSwapchainCreateFlags b)
		{
			return false;
		}

		public static bool operator <(XrSwapchainCreateFlags a, XrSwapchainCreateFlags b)
		{
			return false;
		}

		public static XrSwapchainCreateFlags operator +(XrSwapchainCreateFlags a, XrSwapchainCreateFlags b)
		{
			return default(XrSwapchainCreateFlags);
		}

		public static XrSwapchainCreateFlags operator -(XrSwapchainCreateFlags a, XrSwapchainCreateFlags b)
		{
			return default(XrSwapchainCreateFlags);
		}

		public static XrSwapchainCreateFlags operator *(XrSwapchainCreateFlags a, XrSwapchainCreateFlags b)
		{
			return default(XrSwapchainCreateFlags);
		}

		public static XrSwapchainCreateFlags operator /(XrSwapchainCreateFlags a, XrSwapchainCreateFlags b)
		{
			return default(XrSwapchainCreateFlags);
		}
	}
}
