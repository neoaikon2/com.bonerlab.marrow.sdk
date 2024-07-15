using System;

namespace Wave.OpenXR.CompositionLayer
{
	public struct XrSwapchain : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrSwapchain(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrSwapchain xrBool)
		{
			return 0uL;
		}

		public static implicit operator XrSwapchain(ulong u)
		{
			return default(XrSwapchain);
		}

		public bool Equals(XrSwapchain other)
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

		public static bool operator ==(XrSwapchain a, XrSwapchain b)
		{
			return false;
		}

		public static bool operator !=(XrSwapchain a, XrSwapchain b)
		{
			return false;
		}

		public static bool operator >=(XrSwapchain a, XrSwapchain b)
		{
			return false;
		}

		public static bool operator <=(XrSwapchain a, XrSwapchain b)
		{
			return false;
		}

		public static bool operator >(XrSwapchain a, XrSwapchain b)
		{
			return false;
		}

		public static bool operator <(XrSwapchain a, XrSwapchain b)
		{
			return false;
		}

		public static XrSwapchain operator +(XrSwapchain a, XrSwapchain b)
		{
			return default(XrSwapchain);
		}

		public static XrSwapchain operator -(XrSwapchain a, XrSwapchain b)
		{
			return default(XrSwapchain);
		}

		public static XrSwapchain operator *(XrSwapchain a, XrSwapchain b)
		{
			return default(XrSwapchain);
		}

		public static XrSwapchain operator /(XrSwapchain a, XrSwapchain b)
		{
			return default(XrSwapchain);
		}
	}
}
