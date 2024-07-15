using System;

namespace Wave.OpenXR.CompositionLayer
{
	public struct XrCompositionLayerFlags : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrCompositionLayerFlags(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrCompositionLayerFlags xrBool)
		{
			return 0uL;
		}

		public static implicit operator XrCompositionLayerFlags(ulong u)
		{
			return default(XrCompositionLayerFlags);
		}

		public bool Equals(XrCompositionLayerFlags other)
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

		public static bool operator ==(XrCompositionLayerFlags a, XrCompositionLayerFlags b)
		{
			return false;
		}

		public static bool operator !=(XrCompositionLayerFlags a, XrCompositionLayerFlags b)
		{
			return false;
		}

		public static bool operator >=(XrCompositionLayerFlags a, XrCompositionLayerFlags b)
		{
			return false;
		}

		public static bool operator <=(XrCompositionLayerFlags a, XrCompositionLayerFlags b)
		{
			return false;
		}

		public static bool operator >(XrCompositionLayerFlags a, XrCompositionLayerFlags b)
		{
			return false;
		}

		public static bool operator <(XrCompositionLayerFlags a, XrCompositionLayerFlags b)
		{
			return false;
		}

		public static XrCompositionLayerFlags operator +(XrCompositionLayerFlags a, XrCompositionLayerFlags b)
		{
			return default(XrCompositionLayerFlags);
		}

		public static XrCompositionLayerFlags operator -(XrCompositionLayerFlags a, XrCompositionLayerFlags b)
		{
			return default(XrCompositionLayerFlags);
		}

		public static XrCompositionLayerFlags operator *(XrCompositionLayerFlags a, XrCompositionLayerFlags b)
		{
			return default(XrCompositionLayerFlags);
		}

		public static XrCompositionLayerFlags operator /(XrCompositionLayerFlags a, XrCompositionLayerFlags b)
		{
			return default(XrCompositionLayerFlags);
		}
	}
}
