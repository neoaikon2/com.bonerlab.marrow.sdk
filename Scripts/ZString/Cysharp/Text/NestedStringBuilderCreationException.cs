using System;

namespace Cysharp.Text
{
	internal class NestedStringBuilderCreationException : InvalidOperationException
	{
		protected internal NestedStringBuilderCreationException(string typeName, string extraMessage = "")
		{
		}
	}
}
