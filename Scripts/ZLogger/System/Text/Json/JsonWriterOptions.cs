using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;

namespace System.Text.Json
{
	public struct JsonWriterOptions
	{
		[CompilerGenerated]
		private bool _003CIndented_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CSkipValidation_003Ek__BackingField;

		[CompilerGenerated]
		private JavaScriptEncoder _003CEncoder_003Ek__BackingField;

		public bool Indented
		{
			[CompilerGenerated]
			set
			{
				_003CIndented_003Ek__BackingField = value;
			}
		}

		public bool SkipValidation
		{
			[CompilerGenerated]
			set
			{
				_003CSkipValidation_003Ek__BackingField = value;
			}
		}

		public JavaScriptEncoder Encoder
		{
			[CompilerGenerated]
			set
			{
				_003CEncoder_003Ek__BackingField = value;
			}
		}
	}
}
