using System;

namespace Wave.OpenXR
{
	public struct XrSession : IEquatable<ulong>
	{
		private readonly ulong value;

		public XrSession(ulong u)
		{
			value = 0uL;
		}

		public static implicit operator ulong(XrSession equatable)
		{
			return 0uL;
		}

		public static implicit operator XrSession(ulong u)
		{
			return default(XrSession);
		}

		public bool Equals(XrSession other)
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

		public static bool operator ==(XrSession a, XrSession b)
		{
			return false;
		}

		public static bool operator !=(XrSession a, XrSession b)
		{
			return false;
		}

		public static bool operator >=(XrSession a, XrSession b)
		{
			return false;
		}

		public static bool operator <=(XrSession a, XrSession b)
		{
			return false;
		}

		public static bool operator >(XrSession a, XrSession b)
		{
			return false;
		}

		public static bool operator <(XrSession a, XrSession b)
		{
			return false;
		}

		public static XrSession operator +(XrSession a, XrSession b)
		{
			return default(XrSession);
		}

		public static XrSession operator -(XrSession a, XrSession b)
		{
			return default(XrSession);
		}

		public static XrSession operator *(XrSession a, XrSession b)
		{
			return default(XrSession);
		}

		public static XrSession operator /(XrSession a, XrSession b)
		{
			return default(XrSession);
		}
	}
}
